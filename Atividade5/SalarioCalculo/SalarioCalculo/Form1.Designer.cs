
namespace SalarioCalculo
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
            this.components = new System.ComponentModel.Container();
            this.Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btncalculated = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupboxSexo = new System.Windows.Forms.GroupBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.rtxtR = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.maskedtxtSalario = new System.Windows.Forms.TextBox();
            this.maskedtxtIRPF = new System.Windows.Forms.TextBox();
            this.maskedtxtINSS = new System.Windows.Forms.TextBox();
            this.maskedtxtSF = new System.Windows.Forms.TextBox();
            this.maskedtxtIRPFaliq = new System.Windows.Forms.TextBox();
            this.maskedtxtINSSaliq = new System.Windows.Forms.TextBox();
            this.maskedtxtDep = new System.Windows.Forms.TextBox();
            this.rbtnM = new System.Windows.Forms.RadioButton();
            this.rbtnF = new System.Windows.Forms.RadioButton();
            this.rbtnEC = new System.Windows.Forms.RadioButton();
            this.groupboxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Nome.Location = new System.Drawing.Point(12, 87);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(40, 15);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(405, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(558, 450);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Limpar";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dependentes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(103, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "INSS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(103, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "IRPF";
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(454, 450);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 14;
            this.btnclose.Text = "Fechar";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btncalculated
            // 
            this.btncalculated.Location = new System.Drawing.Point(492, 118);
            this.btncalculated.Name = "btncalculated";
            this.btncalculated.Size = new System.Drawing.Size(116, 46);
            this.btncalculated.TabIndex = 15;
            this.btncalculated.Text = "Calcular";
            this.btncalculated.UseVisualStyleBackColor = true;
            this.btncalculated.Click += new System.EventHandler(this.btncalculated_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(103, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Salário Familia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(364, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Desconto INSS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(364, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Desconto IRPF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(45, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 28);
            this.label9.TabIndex = 20;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(211, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Estado Civil:";
            // 
            // groupboxSexo
            // 
            this.groupboxSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupboxSexo.Controls.Add(this.rbtnF);
            this.groupboxSexo.Controls.Add(this.rbtnM);
            this.groupboxSexo.Location = new System.Drawing.Point(296, 108);
            this.groupboxSexo.Name = "groupboxSexo";
            this.groupboxSexo.Size = new System.Drawing.Size(151, 69);
            this.groupboxSexo.TabIndex = 31;
            this.groupboxSexo.TabStop = false;
            this.groupboxSexo.Text = "Sexo:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(58, 84);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(341, 23);
            this.txtname.TabIndex = 32;
            // 
            // rtxtR
            // 
            this.rtxtR.BackColor = System.Drawing.Color.Gray;
            this.rtxtR.Location = new System.Drawing.Point(45, 208);
            this.rtxtR.Name = "rtxtR";
            this.rtxtR.Size = new System.Drawing.Size(611, 43);
            this.rtxtR.TabIndex = 33;
            this.rtxtR.Text = "";
            this.rtxtR.TextChanged += new System.EventHandler(this.rtxtR_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox2.Location = new System.Drawing.Point(64, 257);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(178, 43);
            this.richTextBox2.TabIndex = 34;
            this.richTextBox2.Text = "SALÁRIO LIQUIDO";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox3.ForeColor = System.Drawing.SystemColors.Menu;
            this.richTextBox3.Location = new System.Drawing.Point(51, 23);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(337, 43);
            this.richTextBox3.TabIndex = 35;
            this.richTextBox3.Text = "CALCULO DO DESCONTO SALÁRIAL";
            // 
            // maskedtxtSalario
            // 
            this.maskedtxtSalario.Location = new System.Drawing.Point(453, 84);
            this.maskedtxtSalario.Name = "maskedtxtSalario";
            this.maskedtxtSalario.Size = new System.Drawing.Size(155, 23);
            this.maskedtxtSalario.TabIndex = 36;
            // 
            // maskedtxtIRPF
            // 
            this.maskedtxtIRPF.Location = new System.Drawing.Point(470, 374);
            this.maskedtxtIRPF.Name = "maskedtxtIRPF";
            this.maskedtxtIRPF.Size = new System.Drawing.Size(125, 23);
            this.maskedtxtIRPF.TabIndex = 37;
            // 
            // maskedtxtINSS
            // 
            this.maskedtxtINSS.Location = new System.Drawing.Point(470, 322);
            this.maskedtxtINSS.Name = "maskedtxtINSS";
            this.maskedtxtINSS.Size = new System.Drawing.Size(125, 23);
            this.maskedtxtINSS.TabIndex = 38;
            // 
            // maskedtxtSF
            // 
            this.maskedtxtSF.Location = new System.Drawing.Point(211, 423);
            this.maskedtxtSF.Name = "maskedtxtSF";
            this.maskedtxtSF.Size = new System.Drawing.Size(100, 23);
            this.maskedtxtSF.TabIndex = 39;
            // 
            // maskedtxtIRPFaliq
            // 
            this.maskedtxtIRPFaliq.Location = new System.Drawing.Point(151, 374);
            this.maskedtxtIRPFaliq.Name = "maskedtxtIRPFaliq";
            this.maskedtxtIRPFaliq.Size = new System.Drawing.Size(100, 23);
            this.maskedtxtIRPFaliq.TabIndex = 40;
            // 
            // maskedtxtINSSaliq
            // 
            this.maskedtxtINSSaliq.Location = new System.Drawing.Point(151, 322);
            this.maskedtxtINSSaliq.Name = "maskedtxtINSSaliq";
            this.maskedtxtINSSaliq.Size = new System.Drawing.Size(100, 23);
            this.maskedtxtINSSaliq.TabIndex = 41;
            // 
            // maskedtxtDep
            // 
            this.maskedtxtDep.Location = new System.Drawing.Point(103, 136);
            this.maskedtxtDep.Name = "maskedtxtDep";
            this.maskedtxtDep.Size = new System.Drawing.Size(83, 23);
            this.maskedtxtDep.TabIndex = 42;
            // 
            // rbtnM
            // 
            this.rbtnM.AutoSize = true;
            this.rbtnM.Location = new System.Drawing.Point(3, 19);
            this.rbtnM.Name = "rbtnM";
            this.rbtnM.Size = new System.Drawing.Size(36, 19);
            this.rbtnM.TabIndex = 0;
            this.rbtnM.TabStop = true;
            this.rbtnM.Text = "M";
            this.rbtnM.UseVisualStyleBackColor = true;
            this.rbtnM.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnF
            // 
            this.rbtnF.AutoSize = true;
            this.rbtnF.Location = new System.Drawing.Point(3, 44);
            this.rbtnF.Name = "rbtnF";
            this.rbtnF.Size = new System.Drawing.Size(31, 19);
            this.rbtnF.TabIndex = 1;
            this.rbtnF.TabStop = true;
            this.rbtnF.Text = "F";
            this.rbtnF.UseVisualStyleBackColor = true;
            // 
            // rbtnEC
            // 
            this.rbtnEC.AutoSize = true;
            this.rbtnEC.Location = new System.Drawing.Point(196, 137);
            this.rbtnEC.Name = "rbtnEC";
            this.rbtnEC.Size = new System.Drawing.Size(78, 19);
            this.rbtnEC.TabIndex = 43;
            this.rbtnEC.TabStop = true;
            this.rbtnEC.Text = "Casado(a)";
            this.rbtnEC.UseVisualStyleBackColor = true;
            this.rbtnEC.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(705, 485);
            this.Controls.Add(this.rbtnEC);
            this.Controls.Add(this.maskedtxtDep);
            this.Controls.Add(this.maskedtxtINSSaliq);
            this.Controls.Add(this.maskedtxtIRPFaliq);
            this.Controls.Add(this.maskedtxtSF);
            this.Controls.Add(this.maskedtxtINSS);
            this.Controls.Add(this.maskedtxtIRPF);
            this.Controls.Add(this.maskedtxtSalario);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.rtxtR);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.groupboxSexo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btncalculated);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupboxSexo.ResumeLayout(false);
            this.groupboxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btncalculated;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupboxSexo;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.RichTextBox rtxtR;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.TextBox maskedtxtSalario;
        private System.Windows.Forms.TextBox maskedtxtIRPF;
        private System.Windows.Forms.TextBox maskedtxtINSS;
        private System.Windows.Forms.TextBox maskedtxtSF;
        private System.Windows.Forms.TextBox maskedtxtIRPFaliq;
        private System.Windows.Forms.TextBox maskedtxtINSSaliq;
        private System.Windows.Forms.TextBox maskedtxtDep;
        private System.Windows.Forms.RadioButton rbtnF;
        private System.Windows.Forms.RadioButton rbtnM;
        private System.Windows.Forms.RadioButton rbtnEC;
    }
}

