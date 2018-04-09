using SnmpSharpNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnmpUsageFee.WinApp
{
    public class Connection
    {

        public string IpAddress { get; set; }
        public int Port { get; set; }
        public string Community { get; set; }
        public SnmpVersion SnmpVersion { get; set; }
        public int Timeout { get; set; }
        public int Retries { get; set; }


        public Connection()
        {
        }

        public SnmpVersion ValidateSnmpVersion(String version)
        {
            if (version.Equals("1"))
            {
                return SnmpVersion.Ver1;
            }
            else if (version.Equals("2c"))
            {
                return SnmpVersion.Ver2;
            }
            else if (version.Equals("3"))
            {
                return SnmpVersion.Ver3;
            }
            else
            {
                throw new Exception("Versão Invalida");
            }

        }
        
    }

}