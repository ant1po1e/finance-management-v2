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
    public enum TextPosition
    {
        Left,
        Right,
        Center,
        Sliding,
        None
    }

    public class CustomProgressBar : ProgressBar
    {
        private Color channelColor = Color.LightSteelBlue;
        private Color sliderColor = Color.RoyalBlue;
        private Color foreBackColor = Color.RoyalBlue;
        private int channelHeight = 6;
        private int sliderHeight = 6;
        private TextPosition showValue = TextPosition.Right;
        private string symbolBefore = "";
        private string symbolAfter = "";
        private bool showMaximun = false;
        private bool paintedBack = false;
        private bool stopPainting = false;

        public CustomProgressBar()
        {
            SetStyle(ControlStyles.UserPaint, true);
            ForeColor = Color.White;
        }

        [Category("Settings")]
        public Color ChannelColor
        {
            get { return channelColor; }
            set
            {
                channelColor = value;
                Invalidate();
            }
        }

        [Category("Settings")]
        public Color SliderColor
        {
            get { return sliderColor; }
            set
            {
                sliderColor = value;
                Invalidate();
            }
        }

        [Category("Settings")]
        public Color ForeBackColor
        {
            get { return foreBackColor; }
            set
            {
                foreBackColor = value;
                Invalidate();
            }
        }

        [Category("Settings")]
        public int ChannelHeight
        {
            get { return channelHeight; }
            set
            {
                channelHeight = value;
                Invalidate();
            }
        }

        [Category("Settings")]
        public int SliderHeight
        {
            get { return sliderHeight; }
            set
            {
                sliderHeight = value;
                Invalidate();
            }
        }

        [Category("Settings")]
        public TextPosition ShowValue
        {
            get { return showValue; }
            set
            {
                showValue = value;
                Invalidate();
            }
        }

        [Category("Settings")]
        public string SymbolBefore
        {
            get { return symbolBefore; }
            set
            {
                symbolBefore = value;
                Invalidate();
            }
        }

        [Category("Settings")]
        public string SymbolAfter
        {
            get { return symbolAfter; }
            set
            {
                symbolAfter = value;
                Invalidate();
            }
        }

        [Category("Settings")]
        public bool ShowMaximun
        {
            get { return showMaximun; }
            set
            {
                showMaximun = value;
                Invalidate();
            }
        }

        [Category("Settings")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
            }
        }

        [Category("Settings")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if (stopPainting == false)
            {
                if (paintedBack == false)
                {
                    Graphics graph = pevent.Graphics;
                    Rectangle rectChannel = new Rectangle(0, 0, Width, ChannelHeight);
                    using (var brushChannel = new SolidBrush(channelColor))
                    {
                        if (channelHeight >= sliderHeight)
                            rectChannel.Y = Height - channelHeight;
                        else rectChannel.Y = Height - (channelHeight + sliderHeight) / 2;
                        
                        graph.Clear(Parent.BackColor);
                        graph.FillRectangle(brushChannel, rectChannel);
                                                                      
                        if (DesignMode == false)
                            paintedBack = true;
                    }
                }

                if (Value == Maximum || Value == Minimum)
                    paintedBack = false;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (stopPainting == false)
            {
                Graphics graph = e.Graphics;
                double scaleFactor = ((double)Value - Minimum) / ((double)Maximum - Minimum);
                int sliderWidth = (int)(Width * scaleFactor);
                Rectangle rectSlider = new Rectangle(0, 0, sliderWidth, sliderHeight);
                using (var brushSlider = new SolidBrush(sliderColor))
                {
                    if (sliderHeight >= channelHeight)
                        rectSlider.Y = Height - sliderHeight;
                    else rectSlider.Y = Height - (sliderHeight + channelHeight) / 2;
                    
                    if (sliderWidth > 1) 
                        graph.FillRectangle(brushSlider, rectSlider);
                    if (showValue != TextPosition.None) 
                        DrawValueText(graph, sliderWidth, rectSlider);
                }
            }
            if (Value == Maximum) stopPainting = true;
            else stopPainting = false; 
        }

        private void DrawValueText(Graphics graph, int sliderWidth, Rectangle rectSlider)
        {
            string text = symbolBefore + Value.ToString() + symbolAfter;
            if (showMaximun) text = text + "/" + symbolBefore + Maximum.ToString() + symbolAfter;
            var textSize = TextRenderer.MeasureText(text, Font);
            var rectText = new Rectangle(0, 0, textSize.Width, textSize.Height + 2);
            using (var brushText = new SolidBrush(ForeColor))
            using (var brushTextBack = new SolidBrush(foreBackColor))
            using (var textFormat = new StringFormat())
            {
                switch (showValue)
                {
                    case TextPosition.Left:
                        rectText.X = 0;
                        textFormat.Alignment = StringAlignment.Near;
                        break;
                    case TextPosition.Right:
                        rectText.X = Width - textSize.Width;
                        textFormat.Alignment = StringAlignment.Far;
                        break;
                    case TextPosition.Center:
                        rectText.X = (Width - textSize.Width) / 2;
                        textFormat.Alignment = StringAlignment.Center;
                        break;
                    case TextPosition.Sliding:
                        rectText.X = sliderWidth - textSize.Width;
                        textFormat.Alignment = StringAlignment.Center;
                        
                        using (var brushClear = new SolidBrush(Parent.BackColor))
                        {
                            var rect = rectSlider;
                            rect.Y = rectText.Y;
                            rect.Height = rectText.Height;
                            graph.FillRectangle(brushClear, rect);
                        }
                        break;
                }

                graph.FillRectangle(brushTextBack, rectText);
                graph.DrawString(text, Font, brushText, rectText, textFormat);
            }
        }
    }
 }
