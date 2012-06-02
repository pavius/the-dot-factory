/*
 * Copyright 2009, Eran "Pavius" Duchan
 * This file is part of The Dot Factory.
 *
 * The Dot Factory is free software: you can redistribute it and/or modify it 
 * under the terms of the GNU General Public License as published by the Free 
 * Software Foundation, either version 3 of the License, or (at your option) 
 * any later version. The Dot Factory is distributed in the hope that it will be 
 * useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
 * or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more 
 * details. You should have received a copy of the GNU General Public License along 
 * with The Dot Factory. If not, see http://www.gnu.org/licenses/.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheDotFactory
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            // set text
            lblAppName.Text = String.Format("The Dot Factory (v.{0})", MainForm.ApplicationVersion);
        }

        private void linkIcons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // open
            System.Diagnostics.Process.Start("http://www.famfamfam.com");
        }

        private void linkSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // open
            System.Diagnostics.Process.Start("http://www.pavius.net");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // open
            System.Diagnostics.Process.Start("https://github.com/mru00");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // open
            System.Diagnostics.Process.Start("https://github.com/psryland");
        }
   }
}
