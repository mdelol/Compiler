using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Compiler.ParserTreeVisualizer
{
    class Logs
    {
        private static Logs _instance = null;
        private List<String> _logs = new List<String>();
        
        private Logs() { 
        
        }

        public static Logs GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logs();
            }

            return _instance;
        }

        public static void AddLog(String text)
        {
            var logs = Logs.GetInstance();

            logs._logs.Add(text);
        }

        public List<String> LogsCollection
        {
            get { return _logs; }
        }

        public void Clear()
        {
            _logs.Clear();
        }
    }
}
