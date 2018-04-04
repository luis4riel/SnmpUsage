namespace SnmpUsageFee.WinApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtCommunit = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.txtRetrans = new System.Windows.Forms.TextBox();
            this.txtResponseEquipament = new System.Windows.Forms.TextBox();
            this.btnGetInfos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetInfos);
            this.groupBox1.Controls.Add(this.txtResponseEquipament);
            this.groupBox1.Controls.Add(this.txtRetrans);
            this.groupBox1.Controls.Add(this.txtTimeOut);
            this.groupBox1.Controls.Add(this.txtVersion);
            this.groupBox1.Controls.Add(this.txtCommunit);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtIp);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Equipamento";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interfaces";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IpAddress:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Community:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Version:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "TimeOut:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Retries:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Resumo Equipamento:";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(9, 39);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(100, 20);
            this.txtIp.TabIndex = 8;
            this.txtIp.Text = "127.0.0.1";
            this.txtIp.TextChanged += new System.EventHandler(this.txtIp_TextChanged);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(115, 39);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(32, 20);
            this.txtPort.TabIndex = 9;
            this.txtPort.Text = "22";
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            // 
            // txtCommunit
            // 
            this.txtCommunit.Location = new System.Drawing.Point(153, 39);
            this.txtCommunit.Name = "txtCommunit";
            this.txtCommunit.Size = new System.Drawing.Size(100, 20);
            this.txtCommunit.TabIndex = 10;
            this.txtCommunit.Text = "abcBolinhas";
            this.txtCommunit.TextChanged += new System.EventHandler(this.txtCommunit_TextChanged);
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(270, 39);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(43, 20);
            this.txtVersion.TabIndex = 11;
            this.txtVersion.Text = "2";
            this.txtVersion.TextChanged += new System.EventHandler(this.txtVersion_TextChanged);
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Location = new System.Drawing.Point(339, 39);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(47, 20);
            this.txtTimeOut.TabIndex = 12;
            this.txtTimeOut.Text = "1000";
            this.txtTimeOut.TextChanged += new System.EventHandler(this.txtTimeOut_TextChanged);
            // 
            // txtRetrans
            // 
            this.txtRetrans.Location = new System.Drawing.Point(408, 39);
            this.txtRetrans.Name = "txtRetrans";
            this.txtRetrans.Size = new System.Drawing.Size(81, 20);
            this.txtRetrans.TabIndex = 13;
            this.txtRetrans.Tag = "";
            this.txtRetrans.Text = "2";
            this.txtRetrans.TextChanged += new System.EventHandler(this.txtRetrans_TextChanged);
            // 
            // txtResponseEquipament
            // 
            this.txtResponseEquipament.Location = new System.Drawing.Point(6, 78);
            this.txtResponseEquipament.Multiline = true;
            this.txtResponseEquipament.Name = "txtResponseEquipament";
            this.txtResponseEquipament.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponseEquipament.Size = new System.Drawing.Size(558, 82);
            this.txtResponseEquipament.TabIndex = 14;
            // 
            // btnGetInfos
            // 
            this.btnGetInfos.Location = new System.Drawing.Point(496, 36);
            this.btnGetInfos.Name = "btnGetInfos";
            this.btnGetInfos.Size = new System.Drawing.Size(68, 23);
            this.btnGetInfos.TabIndex = 15;
            this.btnGetInfos.Text = "GET";
            this.btnGetInfos.UseVisualStyleBackColor = true;
            this.btnGetInfos.Click += new System.EventHandler(this.btnGetInfos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 481);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "SNMP ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetInfos;
        private System.Windows.Forms.TextBox txtResponseEquipament;
        private System.Windows.Forms.TextBox txtRetrans;
        private System.Windows.Forms.TextBox txtTimeOut;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TextBox txtCommunit;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIp;
    }
}

