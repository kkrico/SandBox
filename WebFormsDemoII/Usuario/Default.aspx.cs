using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsDemoII
{
    public partial class Default : System.Web.UI.Page
    {
        public ICollection<UsuarioVO> Usuarios { get; set; }
        public Default()
        {
            Usuarios = new List<UsuarioVO>()
            {
                new UsuarioVO {Nome = "Maria" },
                new UsuarioVO {Nome = "Antonio" },
                new UsuarioVO {Nome = "Carlos" },
                new UsuarioVO {Nome = "José" },
                new UsuarioVO {Nome = "Flávia" },
                new UsuarioVO {Nome = "Leticia" }
            };
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                AtualizarGridView();
        }

        private void AtualizarGridView()
        {
            gvListaUsuarios.DataSource = Usuarios;
            gvListaUsuarios.DataBind();
        }

        protected void gvListaUsuarios_OnRowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void linkDetalhar_OnClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }

    public class UsuarioVO
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Setor { get; set; }
    }
}