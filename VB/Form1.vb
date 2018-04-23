Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
#Region "#usings"
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Layout.Export
Imports System.Drawing.Drawing2D
#End Region ' #usings

Namespace CustomMarks
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			richEditControl1.LoadDocument("Search.rtf")

		End Sub

		#Region "#custommark"
		Private Sub btn_Mark_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Mark.Click
			Dim doc As Document = richEditControl1.Document
			Dim m As CustomMark = doc.CreateCustomMark(doc.Selection.Start, Color.DarkOrange)
		End Sub

		Private Sub richEditControl1_CustomMarkDraw(ByVal sender As Object,  _
ByVal e As DevExpress.XtraRichEdit.RichEditCustomMarkDrawEventArgs) Handles richEditControl1.CustomMarkDraw
			For Each info As CustomMarkVisualInfo In e.VisualInfoCollection
				Dim doc As Document = richEditControl1.Document
				Dim mark As CustomMark = doc.GetCustomMarkByVisualInfo(info)
				e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

				Dim curColor As Color = CType(info.UserData, Color)
				If mark.Position < doc.Selection.Start Then
					curColor = Color.Green
				End If
					Dim p As New Pen(curColor, 3)
					p.StartCap = LineCap.Flat
					p.EndCap = LineCap.ArrowAnchor
					e.Graphics.DrawLine(p, New Point(0, info.Bounds.Y), info.Bounds.Location)
			Next info
		End Sub
		#End Region ' #custommark

		Private Sub btn_DeleteMarks_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_DeleteMarks.Click
			Dim doc As Document = richEditControl1.Document
			Dim i As Integer = 0
			Do While i < doc.CustomMarks.Count

				doc.DeleteCustomMark(doc.CustomMarks(i))
			Loop
		End Sub
	End Class
End Namespace