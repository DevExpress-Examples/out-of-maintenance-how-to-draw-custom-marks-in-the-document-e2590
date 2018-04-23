namespace CustomMarks
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Mark = new DevExpress.XtraEditors.SimpleButton();
            this.btn_DeleteMarks = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(0, 46);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(668, 311);
            this.richEditControl1.TabIndex = 0;
            this.richEditControl1.Text = "richEditControl1";
            this.richEditControl1.CustomMarkDraw += new DevExpress.XtraRichEdit.RichEditCustomMarkDrawEventHandler(this.richEditControl1_CustomMarkDraw);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_DeleteMarks);
            this.panelControl1.Controls.Add(this.btn_Mark);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(668, 46);
            this.panelControl1.TabIndex = 1;
            // 
            // btn_Mark
            // 
            this.btn_Mark.Location = new System.Drawing.Point(12, 12);
            this.btn_Mark.Name = "btn_Mark";
            this.btn_Mark.Size = new System.Drawing.Size(133, 23);
            this.btn_Mark.TabIndex = 0;
            this.btn_Mark.Text = "Draw a custom mark";
            this.btn_Mark.Click += new System.EventHandler(this.btn_Mark_Click);
            // 
            // btn_DeleteMarks
            // 
            this.btn_DeleteMarks.Location = new System.Drawing.Point(176, 12);
            this.btn_DeleteMarks.Name = "btn_DeleteMarks";
            this.btn_DeleteMarks.Size = new System.Drawing.Size(133, 23);
            this.btn_DeleteMarks.TabIndex = 1;
            this.btn_DeleteMarks.Text = "Delete all marks";
            this.btn_DeleteMarks.Click += new System.EventHandler(this.btn_DeleteMarks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 357);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Mark;
        private DevExpress.XtraEditors.SimpleButton btn_DeleteMarks;
    }
}

