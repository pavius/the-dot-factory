namespace TheDotFactory
{
    partial class AboutForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkIcons = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkContact = new System.Windows.Forms.LinkLabel();
            this.linkSite = new System.Windows.Forms.LinkLabel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.linkIcons);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.linkContact);
            this.panel2.Controls.Add(this.linkSite);
            this.panel2.Location = new System.Drawing.Point(9, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 59);
            this.panel2.TabIndex = 3;
            // 
            // linkIcons
            // 
            this.linkIcons.AutoSize = true;
            this.linkIcons.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkIcons.Location = new System.Drawing.Point(87, 33);
            this.linkIcons.Name = "linkIcons";
            this.linkIcons.Size = new System.Drawing.Size(81, 13);
            this.linkIcons.TabIndex = 4;
            this.linkIcons.TabStop = true;
            this.linkIcons.Text = "famfamfam.com";
            this.linkIcons.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkIcons_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Uses glyphs from ";
            // 
            // linkContact
            // 
            this.linkContact.AutoSize = true;
            this.linkContact.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkContact.Location = new System.Drawing.Point(3, 5);
            this.linkContact.Name = "linkContact";
            this.linkContact.Size = new System.Drawing.Size(95, 13);
            this.linkContact.TabIndex = 2;
            this.linkContact.TabStop = true;
            this.linkContact.Text = "admin@pavius.net";
            // 
            // linkSite
            // 
            this.linkSite.AutoSize = true;
            this.linkSite.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkSite.Location = new System.Drawing.Point(3, 19);
            this.linkSite.Name = "linkSite";
            this.linkSite.Size = new System.Drawing.Size(83, 13);
            this.linkSite.TabIndex = 1;
            this.linkSite.TabStop = true;
            this.linkSite.Text = "www.pavius.net";
            this.linkSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSite_LinkClicked);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(60, 7);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(159, 16);
            this.lblAppName.TabIndex = 6;
            this.lblAppName.Text = "The Dot Factory v.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Copyright 2009-2010, Eran \"Pavius\" Duchan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Released under GPL (see license.txt)";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 135);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Name = "AboutForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkContact;
        private System.Windows.Forms.LinkLabel linkSite;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkIcons;
        private System.Windows.Forms.Label label1;

    }
}