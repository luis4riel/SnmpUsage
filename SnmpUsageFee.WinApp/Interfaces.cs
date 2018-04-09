using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnmpUsageFee.WinApp
{
    public class Interfaces
    {
        public string Index { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Speed { get; set; }
        public string Mac { get; set; }
        public string AdministrativeStatus { get; set; }
        public string OperationalStatus { get; set; }
        public string Value { get; internal set; }

        public string[] FindInterface = { "1.3.6.1.2.1.2.1.0" };
       public override string ToString()
        {
            return String.Format("Index: {0}\n" +
                            "Descrição: {1}\n" +
                            "Tipo: {2}\n" +
                            "Velocidade: {3}\n" +
                            "MAC: {4}\n" +
                            "Status administrativo: {5}\n" +
                            "operacional: {6}", 
                            Index, Description, Type, Speed, Mac, AdministrativeStatus, OperationalStatus);
        }
    }
}








