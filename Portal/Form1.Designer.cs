namespace Portal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_nome = new TextBox();
            txt_idade = new TextBox();
            txt_curso = new TextBox();
            btn_adicionar = new Button();
            panel1 = new Panel();
            label5 = new Label();
            lv_alunos = new ListView();
            Nome = new ColumnHeader();
            Idade = new ColumnHeader();
            Curso = new ColumnHeader();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(185, 23);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 30);
            label1.TabIndex = 0;
            label1.Text = "Formulário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(81, 171);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 2;
            label3.Text = "Idade:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(81, 257);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 3;
            label4.Text = "Curso:";
            // 
            // txt_nome
            // 
            txt_nome.BackColor = SystemColors.Menu;
            txt_nome.Location = new Point(77, 119);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(311, 36);
            txt_nome.TabIndex = 4;
            // 
            // txt_idade
            // 
            txt_idade.BackColor = SystemColors.Menu;
            txt_idade.Location = new Point(77, 207);
            txt_idade.Name = "txt_idade";
            txt_idade.Size = new Size(311, 36);
            txt_idade.TabIndex = 5;
            // 
            // txt_curso
            // 
            txt_curso.BackColor = SystemColors.Menu;
            txt_curso.Location = new Point(77, 295);
            txt_curso.Name = "txt_curso";
            txt_curso.Size = new Size(311, 36);
            txt_curso.TabIndex = 6;
            // 
            // btn_adicionar
            // 
            btn_adicionar.BackColor = SystemColors.Menu;
            btn_adicionar.Location = new Point(185, 368);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(117, 47);
            btn_adicionar.TabIndex = 7;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = false;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lv_alunos);
            panel1.Location = new Point(429, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 503);
            panel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label5.Location = new Point(34, 23);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(169, 30);
            label5.TabIndex = 9;
            label5.Text = "Lista de Alunos";
            // 
            // lv_alunos
            // 
            lv_alunos.Columns.AddRange(new ColumnHeader[] { Nome, Idade, Curso });
            lv_alunos.Location = new Point(12, 119);
            lv_alunos.Name = "lv_alunos";
            lv_alunos.Size = new Size(348, 370);
            lv_alunos.TabIndex = 0;
            lv_alunos.UseCompatibleStateImageBehavior = false;
            lv_alunos.View = View.Details;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 80;
            // 
            // Idade
            // 
            Idade.Text = "Idade";
            Idade.Width = 100;
            // 
            // Curso
            // 
            Curso.Text = "Curso";
            Curso.Width = 170;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(81, 76);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 9;
            label2.Text = "Nome:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(801, 501);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btn_adicionar);
            Controls.Add(txt_curso);
            Controls.Add(txt_idade);
            Controls.Add(txt_nome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Formulario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txt_nome;
        private TextBox txt_idade;
        private TextBox txt_curso;
        private Button btn_adicionar;
        private Panel panel1;
        private ListView lv_alunos;
        private ColumnHeader Nome;
        private ColumnHeader Idade;
        private ColumnHeader Curso;
        private Label label5;
        private Label label2;
    }
}
