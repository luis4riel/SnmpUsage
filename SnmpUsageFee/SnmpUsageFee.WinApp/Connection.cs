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
        //
        public String IpAddress { get; set; }
        public String Port { get; set; }
        public String Community { get; set; }
        public SnmpVersion SnmpVersion { get; set; }
        public int Timeout { get; set; }
        public int Retries { get; set; }
        

        public Connection(String ipAddress, String port, int snmpVersion, String community, int retries, int timeout)
        {
            this.IpAddress = ipAddress;
            this.Port = port;
            this.Community = community;
            this.SnmpVersion = ValidateSnmpVersion(snmpVersion);
            this.Timeout = timeout;
            this.Retries = retries;
        }

        public SnmpVersion ValidateSnmpVersion(int version)
        {
            if (SnmpConstants.IsValidVersion(version) == true && version == 1)
                return SnmpVersion.Ver1;
            else if (SnmpConstants.IsValidVersion(version) == true)
                return SnmpVersion.Ver2;
            else
                throw new Exception("Versão inválida");
        }
    }

}