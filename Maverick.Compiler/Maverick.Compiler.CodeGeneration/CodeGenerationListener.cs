using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;
using Antlr4.Runtime.Tree;
using System.Diagnostics.SymbolStore;

namespace Maverick.Compiler.CodeGeneration
{
    public class CodeGenerationListener : LittleBigCBaseListener
    {
        private AssemblyBuilder _assemblyBuilder;
        private TypeBuilder _typeBuilder;
        private ModuleBuilder _module;
        private MethodBuilder _entryMethod;

        private String _name;
        private String _il;

        private List<String> _errors = new List<String>();
        private Boolean _hasEntryPoint = false;

        public List<String> Errors
        {
            get
            {
                return _errors;
            }
        }

        public String Il
        {
            get
            {
                return _il;
            }
        }

        public CodeGenerationListener(String name)
            : base()
        {
            this._name = name;

            AssemblyName assemblyName = new AssemblyName();

            assemblyName.Name = name;

            _assemblyBuilder = Thread.GetDomain().DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.RunAndSave);
            _module = _assemblyBuilder.DefineDynamicModule(String.Format("{0}.exe", name), true);

           // ISymbolDocumentWriter doc = _module.DefineDocument(@"Source.txt", Guid.Empty, Guid.Empty, Guid.Empty);

            _typeBuilder = _module.DefineType(String.Format("{0}Type", name), TypeAttributes.Public | TypeAttributes.Class);
        }

        public override void EnterFunctionDefinition(LittleBigCParser.FunctionDefinitionContext context)
        {
            var functionName = context.Identifier().GetText();

            if (functionName == "main")
            {
                _hasEntryPoint = true;

                _entryMethod = _typeBuilder.DefineMethod("main",
                    MethodAttributes.HideBySig | MethodAttributes.Static | MethodAttributes.Public,
                    typeof(void), new Type[] { typeof(string[]) });
            }
        }


        public override void EnterPostfixExpression(LittleBigCParser.PostfixExpressionContext context)
        {
            if (_hasEntryPoint)
            {
                if (context.argumentExpressionList() != null)
                {
                    var functionName = context.postfixExpression().primaryExpression().Identifier().GetText();

                    if (functionName == "write")
                    {
                        var argsListener = new ArgumentsListener();

                        ParseTreeWalker.Default.Walk(argsListener, context.argumentExpressionList());

                        var text = argsListener.StringConstant;

                        ILGenerator ilGenerator = _entryMethod.GetILGenerator();
                        ilGenerator.EmitWriteLine(text);
                    }
                }
            }
        }

        public override void ExitFunctionDefinition(LittleBigCParser.FunctionDefinitionContext context)
        {
            if (_hasEntryPoint)
            {
                ILGenerator ilGenerator = _entryMethod.GetILGenerator();

                ilGenerator.Emit(OpCodes.Ldc_I4_1);
                ilGenerator.Emit(OpCodes.Call, typeof(Console).GetMethod("ReadKey", new Type[] { typeof(bool) }));
                ilGenerator.Emit(OpCodes.Ret);
            }
        }

        public override void ExitCompilationUnit(LittleBigCParser.CompilationUnitContext context)
        {
            if (_hasEntryPoint)
            {
                Type type = _typeBuilder.CreateType();

                // run it
                //type.GetMethod("main").Invoke(null, new string[] { null });

                // set the entry point for the application and save it
                _assemblyBuilder.SetEntryPoint(_entryMethod, PEFileKinds.ConsoleApplication);

                _assemblyBuilder.Save(String.Format("{0}.exe", _name));
            }
            else
            {
                _errors.Add("Complier: No entry point.");
            }
        }

    }
}
