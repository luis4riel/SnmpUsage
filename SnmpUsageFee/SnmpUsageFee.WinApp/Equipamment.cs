using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnmpUsageFee.WinApp
{
    public class Equipment
    {
        public String Description { get; set; }
        public String Contact { get; set; }
        public String Name { get; set; }
        public String Location { get; set; }
        public String UpTime { get; set; }

        public Equipment()
        {

        }
        public override string ToString()
        {
            return String.Format("Descrição: {0}" + "\n"+
                "Contato: {1} "+ "\n" +
                "Nome: {2} " + "\n" +
                "Localização: {3}" + "\n" +
                "Tempo Ligado: {4}", Description, Contact, Name, Location, UpTime );
        }
    }
}
