using System.Windows.Forms;

namespace SystemTrayApp
{
    partial class AppWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppWindow));
            this.SystemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.button5 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.eghtesad = new System.Windows.Forms.Button();
            this.varzesh = new System.Windows.Forms.Button();
            this.goftogo = new System.Windows.Forms.Button();
            this.salamat = new System.Windows.Forms.Button();
            this.farhang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SystemTrayIcon
            // 
            this.SystemTrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SystemTrayIcon.Visible = true;
            this.SystemTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SystemTrayIconDoubleClick);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::SystemTrayApp.Properties.Resources.radio_avaa1;
            this.button2.Location = new System.Drawing.Point(156, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 65);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ava_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::SystemTrayApp.Properties.Resources.radio_iran1;
            this.button3.Location = new System.Drawing.Point(81, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 65);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.iran_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Image = global::SystemTrayApp.Properties.Resources.radio_javan2;
            this.button1.Location = new System.Drawing.Point(223, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.javan_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::SystemTrayApp.Properties.Resources.ezgif_7_790e9af8e7fd;
            this.button4.Location = new System.Drawing.Point(6, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 65);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ava_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 545);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(339, 67);
            this.webBrowser1.TabIndex = 6;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(11, 160);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(340, 379);
            this.webBrowser2.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::SystemTrayApp.Properties.Resources.radio_namayesh;
            this.button5.Location = new System.Drawing.Point(294, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 65);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.namayesh_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // eghtesad
            // 
            this.eghtesad.Image = global::SystemTrayApp.Properties.Resources.radio_eghtesad;
            this.eghtesad.Location = new System.Drawing.Point(294, 87);
            this.eghtesad.Name = "eghtesad";
            this.eghtesad.Size = new System.Drawing.Size(65, 65);
            this.eghtesad.TabIndex = 9;
            this.eghtesad.UseVisualStyleBackColor = true;
            this.eghtesad.Click += new System.EventHandler(this.eghtesad_Click);
            this.eghtesad.FlatAppearance.BorderSize = 0;
            this.eghtesad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // varzesh
            // 
            this.varzesh.Image = global::SystemTrayApp.Properties.Resources.radio_varzesh;
            this.varzesh.Location = new System.Drawing.Point(223, 86);
            this.varzesh.Name = "varzesh";
            this.varzesh.Size = new System.Drawing.Size(65, 65);
            this.varzesh.TabIndex = 10;
            this.varzesh.UseVisualStyleBackColor = true;
            this.varzesh.Click += new System.EventHandler(this.varzesh_Click);
            this.varzesh.FlatAppearance.BorderSize = 0;
            this.varzesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // goftogo
            // 
            this.goftogo.Image = global::SystemTrayApp.Properties.Resources.radio_goftego;
            this.goftogo.Location = new System.Drawing.Point(152, 86);
            this.goftogo.Name = "goftogo";
            this.goftogo.Size = new System.Drawing.Size(65, 65);
            this.goftogo.TabIndex = 11;
            this.goftogo.UseVisualStyleBackColor = true;
            this.goftogo.Click += new System.EventHandler(this.goftogo_Click);
            this.goftogo.FlatAppearance.BorderSize = 0;
            this.goftogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // salamat
            // 
            this.salamat.Image = global::SystemTrayApp.Properties.Resources.radio_salamat;
            this.salamat.Location = new System.Drawing.Point(81, 86);
            this.salamat.Name = "salamat";
            this.salamat.Size = new System.Drawing.Size(65, 65);
            this.salamat.TabIndex = 12;
            this.salamat.UseVisualStyleBackColor = true;
            this.salamat.Click += new System.EventHandler(this.salamat_Click);
            this.salamat.FlatAppearance.BorderSize = 0;
            this.salamat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // farhang
            // 
            this.farhang.Image = global::SystemTrayApp.Properties.Resources.radio_farhang;
            this.farhang.Location = new System.Drawing.Point(10, 86);
            this.farhang.Name = "farhang";
            this.farhang.Size = new System.Drawing.Size(65, 65);
            this.farhang.TabIndex = 13;
            this.farhang.UseVisualStyleBackColor = true;
            this.farhang.Click += new System.EventHandler(this.farhang_Click);
            this.farhang.FlatAppearance.BorderSize = 0;
            this.farhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // AppWindow
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 611);
            this.Controls.Add(this.farhang);
            this.Controls.Add(this.salamat);
            this.Controls.Add(this.goftogo);
            this.Controls.Add(this.varzesh);
            this.Controls.Add(this.eghtesad);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppWindow";
            this.Text = "رادیو اینترنتی پالیک";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon SystemTrayIcon;
        private System.Windows.Forms.Button button2;
        private Button button3;
        private Button button1;
        private Button button4;
        private WebBrowser webBrowser1;
        private WebBrowser webBrowser2;
        private Button button5;
        private NotifyIcon notifyIcon1;
        private Button eghtesad;
        private Button varzesh;
        private Button goftogo;
        private Button salamat;
        private Button farhang;
    }
}

