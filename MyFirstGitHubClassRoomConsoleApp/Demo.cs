using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp
{
    class Demo
    {
        int _property1;
        string _property2;
        public Demo(int p1, string p2)
        {
            _property1 = p1;
            _property2 = p2;
        }
        public int Property1
        {
            get
            {
                return _property1;
            }
            set
            {
                _property1 = value;
            }
        }
        public string Property2
        {
            get
            {
                return _property2;
            }
            set
            {
                _property2 = value;
            }
        }
    }
}
