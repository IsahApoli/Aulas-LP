using CadAluno.DAO;
using CadAluno.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                AlunoViewModel a = new AlunoViewModel();
                a.Id = Convert.ToInt32(textId.Text);
                a.Nome = textNome.Text;
                a.DataNascimento = Convert.ToDateTime(maskedTextData.Text);
                a.CidadeId = Convert.ToInt32(textCidade.Text);
                a.Mensalidade = Convert.ToDouble(textMesa.Text);

                AlunoDAO dao = new AlunoDAO();
                dao.Inserir(a);
                MessageBox.Show("Sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
