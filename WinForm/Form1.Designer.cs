namespace WinForm
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
            LabelCodmot = new Label();
            textCodmot = new TextBox();
            labelCodpad = new Label();
            textCodpad = new TextBox();
            labelCodfil = new Label();
            textCodfil = new TextBox();
            labelCodmun = new Label();
            textCodmun = new TextBox();
            btnSalvar = new Button();
            labelNome = new Label();
            textNome = new TextBox();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // LabelCodmot
            // 
            LabelCodmot.AutoSize = true;
            LabelCodmot.Location = new Point(333, 56);
            LabelCodmot.Name = "LabelCodmot";
            LabelCodmot.Size = new Size(117, 15);
            LabelCodmot.TabIndex = 0;
            LabelCodmot.Text = "Codigo do motorista";
            LabelCodmot.Click += LabelCodmot_Click;
            // 
            // textCodmot
            // 
            textCodmot.Location = new Point(475, 56);
            textCodmot.Name = "textCodmot";
            textCodmot.Size = new Size(137, 23);
            textCodmot.TabIndex = 1;
            textCodmot.TextChanged += textCodmot_TextChanged;
            // 
            // labelCodpad
            // 
            labelCodpad.AutoSize = true;
            labelCodpad.Location = new Point(39, 105);
            labelCodpad.Name = "labelCodpad";
            labelCodpad.Size = new Size(49, 15);
            labelCodpad.TabIndex = 2;
            labelCodpad.Text = "Codpad";
            // 
            // textCodpad
            // 
            textCodpad.Location = new Point(162, 105);
            textCodpad.Name = "textCodpad";
            textCodpad.Size = new Size(137, 23);
            textCodpad.TabIndex = 3;
            textCodpad.TextChanged += textCodpad_TextChanged;
            // 
            // labelCodfil
            // 
            labelCodfil.AutoSize = true;
            labelCodfil.Location = new Point(334, 100);
            labelCodfil.Name = "labelCodfil";
            labelCodfil.Size = new Size(89, 15);
            labelCodfil.TabIndex = 4;
            labelCodfil.Text = "Codigo da Filial";
            // 
            // textCodfil
            // 
            textCodfil.Location = new Point(475, 100);
            textCodfil.Name = "textCodfil";
            textCodfil.Size = new Size(133, 23);
            textCodfil.TabIndex = 5;
            textCodfil.TextChanged += textCodfil_TextChanged;
            // 
            // labelCodmun
            // 
            labelCodmun.AutoSize = true;
            labelCodmun.Location = new Point(39, 149);
            labelCodmun.Name = "labelCodmun";
            labelCodmun.Size = new Size(117, 15);
            labelCodmun.TabIndex = 6;
            labelCodmun.Text = "Codigo do Muncípio";
            // 
            // textCodmun
            // 
            textCodmun.Location = new Point(162, 146);
            textCodmun.Name = "textCodmun";
            textCodmun.Size = new Size(133, 23);
            textCodmun.TabIndex = 7;
            textCodmun.TextChanged += textCodmun_TextChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(655, 194);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(133, 23);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(39, 56);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(111, 15);
            labelNome.TabIndex = 13;
            labelNome.Text = "Nome do motorista";
            // 
            // textNome
            // 
            textNome.Location = new Point(166, 56);
            textNome.Name = "textNome";
            textNome.Size = new Size(133, 23);
            textNome.TabIndex = 14;
            textNome.TextChanged += textNome_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 194);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(573, 23);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(475, 148);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(111, 19);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "Veículo próprio?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 242);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(textNome);
            Controls.Add(labelNome);
            Controls.Add(btnSalvar);
            Controls.Add(textCodmun);
            Controls.Add(labelCodmun);
            Controls.Add(textCodfil);
            Controls.Add(labelCodfil);
            Controls.Add(textCodpad);
            Controls.Add(labelCodpad);
            Controls.Add(textCodmot);
            Controls.Add(LabelCodmot);
            Name = "Form1";
            Text = "Cadastro Básico De Motoristas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelCodmot;
        private TextBox textCodmot;
        private Label labelCodpad;
        private TextBox textCodpad;
        private Label labelCodfil;
        private TextBox textCodfil;
        private Label labelCodmun;
        private TextBox textCodmun;
        private Button btnSalvar;
        private Label labelNome;
        private TextBox textNome;
        private TextBox textBox1;
        private CheckBox checkBox1;
    }
}