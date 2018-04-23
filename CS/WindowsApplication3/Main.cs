using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DXSample {

    public partial class Main : XtraForm {
        public Main() {
            InitializeComponent();
            Application.AddMessageFilter(new CustomMessageFilter(flyoutPanel1));
            flyoutPanel1.ButtonClick += OnButtonClick;
        }

        void OnButtonClick(object sender, FlyoutPanelButtonClickEventArgs e) {
            XtraMessageBox.Show(e.Button.Caption);
        }
        private void OnShowFlyoutPanelButtonClick(object sender, EventArgs e) {
            flyoutPanel1.ShowBeakForm(Control.MousePosition);
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            flyoutPanel1.ButtonClick -= OnButtonClick;
            base.OnFormClosing(e);
        }
    }
}