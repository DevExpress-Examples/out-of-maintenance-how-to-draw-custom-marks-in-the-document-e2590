using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
#region #usings
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Layout.Export;
using System.Drawing.Drawing2D;
#endregion #usings

namespace CustomMarks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            richEditControl1.LoadDocument("Search.rtf");

        }

        #region #custommark
        private void btn_Mark_Click(object sender, EventArgs e)
        {
            Document doc = richEditControl1.Document;
            CustomMark m = doc.CreateCustomMark(doc.Selection.Start, Color.DarkOrange);   
        }

        private void richEditControl1_CustomMarkDraw(object sender, DevExpress.XtraRichEdit.RichEditCustomMarkDrawEventArgs e)
        {        
            foreach (CustomMarkVisualInfo info in e.VisualInfoCollection)
            {
                Document doc = richEditControl1.Document;
                CustomMark mark = doc.GetCustomMarkByVisualInfo(info);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                Color curColor = (Color)info.UserData;
                if (mark.Position < doc.Selection.Start) curColor = Color.Green;
                    Pen p = new Pen(curColor, 3);
                    p.StartCap = LineCap.Flat;
                    p.EndCap = LineCap.ArrowAnchor;
                    e.Graphics.DrawLine(p, new Point(0 , info.Bounds.Y), info.Bounds.Location);
            }
        }
        #endregion #custommark

        private void btn_DeleteMarks_Click(object sender, EventArgs e)
        {
            Document doc = richEditControl1.Document;
            for (int i = 0; i < doc.CustomMarks.Count; doc.DeleteCustomMark(doc.CustomMarks[i])) ;
        }
    }
}