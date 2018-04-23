Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DXSample

    Partial Public Class Main
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            Application.AddMessageFilter(New CustomMessageFilter(flyoutPanel1))
            AddHandler flyoutPanel1.ButtonClick, AddressOf OnButtonClick
        End Sub

        Private Sub OnButtonClick(ByVal sender As Object, ByVal e As FlyoutPanelButtonClickEventArgs)
            XtraMessageBox.Show(e.Button.Caption)
        End Sub
        Private Sub OnShowFlyoutPanelButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            flyoutPanel1.ShowBeakForm(Control.MousePosition)
        End Sub
        Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
            RemoveHandler flyoutPanel1.ButtonClick, AddressOf OnButtonClick
            MyBase.OnFormClosing(e)
        End Sub
    End Class
End Namespace