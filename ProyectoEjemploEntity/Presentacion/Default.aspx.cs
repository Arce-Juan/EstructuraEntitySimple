using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidad;
using Negocio;


namespace Presentacion
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ObtenerPersonas();
            }
        }

        private void ObtenerPersonas()
        {
            List<tb_Persona> list = PersonaCN.obtenerPersonas();
            foreach (var item in list)
            {
                lblDatos.Text += "Id: " + Convert.ToString(item.idPersona) + " - Apellido y nombre: " + item.apellidos + ", " + item.nombres + "<br/><hr>";
            }
        }
    }
}