using SnmpSharpNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnmpUsageFee.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Connection connection;
        private Equipment equipment;
        private string IpAddress;
        private string Port;
        private string Community;
        private int SnmpVersion;
        private int Timeout;
        private int Retries;

        private void txtIp_TextChanged(object sender, EventArgs e)
        {
            IpAddress = Convert.ToString(txtIp.Text);
        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {
            Port = Convert.ToString(txtPort.Text);
        }

        private void txtCommunit_TextChanged(object sender, EventArgs e)
        {
            Community = Convert.ToString(txtCommunit.Text);
        }

        private void txtVersion_TextChanged(object sender, EventArgs e)
        {
            SnmpVersion = Convert.ToInt32(txtVersion.Text);
        }

        private void txtTimeOut_TextChanged(object sender, EventArgs e)
        {
            Timeout = Convert.ToInt32(txtTimeOut.Text);
        }

        private void txtRetrans_TextChanged(object sender, EventArgs e)
        {
            Retries = Convert.ToInt32(txtRetrans.Text);
        }

        private void btnGetInfos_Click(object sender, EventArgs e)
        {
            GetResponse();
        }

        private void GetResponse()
        {
            connection = new Connection(IpAddress, Port, SnmpVersion, Community, Retries, Timeout);

            // SNMP community name
            OctetString community = new OctetString("abcBolinhas");

            // Define agent parameters class
            AgentParameters param = new AgentParameters(community);

            // Set SNMP version to 1 (or 2)
            param.Version = SnmpSharpNet.SnmpVersion.Ver2;

            // Construct the agent address object
            // IpAddress class is easy to use here because
            //  it will try to resolve constructor parameter if it doesn't
            //  parse to an IP address
            IpAddress agent = new IpAddress("127.0.0.1");

            // Construct target
            UdpTarget target = new UdpTarget((IPAddress)agent, 161, 2000, 1);

            // Pdu class used for all requests
            Pdu pdu = new Pdu(PduType.Get);
            pdu.VbList.Add("1.3.6.1.2.1.1.1.0"); //sysDescr
            pdu.VbList.Add("1.3.6.1.2.1.1.2.0"); //sysObjectID
            pdu.VbList.Add("1.3.6.1.2.1.1.3.0"); //sysUpTime
            pdu.VbList.Add("1.3.6.1.2.1.1.4.0"); //sysContact
            pdu.VbList.Add("1.3.6.1.2.1.1.5.0"); //sysName

            // Make SNMP request
            SnmpV2Packet result = (SnmpV2Packet)target.Request(pdu, param);

            // If result is null then agent didn't reply or we couldn't parse the reply.
            if (result != null)
            {
                // ErrorStatus other then 0 is an error returned by 
                // the Agent - see SnmpConstants for error definitions
                if (result.Pdu.ErrorStatus != 0)
                {
                    // agent reported an error with the request
                    MessageBox.Show("Error in SNMP reply. Error {0} index {1}", Convert.ToString(result.Pdu.ErrorStatus), MessageBoxButtons.OK);
                }
                else
                {
                    // Reply variables are returned in the same order as they were added
                    //  to the VbList

                    equipment = new Equipment();

                    equipment.Description = "oid(" + result.Pdu.VbList[0].Oid.ToString() + ")" +
                        " " + result.Pdu.VbList[0].Value.ToString();
                    equipment.Contact = "oid(" + result.Pdu.VbList[3].Oid.ToString() + ")" +
                        " " + result.Pdu.VbList[3].Value.ToString();
                    equipment.Name = "oid(" + result.Pdu.VbList[4].Oid.ToString() + ")" +
                        " " + result.Pdu.VbList[4].Value.ToString();
                    equipment.Location = "oid(" + result.Pdu.VbList[1].Oid.ToString() + ")" +
                        " " + result.Pdu.VbList[1].Value.ToString();
                    equipment.UpTime = "oid(" + result.Pdu.VbList[2].Oid.ToString() + ")" +
                        " " + result.Pdu.VbList[2].Value.ToString();

                    UpdateFields();
                }
            }
            else
            {
                MessageBox.Show("No response received from SNMP agent.", "Fail", MessageBoxButtons.OK);
            }
        }

        private void UpdateFields()
        {
            txtResponseEquipament.Text = equipment.Description;

            txtResponseEquipament.Text = equipment.ToString().Replace("\n", Environment.NewLine) ;
        }
    }
}
