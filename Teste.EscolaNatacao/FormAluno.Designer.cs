namespace Teste.EscolaNatacao
{
    partial class FormAluno
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
            btnCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            fontDialog1 = new FontDialog();
            label5 = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtMatricula = new TextBox();
            txtEndereco = new TextBox();
            dtpDataNascimento = new DateTimePicker();
            button1 = new Button();
            label6 = new Label();
            btnBuscar = new Button();
            lbNomesAlunos = new ListBox();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(67, 386);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 41);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 113);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 182);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 3;
            label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 257);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 4;
            label4.Text = "Matricula:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 326);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 5;
            label5.Text = "Endereco:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(67, 59);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 23);
            txtNome.TabIndex = 6;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(67, 131);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(200, 23);
            txtTelefone.TabIndex = 7;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(67, 275);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(200, 23);
            txtMatricula.TabIndex = 8;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(67, 344);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(524, 23);
            txtEndereco.TabIndex = 9;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(67, 200);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(200, 23);
            dtpDataNascimento.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(494, 386);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 12;
            button1.Text = "Marcar Aula";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(391, 257);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 13;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(516, 274);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lbNomesAlunos
            // 
            lbNomesAlunos.DisplayMember = "Nome";
            lbNomesAlunos.FormattingEnabled = true;
            lbNomesAlunos.ItemHeight = 15;
            lbNomesAlunos.Location = new Point(350, 41);
            lbNomesAlunos.Name = "lbNomesAlunos";
            lbNomesAlunos.Size = new Size(241, 229);
            lbNomesAlunos.TabIndex = 15;
            // 
            // FormAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lbNomesAlunos);
            Controls.Add(btnBuscar);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(dtpDataNascimento);
            Controls.Add(txtEndereco);
            Controls.Add(txtMatricula);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Name = "FormAluno";
            Text = "Aluno";
            Load += FormAluno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private FontDialog fontDialog1;
        private Label label5;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtMatricula;
        private TextBox txtEndereco;
        private DateTimePicker dtpDataNascimento;
        private Button button1;
        private Label label6;
        private Button btnBuscar;
        private ListBox lbNomesAlunos;
    }
}