Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Namespace DXSample
    Partial Public Class Main
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Main))
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.flyoutPanel1 = New DXSample.CustomFlyoutPanel()
            DirectCast(Me.flyoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(170, 47)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(337, 54)
            Me.simpleButton1.TabIndex = 0
            Me.simpleButton1.Text = "Show FlyoutPanel"
            ' 
            ' flyoutPanel1
            ' 
            Me.flyoutPanel1.Location = New System.Drawing.Point(170, 120)
            Me.flyoutPanel1.Name = "flyoutPanel1"
            Me.flyoutPanel1.OptionsButtonPanel.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() { _
                New DevExpress.Utils.PeekFormButton("Button1", (DirectCast(resources.GetObject("flyoutPanel1.OptionsButtonPanel.Buttons"), System.Drawing.Image)), False, True, ""), _
                New DevExpress.Utils.PeekFormButton("Button2", (DirectCast(resources.GetObject("flyoutPanel1.OptionsButtonPanel.Buttons1"), System.Drawing.Image)), False, True, ""), _
                New DevExpress.Utils.PeekFormButton("Button3", (DirectCast(resources.GetObject("flyoutPanel1.OptionsButtonPanel.Buttons2"), System.Drawing.Image)), False, True, "") _
            })
            Me.flyoutPanel1.OptionsButtonPanel.ShowButtonPanel = True
            Me.flyoutPanel1.OwnerControl = Me
            Me.flyoutPanel1.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
            Me.flyoutPanel1.Size = New System.Drawing.Size(337, 61)
            Me.flyoutPanel1.TabIndex = 1
            ' 
            ' Main
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(696, 193)
            Me.Controls.Add(Me.flyoutPanel1)
            Me.Controls.Add(Me.simpleButton1)
            Me.Name = "Main"
            Me.Text = "Main"
            DirectCast(Me.flyoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private flyoutPanel1 As CustomFlyoutPanel


    End Class
End Namespace