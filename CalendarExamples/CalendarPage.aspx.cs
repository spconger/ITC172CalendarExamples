﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CalendarPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {

        string myDate = Calendar1.SelectedDate.ToShortDateString();
        string birthday = "5/9/2017";
        if (myDate.Equals(birthday))
        {
            Label1.Text = "happy Birthday";
        }
        else
        {
            Label1.Text= Calendar1.SelectedDate.ToShortDateString();
        }
        //Label1.Text = DateTime.Now.ToString();
    }
    
}