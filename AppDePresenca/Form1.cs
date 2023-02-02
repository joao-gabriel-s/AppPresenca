using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using formspresencaa.Repositorios;
using ClosedXML.Excel;
using System.Diagnostics;
using System.Threading;

namespace formspresencaa
{
    public partial class Form1 : Form
    {
        AlunoRepositorio alunoRepositorio = new AlunoRepositorio();

        List<Aluno> alunos = new List<Aluno>();

        int enviarCodigo = 0;
        int atualizarCodigo = 0;

        public Form1()
        {
            InitializeComponent();

            comboBox2.Visible = false;
            button7.Visible = false;
            NovoNome.Visible = false;
            NomeAluno.Visible = false;
            TurmaAluno.Visible = false;
            EmpresaAluno.Visible = false;
            Data.Visible = false;
            atualizarListaAlunos.Visible = false;
            selecionarListaAlunos.Visible = false;

            button3.Visible = false;
            button4.Visible = false;
            listView3.Visible = false;
            listView2.Visible = false;
            listView1.Visible = false;
            BuscarTodos.Visible = false;
            PresencaFalta.Visible = false;
            textBoxPF.Visible = false;
            button2.Visible = false;
            button1.Visible = false;
            btn_falta.Visible = false;
            imprimir.Visible = false;
            button5.Visible = false;
            textBox2.Visible = false;
            button6.Visible = false;
            selecionarTurma.Visible = false;
            comboBox1.Visible = false;
        }
        public void Limpar()
        {
            NovoNome.Text = "";
            NomeAluno.Text = "";
            TurmaAluno.Text = "";
            EmpresaAluno.Text = "";
            textBox1.Text = "";

            NovoNome.PlaceholderText = "Novo nome";
            NomeAluno.PlaceholderText = "Nome";
            TurmaAluno.PlaceholderText = "Turma";
            EmpresaAluno.PlaceholderText = "Empresa";
        }

        private void button1_Click(object sender, EventArgs e) //MOSTRAR CADASTRAR
        {
            atualizarListaAlunos.Visible = false;
            comboBox2.Visible = false;
            button7.Visible = false;
            selecionarTurma.Visible = false;
            comboBox1.Visible = false;
            textBox2.Visible = false;
            button5.Visible = false;
            listView3.Visible = false;
            button3.Visible = true;
            button4.Visible = true;
            Data.Visible = false;
            NovoNome.Visible = false;
            PresencaFalta.Visible = false;
            textBoxPF.Visible = false;
            textBox1.Visible = true;
            listView1.Visible = false;
            listView2.Visible = false;
            button1.Visible = false;
            btn_falta.Visible = false;
            imprimir.Visible = false;
            button6.Visible = false;

            EmpresaAluno.ReadOnly = false;
            TurmaAluno.ReadOnly = false;

            atualizarCodigo = 1;

            Limpar();

            BuscarTodos.Visible = false;
            mensagem1.Text = "Selecione e digite os dados do aluno:";
            NomeAluno.Visible = false;
            TurmaAluno.Visible = false;
            EmpresaAluno.Visible = false;
            button2.Visible = false;
            button2.Text = "Salvar";
            textBox1.Text = "";


        }

