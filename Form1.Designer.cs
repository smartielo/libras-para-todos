namespace WinFormsApp1
{
    partial class Trabalho
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
            lblnome = new Label();
            lblnascimento = new Label();
            lblcpf = new Label();
            lblgenero = new Label();
            lblendereço = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            rbhomem = new RadioButton();
            rbmulher = new RadioButton();
            cltermos = new CheckBox();
            btcadastro = new Button();
            btproxima = new Button();
            SuspendLayout();
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Font = new Font("Snap ITC", 25F);
            lblnome.Location = new Point(12, 51);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(134, 44);
            lblnome.TabIndex = 0;
            lblnome.Text = "Nome:";
            lblnome.Click += label1_Click;
            // 
            // lblnascimento
            // 
            lblnascimento.AutoSize = true;
            lblnascimento.Font = new Font("Snap ITC", 25F);
            lblnascimento.Location = new Point(3, 108);
            lblnascimento.Name = "lblnascimento";
            lblnascimento.Size = new Size(403, 44);
            lblnascimento.TabIndex = 4;
            lblnascimento.Text = "Data de nascimento:";
            lblnascimento.Click += label1_Click_1;
            // 
            // lblcpf
            // 
            lblcpf.AutoSize = true;
            lblcpf.Font = new Font("Snap ITC", 25F);
            lblcpf.Location = new Point(12, 170);
            lblcpf.Name = "lblcpf";
            lblcpf.Size = new Size(102, 44);
            lblcpf.TabIndex = 5;
            lblcpf.Text = "Cpf:";
            // 
            // lblgenero
            // 
            lblgenero.AutoSize = true;
            lblgenero.Font = new Font("Snap ITC", 25F);
            lblgenero.Location = new Point(12, 237);
            lblgenero.Name = "lblgenero";
            lblgenero.Size = new Size(166, 44);
            lblgenero.TabIndex = 6;
            lblgenero.Text = "Gênero:";
            lblgenero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblendereço
            // 
            lblendereço.AutoSize = true;
            lblendereço.Font = new Font("Snap ITC", 25F);
            lblendereço.Location = new Point(12, 300);
            lblendereço.Name = "lblendereço";
            lblendereço.Size = new Size(205, 44);
            lblendereço.TabIndex = 7;
            lblendereço.Text = "Endereço:";
            lblendereço.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(412, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 23);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(117, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(265, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(223, 320);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(193, 23);
            textBox5.TabIndex = 12;
            // 
            // rbhomem
            // 
            rbhomem.AutoSize = true;
            rbhomem.Location = new Point(184, 258);
            rbhomem.Name = "rbhomem";
            rbhomem.Size = new Size(69, 19);
            rbhomem.TabIndex = 13;
            rbhomem.TabStop = true;
            rbhomem.Text = "Homem";
            rbhomem.UseVisualStyleBackColor = true;
            rbhomem.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbmulher
            // 
            rbmulher.AutoSize = true;
            rbmulher.Location = new Point(270, 258);
            rbmulher.Name = "rbmulher";
            rbmulher.Size = new Size(63, 19);
            rbmulher.TabIndex = 14;
            rbmulher.TabStop = true;
            rbmulher.Text = "Mulher";
            rbmulher.UseVisualStyleBackColor = true;
            // 
            // cltermos
            // 
            cltermos.AutoSize = true;
            cltermos.Location = new Point(32, 390);
            cltermos.Name = "cltermos";
            cltermos.Size = new Size(156, 19);
            cltermos.TabIndex = 15;
            cltermos.Text = "Aceito os Termos de Uso";
            cltermos.UseVisualStyleBackColor = true;
            cltermos.CheckedChanged += cltermos_CheckedChanged;
            // 
            // btcadastro
            // 
            btcadastro.Font = new Font("Segoe UI", 15F);
            btcadastro.ForeColor = Color.Black;
            btcadastro.Location = new Point(665, 352);
            btcadastro.Name = "btcadastro";
            btcadastro.Size = new Size(201, 57);
            btcadastro.TabIndex = 16;
            btcadastro.Text = "Cadastrar";
            btcadastro.UseVisualStyleBackColor = true;
            btcadastro.Click += btcadastro_Click;
            // 
            // btproxima
            // 
            btproxima.ForeColor = Color.DarkBlue;
            btproxima.Location = new Point(779, 126);
            btproxima.Name = "btproxima";
            btproxima.Size = new Size(152, 88);
            btproxima.TabIndex = 17;
            btproxima.Text = "Surpresinha";
            btproxima.UseVisualStyleBackColor = true;
            btproxima.Click += btproxima_Click;
            // 
            // Trabalho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(978, 446);
            Controls.Add(btproxima);
            Controls.Add(btcadastro);
            Controls.Add(cltermos);
            Controls.Add(rbmulher);
            Controls.Add(rbhomem);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblendereço);
            Controls.Add(lblgenero);
            Controls.Add(lblcpf);
            Controls.Add(lblnascimento);
            Controls.Add(lblnome);
            ForeColor = Color.Cornsilk;
            Name = "Trabalho";
            Text = "Trabalho";
            Load += Trabalho_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnome; 
        private Label lblnascimento;
        private Label lblcpf;
        private Label lblgenero;
        private Label lblendereço;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private RadioButton rbhomem;
        private RadioButton rbmulher;
        private CheckBox cltermos;
        public Button btcadastro;
        private Button btproxima;
    }
}
