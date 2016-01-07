using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRUD.Objetos;

namespace CRUD.Web.Apartamentos
{
    public partial class Visualizar : System.Web.UI.Page
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
                lblAndar.Text = ap.Andar.ToString();
                lblDono.Text = ap.Dono;
                lblArea.Text = ap.Area.ToString();
                lblVagas.Text = ap.VagasGaragem.ToString();
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Editar.aspx?Numero=" + Request.QueryString["Numero"]);
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Predio.ExcluirApartamento(Request.QueryString["Numero"]);
            Response.Redirect("Listar.aspx");
        }
    }
}