        private void Atualizar_Click(object sender, EventArgs e) //MOSTRAR ATUALIZAR
        {
            Limpar();
            atualizarListaAlunos.Items.Clear();

            comboBox2.Visible = false;
            button7.Visible = false;
            selecionarTurma.Visible = false;
            comboBox1.Visible = false;
            textBox2.Visible = false;
            EmpresaAluno.ReadOnly = false;
            TurmaAluno.ReadOnly = false;

            atualizarListaAlunos.Visible = false;
            selecionarListaAlunos.Visible = false;
            button5.Visible = false;
            listView3.Visible = false;
            button3.Visible = true;
            button4.Visible = true;
            btn_falta.Visible = false;
            Data.Visible = false;
            PresencaFalta.Visible = false;
            textBoxPF.Visible = false;
            listView1.Visible = false;
            listView2.Visible = false;
            button1.Visible = false;
            imprimir.Visible = false;
            button6.Visible = false;

            enviarCodigo = 2;
            atualizarCodigo = 2;

            BuscarTodos.Visible = false;
            NovoNome.Visible = false;
            NomeAluno.Visible = false;
            TurmaAluno.Visible = false;
            EmpresaAluno.Visible = false;

            button2.Visible = false;
            button6.Text = "Atualizar";
            button2.Text = "Atualizar";
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e) //ENVIAR
        {
            if (enviarCodigo == 1) //ENVIAR DADOS ALUNO
            {
                string nomeAluno = NomeAluno.Text;
                string turmaAluno = TurmaAluno.Text;
                string empresaAluno = EmpresaAluno.Text;

                Aluno aluno = new Aluno(nomeAluno, turmaAluno, empresaAluno);

                if (alunoRepositorio.SalvarAluno(aluno))
                {
                    textBox1.Text = "Salvo";
                }
            }


            if (enviarCodigo == 2) //ATUALIZAR DADOS
            {
                string novoNome = NovoNome.Text;
                string nomeAluno = NomeAluno.Text;
                string turmaAluno = TurmaAluno.Text;
                string empresaAluno = EmpresaAluno.Text;
                string reservado = reservadoAluno.Text;

                Aluno aluno = new Aluno(nomeAluno, turmaAluno, empresaAluno);

                if (alunoRepositorio.AtualizarDadosAluno(aluno, reservado))
                {
                    textBox1.Text = "Atualizado";
                }
            }

            if (enviarCodigo == 3) //BUSCAR ALUNO
            {
                string nomeAluno = NomeAluno.Text;

                var aluno = alunoRepositorio.BuscarInfoAluno(nomeAluno);

                if (alunoRepositorio.BuscarInfoAluno(nomeAluno) is null)
                {
                    textBox1.Text = "O aluno inserido não existe, confira se inseriu o nome corretamente, ou cadastre-o.";
                }
                else
                {
                    if (aluno.Nome == nomeAluno)
                    {
                        TurmaAluno.Text = aluno.Turma;
                        EmpresaAluno.Text = aluno.Empresa;
                        textBox1.Text = "Encontrado";
                    }
                    else
                    {
                        textBox1.Text = "Não encontrado";
                    }

                }

            }

        }

        private void Presenca_Click(object sender, EventArgs e)
        {
            Limpar();

            comboBox1.Items.Clear();
            listView2.Items.Clear();
            string nomeAluno = NomeAluno.Text;

            string dia = Convert.ToString(Data.Value.Day);
            string mes = Convert.ToString(Data.Value.Month);
            string ano = Convert.ToString(Data.Value.Year);

            if (dia.Length <= 1)
            {
                string zero = "0";
                dia = zero + dia;
            }
            if (mes.Length <= 1)
            {
                string zero = "0";
                mes = zero + mes;
            }

            string dataDeHoje = dia + "/" + mes + "/" + ano;

            mensagem1.Text = "Digite o nome do aluno:";

            var todas = alunoRepositorio.BuscarTodasTurmas(); //COMBOBOX TURMAS

            var todasOrdem = from a in todas
                             orderby a
                             select new { a };

            foreach (var item in todasOrdem)
            {
                comboBox1.Items.Add(item.a);
            }

            selecionarListaAlunos.Visible = false;
            atualizarListaAlunos.Visible = false;
            comboBox2.Visible = false;
            button7.Visible = true;
            selecionarTurma.Visible = true;
            comboBox1.Visible = true;
            button6.Visible = false;
            textBox2.Visible = false;
            button5.Visible = false;
            listView3.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            btn_falta.Visible = true;
            BuscarTodos.Visible = false;
            NomeAluno.Visible = true;
            Data.Visible = true;
            NovoNome.Visible = false;
            TurmaAluno.Visible = false;
            EmpresaAluno.Visible = false;
            listView1.Visible = false;
            listView2.Visible = true;
            button1.Visible = true;
            imprimir.Visible = false;

            textBox1.Visible = false;
            button2.Visible = false;
            PresencaFalta.Visible = true;
            textBoxPF.Visible = true;
            textBoxPF.Text = "";
        }

