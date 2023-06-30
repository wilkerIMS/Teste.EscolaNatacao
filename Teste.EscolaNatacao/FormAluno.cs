namespace Teste.EscolaNatacao
{
    public partial class FormAluno : Form
    {
        public FormAluno()
        {
            InitializeComponent();
        }

        List<Aluno> alunos = new List<Aluno>();
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            aluno.Nome = txtNome.Text;
            aluno.Telefone = txtTelefone.Text;
            aluno.Matricula = txtMatricula.Text;
            aluno.Endereco = txtEndereco.Text;
            aluno.DataNascimento = dtpDataNascimento.Value;

            alunos.Add(aluno);

            MessageBox.Show("O aluno " + aluno.Nome + " foi cadastrado com sucesso.");

            
        }

        public void CriarMockup()
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "Saulo Figueredo";
            aluno.Telefone = "(64) 98451-4581";
            aluno.Matricula = "12345";
            aluno.Endereco = "R.10, Qd. 21, Lt 02";
            aluno.DataNascimento = new DateTime(2005, 01, 25); //DateTime (Ano, Mes, Dia)

            alunos.Add(aluno);

            aluno = new Aluno();
            aluno.Nome = "Luiz Inacio";
            aluno.Telefone = "(64) 99999-9999";
            aluno.Matricula = "56789";
            aluno.Endereco = "R.15, Qd. 01, Lt 56";
            aluno.DataNascimento = new DateTime(2000, 11, 10);

            alunos.Add(aluno);

            aluno = new Aluno();
            aluno.Nome = "Pedro Marcelo Rossi";
            aluno.Telefone = "(72) 69696-9696";
            aluno.Matricula = "214455";
            aluno.Endereco = "R.Guto Fofos, Qd. 04, Lt 10";
            aluno.DataNascimento = new DateTime(2010, 05, 20);

            alunos.Add(aluno);


        }

        private void FormAluno_Load(object sender, EventArgs e)
        {
            CriarMockup();
            //lblQuantidadeAlunos.Text = alunos.Count().ToString();
            foreach (var aluno in alunos)
            {
                lbNomesAlunos.Items.Add(aluno);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAulas form = new FormAulas(alunos);
            form.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                var alunoEncontrados = alunos.Where(a => a.Nome == txtNome.Text);

                if (alunoEncontrados.Any())
                {
                    Aluno alunoEncontrado = alunoEncontrados.First();
                    carregarDadoAluno(alunoEncontrado);
                }
                else
                {
                    MessageBox.Show("Aluno não existente.");
                }
            }
            else
            {
                MessageBox.Show("Digite um nome para buscar");
            }
        }
        public void carregarDadoAluno(Aluno aluno)
        {
            txtEndereco.Text = aluno.Endereco;
            txtMatricula.Text = aluno.Matricula;
            txtTelefone.Text = aluno.Telefone;
            dtpDataNascimento.Value = aluno.DataNascimento;
        }
    }
}