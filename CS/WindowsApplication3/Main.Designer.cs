
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
namespace DXSample {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.flyoutPanel1 = new DXSample.CustomFlyoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(170, 47);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(337, 54);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Show FlyoutPanel";
            this.simpleButton1.Click += new System.EventHandler(this.OnShowFlyoutPanelButtonClick);
            // 
            // flyoutPanel1
            // 
            this.flyoutPanel1.Location = new System.Drawing.Point(170, 120);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.OptionsButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.Utils.PeekFormButton("Button1", ((System.Drawing.Image)(resources.GetObject("flyoutPanel1.OptionsButtonPanel.Buttons"))), false, true, ""),
            new DevExpress.Utils.PeekFormButton("Button2", ((System.Drawing.Image)(resources.GetObject("flyoutPanel1.OptionsButtonPanel.Buttons1"))), false, true, ""),
            new DevExpress.Utils.PeekFormButton("Button3", ((System.Drawing.Image)(resources.GetObject("flyoutPanel1.OptionsButtonPanel.Buttons2"))), false, true, "")});
            this.flyoutPanel1.OptionsButtonPanel.ShowButtonPanel = true;
            this.flyoutPanel1.OwnerControl = this;
            this.flyoutPanel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.flyoutPanel1.Size = new System.Drawing.Size(337, 61);
            this.flyoutPanel1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 193);
            this.Controls.Add(this.flyoutPanel1);
            this.Controls.Add(this.simpleButton1);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private CustomFlyoutPanel flyoutPanel1;

     
    }
}