        private void PresencaFalta_Click(object sender, EventArgs e)
        {
            string nomeAluno = NomeAluno.Text;

            string dia = Convert.ToString(Data.Value.Day);
            string mes = Convert.ToString(Data.Value.Month);
            string ano = Convert.ToString(Data.Value.Year);

            if (dia.Length <= 1)
            {
                string zero = "0";
                dia = zero + dia;
            }
            if (mes.Length <= 1)
            {
                string zero = "0";
                mes = zero + mes;
            }

            string dataDeHoje = dia + "/" + mes + "/" + ano;


            var verificacao = alunoRepositorio.BuscarAluno(nomeAluno);

            if (verificacao is null)
            {
                textBoxPF.Text = "O aluno inserido não existe, confira se inseriu o nome corretamente, ou cadastre-o.";
            }
            else
            {

                if (alunoRepositorio.BuscarAluno(nomeAluno).Nome == nomeAluno)
                {
                    textBoxPF.Text = "Presença computada";
                }
                else
                {
                    textBoxPF.Text = "Erro";
                }
            }

        }

        private void Falta_Click(object sender, EventArgs e)
        {
            Limpar();

            mensagem1.Text = "Digite o nome do aluno:";

            BuscarTodos.Visible = false;
            NomeAluno.Visible = true;
            Data.Visible = true;
            NovoNome.Visible = false;
            TurmaAluno.Visible = false;
            EmpresaAluno.Visible = false;
            listView1.Visible = false;
            listView2.Visible = true;
            button1.Visible = true;
            imprimir.Visible = false;

            button2.Visible = false;
            PresencaFalta.Visible = true;
            textBoxPF.Visible = true;
            PresencaFalta.Text = "Faltou";
            textBoxPF.Text = "";
        }

        private void BuscarInfoNome_Click(object sender, EventArgs e)
        {
            Limpar();

            enviarCodigo = 3;

            mensagem1.Text = "Digite o nome do aluno:";

            selecionarListaAlunos.Visible = false;
            atualizarListaAlunos.Visible = false;
            comboBox2.Visible = false;
            button7.Visible = false;
            selecionarTurma.Visible = false;
            comboBox1.Visible = false;
            textBox2.Visible = false;
            button5.Visible = false;
            listView3.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            EmpresaAluno.ReadOnly = true;
            TurmaAluno.ReadOnly = true;
            button6.Visible = false;

            btn_falta.Visible = false;
            BuscarTodos.Visible = false;
            NomeAluno.Visible = true;
            NovoNome.Visible = false;
            TurmaAluno.Visible = true;
            EmpresaAluno.Visible = true;
            listView1.Visible = false;
            listView2.Visible = false;
            button1.Visible = false;
            imprimir.Visible = false;

            button2.Visible = true;
            PresencaFalta.Visible = false;
            textBoxPF.Visible = false;
            Data.Visible = false;
            button2.Text = "Buscar";
            textBox1.Text = "";

        }

        private void BuscarPresenca_Click(object sender, EventArgs e)
        {
            Limpar();
            comboBox2.Items.Clear();

            mensagem1.Text = "Escolha a data";
            listView1.Items.Clear();

            selecionarListaAlunos.Visible = false;
            atualizarListaAlunos.Visible = false;
            comboBox2.Visible = true;
            button7.Visible = false;
            selecionarTurma.Visible = false;
            comboBox1.Visible = false;
            textBox2.Visible = false;
            button5.Visible = false;
            listView3.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button2.Visible = false;
            btn_falta.Visible = false;
            listView1.Visible = true;
            EmpresaAluno.ReadOnly = true;
            TurmaAluno.ReadOnly = true;
            imprimir.Visible = true;
            button6.Visible = false;

            NomeAluno.Visible = false;
            NovoNome.Visible = false;
            TurmaAluno.Visible = false;
            EmpresaAluno.Visible = false;
            listView1.Visible = true;
            listView2.Visible = false;
            button1.Visible = false;

            BuscarTodos.Visible = true;
            button2.Visible = true;
            PresencaFalta.Visible = false;
            textBoxPF.Visible = false;
            Data.Visible = true;
            button2.Visible = false;
            textBox1.Visible = false;

            var todas = alunoRepositorio.BuscarTodasTurmas(); //COMBOBOX TURMAS

            var todasOrdem = from a in todas
                             orderby a
                             select new { a };

            foreach (var item in todasOrdem)
            {
                comboBox2.Items.Add(item.a);
            }

        }

