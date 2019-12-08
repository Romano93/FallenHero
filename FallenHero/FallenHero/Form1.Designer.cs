namespace FallenHero
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAttach = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Aim = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chbTrigger = new System.Windows.Forms.CheckBox();
            this.tabMisc = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chbBhop = new System.Windows.Forms.CheckBox();
            this.tabVisual = new System.Windows.Forms.TabPage();
            this.chbBoxEsp = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabSkinchanger = new System.Windows.Forms.TabPage();
            this.btnSaveSkin = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lsbSkins = new System.Windows.Forms.ListBox();
            this.txbSearchSkin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbWeapon = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.chbSkinchanger = new System.Windows.Forms.CheckBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.BtnSaveNewCfg = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.cmbCfg = new System.Windows.Forms.ComboBox();
            this.txbSettingName = new System.Windows.Forms.TextBox();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chbOnlyEnemy = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.Aim.SuspendLayout();
            this.tabMisc.SuspendLayout();
            this.tabVisual.SuspendLayout();
            this.tabSkinchanger.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(12, 514);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(130, 33);
            this.btnAttach.TabIndex = 0;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 480);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(134, 20);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status: Detached";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Aim);
            this.tabControl1.Controls.Add(this.tabMisc);
            this.tabControl1.Controls.Add(this.tabVisual);
            this.tabControl1.Controls.Add(this.tabSkinchanger);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(381, 421);
            this.tabControl1.TabIndex = 4;
            // 
            // Aim
            // 
            this.Aim.Controls.Add(this.label4);
            this.Aim.Controls.Add(this.label3);
            this.Aim.Controls.Add(this.chbTrigger);
            this.Aim.Location = new System.Drawing.Point(4, 22);
            this.Aim.Name = "Aim";
            this.Aim.Padding = new System.Windows.Forms.Padding(3);
            this.Aim.Size = new System.Drawing.Size(373, 395);
            this.Aim.TabIndex = 1;
            this.Aim.Text = "tabAim";
            this.Aim.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reading";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Writing";
            // 
            // chbTrigger
            // 
            this.chbTrigger.AutoSize = true;
            this.chbTrigger.Location = new System.Drawing.Point(155, 42);
            this.chbTrigger.Name = "chbTrigger";
            this.chbTrigger.Size = new System.Drawing.Size(74, 17);
            this.chbTrigger.TabIndex = 0;
            this.chbTrigger.Text = "Triggerbot";
            this.chbTrigger.UseVisualStyleBackColor = true;
            this.chbTrigger.CheckedChanged += new System.EventHandler(this.chbTrigger_CheckedChanged);
            // 
            // tabMisc
            // 
            this.tabMisc.Controls.Add(this.label2);
            this.tabMisc.Controls.Add(this.label1);
            this.tabMisc.Controls.Add(this.chbBhop);
            this.tabMisc.Location = new System.Drawing.Point(4, 22);
            this.tabMisc.Name = "tabMisc";
            this.tabMisc.Padding = new System.Windows.Forms.Padding(3);
            this.tabMisc.Size = new System.Drawing.Size(373, 395);
            this.tabMisc.TabIndex = 0;
            this.tabMisc.Text = "Misc";
            this.tabMisc.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reading";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Writing";
            // 
            // chbBhop
            // 
            this.chbBhop.AutoSize = true;
            this.chbBhop.Location = new System.Drawing.Point(6, 42);
            this.chbBhop.Name = "chbBhop";
            this.chbBhop.Size = new System.Drawing.Size(69, 17);
            this.chbBhop.TabIndex = 0;
            this.chbBhop.Text = "Auto-hop";
            this.chbBhop.UseVisualStyleBackColor = true;
            this.chbBhop.CheckedChanged += new System.EventHandler(this.chbBhop_CheckedChanged);
            // 
            // tabVisual
            // 
            this.tabVisual.Controls.Add(this.chbOnlyEnemy);
            this.tabVisual.Controls.Add(this.chbBoxEsp);
            this.tabVisual.Controls.Add(this.label11);
            this.tabVisual.Controls.Add(this.label10);
            this.tabVisual.Location = new System.Drawing.Point(4, 22);
            this.tabVisual.Name = "tabVisual";
            this.tabVisual.Size = new System.Drawing.Size(373, 395);
            this.tabVisual.TabIndex = 4;
            this.tabVisual.Text = "Visual";
            this.tabVisual.UseVisualStyleBackColor = true;
            // 
            // chbBoxEsp
            // 
            this.chbBoxEsp.AutoSize = true;
            this.chbBoxEsp.Location = new System.Drawing.Point(155, 42);
            this.chbBoxEsp.Name = "chbBoxEsp";
            this.chbBoxEsp.Size = new System.Drawing.Size(68, 17);
            this.chbBoxEsp.TabIndex = 5;
            this.chbBoxEsp.Text = "Box ESP";
            this.chbBoxEsp.UseVisualStyleBackColor = true;
            this.chbBoxEsp.CheckedChanged += new System.EventHandler(this.chbBoxEsp_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(152, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Reading";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Writing";
            // 
            // tabSkinchanger
            // 
            this.tabSkinchanger.Controls.Add(this.btnSaveSkin);
            this.tabSkinchanger.Controls.Add(this.label7);
            this.tabSkinchanger.Controls.Add(this.lsbSkins);
            this.tabSkinchanger.Controls.Add(this.txbSearchSkin);
            this.tabSkinchanger.Controls.Add(this.label6);
            this.tabSkinchanger.Controls.Add(this.cmbWeapon);
            this.tabSkinchanger.Controls.Add(this.label5);
            this.tabSkinchanger.Controls.Add(this.btnApply);
            this.tabSkinchanger.Controls.Add(this.chbSkinchanger);
            this.tabSkinchanger.Location = new System.Drawing.Point(4, 22);
            this.tabSkinchanger.Name = "tabSkinchanger";
            this.tabSkinchanger.Size = new System.Drawing.Size(373, 395);
            this.tabSkinchanger.TabIndex = 3;
            this.tabSkinchanger.Text = "SkinChanger";
            this.tabSkinchanger.UseVisualStyleBackColor = true;
            // 
            // btnSaveSkin
            // 
            this.btnSaveSkin.Location = new System.Drawing.Point(288, 328);
            this.btnSaveSkin.Name = "btnSaveSkin";
            this.btnSaveSkin.Size = new System.Drawing.Size(82, 23);
            this.btnSaveSkin.TabIndex = 9;
            this.btnSaveSkin.Text = "Speichern";
            this.btnSaveSkin.UseVisualStyleBackColor = true;
            this.btnSaveSkin.Click += new System.EventHandler(this.btnSaveSkin_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Suche";
            // 
            // lsbSkins
            // 
            this.lsbSkins.FormattingEnabled = true;
            this.lsbSkins.Location = new System.Drawing.Point(11, 152);
            this.lsbSkins.Name = "lsbSkins";
            this.lsbSkins.Size = new System.Drawing.Size(271, 199);
            this.lsbSkins.TabIndex = 7;
            // 
            // txbSearchSkin
            // 
            this.txbSearchSkin.Location = new System.Drawing.Point(9, 124);
            this.txbSearchSkin.Name = "txbSearchSkin";
            this.txbSearchSkin.Size = new System.Drawing.Size(273, 20);
            this.txbSearchSkin.TabIndex = 6;
            this.txbSearchSkin.TextChanged += new System.EventHandler(this.txbSearchSkin_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Weapon:";
            // 
            // cmbWeapon
            // 
            this.cmbWeapon.FormattingEnabled = true;
            this.cmbWeapon.Location = new System.Drawing.Point(9, 78);
            this.cmbWeapon.Name = "cmbWeapon";
            this.cmbWeapon.Size = new System.Drawing.Size(361, 21);
            this.cmbWeapon.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Writing";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(3, 369);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(367, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply Skins";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // chbSkinchanger
            // 
            this.chbSkinchanger.AutoSize = true;
            this.chbSkinchanger.Location = new System.Drawing.Point(6, 42);
            this.chbSkinchanger.Name = "chbSkinchanger";
            this.chbSkinchanger.Size = new System.Drawing.Size(86, 17);
            this.chbSkinchanger.TabIndex = 1;
            this.chbSkinchanger.Text = "Skinchanger";
            this.chbSkinchanger.UseVisualStyleBackColor = true;
            this.chbSkinchanger.CheckedChanged += new System.EventHandler(this.chbSkinchanger_CheckedChanged);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.BtnSaveNewCfg);
            this.tabSettings.Controls.Add(this.label9);
            this.tabSettings.Controls.Add(this.label8);
            this.tabSettings.Controls.Add(this.btnRefreshList);
            this.tabSettings.Controls.Add(this.cmbCfg);
            this.tabSettings.Controls.Add(this.txbSettingName);
            this.tabSettings.Controls.Add(this.btnLoadSettings);
            this.tabSettings.Controls.Add(this.btnSaveSettings);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(373, 395);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // BtnSaveNewCfg
            // 
            this.BtnSaveNewCfg.Location = new System.Drawing.Point(265, 99);
            this.BtnSaveNewCfg.Name = "BtnSaveNewCfg";
            this.BtnSaveNewCfg.Size = new System.Drawing.Size(92, 23);
            this.BtnSaveNewCfg.TabIndex = 7;
            this.BtnSaveNewCfg.Text = "Save New Cfg";
            this.BtnSaveNewCfg.UseVisualStyleBackColor = true;
            this.BtnSaveNewCfg.Click += new System.EventHandler(this.BtnSaveNewCfg_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Neue Config:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Gespeicherte Configs:";
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Location = new System.Drawing.Point(265, 28);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(92, 23);
            this.btnRefreshList.TabIndex = 4;
            this.btnRefreshList.Text = "Refresh List";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // cmbCfg
            // 
            this.cmbCfg.FormattingEnabled = true;
            this.cmbCfg.Location = new System.Drawing.Point(8, 30);
            this.cmbCfg.Name = "cmbCfg";
            this.cmbCfg.Size = new System.Drawing.Size(251, 21);
            this.cmbCfg.TabIndex = 3;
            // 
            // txbSettingName
            // 
            this.txbSettingName.Location = new System.Drawing.Point(8, 101);
            this.txbSettingName.Name = "txbSettingName";
            this.txbSettingName.Size = new System.Drawing.Size(251, 20);
            this.txbSettingName.TabIndex = 2;
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.Location = new System.Drawing.Point(152, 349);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(107, 32);
            this.btnLoadSettings.TabIndex = 1;
            this.btnLoadSettings.Text = "Load Settings";
            this.btnLoadSettings.UseVisualStyleBackColor = true;
            this.btnLoadSettings.Click += new System.EventHandler(this.btnLoadSettings_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(8, 349);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(107, 32);
            this.btnSaveSettings.TabIndex = 0;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(168, 514);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chbOnlyEnemy
            // 
            this.chbOnlyEnemy.AutoSize = true;
            this.chbOnlyEnemy.Location = new System.Drawing.Point(229, 42);
            this.chbOnlyEnemy.Name = "chbOnlyEnemy";
            this.chbOnlyEnemy.Size = new System.Drawing.Size(107, 17);
            this.chbOnlyEnemy.TabIndex = 6;
            this.chbOnlyEnemy.Text = "Draw only enemy";
            this.chbOnlyEnemy.UseVisualStyleBackColor = true;
            this.chbOnlyEnemy.CheckedChanged += new System.EventHandler(this.chbOnlyEnemy_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 589);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnAttach);
            this.Name = "Form1";
            this.Text = "FallenHero";
            this.tabControl1.ResumeLayout(false);
            this.Aim.ResumeLayout(false);
            this.Aim.PerformLayout();
            this.tabMisc.ResumeLayout(false);
            this.tabMisc.PerformLayout();
            this.tabVisual.ResumeLayout(false);
            this.tabVisual.PerformLayout();
            this.tabSkinchanger.ResumeLayout(false);
            this.tabSkinchanger.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMisc;
        private System.Windows.Forms.CheckBox chbBhop;
        private System.Windows.Forms.TabPage Aim;
        private System.Windows.Forms.CheckBox chbTrigger;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnLoadSettings;
        private System.Windows.Forms.CheckBox chbSkinchanger;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TabPage tabSkinchanger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lsbSkins;
        private System.Windows.Forms.TextBox txbSearchSkin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbWeapon;
        private System.Windows.Forms.Button btnSaveSkin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txbSettingName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.ComboBox cmbCfg;
        private System.Windows.Forms.Button BtnSaveNewCfg;
        private System.Windows.Forms.TabPage tabVisual;
        private System.Windows.Forms.CheckBox chbBoxEsp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chbOnlyEnemy;
    }
}

