using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace AlimentacaoSaudavel
{
    public class CustomButton : Button
    {
        [Category("Aparência")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color HoverColor { get; set; } = Color.FromArgb(46, 125, 79);

        [Category("Aparência")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color NormalColor { get; set; } = Color.FromArgb(15, 72, 47);

        public CustomButton()
        {
            BackColor = NormalColor;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Width = 250;
            Height = 45;
            ForeColor = Color.White;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            BackColor = HoverColor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = NormalColor;
        }
    }
}
