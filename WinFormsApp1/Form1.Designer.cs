namespace WFdesafioArquivo
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
            dialogSearch = new OpenFileDialog();
            buttonBuscar = new Button();
            textBoxCaminhoArquivo = new TextBox();
            tabControl = new TabControl();
            tabPageAlunos = new TabPage();
            gridAlunos = new DataGridView();
            Aluno = new DataGridViewTextBoxColumn();
            curso = new DataGridViewTextBoxColumn();
            tabPagePessoas = new TabPage();
            gridPessoas = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            cidade = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            RG = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            tabPageCursos = new TabPage();
            gridCursos = new DataGridView();
            codigoCurso = new DataGridViewTextBoxColumn();
            nomeCurso = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            tabControl.SuspendLayout();
            tabPageAlunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridAlunos).BeginInit();
            tabPagePessoas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPessoas).BeginInit();
            tabPageCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCursos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // buttonBuscar
            // 
            buttonBuscar.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBuscar.Location = new Point(594, 16);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 92);
            buttonBuscar.TabIndex = 0;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buscarArquivoDeTexto;
            // 
            // textBoxCaminhoArquivo
            // 
            textBoxCaminhoArquivo.Location = new Point(262, 85);
            textBoxCaminhoArquivo.Name = "textBoxCaminhoArquivo";
            textBoxCaminhoArquivo.ReadOnly = true;
            textBoxCaminhoArquivo.Size = new Size(327, 23);
            textBoxCaminhoArquivo.TabIndex = 1;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageAlunos);
            tabControl.Controls.Add(tabPagePessoas);
            tabControl.Controls.Add(tabPageCursos);
            tabControl.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl.Location = new Point(12, 108);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(661, 330);
            tabControl.TabIndex = 2;
            tabControl.MouseClick += listar;
            // 
            // tabPageAlunos
            // 
            tabPageAlunos.Controls.Add(gridAlunos);
            tabPageAlunos.Location = new Point(4, 26);
            tabPageAlunos.Name = "tabPageAlunos";
            tabPageAlunos.Padding = new Padding(3);
            tabPageAlunos.Size = new Size(653, 300);
            tabPageAlunos.TabIndex = 0;
            tabPageAlunos.Text = "Alunos";
            tabPageAlunos.UseVisualStyleBackColor = true;
            // 
            // gridAlunos
            // 
            gridAlunos.AllowUserToAddRows = false;
            gridAlunos.AllowUserToDeleteRows = false;
            gridAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridAlunos.Columns.AddRange(new DataGridViewColumn[] { Aluno, curso });
            gridAlunos.Dock = DockStyle.Fill;
            gridAlunos.Location = new Point(3, 3);
            gridAlunos.Name = "gridAlunos";
            gridAlunos.ReadOnly = true;
            gridAlunos.RowTemplate.Height = 25;
            gridAlunos.Size = new Size(647, 294);
            gridAlunos.TabIndex = 0;
            gridAlunos.CellContentClick += gridAlunos_CellContentClick;
            // 
            // Aluno
            // 
            Aluno.HeaderText = "Aluno";
            Aluno.MinimumWidth = 302;
            Aluno.Name = "Aluno";
            Aluno.ReadOnly = true;
            Aluno.Resizable = DataGridViewTriState.False;
            Aluno.Width = 302;
            // 
            // curso
            // 
            curso.HeaderText = "Curso";
            curso.MinimumWidth = 302;
            curso.Name = "curso";
            curso.ReadOnly = true;
            curso.Width = 302;
            // 
            // tabPagePessoas
            // 
            tabPagePessoas.Controls.Add(gridPessoas);
            tabPagePessoas.Location = new Point(4, 26);
            tabPagePessoas.Name = "tabPagePessoas";
            tabPagePessoas.Padding = new Padding(3);
            tabPagePessoas.Size = new Size(653, 300);
            tabPagePessoas.TabIndex = 1;
            tabPagePessoas.Text = "Pessoas";
            tabPagePessoas.UseVisualStyleBackColor = true;
            // 
            // gridPessoas
            // 
            gridPessoas.AllowUserToAddRows = false;
            gridPessoas.AllowUserToDeleteRows = false;
            gridPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPessoas.Columns.AddRange(new DataGridViewColumn[] { nome, cidade, telefone, RG, cpf });
            gridPessoas.Dock = DockStyle.Fill;
            gridPessoas.Location = new Point(3, 3);
            gridPessoas.Name = "gridPessoas";
            gridPessoas.ReadOnly = true;
            gridPessoas.RowTemplate.Height = 25;
            gridPessoas.Size = new Size(647, 294);
            gridPessoas.TabIndex = 0;
            // 
            // nome
            // 
            nome.HeaderText = "Nome";
            nome.MinimumWidth = 130;
            nome.Name = "nome";
            nome.ReadOnly = true;
            nome.Width = 130;
            // 
            // cidade
            // 
            cidade.HeaderText = "Cidade";
            cidade.MinimumWidth = 102;
            cidade.Name = "cidade";
            cidade.ReadOnly = true;
            cidade.Width = 102;
            // 
            // telefone
            // 
            telefone.HeaderText = "Telefone";
            telefone.MinimumWidth = 130;
            telefone.Name = "telefone";
            telefone.ReadOnly = true;
            telefone.Width = 130;
            // 
            // RG
            // 
            RG.HeaderText = "rg";
            RG.MinimumWidth = 110;
            RG.Name = "RG";
            RG.ReadOnly = true;
            RG.Width = 110;
            // 
            // cpf
            // 
            cpf.HeaderText = "CPF";
            cpf.MinimumWidth = 130;
            cpf.Name = "cpf";
            cpf.ReadOnly = true;
            cpf.Width = 130;
            // 
            // tabPageCursos
            // 
            tabPageCursos.Controls.Add(gridCursos);
            tabPageCursos.Location = new Point(4, 26);
            tabPageCursos.Name = "tabPageCursos";
            tabPageCursos.Size = new Size(653, 300);
            tabPageCursos.TabIndex = 2;
            tabPageCursos.Text = "Cursos";
            tabPageCursos.UseVisualStyleBackColor = true;
            // 
            // gridCursos
            // 
            gridCursos.AllowUserToAddRows = false;
            gridCursos.AllowUserToDeleteRows = false;
            gridCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCursos.Columns.AddRange(new DataGridViewColumn[] { codigoCurso, nomeCurso });
            gridCursos.Dock = DockStyle.Fill;
            gridCursos.Location = new Point(0, 0);
            gridCursos.Name = "gridCursos";
            gridCursos.ReadOnly = true;
            gridCursos.RowTemplate.Height = 25;
            gridCursos.Size = new Size(653, 300);
            gridCursos.TabIndex = 1;
            // 
            // codigoCurso
            // 
            codigoCurso.HeaderText = "Código";
            codigoCurso.MinimumWidth = 102;
            codigoCurso.Name = "codigoCurso";
            codigoCurso.ReadOnly = true;
            codigoCurso.Width = 102;
            // 
            // nomeCurso
            // 
            nomeCurso.HeaderText = "Curso";
            nomeCurso.MinimumWidth = 502;
            nomeCurso.Name = "nomeCurso";
            nomeCurso.ReadOnly = true;
            nomeCurso.Width = 502;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(114, 88);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 3;
            label1.Text = "Arquivo de texto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(440, 64);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Highlight;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(132, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 81);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Location = new Point(12, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(96, 101);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(682, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tabControl);
            Controls.Add(textBoxCaminhoArquivo);
            Controls.Add(buttonBuscar);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Desafio arquivo WF";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            tabPageAlunos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridAlunos).EndInit();
            tabPagePessoas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridPessoas).EndInit();
            tabPageCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridCursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;//
        private TextBox textBox1;
        private Button button1;//
        private FileSystemWatcher fileSystemWatcher1;//
        private OpenFileDialog dialogSearch;//
        private Button buttonBuscar;//
        private TextBox textBoxCaminhoArquivo;//
        private TabControl tabControl;//
        private TabPage tabPageAlunos;//
        private TabPage tabPagePessoas;//
        private DataGridView gridAlunos;//
        private DataGridView gridPessoas;//
        private DataGridViewTextBoxColumn Aluno;//
        private DataGridViewTextBoxColumn curso;//
        private DataGridViewTextBoxColumn nome;//
        private DataGridViewTextBoxColumn cidade;//
        private DataGridViewTextBoxColumn telefone;//
        private DataGridViewTextBoxColumn RG;//
        private DataGridViewTextBoxColumn cpf;//
        private TabPage tabPageCursos;//
        private DataGridView gridCursos;//
        private DataGridViewTextBoxColumn codigoCurso;//
        private DataGridViewTextBoxColumn nomeCurso;//
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}