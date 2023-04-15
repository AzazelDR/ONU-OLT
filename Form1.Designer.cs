namespace OLT_ONU
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            btnClean = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            btnBuscar = new Button();
            btnNext = new Button();
            btnAdd = new Button();
            btnPotencia = new Button();
            btnDelete = new Button();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            label9 = new Label();
            btnInfoTec = new Button();
            btnSP = new Button();
            btnSPD = new Button();
            btnUpdateSoft = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(43, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(75, 98);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(43, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(124, 98);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(44, 23);
            textBox4.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Marsella, Acropolis, Lot. S.A.", "San Miguel", "Usulutan", "\"0/0\" S.G., V.Tzuchi, Q2 K y L", "\"0/0\" Ecoterra", "\"0/0\" Mediterraneo", "\"0/0\" Pinares", "\"0/1\" S.G., V.Tzuchi, Q2 K y L", "\"0/1\" Ecoterra", "\"0/1\" Mediterraneo", "\"0/1\" Pinares" });
            comboBox1.Location = new Point(221, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(327, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(454, 156);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(94, 23);
            btnClean.TabIndex = 11;
            btnClean.Text = "Limpiar texto";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 28);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 12;
            label1.Text = "Serial ONU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 80);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 13;
            label2.Text = "SLOT #";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 80);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 14;
            label3.Text = "PON #";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 80);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 15;
            label4.Text = "ONU #";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 28);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 16;
            label5.Text = "Lugar";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(26, 182);
            label6.Name = "label6";
            label6.Size = new Size(0, 21);
            label6.TabIndex = 17;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(174, 98);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(79, 23);
            textBox5.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(174, 80);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 19;
            label7.Text = "Service Port #";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(26, 127);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 23);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "Buscar Nuevo";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(132, 127);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 23);
            btnNext.TabIndex = 21;
            btnNext.Text = "Listado de ONU";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(238, 127);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnPotencia
            // 
            btnPotencia.Location = new Point(319, 127);
            btnPotencia.Name = "btnPotencia";
            btnPotencia.Size = new Size(75, 23);
            btnPotencia.TabIndex = 23;
            btnPotencia.Text = "Potencia";
            btnPotencia.UseVisualStyleBackColor = true;
            btnPotencia.Click += btnPotencia_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(400, 127);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(365, 98);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(365, 80);
            label8.Name = "label8";
            label8.Size = new Size(26, 15);
            label8.TabIndex = 26;
            label8.Text = "DUI";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(259, 98);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(259, 80);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 28;
            label9.Text = "IP a colocar";
            // 
            // btnInfoTec
            // 
            btnInfoTec.Location = new Point(336, 156);
            btnInfoTec.Name = "btnInfoTec";
            btnInfoTec.Size = new Size(112, 23);
            btnInfoTec.TabIndex = 29;
            btnInfoTec.Text = "Info para tecnico";
            btnInfoTec.UseVisualStyleBackColor = true;
            btnInfoTec.Click += btnInfoTec_Click;
            // 
            // btnSP
            // 
            btnSP.Location = new Point(26, 156);
            btnSP.Name = "btnSP";
            btnSP.Size = new Size(141, 23);
            btnSP.TabIndex = 30;
            btnSP.Text = "Service Port Siguiente";
            btnSP.UseVisualStyleBackColor = true;
            btnSP.Click += btnSP_Click;
            // 
            // btnSPD
            // 
            btnSPD.Location = new Point(173, 156);
            btnSPD.Name = "btnSPD";
            btnSPD.Size = new Size(157, 23);
            btnSPD.TabIndex = 31;
            btnSPD.Text = "Borrar Service Port de base";
            btnSPD.UseVisualStyleBackColor = true;
            btnSPD.Click += btnSPD_Click;
            // 
            // btnUpdateSoft
            // 
            btnUpdateSoft.Enabled = false;
            btnUpdateSoft.Image = (Image)resources.GetObject("btnUpdateSoft.Image");
            btnUpdateSoft.Location = new Point(537, 185);
            btnUpdateSoft.Name = "btnUpdateSoft";
            btnUpdateSoft.Size = new Size(35, 35);
            btnUpdateSoft.TabIndex = 32;
            btnUpdateSoft.UseVisualStyleBackColor = true;
            btnUpdateSoft.Visible = false;
            btnUpdateSoft.Click += btnUpdateSoft_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 226);
            Controls.Add(btnUpdateSoft);
            Controls.Add(btnSPD);
            Controls.Add(btnSP);
            Controls.Add(btnInfoTec);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(btnDelete);
            Controls.Add(btnPotencia);
            Controls.Add(btnAdd);
            Controls.Add(btnNext);
            Controls.Add(btnBuscar);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClean);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(595, 265);
            MinimumSize = new Size(595, 265);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuracion de ONU";
            TopMost = true;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Button btnClean;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private Button btnBuscar;
        private Button btnNext;
        private Button btnAdd;
        private Button btnPotencia;
        private Button btnDelete;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private Label label9;
        private Button btnInfoTec;
        private Button btnSP;
        private Button btnSPD;
        private Button btnUpdateSoft;
    }
}