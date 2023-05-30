using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Pessoa pessoa;
        List<Pessoa> listP = new List<Pessoa>();
        private void button1_Click(object sender, EventArgs e)
        {
            pessoa = new Pessoa();
            pessoa.Nome = textBox1.Text;
            pessoa.Cidade = textBox2.Text;
            if(checkBox1.Checked == true)
                pessoa.ListaJogos.Add("Ele é");
            if (checkBox2.Checked == true)
                pessoa.ListaJogos.Add("Ele Não é");
            listP.Add(pessoa);
            textBox1.Clear();
            textBox2.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var i in listP)
            {
                listBox1.Items.Add(i.Mostra());
            }
        }
    }
    public class Pessoa
    {
        private string nome, cidade;
        private List<string> listaJogos;
        public global::System.String Nome { get => nome; set => nome = value; }
        public global::System.String Cidade { get => cidade; set => cidade = value; }
        public List<string> ListaJogos { get => listaJogos; set => listaJogos = value; }

        public string Mostra() { 
            string msg = $"Nome: {Nome}\tCidade: {Cidade}\n";
            foreach (var i in listaJogos)
                msg += "\t" + i;
            return msg;
        }
        public Pessoa()
        {
            ListaJogos= new List<string>();
        }
    }
}
