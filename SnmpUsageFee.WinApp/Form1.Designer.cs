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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetInfos = new System.Windows.Forms.Button();
            this.txtResponseEquipament = new System.Windows.Forms.TextBox();
            this.txtRetrans = new System.Windows.Forms.TextBox();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtCommunit = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtResponseInterface = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGetResponseInterface = new System.Windows.Forms.Button();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.cmbInterface = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.graphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphic)).BeginInit();
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
            // txtResponseEquipament
            // 
            this.txtResponseEquipament.Location = new System.Drawing.Point(6, 78);
            this.txtResponseEquipament.Multiline = true;
            this.txtResponseEquipament.Name = "txtResponseEquipament";
            this.txtResponseEquipament.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponseEquipament.Size = new System.Drawing.Size(558, 82);
            this.txtResponseEquipament.TabIndex = 14;
            // 
            // txtRetrans
            // 
            this.txtRetrans.Location = new System.Drawing.Point(408, 39);
            this.txtRetrans.Name = "txtRetrans";
            this.txtRetrans.Size = new System.Drawing.Size(81, 20);
            this.txtRetrans.TabIndex = 13;
            this.txtRetrans.Tag = "";
            this.txtRetrans.Text = "2";
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Location = new System.Drawing.Point(339, 39);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(47, 20);
            this.txtTimeOut.TabIndex = 12;
            this.txtTimeOut.Text = "1000";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(270, 39);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(43, 20);
            this.txtVersion.TabIndex = 11;
            this.txtVersion.Text = "2";
            // 
            // txtCommunit
            // 
            this.txtCommunit.Location = new System.Drawing.Point(153, 39);
            this.txtCommunit.Name = "txtCommunit";
            this.txtCommunit.Size = new System.Drawing.Size(100, 20);
            this.txtCommunit.TabIndex = 10;
            this.txtCommunit.Text = "abcBolinhas";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(115, 39);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(32, 20);
            this.txtPort.TabIndex = 9;
            this.txtPort.Text = "161";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(9, 39);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(100, 20);
            this.txtIp.TabIndex = 8;
            this.txtIp.Text = "127.0.0.1";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Retries:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Version:";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtResponseInterface);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnGetResponseInterface);
            this.groupBox2.Controls.Add(this.txtInterval);
            this.groupBox2.Controls.Add(this.cmbInterface);
            this.groupBox2.Location = new System.Drawing.Point(12, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 168);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interfaces";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Resumo Interface:";
            // 
            // txtResponseInterface
            // 
            this.txtResponseInterface.Location = new System.Drawing.Point(6, 80);
            this.txtResponseInterface.Multiline = true;
            this.txtResponseInterface.Name = "txtResponseInterface";
            this.txtResponseInterface.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponseInterface.Size = new System.Drawing.Size(558, 82);
            this.txtResponseInterface.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Intervalo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Interfaces:";
            // 
            // btnGetResponseInterface
            // 
            this.btnGetResponseInterface.Location = new System.Drawing.Point(496, 39);
            this.btnGetResponseInterface.Name = "btnGetResponseInterface";
            this.btnGetResponseInterface.Size = new System.Drawing.Size(68, 23);
            this.btnGetResponseInterface.TabIndex = 16;
            this.btnGetResponseInterface.Text = "GET";
            this.btnGetResponseInterface.UseVisualStyleBackColor = true;
            this.btnGetResponseInterface.Click += new System.EventHandler(this.btnGetResponseInterface_Click);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(410, 40);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(79, 20);
            this.txtInterval.TabIndex = 1;
            this.txtInterval.Text = "3";
            // 
            // cmbInterface
            // 
            this.cmbInterface.FormattingEnabled = true;
            this.cmbInterface.Location = new System.Drawing.Point(6, 40);
            this.cmbInterface.Name = "cmbInterface";
            this.cmbInterface.Size = new System.Drawing.Size(398, 21);
            this.cmbInterface.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.graphic);
            this.groupBox3.Location = new System.Drawing.Point(12, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 234);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Interfaces";
            // 
            // graphic
            // 
            this.graphic.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.graphic.BorderlineColor = System.Drawing.Color.Transparent;
            this.graphic.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.Name = "ChartArea1";
            this.graphic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graphic.Legends.Add(legend1);
            this.graphic.Location = new System.Drawing.Point(12, 15);
            this.graphic.Name = "graphic";
            this.graphic.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Taxa";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.graphic.Series.Add(series1);
            this.graphic.Size = new System.Drawing.Size(552, 209);
            this.graphic.TabIndex = 3;
            this.graphic.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 601);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "SNMP ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphic)).EndInit();
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
        private System.Windows.Forms.TextBox txtResponseInterface;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGetResponseInterface;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.ComboBox cmbInterface;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphic;
        private System.Windows.Forms.Label label10;
    }
}

