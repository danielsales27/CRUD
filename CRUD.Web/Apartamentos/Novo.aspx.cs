using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRUD.Objetos;

namespace CRUD.Web.Apartamentos
{
    public partial class Novo : System.Web.UI.Page
    {
        public Predio Predio
        {
            get { return (Predio)Application["Predio"]; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }       

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Apartamento ap = new Apartamento();
            ap.Numero = txtNumero.Text;
            ap.Andar = Convert.ToInt32(txtAndar.Text);
            ap.Dono = txtDono.Text;
            ap.Area = Convert.ToDouble(txtArea.Text);
            ap.VagasGaragem = Convert.ToInt32(txtVagas.Text);

            Predio.AdicionarApartamento(ap);
            lblMensagem.Text = "Apartamento adicionado com sucesso";
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            txtAndar.Text = "";
            txtDono.Text = "";
            txtArea.Text = "";
            txtVagas.Text = "";
            lblMensagem.Text = "";
        }

        
    }
}