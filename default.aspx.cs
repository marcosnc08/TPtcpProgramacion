using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        Hashtable agenda = new Hashtable();
        
        DataRow row = null;

        dt.Columns.Add("nombre", typeof(string));
        dt.Columns.Add("dni", typeof(string));
        dt.Columns.Add("fecha", typeof(string));
        dt.Columns.Add("direccion", typeof(string));

        if (Session["agenda"] != null)
        {
            agenda = (Hashtable)Session["agenda"];

            foreach(DictionaryEntry p in agenda)
            {
                contacto contacto_actual = (contacto)p.Value;
                row = dt.NewRow();
                row["nombre"] = contacto_actual.nombre;
                row["dni"] = contacto_actual.dni;
                row["fecha"] = contacto_actual.fecha;
                row["direccion"] = contacto_actual.direccion;

                dt.Rows.Add(row);
            }

            gdLista.DataSource = dt;
            gdLista.DataBind();
        }
            
        
        
    }
}