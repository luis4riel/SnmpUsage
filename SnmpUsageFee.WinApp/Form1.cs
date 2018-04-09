using SnmpSharpNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace SnmpUsageFee.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Connection conn = new Connection();
        private Equipment equipment = new Equipment();
        private Interfaces interfaces = new Interfaces();
        Dictionary<Oid, AsnType> resultcmb;

        private void btnGetInfos_Click(object sender, EventArgs e)
        {
            ConvertConnectionToObject();

            //deixei fixo, pensar numa jogada com os enuns...
            //connection.SnmpVersion = Convert.ToInt32(txtVersion.Text);
            conn.SnmpVersion = SnmpVersion.Ver2;

            SnmpGetEquipment(conn.IpAddress, conn.Port, conn.Community,
                conn.Timeout, conn.Retries, conn.SnmpVersion, equipment.Oids);
            SnmpGetInterfaces(conn.IpAddress, conn.Port, conn.Community,
                conn.Timeout, conn.Retries, conn.SnmpVersion, interfaces.FindInterface);
        }

        private void SnmpGetEquipment(string ipAddress, int port, string community, int timeout, int retry,
            SnmpVersion version, string[] oidList)
        {

            SimpleSnmp snmp = new SimpleSnmp(ipAddress, port, community, timeout, retry);

            if (!snmp.Valid)
            {
                MessageBox.Show("SNMP agent host name/ip address is invalid.");
                return;
            }

            Dictionary<Oid, AsnType> result = snmp.Get(version, oidList);

            if (result == null)
            {
                MessageBox.Show("No results received.");
                return;
            }

            foreach (KeyValuePair<Oid, AsnType> kvp in result)
            {
                PopularTxtEquipment(kvp);
            }
        }


        private void SnmpGetInterfaces(string ipAddress, int port, string community, int timeout, int retry,
            SnmpVersion version, string[] oidList)
        {
            SimpleSnmp snmp = new SimpleSnmp(ipAddress, port, community, timeout, retry);

            if (!snmp.Valid)
            {
                MessageBox.Show("SNMP agent host name/ip address is invalid.");
                return;
            }

            Dictionary<Oid, AsnType> result = snmp.Get(version, oidList);

            if (result == null)
            {
                MessageBox.Show("No results received.");
                return;
            }

            int quantInterface = 0;
            foreach (KeyValuePair<Oid, AsnType> kvp in result)
            {
                quantInterface = Convert.ToInt32(kvp.Value.ToString());
                string[] array = new String[33]; ;
                ///está com 35 pois quando passa deste valor a lista retorna null, alterar depois para quantinterface
                for (int i = 1; i < 33; i++)
                {
                    array[i] = ("1.3.6.1.2.1.2.2.1.2." + i);
                }
                resultcmb = snmp.Get(version, array);
                foreach (var item in resultcmb)
                {
                    cmbInterface.Items.Add(item.Value.ToString());
                }
            }

            #region outra forma para capturar....
            ////faz a chamada da porra toda do snmp
            //IpAddress agent = new IpAddress(ipAddress);
            //UdpTarget target = new UdpTarget((IPAddress)agent, port, timeout, retry);
            //OctetString comm = new OctetString(community);
            //AgentParameters param = new AgentParameters(comm);
            //param.Version = SnmpVersion.Ver2;

            ////fiz esta jogada pra apresentar somente o numero das interfaces.
            //Pdu pdu = new Pdu(PduType.Get);
            //pdu.VbList.Add("1.3.6.1.2.1.2.1.0");
            //resultInterface = (SnmpV2Packet)target.Request(pdu, param);
            //if (resultInterface.Pdu.ErrorStatus != 0)
            //{
            //    MessageBox.Show("Error in SNMP reply. Error {0} index {1}",
            //        Convert.ToString(resultInterface.Pdu.ErrorStatus),
            //        MessageBoxButtons.OK);
            //}
            //else
            //{
            //    interfaces.quantInterfaces = resultInterface.Pdu.VbList[0].Value.ToString();
            //    quantInterfaces = Convert.ToInt32(interfaces.quantInterfaces);
            //    for (int i = 1; i < quantInterfaces; i++)
            //    {
            //        pdu.VbList.Add("1.3.6.1.2.1.2.2.1.2." + i);
            //        resultInterface = (SnmpV2Packet)target.Request(pdu, param);
            //        cmbInterface.Items.Add(resultInterface.Pdu.VbList[i].Value.ToString());
            //    }

            //}
            #endregion
        }

        private void btnGetResponseInterface_Click(object sender, EventArgs e)
        {
            int controlTime = 0;
            int Interval = Convert.ToInt32(txtInterval.Text);
            int lala = 5;
            int lulu = 9;
            while (controlTime < Interval)
            {
                Thread.Sleep(Interval + 00000);
                controlTime++;
                txtResponseInterface.Clear();
                interfaces.Value = cmbInterface.SelectedItem.ToString();

                foreach (var item in resultcmb)
                {
                    if (interfaces.Value == item.Value.ToString())
                    {
                        //esta jogada faz com que eu capture a referencia da interface e concatene com os oidss da interface.
                        string x = item.Key.ToString();
                        int indice = 0;
                        if (x.Length == 21)
                            indice = Convert.ToInt32(x.Substring(x.Length - 1));
                        else
                            indice = Convert.ToInt32(x.Substring(x.Length - 2));

                        string[] InterfaceValues = {
                        "1.3.6.1.2.1.2.2.1.1." + indice,
                        "1.3.6.1.2.1.2.2.1.2." + indice,
                        "1.3.6.1.2.1.2.2.1.3." + indice,
                        "1.3.6.1.2.1.2.2.1.5." + indice,
                        "1.3.6.1.2.1.2.2.1.6." + indice,
                        "1.3.6.1.2.1.2.2.1.7." + indice,
                        "1.3.6.1.2.1.2.2.1.8." + indice};

                        SimpleSnmp snmp = new SimpleSnmp(conn.IpAddress, conn.Port, conn.Community, conn.Timeout, conn.Retries);
                        Dictionary<Oid, AsnType> resultInterface = snmp.Get(conn.SnmpVersion, InterfaceValues);
                        foreach (KeyValuePair<Oid, AsnType> kvp in resultInterface)
                        {
                            txtResponseInterface.AppendText(Convert.ToString(controlTime));
                            popularTxtInterface(indice, kvp);
                        }
                    }
                }
                this.graphic.Series["Taxa"].Points.AddXY(lulu, lala);
            }
        }

        #region methods utils
        private void popularTxtInterface(int indice, KeyValuePair<Oid, AsnType> kvp)
        {
            if (kvp.Key.ToString().Contains("1.3.6.1.2.1.2.2.1.1." + indice))
            {
                txtResponseInterface.AppendText("Index: " + kvp.Value.ToString() + "\n".Replace("\n", Environment.NewLine));
            }
            else if (kvp.Key.ToString().Contains("1.3.6.1.2.1.2.2.1.2." + indice))
            {
                txtResponseInterface.AppendText("Descrição: " + kvp.Value.ToString() + "\n".Replace("\n", Environment.NewLine));
            }
            else if (kvp.Key.ToString().Contains("1.3.6.1.2.1.2.2.1.3." + indice))
            {
                txtResponseInterface.AppendText("Tipo: " + kvp.Value.ToString() + " \n".Replace("\n", Environment.NewLine));
            }
            else if (kvp.Key.ToString().Contains("1.3.6.1.2.1.2.2.1.5." + indice))
            {
                txtResponseInterface.AppendText("Velocidade: " + kvp.Value.ToString() + " \n".Replace("\n", Environment.NewLine));
            }
            else if (kvp.Key.ToString().Contains("1.3.6.1.2.1.2.2.1.6." + indice))
            {
                txtResponseInterface.AppendText("Mac: " + kvp.Value.ToString() + " \n".Replace("\n", Environment.NewLine));
            }
            else if (kvp.Key.ToString().Contains("1.3.6.1.2.1.2.2.1.7." + indice))
            {
                txtResponseInterface.AppendText("Status Administrativo: " + kvp.Value.ToString() + " \n".Replace("\n", Environment.NewLine));
            }
            else if (kvp.Key.ToString().Contains("1.3.6.1.2.1.2.2.1.8." + indice))
            {
                txtResponseInterface.AppendText("Status Operacional: " + kvp.Value.ToString());
            }
            else
            {
                txtResponseInterface.AppendText("Null");
            }
        }

        private void PopularTxtEquipment(KeyValuePair<Oid, AsnType> kvp)
        {
            if (kvp.Key.ToString().Contains("1.3.6.1.2.1.1.1.0"))
            {
                txtResponseEquipament.AppendText("Descrição: " + kvp.Value.ToString() + "\n".Replace("\n", Environment.NewLine));
            }
            else if (kvp.Key.ToString().Contains("1.3.6.1.2.1.1.6.0"))
            {
                txtResponseEquipament.AppendText("Localização: " + kvp.Value.ToString() + "\n".Replace("\n", Environment.NewLine));
            }
            else if (kvp.Key.ToString().Contains("1.3.6.1.2.1.1.3.0"))
            {
                txtResponseEquipament.AppendText("Tempo Ligado: " + kvp.Value.ToString() + " \n".Replace("\n", Environment.NewLine));
            }
            else if (kvp.Key.ToString().Contains("1.3.6.1.2.1.1.4.0"))
            {
                txtResponseEquipament.AppendText("Contato: " + kvp.Value.ToString() + " \n".Replace("\n", Environment.NewLine));
            }
            else if (kvp.Key.ToString().Contains("1.3.6.1.2.1.1.5.0"))
            {
                txtResponseEquipament.AppendText("Nome do equipamento: " + kvp.Value.ToString());
            }
            else
            {
                txtResponseEquipament.AppendText("Null");
            }
        }

        private void ConvertConnectionToObject()
        {
            conn.IpAddress = System.Convert.ToString(txtIp.Text);
            conn.Port = System.Convert.ToInt32(txtPort.Text);
            conn.Community = System.Convert.ToString(txtCommunit.Text);
            conn.Timeout = System.Convert.ToInt32(txtTimeOut.Text);
            conn.Retries = System.Convert.ToInt32(txtRetrans.Text);
        }

        #endregion

    }
}
