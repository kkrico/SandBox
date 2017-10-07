using System;

namespace WebFormsDemoII.Exemplo01
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnClick(object sender, EventArgs e)
        {
            lblNome.Text = txtNome.Text;
        }

        protected void OnClickButton2(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}