        private void BuscarTodos_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string dia = Convert.ToString(Data.Value.Day);
            string mes = Convert.ToString(Data.Value.Month);
            string ano = Convert.ToString(Data.Value.Year);

            if (dia.Length <= 1)
            {
                string zero = "0";
                dia = zero + dia;
            }
            if (mes.Length <= 1)
            {
                string zero = "0";
                mes = zero + mes;
            }

            string dataDeHoje = dia + "/" + mes + "/" + ano;
            var todosDia = alunoRepositorio.BuscarTodosDoDia(dataDeHoje);

            string turma = comboBox2.Text;
            var todosTurma = alunoRepositorio.BuscarTodosDaTurma(turma);

            var todasDiaOrdem = from a in todosDia
                                orderby a.Nome
                                select new { a.Nome };

            var todasTurmaOrdem = from a in todosTurma
                                  orderby a.Nome
                                  select new { a.Nome };

            foreach (var doDia in todasDiaOrdem)
            {
                foreach (var daTurma in todasTurmaOrdem)
                {
                    if (doDia.Nome == daTurma.Nome)
                    {
                        listView1.Items.Add(doDia.Nome);
                    }
                    else
                    {
                        int um = 1;
                    }
                }
            }
        }

        private void imprimir_Click(object sender, EventArgs e)
        {

            string dia = Convert.ToString(Data.Value.Day);
            string mes = Convert.ToString(Data.Value.Month);
            string ano = Convert.ToString(Data.Value.Year);

            if (dia.Length <= 1)
            {
                string zero = "0";
                dia = zero + dia;
            }
            if (mes.Length <= 1)
            {
                string zero = "0";
                mes = zero + mes;
            }

            string dataDeHoje = dia + "/" + mes + "/" + ano;

            var todos = alunoRepositorio.BuscarTodosDoDia(dataDeHoje);

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Alunos");

                int i = 0;

                worksheet.Cell("A1").Value = "ALUNOS";
                worksheet.Cell("A1").Style.Font.Bold = true;


                foreach (var item in todos)
                {
                    i++;
                    worksheet.Cell("A" + (i + 1)).Value = item.Nome;
                    worksheet.Cell("B" + (i + 1)).Value = "PRESENTE";
                }

                workbook.SaveAs(@"C:\Users\Bigode\Desktop\Code\teste2.xlsx");
            }

