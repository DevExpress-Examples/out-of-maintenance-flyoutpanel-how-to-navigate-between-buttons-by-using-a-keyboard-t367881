using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.ButtonPanel;
using DevExpress.Utils.Drawing.Helpers;

namespace DXSample {
    public class CustomFlyoutPanel : FlyoutPanel, IButtonsPanelOwner {
        public CustomFlyoutPanel() {
            
        }
        ObjectPainter IButtonsPanelOwner.GetPainter() {
            if (LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.Skin)
                return new CustomFlyoutButtonPanelControlSkinPainter(LookAndFeel);
            return new ButtonsPanelControlPainter();
        }
        int btnIndex = -1;
        internal int HotButtonIndex {
            get { return btnIndex; }
            set {
                if (value > ButtonPanel.Buttons.Count - 1 || value < 0) return;
                btnIndex = value;
                UpdateButtonPanel();
            }
        }
        internal void PerformClick() {
            if (btnIndex == -1) return;
            (ButtonPanel as IButtonsPanel).PerformClick(ButtonPanel.Buttons[btnIndex]);
            btnIndex = -1;
        }
    }
    public class CustomFlyoutButtonPanelControlSkinPainter : FlyoutButtonPanelControlSkinPainter {
        public CustomFlyoutButtonPanelControlSkinPainter(DevExpress.Skins.ISkinProvider provider)
            : base(provider) {

        }
        public override ObjectState CalcButtonState(IBaseButton button, IButtonsPanel panel) {
            CustomFlyoutPanel flyoutPanel = panel.Owner as CustomFlyoutPanel;
            if (flyoutPanel.HotButtonIndex == panel.Buttons.IndexOf(button))
                return ObjectState.Hot;
            return base.CalcButtonState(button, panel);
        }
    }
    public class CustomMessageFilter : IMessageFilter {
        CustomFlyoutPanel flyoutPanel;
        public CustomMessageFilter(CustomFlyoutPanel flyoutPanel) {
            this.flyoutPanel = flyoutPanel;
        }
        public bool PreFilterMessage(ref Message m) {
            if (flyoutPanel.IsPopupOpen && flyoutPanel.OptionsButtonPanel.ShowButtonPanel) {
                if (m.Msg == MSG.WM_SYSKEYDOWN) {
                    flyoutPanel.HotButtonIndex = 0;
                    return true;
                }
                if (m.Msg == MSG.WM_KEYDOWN) {
                    if ((int)m.WParam == 37) {//left arrow
                        flyoutPanel.HotButtonIndex--;
                    }
                    if ((int)m.WParam == 39) {//right arrow
                        flyoutPanel.HotButtonIndex++;
                    }
                    if ((int)m.WParam == 13) {//enter
                        flyoutPanel.PerformClick();
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
