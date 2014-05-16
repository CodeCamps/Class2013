using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpriteSheeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetDefaults();
            splitContainer1.Panel1.AutoScroll = true;
        }

        public void SetDefaults()
        {
            if (String.IsNullOrEmpty(txtSheetName.Text))
            {
                dlgSheetPath.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
            txtSheetName.Text = "Untitled";

            ddlDataFormat.SelectedIndex = 1;
            ddlDataFormat.Enabled = false;
            chkTrimFileExtension.Checked = true;

            ddlImageFormat.SelectedIndex = 3;
            ddlImageFormat.Enabled = false;

            ddlColorFormat.SelectedIndex = 0;
            ddlColorFormat.Enabled = false;
            ddlDithering.SelectedIndex = 0;
            ddlDithering.Enabled = false;
            chkPremultiplyAlpha.Checked = false;
            chkPremultiplyAlpha.Enabled = false;

            ddlWidth.SelectedIndex = 6;
            ddlHeight.SelectedIndex = 6;
            chkIsMaxSize.Checked = true;
            chkForceSquare.Checked = false;
            chkForcePowerOf2.Checked = true;

            ddlScale.SelectedIndex = 0;
            ddlScale.Enabled = false;
            ddlScaleMode.SelectedIndex = 0;
            ddlScaleMode.Enabled = false;

            ddlAlgorithm.SelectedIndex = 0;
            ddlAlgorithm.Enabled = false;
            ddlHeuristics.SelectedIndex = 0;
            ddlHeuristics.Enabled = false;
            numPadding.Value = 2;
            chkAllowRotation.Checked = false;

            ddlTrimMode.SelectedIndex = 0;
            ddlTrimMode.Enabled = false;
            numTrimThreshold.Value = 1;
            chkTransparentMask.Checked = false;

            chkDebugMode.Checked = false;
        }

        private void lnkSheetPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DialogResult.OK == dlgSheetPath.ShowDialog())
            {
                txtSheetPath.Text = dlgSheetPath.SelectedPath;
            }
        }
    }
}
