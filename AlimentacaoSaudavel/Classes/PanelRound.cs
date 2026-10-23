using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AlimentacaoSaudavel
{
    public class PanelRound
    {
        public void ArredondarCantos(Control control, int raio)
        {
            if (control.Width <= 0 || control.Height <= 0)
            {
                return;
            }

            int diametro = raio * 2;

            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, diametro, diametro, 180, 90); // Canto superior esquerdo
            path.AddArc(control.Width - diametro, 0, diametro, diametro, 270, 90); // Canto superior direito
            path.AddArc(control.Width - diametro, control.Height - diametro, diametro, diametro, 0, 90); // Canto inferior direito
            path.AddArc(0, control.Height - diametro, diametro, diametro, 90, 90); // Canto inferior esquerdo

            path.CloseFigure();

            control.Region = new Region(path);
        }
    }
}
