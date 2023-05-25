using System.Windows.Forms;

namespace DesafioWinForms01
{
    public partial class Form1 : Form
    {
        DateTime time;
        List<Pessoa> pessoas = new List<Pessoa>();
        List<Aluno> alunos = new List<Aluno>();
        List<Curso> cursos = new List<Curso>();

        public Form1()
        {
            InitializeComponent();
        }



        private void buscarArquivo(object sender, EventArgs e)
        {


            if (dialogSearch.ShowDialog() == DialogResult.OK)
            {
                Conector.carregarDados(pessoas, alunos, cursos, dialogSearch.FileName);
                MessageBox.Show($"Número de pessoas: {pessoas.Count()}\nNúmero de alunos: {alunos.Count()}");

                alunos.ForEach(aluno =>
                {
                    gridAlunos.Rows.Add(aluno.Nome, aluno.Curso.NomeCurso);
                    textBoxCaminhoArquivo.Text = dialogSearch.FileName;
                });
            }
        }

        private void listarAlunos(object sender, MouseEventArgs e)
        {
            if (pessoas.Count > 0)
            {
                pessoas.ForEach(pessoa =>
                {
                    gridPessoas.Rows.Add(pessoa.Nome, pessoa.Cidade, pessoa.Telefone, pessoa.Rg, pessoa.Cpf);
                });
            }

            if (cursos.Count > 0)
            {
                cursos.ForEach(curso =>
                {
                    gridCursos.Rows.Add(curso.CodigoCurso, curso.NomeCurso);
                });

            }
        }

        private void gridAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;
            label2.Text = time.ToLocalTime().ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}