using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CallStackMajig
{
    [Guid("B509C73D-A4CE-4651-A9AA-C1C8CE7350FC")]
    public interface ICallStack_Interface
    {
        void CSMEnable(string DBName);
        
    }

}

namespace CallStackMajig
{
    [Guid("F286BE02-E9DA-4907-8DAA-7B4F1C89D4D4")]
    public class CallStackObj
    {
        public void CSMEnable(string DBName)
        {

        }
    }
}
