﻿using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeMoQLSV1.Report
{
    public partial class frmRP_DSSV : Form
    {
        public frmRP_DSSV()
        {
            InitializeComponent();
        }
        public string paratext_maK { set; get; }
        public string paratext_maN { set; get; }
        public string paratext_maL { set; get; }
        public string paratext_maSV { set; get; }
        public string paratext_maMH { set; get; }
        public string paratext_maHocKi { set; get; }
        private void crpv_DSSV_Load(object sender, EventArgs e)
        {
            RP_DSSV rp = new RP_DSSV();
            ParameterValues a = new ParameterValues();
            ParameterDiscreteValue b = new ParameterDiscreteValue();
            ParameterFieldDefinitions c;
            ParameterFieldDefinition d;

            b.Value = paratext_maK.ToString().Trim();
            c = rp.DataDefinition.ParameterFields;
            d = c["@maK"];
            a = d.CurrentValues;

            a.Clear();
            a.Add(b);
            d.ApplyCurrentValues(a);
            //Ma nghanh
            ParameterValues a1 = new ParameterValues();
            ParameterDiscreteValue b1 = new ParameterDiscreteValue();
            ParameterFieldDefinitions c1;
            ParameterFieldDefinition d1;
            b1.Value = paratext_maN.ToString().Trim();
            c1 = rp.DataDefinition.ParameterFields;
            d1 = c1["@maN"];
            a1 = d1.CurrentValues;

            a1.Clear();
            a1.Add(b1);
            d1.ApplyCurrentValues(a1);
            // Ma lop
            ParameterValues a2 = new ParameterValues();
            ParameterDiscreteValue b2 = new ParameterDiscreteValue();
            ParameterFieldDefinitions c2;
            ParameterFieldDefinition d2;
            b2.Value = paratext_maL.ToString().Trim();
            c2 = rp.DataDefinition.ParameterFields;
            d2 = c2["@maL"];
            a2 = d2.CurrentValues;

            a2.Clear();
            a2.Add(b2);
            d2.ApplyCurrentValues(a2);
            //// Ma SV
            //ParameterValues a3 = new ParameterValues();
            //ParameterDiscreteValue b3 = new ParameterDiscreteValue();
            //ParameterFieldDefinitions c3;
            //ParameterFieldDefinition d3;
            //b3.Value = paratext_maSV.ToString();
            //c3 = rp.DataDefinition.ParameterFields;
            //d3 = c3["@maSV"];
            //a3 = d3.CurrentValues;

            //a3.Clear();
            //a3.Add(b3);
            //d3.ApplyCurrentValues(a3);
            ////Ma Mon hoc
            //ParameterValues a4 = new ParameterValues();
            //ParameterDiscreteValue b4 = new ParameterDiscreteValue();
            //ParameterFieldDefinitions c4;
            //ParameterFieldDefinition d4;

            //b4.Value = paratext_maMH.ToString();
            //c4 = rp.DataDefinition.ParameterFields;
            //d4 = c4["@maMH"];
            //a4 = d4.CurrentValues;

            //a4.Clear();
            //a4.Add(b4);
            //d4.ApplyCurrentValues(a4);
            //Ma HocKi
            //ParameterValues a5 = new ParameterValues();
            //ParameterDiscreteValue b5 = new ParameterDiscreteValue();
            //ParameterFieldDefinitions c5;
            //ParameterFieldDefinition d5;

            //b5.Value = paratext_maHocKi.ToString();
            //c5 = rp.DataDefinition.ParameterFields;
            //d5 = c5["@maHocKi"];
            //a5 = d5.CurrentValues;

            //a5.Clear();
            //a5.Add(b5);
            //d5.ApplyCurrentValues(a5);

            crpv_DSSV.ReportSource = rp;
            crpv_DSSV.Refresh();
        }
    }
}
