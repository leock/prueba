﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Web.DynamicData;
using CarteraEmpleo.Clases;

namespace CarteraEmpleo
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            cCorreoComunicacion ins = new cCorreoComunicacion();
            txtCorreo.Text = ins.SendMail("jeragones@hotmail.com", "jeragones@gmail.com", "Hola", "Si funciona !!!");
        }

    }
}
