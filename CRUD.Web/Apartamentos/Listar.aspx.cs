using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRUD.Objetos;

namespace CRUD.Web.Apartamentos
{
    public partial class Listar : System.Web.UI.Page
    {

        public Predio Predio
        {
            get { return (Predio)Application["Predio"]; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                string tabela = "<table><tr><td>Número do Apartamento</td><td>Nome do proprietário</td><tr>";
                foreach (Apartamento ap in Predio.Apartamentos)
                {
                    tabela += string.Format("<tr><td><a href=\"Visualizar.aspx?Numero={0}\">{0}</a><td>{1}</td></tr>",
                        ap.Numero, ap.Dono);
                }
                tabela += "</table>";
                litTabela.Text = tabela;
            }
        }
    }
}