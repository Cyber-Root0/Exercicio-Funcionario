using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_CadastroFuncionario
{
    public partial class CADASTRO : Form
    {
        public CADASTRO()
        {
            InitializeComponent();
        }

       // CRIAÇÃO DA STRUKT

            struct dados
        {
            public string nome;
            public int codigo;   
            public int idade;
            public string sexo;
            public double salario;       
        }

        dados[] vetor = new dados[5];
        int i = 0;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {

            //inicialição do sistema (sistema de loop)
            int repetidor = 5;


            if (i < repetidor)
            {
                string sexo = cb_sexo.Text;
                int idade = 0;
                DateTime datanascimento = Convert.ToDateTime(tb_data.Text);
                idade = DateTime.Now.Year - datanascimento.Year;



                //definição dos vetores

                vetor[i].nome = tb_nome.Text;
                vetor[i].codigo = Convert.ToInt32(tb_codigo.Text);
                vetor[i].sexo = sexo;
                vetor[i].idade = idade;

                //calculo do salaio
                double horas = Convert.ToDouble(tb_horas.Text);
                double valor = Convert.ToDouble(tb_valor.Text);
                double salario = valor * horas;
                double bonusfeminino = 0.2 * salario;
                double bonusidoso = 0.3 * salario;

               
                if (sexo == "M")
                {
                    salario = salario+0;
                    vetor[i].salario = salario;

                }

                if (sexo=="F")
                {
                    salario = salario + bonusfeminino;
                    vetor[i].salario = salario;
                    

                }
                if (idade >= 50)
                {
                    salario = salario + bonusidoso;
                    vetor[i].salario = salario;
                        
                    
                }

                //definição das coisas la no layout
                grid1.Rows.Add(vetor[i].codigo, vetor[i].nome, vetor[i].sexo, vetor[i].idade, vetor[i].salario);


                // configuração de loop
                i++;
                // finalização do sistema e Limpeza de caixas + Focus
                tb_nome.Text = "";
                tb_codigo.Text = "";
                tb_data.Text = "";
                tb_valor.Text = "";
                tb_horas.Text = "";
                cb_sexo.Text = "";
                tb_nome.Focus();



            }
            else { MessageBox.Show("Limite De Memoria Atingido"); }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            // finalização do sistema e Limpeza de caixas + Focus
            tb_nome.Text = "";
            tb_codigo.Text = "";
            tb_data.Text = "";
            tb_valor.Text = "";
            tb_horas.Text = "";
            cb_sexo.Text = "";
            tb_nome.Focus();
        }

        private void tb_repetidor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string pesquisa = tb_pesquisa.Text;

            int repetidor = 0;
            int qualvetor = 0;
            int res = 0;

            while(repetidor<=5 && res==0)
            {
                if (vetor[repetidor].nome == pesquisa)
                {
                    res = 1;
                    qualvetor = repetidor;


                }
                else { repetidor++; }

                

            }

            int idadee = vetor[qualvetor].idade;
            int codigo = vetor[qualvetor].codigo;
            double salar = vetor[qualvetor].salario;
            res_nome.Text = vetor[qualvetor].nome;
            res_idade.Text = Convert.ToString(idadee);
            res_sexo.Text = vetor[qualvetor].sexo;
            res_cod.Text = Convert.ToString(codigo);
            res_salario.Text = "R$: "+Convert.ToString(salar);
                 



        }
    }
}
