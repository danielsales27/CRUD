using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRUD.Objetos;

namespace CRUD.Web.Apartamentos
{
    public partial class Editar : System.Web.UI.Page
    {
        public Predio Predio
        {
            get { return (Predio)Application["Predio"]; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string numero = Request.QueryString["Numero"];
                Apartamento ap = Predio.ConsultarApartamento(numero);
                lblNumero.Text = ap.Numero;
                txtAndar.Text = ap.Andar.ToString();
                txtDono.Text = ap.Dono;
                txtArea.Text = ap.Area.ToString();
                txtVagas.Text = ap.VagasGaragem.ToString();
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            string numero = Request.QueryString["Numero"];
            Apartamento ap = Predio.ConsultarApartamento(numero);
            ap.Andar = Convert.ToInt32(txtAndar.Text);
            ap.Dono = txtDono.Text;
            ap.Area = Convert.ToDouble(txtArea.Text);
            ap.VagasGaragem = Convert.ToInt32(txtVagas.Text);

            Predio.AdicionarApartamento(ap);
            lblMensagem.Text = "Apartamento alterado com sucesso";
        }
    }
}