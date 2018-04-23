Imports Microsoft.VisualBasic
Imports System
Namespace CustomMarks
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.btn_Mark = New DevExpress.XtraEditors.SimpleButton()
			Me.btn_DeleteMarks = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' richEditControl1
			' 
			Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControl1.Location = New System.Drawing.Point(0, 46)
			Me.richEditControl1.Name = "richEditControl1"
			Me.richEditControl1.Size = New System.Drawing.Size(668, 311)
			Me.richEditControl1.TabIndex = 0
			Me.richEditControl1.Text = "richEditControl1"
'			Me.richEditControl1.CustomMarkDraw += New DevExpress.XtraRichEdit.RichEditCustomMarkDrawEventHandler(Me.richEditControl1_CustomMarkDraw);
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.btn_DeleteMarks)
			Me.panelControl1.Controls.Add(Me.btn_Mark)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(668, 46)
			Me.panelControl1.TabIndex = 1
			' 
			' btn_Mark
			' 
			Me.btn_Mark.Location = New System.Drawing.Point(12, 12)
			Me.btn_Mark.Name = "btn_Mark"
			Me.btn_Mark.Size = New System.Drawing.Size(133, 23)
			Me.btn_Mark.TabIndex = 0
			Me.btn_Mark.Text = "Draw a custom mark"
'			Me.btn_Mark.Click += New System.EventHandler(Me.btn_Mark_Click);
			' 
			' btn_DeleteMarks
			' 
			Me.btn_DeleteMarks.Location = New System.Drawing.Point(176, 12)
			Me.btn_DeleteMarks.Name = "btn_DeleteMarks"
			Me.btn_DeleteMarks.Size = New System.Drawing.Size(133, 23)
			Me.btn_DeleteMarks.TabIndex = 1
			Me.btn_DeleteMarks.Text = "Delete all marks"
'			Me.btn_DeleteMarks.Click += New System.EventHandler(Me.btn_DeleteMarks_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(668, 357)
			Me.Controls.Add(Me.richEditControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = " "
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents btn_Mark As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btn_DeleteMarks As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

