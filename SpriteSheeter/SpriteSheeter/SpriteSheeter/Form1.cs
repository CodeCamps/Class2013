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
            ddlDataFormat.SelectedIndex = 1;
            ddlImageFormat.SelectedIndex = 3;
            ddlColorFormat.SelectedIndex = 0;
            ddlColorFormat.Enabled = false;
            ddlDithering.SelectedIndex = 0;
            ddlDithering.Enabled = false;
            ddlAlgorithm.SelectedIndex = 0;
            ddlAlgorithm.Enabled = false;
            ddlHeuristics.SelectedIndex = 0;
            ddlHeuristics.Enabled = false;
            ddlTrimMode.SelectedIndex = 0;
            ddlTrimMode.Enabled = false;
            ddlScale.SelectedIndex = 0;
            ddlScaleMode.SelectedIndex = 0;
            ddlWidth.SelectedIndex = 6;
            ddlHeight.SelectedIndex = 6;

        }
    }
}
