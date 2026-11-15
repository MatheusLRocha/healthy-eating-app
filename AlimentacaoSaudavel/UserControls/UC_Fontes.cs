using AlimentacaoSaudavel.UserControls.Base;
using AlimentacaoSaudavel.UserControls.ClassificacaoAlimentos;
using AlimentacaoSaudavel.UserControls.MacroNutrientes;
using AlimentacaoSaudavel.UserControls.MicroNutrientes;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls
{
    public partial class UC_Fontes : UserControl
    {
        public UC_Fontes()
        {
            InitializeComponent();

            linkLabel1.LinkClicked += LinkLabel_LinkClicked;
            linkLabel2.LinkClicked += LinkLabel_LinkClicked;
            linkLabel4.LinkClicked += LinkLabel_LinkClicked;
            linkLabel5.LinkClicked += LinkLabel_LinkClicked;
        }

        PanelRound panelRound = new PanelRound();

        private void LinkLabel_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            if (sender is LinkLabel linkLabel &&
            linkLabel.Tag is string url &&
            Uri.TryCreate(url, UriKind.Absolute, out Uri? uri))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = uri.ToString(),
                    UseShellExecute = true
                });
            }
        }

        private void UC_Fontes_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 20);

            foreach (Panel panel in tableLayoutPanel1.Controls)
            {
                panelRound.ArredondarCantos(panel, 8);

                panel.Padding = new Padding(10);
            }
        }
    }
}
