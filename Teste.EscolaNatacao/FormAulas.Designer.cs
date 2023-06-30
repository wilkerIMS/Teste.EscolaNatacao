namespace Teste.EscolaNatacao
{
    partial class FormAulas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            cmbNome = new ComboBox();
            cmbAula = new ComboBox();
            btnComfimar = new Button();
            dtpDataInicio = new DateTimePicker();
            mtbHora = new MaskedTextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 32);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Aluno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 76);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Aula:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 122);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 3;
            label4.Text = "Data de Inicio:";
            // 
            // cmbNome
            // 
            cmbNome.DisplayMember = "Nome";
            cmbNome.FormattingEnabled = true;
            cmbNome.Location = new Point(109, 24);
            cmbNome.Name = "cmbNome";
            cmbNome.Size = new Size(200, 23);
            cmbNome.TabIndex = 4;
            cmbNome.ValueMember = "Matricula";
            // 
            // cmbAula
            // 
            cmbAula.DisplayMember = "Especialidade";
            cmbAula.FormattingEnabled = true;
            cmbAula.Location = new Point(109, 68);
            cmbAula.Name = "cmbAula";
            cmbAula.Size = new Size(200, 23);
            cmbAula.TabIndex = 5;
            cmbAula.ValueMember = "Nome";
            // 
            // btnComfimar
            // 
            btnComfimar.Location = new Point(234, 169);
            btnComfimar.Name = "btnComfimar";
            btnComfimar.Size = new Size(75, 23);
            btnComfimar.TabIndex = 8;
            btnComfimar.Text = "Comfimar";
            btnComfimar.UseVisualStyleBackColor = true;
            btnComfimar.Click += btnComfimar_Click;
            // 
            // dtpDataInicio
            // 
            dtpDataInicio.Location = new Point(109, 114);
            dtpDataInicio.Name = "dtpDataInicio";
            dtpDataInicio.Size = new Size(91, 23);
            dtpDataInicio.TabIndex = 9;
            // 
            // mtbHora
            // 
            mtbHora.Location = new Point(273, 112);
            mtbHora.Mask = "00:00";
            mtbHora.Name = "mtbHora";
            mtbHora.Size = new Size(36, 23);
            mtbHora.TabIndex = 10;
            mtbHora.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 120);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 11;
            label3.Text = "Hora:";
            // 
            // FormAulas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 204);
            Controls.Add(label3);
            Controls.Add(mtbHora);
            Controls.Add(dtpDataInicio);
            Controls.Add(btnComfimar);
            Controls.Add(cmbAula);
            Controls.Add(cmbNome);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAulas";
            Text = "FormAulas";
            Load += FormAulas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private ComboBox cmbNome;
        private ComboBox cmbAula;
        private Button btnComfimar;
        private DateTimePicker dtpDataInicio;
        private MaskedTextBox mtbHora;
        private Label label3;
    }
}