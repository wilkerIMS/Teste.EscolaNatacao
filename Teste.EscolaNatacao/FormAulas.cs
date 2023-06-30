using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste.EscolaNatacao
{
    public partial class FormAulas : Form
    {
        List<Aluno> _alunos;
        public FormAulas(List<Aluno> aluno)
        {
            InitializeComponent();
            _alunos = aluno;

            foreach (Aluno a in _alunos)
            {
                cmbNome.Items.Add(a);
            }
        }


        private void btnComfimar_Click(object sender, EventArgs e)
        {
            Aluno aluno = cmbNome.SelectedItem as Aluno;
            Professor professor = cmbAula.SelectedItem as Professor;

            Aula aula = new Aula();
            aula.InicioAula = dtpDataInicio.Value;
            aula.Aluno = aluno;
            aula.Professor = professor;
            aula.Hora = mtbHora.Text;

            string menssagem = "A aula do aluno " + aula.Aluno.Nome +
                "\nFoi marcada para as aulas de: " + aula.Professor.Especialidade +
                "\nCom o professor: " + aula.Professor.Nome +
                "\nO começo previsto para a data de: " + aula.InicioAula.ToShortDateString() +
                " as " + aula.Hora;

            MessageBox.Show(menssagem);
            this.Close();
        }

        private void FormAulas_Load(object sender, EventArgs e)
        {
            criarMokups();
        }

        public void criarMokups()
        {
            Professor professor1 = new Professor();
            professor1.Nome = "Arlong";
            professor1.Especialidade = "Natação Infantil";
            professor1.CPF = "566-455-344.12";
            professor1.Telefone = "(62) 96666-6666";

            cmbAula.Items.Add(professor1);

            Professor professor2 = new Professor();
            professor2.Nome = "Jinbei";
            professor2.Especialidade = "Hidroginástica";
            professor2.CPF = "222-222-111.65";
            professor2.Telefone = "(62) 92222-2322";

            cmbAula.Items.Add(professor2);

            Professor professor3 = new Professor();
            professor3.Nome = "Vander Decken IX";
            professor3.Especialidade = "Iniciantes";
            professor3.CPF = "014-265-489-00";
            professor3.Telefone = "(62) 99687-1265";

            cmbAula.Items.Add(professor3);



        }

    }
}
