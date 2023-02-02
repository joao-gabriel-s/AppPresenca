
namespace formspresencaa
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
            this.Cadastrar = new System.Windows.Forms.Button();
            this.mensagem1 = new System.Windows.Forms.TextBox();
            this.Atualizar = new System.Windows.Forms.Button();
            this.NomeAluno = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TurmaAluno = new System.Windows.Forms.TextBox();
            this.EmpresaAluno = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NovoNome = new System.Windows.Forms.TextBox();
            this.Presenca = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.PresencaFalta = new System.Windows.Forms.Button();
            this.textBoxPF = new System.Windows.Forms.TextBox();
            this.BuscarInfoNome = new System.Windows.Forms.Button();
            this.BuscarPresenca = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BuscarTodos = new System.Windows.Forms.Button();
            this.imprimir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_falta = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.selecionarTurma = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.reserva = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.atualizarListaAlunos = new System.Windows.Forms.ListView();
            this.selecionarListaAlunos = new System.Windows.Forms.Button();
            this.reservadoAluno = new System.Windows.Forms.TextBox();
            this.reservadoTurma = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(13, 12);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(86, 43);
            this.Cadastrar.TabIndex = 0;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // mensagem1
            // 
            this.mensagem1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mensagem1.Location = new System.Drawing.Point(13, 78);
            this.mensagem1.Name = "mensagem1";
            this.mensagem1.ReadOnly = true;
            this.mensagem1.Size = new System.Drawing.Size(221, 16);
            this.mensagem1.TabIndex = 1;
            // 
            // Atualizar
            // 
            this.Atualizar.Location = new System.Drawing.Point(101, 12);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(86, 43);
            this.Atualizar.TabIndex = 2;
            this.Atualizar.Text = "Atualizar cadastro";
            this.Atualizar.UseVisualStyleBackColor = true;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // NomeAluno
            // 
            this.NomeAluno.Location = new System.Drawing.Point(13, 100);
            this.NomeAluno.Name = "NomeAluno";
            this.NomeAluno.PlaceholderText = "Nome";
            this.NomeAluno.Size = new System.Drawing.Size(221, 23);
            this.NomeAluno.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TurmaAluno
            // 
            this.TurmaAluno.Location = new System.Drawing.Point(13, 129);
            this.TurmaAluno.Name = "TurmaAluno";
            this.TurmaAluno.PlaceholderText = "Turma";
            this.TurmaAluno.Size = new System.Drawing.Size(221, 23);
            this.TurmaAluno.TabIndex = 5;
            // 
            // EmpresaAluno
            // 
            this.EmpresaAluno.Location = new System.Drawing.Point(13, 158);
            this.EmpresaAluno.Name = "EmpresaAluno";
            this.EmpresaAluno.PlaceholderText = "Empresa";
            this.EmpresaAluno.Size = new System.Drawing.Size(221, 23);
            this.EmpresaAluno.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(101, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(133, 16);
            this.textBox1.TabIndex = 7;
            // 
            // NovoNome
            // 
            this.NovoNome.Location = new System.Drawing.Point(13, 102);
            this.NovoNome.Name = "NovoNome";
            this.NovoNome.PlaceholderText = "Novo nome";
            this.NovoNome.Size = new System.Drawing.Size(221, 23);
            this.NovoNome.TabIndex = 8;
            // 
            // Presenca
            // 
            this.Presenca.Location = new System.Drawing.Point(189, 12);
            this.Presenca.Name = "Presenca";
            this.Presenca.Size = new System.Drawing.Size(86, 43);
            this.Presenca.TabIndex = 9;
            this.Presenca.Text = "Presença";
            this.Presenca.UseVisualStyleBackColor = true;
            this.Presenca.Click += new System.EventHandler(this.Presenca_Click);
            // 
            // Data
            // 
            this.Data.CustomFormat = "dd/MM/yyyy";
            this.Data.Location = new System.Drawing.Point(240, 100);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(211, 23);
            this.Data.TabIndex = 10;
            // 
            // PresencaFalta
            // 
            this.PresencaFalta.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.PresencaFalta.Location = new System.Drawing.Point(13, 129);
            this.PresencaFalta.Name = "PresencaFalta";
            this.PresencaFalta.Size = new System.Drawing.Size(75, 23);
            this.PresencaFalta.TabIndex = 11;
            this.PresencaFalta.Text = "PRESENÇA";
            this.PresencaFalta.UseVisualStyleBackColor = false;
            this.PresencaFalta.Click += new System.EventHandler(this.PresencaFalta_Click);
            // 
            // textBoxPF
            // 
            this.textBoxPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPF.Location = new System.Drawing.Point(175, 149);
            this.textBoxPF.Multiline = true;
            this.textBoxPF.Name = "textBoxPF";
            this.textBoxPF.ReadOnly = true;
            this.textBoxPF.Size = new System.Drawing.Size(59, 47);
            this.textBoxPF.TabIndex = 12;
            // 
            // BuscarInfoNome
            // 
            this.BuscarInfoNome.Location = new System.Drawing.Point(277, 12);
            this.BuscarInfoNome.Name = "BuscarInfoNome";
            this.BuscarInfoNome.Size = new System.Drawing.Size(86, 43);
            this.BuscarInfoNome.TabIndex = 14;
            this.BuscarInfoNome.Text = "Buscar aluno";
            this.BuscarInfoNome.UseVisualStyleBackColor = true;
            this.BuscarInfoNome.Click += new System.EventHandler(this.BuscarInfoNome_Click);
            // 
            // BuscarPresenca
            // 
            this.BuscarPresenca.Location = new System.Drawing.Point(365, 12);
            this.BuscarPresenca.Name = "BuscarPresenca";
            this.BuscarPresenca.Size = new System.Drawing.Size(86, 43);
            this.BuscarPresenca.TabIndex = 15;
            this.BuscarPresenca.Text = "Buscar presença";
            this.BuscarPresenca.UseVisualStyleBackColor = true;
            this.BuscarPresenca.Click += new System.EventHandler(this.BuscarPresenca_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 100);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(222, 247);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // BuscarTodos
            // 
            this.BuscarTodos.Location = new System.Drawing.Point(240, 158);
            this.BuscarTodos.Name = "BuscarTodos";
            this.BuscarTodos.Size = new System.Drawing.Size(75, 23);
            this.BuscarTodos.TabIndex = 18;
            this.BuscarTodos.Text = "Buscar";
            this.BuscarTodos.UseVisualStyleBackColor = true;
            this.BuscarTodos.Click += new System.EventHandler(this.BuscarTodos_Click);
            // 
            // imprimir
            // 
            this.imprimir.Location = new System.Drawing.Point(360, 369);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(91, 43);
            this.imprimir.TabIndex = 19;
            this.imprimir.Text = "Imprimir";
            this.imprimir.UseVisualStyleBackColor = true;
            this.imprimir.Click += new System.EventHandler(this.imprimir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_falta
            // 
            this.btn_falta.BackColor = System.Drawing.Color.IndianRed;
            this.btn_falta.Location = new System.Drawing.Point(94, 129);
            this.btn_falta.Name = "btn_falta";
            this.btn_falta.Size = new System.Drawing.Size(75, 23);
            this.btn_falta.TabIndex = 22;
            this.btn_falta.Text = "FALTA";
            this.btn_falta.UseVisualStyleBackColor = false;
            this.btn_falta.Click += new System.EventHandler(this.btn_falta_Click);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(240, 129);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(211, 247);
            this.listView2.TabIndex = 24;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Tile;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(240, 100);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(211, 276);
            this.listView3.TabIndex = 25;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.List;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 43);
            this.button3.TabIndex = 26;
            this.button3.Text = "Aluno";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(104, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 43);
            this.button4.TabIndex = 27;
            this.button4.Text = "Turma";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(312, 382);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 30);
            this.button5.TabIndex = 28;
            this.button5.Text = "Selecionar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 127);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 29;
            this.button6.Text = "Salvar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(93, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(141, 16);
            this.textBox2.TabIndex = 30;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 23);
            this.comboBox1.TabIndex = 31;
            // 
            // selecionarTurma
            // 
            this.selecionarTurma.Location = new System.Drawing.Point(159, 184);
            this.selecionarTurma.Name = "selecionarTurma";
            this.selecionarTurma.Size = new System.Drawing.Size(75, 23);
            this.selecionarTurma.TabIndex = 32;
            this.selecionarTurma.Text = "Selecionar";
            this.selecionarTurma.UseVisualStyleBackColor = true;
            this.selecionarTurma.Click += new System.EventHandler(this.selecionarTurma_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button7.Location = new System.Drawing.Point(13, 155);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 33;
            this.button7.Text = "TODOS";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.MouseLeave += new System.EventHandler(this.button7_MouseLeave);
            this.button7.MouseHover += new System.EventHandler(this.button7_MouseHover);
            // 
            // reserva
            // 
            this.reserva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reserva.Location = new System.Drawing.Point(12, 396);
            this.reserva.Name = "reserva";
            this.reserva.ReadOnly = true;
            this.reserva.Size = new System.Drawing.Size(141, 16);
            this.reserva.TabIndex = 34;
            this.reserva.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(240, 129);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(211, 23);
            this.comboBox2.TabIndex = 35;
            // 
            // atualizarListaAlunos
            // 
            this.atualizarListaAlunos.HideSelection = false;
            this.atualizarListaAlunos.Location = new System.Drawing.Point(13, 213);
            this.atualizarListaAlunos.Name = "atualizarListaAlunos";
            this.atualizarListaAlunos.Size = new System.Drawing.Size(221, 163);
            this.atualizarListaAlunos.TabIndex = 36;
            this.atualizarListaAlunos.UseCompatibleStateImageBehavior = false;
            this.atualizarListaAlunos.View = System.Windows.Forms.View.Tile;
            // 
            // selecionarListaAlunos
            // 
            this.selecionarListaAlunos.Location = new System.Drawing.Point(77, 382);
            this.selecionarListaAlunos.Name = "selecionarListaAlunos";
            this.selecionarListaAlunos.Size = new System.Drawing.Size(76, 30);
            this.selecionarListaAlunos.TabIndex = 37;
            this.selecionarListaAlunos.Text = "Selecionar";
            this.selecionarListaAlunos.UseVisualStyleBackColor = true;
            this.selecionarListaAlunos.Click += new System.EventHandler(this.selecionarListaAlunos_Click);
            // 
            // reservadoAluno
            // 
            this.reservadoAluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservadoAluno.Location = new System.Drawing.Point(159, 380);
            this.reservadoAluno.Name = "reservadoAluno";
            this.reservadoAluno.ReadOnly = true;
            this.reservadoAluno.Size = new System.Drawing.Size(141, 16);
            this.reservadoAluno.TabIndex = 38;
            this.reservadoAluno.Visible = false;
            // 
            // reservadoTurma
            // 
            this.reservadoTurma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservadoTurma.Location = new System.Drawing.Point(159, 402);
            this.reservadoTurma.Name = "reservadoTurma";
            this.reservadoTurma.ReadOnly = true;
            this.reservadoTurma.Size = new System.Drawing.Size(141, 16);
            this.reservadoTurma.TabIndex = 39;
            this.reservadoTurma.Visible = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.IndianRed;
            this.button8.Location = new System.Drawing.Point(94, 155);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 40;
            this.button8.Text = "TODOS";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            this.button8.MouseLeave += new System.EventHandler(this.button8_MouseLeave);
            this.button8.MouseHover += new System.EventHandler(this.button8_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 422);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.selecionarListaAlunos);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.BuscarTodos);
            this.Controls.Add(this.reserva);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imprimir);
            this.Controls.Add(this.BuscarPresenca);
            this.Controls.Add(this.BuscarInfoNome);
            this.Controls.Add(this.Presenca);
            this.Controls.Add(this.NovoNome);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NomeAluno);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.mensagem1);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.reservadoTurma);
            this.Controls.Add(this.reservadoAluno);
            this.Controls.Add(this.PresencaFalta);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.selecionarTurma);
            this.Controls.Add(this.textBoxPF);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.atualizarListaAlunos);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_falta);
            this.Controls.Add(this.TurmaAluno);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.EmpresaAluno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sistema de Chamada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.TextBox mensagem1;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.TextBox NomeAluno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TurmaAluno;
        private System.Windows.Forms.TextBox EmpresaAluno;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox NovoNome;
        private System.Windows.Forms.Button Presenca;
        private System.Windows.Forms.DateTimePicker Data;
        private System.Windows.Forms.Button PresencaFalta;
        private System.Windows.Forms.TextBox textBoxPF;
        private System.Windows.Forms.Button BuscarInfoNome;
        private System.Windows.Forms.Button BuscarPresenca;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button BuscarTodos;
        private System.Windows.Forms.Button imprimir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_falta;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button selecionarTurma;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox reserva;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListView atualizarListaAlunos;
        private System.Windows.Forms.Button selecionarListaAlunos;
        private System.Windows.Forms.TextBox reservadoAluno;
        private System.Windows.Forms.TextBox reservadoTurma;
        private System.Windows.Forms.Button button8;
    }
}