            Process.Start(new ProcessStartInfo(@"C:\Users\Bigode\Desktop\Code\teste2.xlsx") { UseShellExecute = true });

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            reservadoAluno.Text = listView2.SelectedItems[0].Text;
            NomeAluno.Text = listView2.SelectedItems[0].Text;
        }

        private void btn_falta_Click(object sender, EventArgs e)
        {

            string nomeAluno = NomeAluno.Text;

            string dia = Convert.ToString(Data.Value.Day);
            string mes = Convert.ToString(Data.Value.Month);
            string ano = Convert.ToString(Data.Value.Year);

            if (dia.Length <= 1)
            {
                string zero = "0";
                dia = zero + dia;
            }
            if (mes.Length <= 1)
            {
                string zero = "0";
                mes = zero + mes;
            }

            string dataDeHoje = dia + "/" + mes + "/" + ano;

            var checar = alunoRepositorio.BuscarTodosDoDia(dataDeHoje);
            alunoRepositorio.DeletarPresenca(dataDeHoje, nomeAluno);
            var todos = alunoRepositorio.BuscarTodosDoDia(dataDeHoje);

            int teste = 0;
            int teste2 = 0;
            int teste3 = 0;

            foreach (var item in todos)
            {
                if (item.Nome == nomeAluno)
                {
                    textBoxPF.Text = "Falta não computada, confira os campos e tente novamente";
                    teste2 = 1;
                    teste3 = 1;
                }

            }
            if (teste2 == 0)
            {

                foreach (var item in checar)
                {
                    if (item.Nome != nomeAluno)
                    {
                        teste = 1;
                        teste3 = 1;
                    }

                }
                if (teste == 1)
                {
                    textBoxPF.Text = "O aluno não possuia presença, ou recebeu presença mais de uma vez no mesmo dia";
                }

            }
            if (teste3 == 0)
            {
                textBoxPF.Text = "Falta computada!";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Limpar();
            listView3.Clear();
            NomeAluno.PlaceholderText = "Nome";

            if (atualizarCodigo == 1) //CADASTRAR ALUNO
            {


                button5.Visible = true;
                TurmaAluno.ReadOnly = true;
                button3.Visible = false;
                button4.Visible = false;
                listView3.Visible = true;
                selecionarListaAlunos.Visible = false;

                NomeAluno.Visible = true;
                TurmaAluno.Visible = true;
                EmpresaAluno.Visible = true;
                button2.Visible = true;
                button2.Text = "Salvar";
                textBox1.Text = "";

                enviarCodigo = 1;

                var todas = alunoRepositorio.BuscarTodasTurmas();

                var todosOrdem = from a in todas
                                 orderby a
                                 select new { a };

                foreach (var item in todosOrdem)
                {
                    listView3.Items.Add(item.a);
                }
            }
            if (atualizarCodigo == 2) //ATUALIZAR ALUNO
            {
                listView2.Items.Clear();

                button1.Visible = true;
                button5.Visible = false;
                TurmaAluno.ReadOnly = false;
                button3.Visible = false;
                button1.Visible = false;
                button4.Visible = false;
                button5.Visible = true;
                listView3.Visible = true;
                atualizarListaAlunos.Visible = true;
                selecionarListaAlunos.Visible = true;

                NomeAluno.Visible = true;
                TurmaAluno.Visible = true;
                EmpresaAluno.Visible = true;
                button2.Visible = true;
                button2.Text = "Atualizar";
                textBox1.Text = "";

                //Lista turmas

                var todas = alunoRepositorio.BuscarTodasTurmas();

                var todosOrdem = from a in todas
                                 orderby a
                                 select new { a };

                foreach (var item in todosOrdem)
                {
                    atualizarListaAlunos.Items.Add(item.a);
                }

                //Lista alunos

                var todosAlunos = alunoRepositorio.BuscarTodosAlunos();

                var todosAlunosOrdem = from a in todosAlunos
                                       orderby a.Nome
                                       select new { a.Nome };

                foreach (var item in todosAlunosOrdem)
                {
                    listView3.Items.Add(item.Nome);
                }


            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            //CADASTRAR TURMA
            if (atualizarCodigo == 1)
            {
                Limpar();
                listView3.Clear();
                NomeAluno.PlaceholderText = "Turma";

                button6.Visible = true;
                textBox2.Visible = true;
                button5.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                listView3.Visible = true;

                NomeAluno.Visible = true;
                TurmaAluno.Visible = false;
                EmpresaAluno.Visible = false;
                button2.Visible = false;
                button2.Text = "Salvar";
                textBox1.Text = "";

                enviarCodigo = 4;

                var todas = alunoRepositorio.BuscarTodasTurmas();

                var todosOrdem = from a in todas
                                 orderby a
                                 select new { a };

                foreach (var item in todosOrdem)
                {
                    listView3.Items.Add(item.a);
                }

            }

            //ATUALIZAR TURMA
            if (atualizarCodigo == 2)
            {
                Limpar();
                listView3.Items.Clear();

                atualizarListaAlunos.Visible = false;
                selecionarListaAlunos.Visible = false;
                button6.Visible = true;
                textBox2.Visible = true;
                button5.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                listView3.Visible = true;

                NomeAluno.Visible = true;
                NomeAluno.PlaceholderText = "Turma";
                TurmaAluno.Visible = false;
                EmpresaAluno.Visible = false;
                button2.Visible = false;
                button2.Text = "Atualizar";
                textBox1.Text = "";

                enviarCodigo = 4;

                var todas = alunoRepositorio.BuscarTodasTurmas();

                var todosOrdem = from a in todas
                                 orderby a
                                 select new { a };

                foreach (var item in todosOrdem)
                {
                    listView3.Items.Add(item.a);
                }

            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (atualizarCodigo == 2)
            {
                NomeAluno.Text = listView3.SelectedItems[0].Text;
                reservadoAluno.Text = listView3.SelectedItems[0].Text;
            }
            if (atualizarCodigo == 1)
            {
                TurmaAluno.Text = listView3.SelectedItems[0].Text;
                reservadoAluno.Text = listView3.SelectedItems[0].Text;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (atualizarCodigo == 1) //SALVAR
            {
                string turma = NomeAluno.Text;

                if (alunoRepositorio.SalvarTurma(turma))
                {
                    textBox2.Text = "Salvo";
                }

            }
            if (atualizarCodigo == 2) //ATUALIZAR
            {
                string reserva = reservadoAluno.Text;
                string turma = NomeAluno.Text;

                if (alunoRepositorio.AtualizarDadosTurma(turma, reserva) && alunoRepositorio.AtualizarDadosTurmaEmGeral(turma, reserva))
                {
                    textBox2.Text = "Atualizado";
                }

            }
        }

        private void selecionarTurma_Click_1(object sender, EventArgs e)
        {
            listView2.Clear();

            string turma = comboBox1.Text;
            var todos = alunoRepositorio.BuscarTodosDaTurma(turma);

            var todosOrdem = from a in todos
                             orderby a.Nome
                             select new { a.Nome };

            foreach (var item in todosOrdem)
            {
                listView2.Items.Add(item.Nome);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string dia = Convert.ToString(Data.Value.Day);
            string mes = Convert.ToString(Data.Value.Month);
            string ano = Convert.ToString(Data.Value.Year);

            if (dia.Length <= 1)
            {
                string zero = "0";
                dia = zero + dia;
            }
            if (mes.Length <= 1)
            {
                string zero = "0";
                mes = zero + mes;
            }

            string dataDeHoje = dia + "/" + mes + "/" + ano;

            string turma = comboBox1.Text;
            var todosDaTurma = alunoRepositorio.BuscarTodosDaTurma(turma);

            foreach (var aluno in todosDaTurma)
            {
                alunoRepositorio.CriarDiaDeHojeDarPresenca(dataDeHoje, aluno.Nome);
            }
            textBox1.Text = "Computado!";

        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            reserva.Text = NomeAluno.Text;
            NomeAluno.Text = "";
            NomeAluno.Visible = false;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            NomeAluno.Text = "";
            NomeAluno.Text = reserva.Text;
            NomeAluno.Visible = true;
        }

        private void selecionarListaAlunos_Click(object sender, EventArgs e)
        {
            TurmaAluno.Text = atualizarListaAlunos.SelectedItems[0].Text;
            reservadoTurma.Text = atualizarListaAlunos.SelectedItems[0].Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string dia = Convert.ToString(Data.Value.Day);
            string mes = Convert.ToString(Data.Value.Month);
            string ano = Convert.ToString(Data.Value.Year);

            if (dia.Length <= 1)
            {
                string zero = "0";
                dia = zero + dia;
            }
            if (mes.Length <= 1)
            {
                string zero = "0";
                mes = zero + mes;
            }

            string dataDeHoje = dia + "/" + mes + "/" + ano;

            string turma = comboBox1.Text;
            var todosDaTurma = alunoRepositorio.BuscarTodosDaTurma(turma);

            foreach (var aluno in todosDaTurma)
            {
                alunoRepositorio.DeletarPresenca(dataDeHoje, aluno.Nome);
            }
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
                reserva.Text = NomeAluno.Text;
                NomeAluno.Text = "";
                NomeAluno.Visible = false;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
                NomeAluno.Text = "";
                NomeAluno.Text = reserva.Text;
                NomeAluno.Visible = true;   
        }
    }
}
