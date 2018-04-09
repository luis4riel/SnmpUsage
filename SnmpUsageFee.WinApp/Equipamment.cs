using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnmpUsageFee.WinApp
{
    public class Equipment
    {
        public string Description { get; set; }
        public string Contact { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string UpTime { get; set; }
        public string Temp { get; set; }

        public string[] Oids = { "1.3.6.1.2.1.1.1.0",
            "1.3.6.1.2.1.1.6.0",
            "1.3.6.1.2.1.1.3.0",
            "1.3.6.1.2.1.1.4.0",
            "1.3.6.1.2.1.1.5.0"};
        
        public Equipment()
        {

        }

        public override string ToString()
        {
            return String.Format("Descrição: {0}" + "\n"+
                "Contato: {1} "+ "\n" +
                "Nome: {2} " + "\n" +
                "Localização: {3}" + "\n" +
                "Tempo Ligado: {4}" +"\n" +
                "Temperatura: {5}", Description, Contact, Name, Location, UpTime, Temp );
        }
    }
}
