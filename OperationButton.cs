using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace AwesomeCalculator
{

    internal class OperationButton : Button
    {
        public enum Types
        {
            Clear,
            Plus,
            Minus,
            Multiplication,
            Sqrt,
            Opposite,
            Equel,
            Dot,
            Num1,
            Num2,
            Num3,
            Num4,
            Num5,
            Num6,
            Num7,
            Num8,
            Num9,
            Num0,
            MemPlus,
            MemRead,
            MemClear,
            Del
        }

        public static string ButtonTypeToString(Types type)
        {
            switch (type)
            {
                case Types.Clear: return "CE";
                case Types.Plus: return "+";
                case Types.Minus: return "-";
                case Types.Multiplication: return "*";
                case Types.Sqrt: return "sqrt";
                case Types.Opposite: return "1/x";
                case Types.Equel: return "=";
                case Types.Dot: return ".";
                case Types.Num1: return "1";
                case Types.Num2: return "2";
                case Types.Num3: return "3";
                case Types.Num4: return "4";
                case Types.Num5: return "5";
                case Types.Num6: return "6";
                case Types.Num7: return "7";
                case Types.Num8: return "8";
                case Types.Num9: return "9";
                case Types.Num0: return "0";
                case Types.MemPlus: return "M+";
                case Types.MemRead: return "MR";
                case Types.MemClear: return "MC";
                case Types.Del: return "DEL";
                default: return "?";
            }
        }

        //Fields
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.PaleVioletRed;
        private Types opType = Types.Clear;

        //Properties
        [Category("Appereance Extension")]
        public Types OperationType
        {
            get { return opType; }
            set
            {
                opType = value;
                this.Text = ButtonTypeToString(opType);
                this.Invalidate();
            }
        }

        [Category("Appereance Extension")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Appereance Extension")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        [Category("Appereance Extension")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Appereance Extension")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("Appereance Extension")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        //Constructor
        public OperationButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.FromArgb(52, 52, 52);
            this.ForeColor = Color.FromArgb(212, 212, 212);
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(45,45,45);
            this.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 3);
            this.Resize += new EventHandler(Button_Resize);
            BackgroundColor = Color.FromArgb(52, 52, 52);
            BorderRadius = 10;
            OperationType = Types.Clear;
            Font = new Font("Segoe UI", 22); ;
        }

        //Methods
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);


            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //Button border                    
                    if (borderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }
    }
}
