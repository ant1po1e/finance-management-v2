using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Tabungan_Ceritanya_V2.Controls
{
    public class CustomRadioButton : RadioButton
    {
        private Color checkedColor = Color.MediumSlateBlue;
        private Color unCheckedColor = Color.Gray;

        [Category("Settings")]
        public Color CheckedColor
        {
            get { return checkedColor; }
            set
            {
                checkedColor = value;
                Invalidate();
            }
        }

        [Category("Settings")]
        public Color UnCheckedColor
        {
            get { return unCheckedColor; }
            set
            {
                unCheckedColor = value;
                Invalidate();
            }
        }

        public CustomRadioButton()
        {
            MinimumSize = new Size(0, 21);
            Padding = new Padding(10, 0, 0, 0);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            float rbBorderSize = 18F;
            float rbCheckSize = 12F;

            RectangleF rectRbBorder = new RectangleF()
            {
                X = 0.5F,
                Y = (Height - rbBorderSize) / 2, 
                Width = rbBorderSize,
                Height = rbBorderSize
            };

            RectangleF rectRbCheck = new RectangleF()
            {
                X = rectRbBorder.X + (rectRbBorder.Width - rbCheckSize) / 2, 
                Y = (Height - rbCheckSize) / 2, 
                Width = rbCheckSize,
                Height = rbCheckSize
            };

            using (Pen penBorder = new Pen(checkedColor, 1.6F))
            using (SolidBrush brushRbCheck = new SolidBrush(checkedColor))
            using (SolidBrush brushText = new SolidBrush(ForeColor))
            {
                graphics.Clear(BackColor);

                if (Checked)
                {
                    graphics.DrawEllipse(penBorder, rectRbBorder);
                    graphics.FillEllipse(brushRbCheck, rectRbCheck);
                }
                else
                {
                    penBorder.Color = unCheckedColor;
                    graphics.DrawEllipse(penBorder, rectRbBorder); 
                }

                graphics.DrawString(Text, Font, brushText,
                    rbBorderSize + 8, (Height - TextRenderer.MeasureText(Text, Font).Height) / 2);
            }
        }
    }
}
