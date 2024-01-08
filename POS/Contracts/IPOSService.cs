using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POS.Contracts
{
    public interface IPOSService
    {
        virtual string PrintDate()
        
        {
            return DateTime.Now.ToString("O")+" From AutoImplementation";
        }
    }
}
