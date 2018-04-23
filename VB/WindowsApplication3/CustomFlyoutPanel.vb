Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.ButtonPanel
Imports DevExpress.Utils.Drawing.Helpers

Namespace DXSample
    Public Class CustomFlyoutPanel
        Inherits FlyoutPanel
        Implements IButtonsPanelOwner

        Public Sub New()

        End Sub
        Private Function IButtonsPanelOwner_GetPainter() As ObjectPainter Implements IButtonsPanelOwner.GetPainter
            If LookAndFeel.ActiveStyle = ActiveLookAndFeelStyle.Skin Then
                Return New CustomFlyoutButtonPanelControlSkinPainter(LookAndFeel)
            End If
            Return New ButtonsPanelControlPainter()
        End Function
        Private btnIndex As Integer = -1
        Friend Property HotButtonIndex() As Integer
            Get
                Return btnIndex
            End Get
            Set(ByVal value As Integer)
                If value > ButtonPanel.Buttons.Count - 1 OrElse value < 0 Then
                    Return
                End If
                btnIndex = value
                UpdateButtonPanel()
            End Set
        End Property
        Friend Sub PerformClick()
            If btnIndex = -1 Then
                Return
            End If
            TryCast(ButtonPanel, IButtonsPanel).PerformClick(ButtonPanel.Buttons(btnIndex))
            btnIndex = -1
        End Sub
    End Class
    Public Class CustomFlyoutButtonPanelControlSkinPainter
        Inherits FlyoutButtonPanelControlSkinPainter

        Public Sub New(ByVal provider As DevExpress.Skins.ISkinProvider)
            MyBase.New(provider)

        End Sub
        Public Overrides Function CalcButtonState(ByVal button As IBaseButton, ByVal panel As IButtonsPanel) As ObjectState
            Dim flyoutPanel As CustomFlyoutPanel = TryCast(panel.Owner, CustomFlyoutPanel)
            If flyoutPanel.HotButtonIndex = panel.Buttons.IndexOf(button) Then
                Return ObjectState.Hot
            End If
            Return MyBase.CalcButtonState(button, panel)
        End Function
    End Class
    Public Class CustomMessageFilter
        Implements IMessageFilter

        Private flyoutPanel As CustomFlyoutPanel
        Public Sub New(ByVal flyoutPanel As CustomFlyoutPanel)
            Me.flyoutPanel = flyoutPanel
        End Sub
        Public Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
            If flyoutPanel.IsPopupOpen AndAlso flyoutPanel.OptionsButtonPanel.ShowButtonPanel Then
                If m.Msg = MSG.WM_SYSKEYDOWN Then
                    flyoutPanel.HotButtonIndex = 0
                    Return True
                End If
                If m.Msg = MSG.WM_KEYDOWN Then
                    If CInt((m.WParam)) = 37 Then 'left arrow
                        flyoutPanel.HotButtonIndex -= 1
                    End If
                    If CInt((m.WParam)) = 39 Then 'right arrow
                        flyoutPanel.HotButtonIndex += 1
                    End If
                    If CInt((m.WParam)) = 13 Then 'enter
                        flyoutPanel.PerformClick()
                    End If
                    Return True
                End If
            End If
            Return False
        End Function
    End Class
End Namespace
