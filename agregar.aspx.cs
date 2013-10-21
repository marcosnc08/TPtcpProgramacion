using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class agregar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void btnCrear_Click(object sender, EventArgs e)
    {
        contacto p = new contacto();
        p.nombre = txtNombre.Text;
        p.dni = txtDni.Text;
        p.direccion = txtdir.Text;
        p.fecha = Convert.ToString(cldNacimiento.SelectedDate);

        Hashtable agenda;

        if (Session["agenda"] == null)
            agenda = new Hashtable();
        else
            agenda = (Hashtable)Session["agenda"];
        agenda.Add(p.nombre, p);

        Session["agenda"] = agenda;

    }
}