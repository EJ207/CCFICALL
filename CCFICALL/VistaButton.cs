using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace VistaButton
{
    /// <summary>
    /// A replacement control for the default Button. It
    /// renders in the Windows Vista style regardless of
    /// Operating System and provides functionality for
    /// changing the display color.
    /// </summary>
    [DefaultEvent("Click"), DefaultProperty("Text")]
    public partial class VistaButton : UserControl
    {
        #region -  Constructor  -

            public VistaButton()
            {
                InitializeComponent();
                // Optimize Painting methods and set double buffering.
                SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                SetStyle(ControlStyles.UserPaint, true);

                // Repaint the control when it's size is changed.
                SetStyle(ControlStyles.ResizeRedraw, true);

                // Make the control selectable.
                SetStyle(ControlStyles.Selectable, true);

                // Allow a transparent background color.
                SetStyle(ControlStyles.SupportsTransparentBackColor, true);

                // Set the background color.
                BackColor = Color.Transparent;
            }

        #endregion

        #region -  Private Variables  -

            private Image mImage;
            private int mImagePadding = 3;
            private Size mImageSize = new Size(24, 24);
            private ContentAlignment mImageAlign = ContentAlignment.MiddleLeft;
            private ContentAlignment mTextAlign = ContentAlignment.MiddleCenter;

            private Color mHighlightColor = Color.White;

            // Normal Colors.
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            private Color mBackgroundColor1 = Color.FromArgb(25, 25, 25),
                          mBackgroundColor2 = Color.Black,
                          mOuterStroke = Color.Black;


            private Color mHoverColor = Color.FromArgb(0, 150, 255);

            // Down Colors.
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            private Color mDownColor1 = Color.Black, 
                          mDownColor2 = Color.Black, 
                          mOuterDown = Color.Black, 
                          mInnerDown = Color.Black, 
                          mInnerFocus = Color.FromArgb(150, Color.White),
                          mOuterFocus = Color.Black;

            private Color mInnerStroke = Color.FromArgb(150, Color.White);
            private Color mGlowColor = Color.FromArgb(152, 255, 255, 255);

            private bool mousedown = false;
            private bool mouseover = false;
            private float mHoverIntense = 0.0f;

            private static readonly ColorMatrix mGreyscale = new ColorMatrix(
            new Single[][]
            {
                new Single[] {0.3f, 0.3f, 0.3f, 0, 0},
                new Single[] {0.59f, 0.59f, 0.59f, 0, 0},
                new Single[] {0.11f, 0.11f, 0.11f, 0, 0},
                new Single[] {0, 0, 0, 1, 0},
                new Single[] {0, 0, 0, 0, 1}
            });
        
        #endregion

        #region -  Properties  -

            /// <summary>
            /// The text displayed on the button.
            /// </summary>
            [Bindable(true),
            Browsable(true),
            Category("Appearance"),
            EditorBrowsable(EditorBrowsableState.Always),
            Description("The text displayed on the button."),
            DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public override string Text
            {
                get { return base.Text; }
                set { base.Text = value; this.Invalidate(); }
            }
            
            /// <summary>
            /// The alignment of the text displayed on the button.
            /// </summary>
            [Category("Appearance"),
            DefaultValue(typeof(ContentAlignment), "MiddleCenter"),
            Description("The alignment of the text displayed on the bar.")]
            public ContentAlignment TextAlign
            {
                get { return mTextAlign; }
                set { mTextAlign = value; this.Invalidate(); }
            }
            
            /// <summary>
            /// The image to display.
            /// </summary>
            [Category("Appearance"),
            DefaultValue(null),
            Description("The image to display.")]
            public Image Image
            {
                get { return mImage; }
                set { mImage = value; this.Invalidate(); }
            }
            
            /// <summary>
            /// The alignment of the given image relative to the button.
            /// </summary>
            [Category("Appearance"),
            DefaultValue(typeof(ContentAlignment), "MiddleLeft"),
            Description("The alignment of the given image relative to the parent control.")]
            public ContentAlignment ImageAlign
            {
                get { return mImageAlign; }
                set { mImageAlign = value; this.Invalidate(); }
            }

            /// <summary>
            /// The size to display the image.
            /// </summary>
            [Category("Appearance"),
            DefaultValue(typeof(Size), "24, 24"),
            Description("The size to display the image.")]
            public Size ImageSize
            {
                get { return mImageSize; }
                set { mImageSize = value; this.Invalidate(); }
            }

            /// <summary>
            /// The amount to pad the image from the edges of the control.
            /// </summary>
            [Category("Appearance"),
            DefaultValue(3),
            Description("The amount to pad the image from the edges of the control.")]
            public int ImagePadding
            {
                get { return mImagePadding; }
                set { mImagePadding = value; this.Invalidate(); }
            }

        #endregion

        #region -  Drawing  -

            private void DrawBackground(System.Drawing.Graphics g)
            {
                // The outline of the control.
                Rectangle r = this.ClientRectangle;
                r.X++; r.Y++; r.Width -= 3; r.Height -= 3;

                // Create a rounded rectangle with a 2px corner radius.
                using (GraphicsPath rr = RoundRect(r, 2, 2, 2, 2))
                {
                    // If the control is disabled.
                    if (!this.Enabled)
                    {
                        // Solid background.
                        using (SolidBrush bg = new SolidBrush(Color.FromArgb(244, 244, 244)))
                        {
                            // Fill the background
                            g.FillPath(bg, rr);
                        }
                        return;
                    }
                    else // If the control is enabled.
                    {
                        if (mouseover)
                        {
                            //mBackgroundColor1 = Color.FromArgb(70, 70, 70);
                            //mBackgroundColor2 = Color.FromArgb(20, 20, 20);
                        }

                        if (mousedown)
                        {
                            // Draw a solid background.
                            g.FillPath(new SolidBrush(Color.Black), rr);
                        }
                        else
                        {
                            // Draw a gradiented background.
                            using (LinearGradientBrush bg = new LinearGradientBrush(r, mBackgroundColor1, mBackgroundColor2, LinearGradientMode.Vertical))
                                g.FillPath(bg, rr);
                        }

                        if (mouseover)
                        {
                            r = new Rectangle(0, this.Height - 6, this.Width, 4);
                            using (LinearGradientBrush bg = new LinearGradientBrush(r, Color.Transparent, Color.FromArgb(100, Color.White), LinearGradientMode.Vertical))
                            {
                                r.Y++;
                                g.FillRectangle(bg, r);
                            }
                        }   
                    }
                }
            }

            private void DrawHighlight(System.Drawing.Graphics g)
            {
                // Stop processing if the control is disabled.
                if (!this.Enabled) return;

                // The bounds for the top highlight. 
                Rectangle tr = new Rectangle(2, 1, this.Width - 2, this.Height / 2 - 1);

                // Create the graphics path to fit the highlight shape.
                using (GraphicsPath tp = RoundRect(tr, 2, 2, 0, 0))
                {
                    // Set the clipping to the highlight.
                    g.SetClip(tp);

                    Color c1 = Color.FromArgb(150, Color.White);
                    Color c2 = Color.FromArgb(50, Color.White);

                    if (mouseover)
                    {
                        c1 = Color.FromArgb(200, Color.White);
                    }

                    // Create the gradient for the top highlight.
                    using (LinearGradientBrush tg = new LinearGradientBrush(tr, c1, c2, LinearGradientMode.Vertical))
                    {
                        // Draw the highlight.
                        g.FillPath(tg, tp);
                    }
                }
                g.ResetClip();
            }

            private void DrawInnerStroke(System.Drawing.Graphics g)
            {
                // Get the client rectangle.
                Rectangle r = this.ClientRectangle;

                // Modify it to reach the inner stroke.
                r.X += 2; r.Y += 2; r.Width -= 5; r.Height -= 5;

                // Create the rounded rectangle.
                using (GraphicsPath rr = RoundRect(r, 2, 2, 2, 2))
                {
                    // Get the inner stroke color.
                    Color c1 = mInnerStroke;

                    // If the button is focused.
                    if (this.Focused)
                    {
                        // Get the focused inner stroke color.
                        c1 = mInnerFocus;

                        // Using a new pen to draw the focus rectangle.
                        using (Pen p = new Pen(Color.Black))
                        {
                            // Remove anti-aliasing.
                            g.SmoothingMode = SmoothingMode.Default;

                            // Set the width.
                            p.Width = 1;

                            // Set the line style.
                            p.DashStyle = DashStyle.Dot;

                            // Get the inner stroke rectangle.
                            Rectangle r2 = r;

                            // Shrink it.
                            r2.X += 1; r2.Y += 1; r2.Width -= 2; r2.Height -= 2;

                            // Draw the rectangle.
                            g.DrawRectangle(p, r2);

                            // Reset the aliasing mode.
                            g.SmoothingMode = SmoothingMode.AntiAlias;
                        }
                    }

                    // If the mouse button is down.
                    if (mousedown)
                        // Get the mouse down inner stroke.
                        c1 = mInnerDown;

                    // Create the pen for drawing it.
                    using (Pen p = new Pen(c1))
                        // Draw the inner stroke.
                        g.DrawPath(p, rr);
                }
            }

            private void DrawOuterStroke(System.Drawing.Graphics g)
            {
                // Get the bounds of the control.
                Rectangle r = this.ClientRectangle;
                r.X++; r.Y++; r.Width -= 3; r.Height -= 3;

                // Create the needed rounded rectangle for the outline.
                using (GraphicsPath rr = RoundRect(r, 2, 2, 2, 2))
                {
                    // Create the pen to draw the outline.
                    Color c1 = mOuterStroke;

                    // If the button is focused.
                    if (Focused)
                        // Get the focus stroke colour.
                        c1 = mOuterFocus;

                    // If the mouse is down.
                    if (mousedown)
                        // Get the mouse down outer stroke.
                        c1 = GetIntermediateColor(mOuterStroke,
                            mOuterDown, mHoverIntense);

                    if (!this.Enabled) c1 = Color.FromArgb(177, 177, 177);

                    // Create a new pen to draw the outline.
                    using (Pen p = new Pen(c1))
                        // Draw the outline.
                        g.DrawPath(p, rr);
                }
            }

            private void DrawImage(System.Drawing.Graphics g)
            {
                if (Image == null) return;

                Point p = new Point(mImagePadding + Padding.Left, mImagePadding + Padding.Top);

                switch (ImageAlign)
                {
                    case ContentAlignment.BottomCenter:
                    case ContentAlignment.BottomLeft:
                    case ContentAlignment.BottomRight:
                        p.Y = this.Height - ImageSize.Height - mImagePadding - Padding.Bottom;
                        break;
                    case ContentAlignment.MiddleCenter:
                    case ContentAlignment.MiddleLeft:
                    case ContentAlignment.MiddleRight:
                        p.Y = (this.Height - ImageSize.Height) / 2;
                        break;
                }

                switch (ImageAlign)
                {
                    case ContentAlignment.BottomRight:
                    case ContentAlignment.MiddleRight:
                    case ContentAlignment.TopRight:
                        p.X = this.Width - ImageSize.Width - mImagePadding - Padding.Right;
                        break;
                    case ContentAlignment.BottomCenter:
                    case ContentAlignment.MiddleCenter:
                    case ContentAlignment.TopCenter:
                        p.X = (this.Width - ImageSize.Width) / 2;
                        break;
                }

                Rectangle bounds = new Rectangle(p, ImageSize);

                ImageAttributes ia = new ImageAttributes();

                if (!this.Enabled)
                {
                    ia.SetColorMatrix(mGreyscale);
                }

                g.DrawImage(Image, bounds, 0, 0, Image.Width, Image.Height, GraphicsUnit.Pixel, ia);
            }

            private void DrawText(System.Drawing.Graphics g)
            {
                // Get the text alignment.
                StringFormat sf = ToStringFormat(mTextAlign);

                // Get the colour of text to be used.
                Color c = (this.Enabled) ? this.ForeColor :
                    Color.FromArgb(160, 160, 160);

                // Get the bounding rectangle.
                Rectangle r = this.ClientRectangle;
                r.X = Padding.Left; r.Y = Padding.Top;
                r.Width = this.Width - Padding.Horizontal;
                r.Height = this.Height - Padding.Vertical;

                // Draw the text.
                g.DrawString(base.Text, this.Font, new SolidBrush(c), r, sf);
            }

        #endregion

        #region -  Paint Handler  -

            private void VistaButton_Paint(object sender, PaintEventArgs e)
            {
                // Set the smoothing.
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

                DrawBackground(e.Graphics); // Draw the background.
                DrawHighlight(e.Graphics); // Draw the highlight.
                DrawInnerStroke(e.Graphics); // Draw the inner stroke.
                DrawOuterStroke(e.Graphics); // Draw the outer stroke.
                DrawImage(e.Graphics); // Draw the image.
                DrawText(e.Graphics); // Draw the text.
            }

        #endregion

        #region -  Mouse Events  -

            private void VistaButton_MouseEnter(object sender, EventArgs e)
            {
                // Mouse over.
                mouseover = true;

                // Set the color change.
                mHoverIntense = 1.0f;

                // Redraw.
                this.Invalidate();
            }

            private void VistaButton_MouseLeave(object sender, EventArgs e)
            {
                // Not mouse over.
                mouseover = false;

                // Stop the color change.
                mHoverIntense = 0.0f;

                // Redraw.
                this.Invalidate();
            }

            private void VistaButton_MouseDown(object sender, MouseEventArgs e)
            {
                // True if the left mouse button was pressed.
                if (e.Button == MouseButtons.Left) 
                    mousedown = true;

                // Redraw.
                this.Invalidate();
            }

            private void VistaButton_MouseUp(object sender, MouseEventArgs e)
            {
                // False if the left mouse button was released.
                if (e.Button == MouseButtons.Left) 
                    mousedown = false;
                
                // Redraw.
                this.Invalidate();
            }

        #endregion

        #region -  Focus Events  -

            private void VistaButton_Enter(object sender, EventArgs e)
            {
                // Redraw.
                this.Invalidate();
            }

            private void VistaButton_Leave(object sender, EventArgs e)
            {
                // Redraw.
                this.Invalidate();
            }

        #endregion

        #region -  Key Events  -

            private void VistaButton_KeyPress(object sender, KeyPressEventArgs e)
            {
                // Raise the click event when enter is pressed.
                if (e.KeyChar == (char)13) 
                    base.OnClick(e);
            }

            private void VistaButton_KeyDown(object sender, KeyEventArgs e)
            {
                // If space was pressed down.
                if (e.KeyCode == Keys.Space)
                {
                    // simulate mouse over and down.
                    mouseover = true;
                    mousedown = true;
                    mHoverIntense = 1.0f;

                    // Get the middle of the button in screen co-ordinates.
                    Point p = this.PointToScreen(this.Location);
                    p.X += this.Width / 2;
                    p.Y += this.Height / 2;

                    // Create the MouseEventsArgs to raise the MouseDown event.
                    MouseEventArgs m = 
                        new MouseEventArgs(MouseButtons.Left, 1, p.X, p.Y, 0);

                    // Raise the MouseDown event.
                    base.OnMouseDown(m);

                    // Redraw.
                    this.Invalidate();
                }
            }

            private void VistaButton_KeyUp(object sender, KeyEventArgs e)
            {
                // If the space key was released.
                if (e.KeyCode == Keys.Space)
                {
                    // Get the middle point of the button relative to the screen.
                    Point p = this.PointToScreen(this.Location);
                    p.X += this.Width / 2;
                    p.Y += this.Height / 2;

                    // Create the event arguments.
                    MouseEventArgs m = 
                        new MouseEventArgs(MouseButtons.Left, 1, p.X, p.Y, 0);

                    // If the mouse is already inside it.
                    if (this.RectangleToScreen(this.ClientRectangle).Contains(Cursor.Position))
                    {
                        // Mouse over.
                        mouseover = true;
                        mHoverIntense = 1.0f;
                    }
                    else
                    {
                        // Mouse not over.
                        mouseover = false;
                        mHoverIntense = 0.0f;
                    }
                    // Raise the click event.
                    base.OnClick(m);

                    // Redraw.
                    this.Invalidate();
                }
            }
        #endregion

        #region -  Other Events  -

            private void VistaButton_EnabledChanged(object sender, EventArgs e)
            {
                // Redraw the control.
                this.Invalidate();
            }

            private void VistaButton_PaddingChanged(object sender, EventArgs e)
            {
                // Redraw the control.
                this.Invalidate();
            }

        #endregion

        #region -  Required Methods  -

            #region -  private static GraphicsPath:RoundRect  -

                private static GraphicsPath RoundRect(RectangleF r, float r1, float r2, float r3, float r4)
                {
                    // Declare and assign variables to make the following lines shorter.
                    float x = r.X, y = r.Y, w = r.Width, h = r.Height;

                    // Declare a new graphics path.
                    GraphicsPath rr = new GraphicsPath();

                    // The top left hand corner.
                    rr.AddBezier(x, y + r1, x, y, x + r1, y, x + r1, y);
                    // The top line.
                    rr.AddLine(x + r1, y, x + w - r2, y);
                    // The top right hand corner.
                    rr.AddBezier(x + w - r2, y, x + w, y, x + w, y + r2, x + w, y + r2);
                    // The left line.
                    rr.AddLine(x + w, y + r2, x + w, y + h - r3);
                    // The bottom right hand corner.
                    rr.AddBezier(x + w, y + h - r3, x + w, y + h, x + w - r3, y + h, x + w - r3, y + h);
                    // The bottom line.
                    rr.AddLine(x + w - r3, y + h, x + r4, y + h);
                    // The bottom left hand corner.
                    rr.AddBezier(x + r4, y + h, x, y + h, x, y + h - r4, x, y + h - r4);
                    // The left line.
                    rr.AddLine(x, y + h - r4, x, y + r1);

                    // Return the result.
                    return rr;
                }

            #endregion

            #region -  private static Color:GetIntermediateColor  -

                private static Color GetIntermediateColor(Color c1, Color c2, float pc)
                {
                    // If the percentage is 0, return the first color.
                    if (pc == 0) { return c1; }

                    // If the percentage is 1, return the second color.
                    if (pc == 1) { return c2; }

                    // If the percentage is out of bounds.
                    if (pc < 0 || pc > 1)
                    {
                        throw new ArgumentOutOfRangeException(
                            "pc", pc, 
                            "This parameter only accepts values between 0 and 1");
                    }

                    // Set up variables. Arithmetic with the original values can
                    // cause some errors because values cannot be higher than 255
                    // and they cannot be less that 0.
                    int ca = c1.A, cr = c1.R, cg = c1.G, cb = c1.B;
                    int c2a = c2.A, c2r = c2.R, c2g = c2.G, c2b = c2.B;

                    // Get the alpha value. This works by getting the difference
                    // between the starting and ending numbers and then finding the
                    // value at the given percentage. This value is then added to
                    // the original color component value.

                    int a = (int)Math.Abs(ca + ((ca - c2a) * pc)); // Alpha
                    int r = (int)Math.Abs(cr - ((cr - c2r) * pc)); // Red
                    int g = (int)Math.Abs(cg - ((cg - c2g) * pc)); // Green
                    int b = (int)Math.Abs(cb - ((cb - c2b) * pc)); // Blue

                    // Check to make sure all of the values are in range.

                    if (a > 255) { a = 255; } if (a < 0) { a = 0; } // Alpha
                    if (r > 255) { r = 255; } if (r < 0) { r = 0; } // Red
                    if (g > 255) { g = 255; } if (g < 0) { g = 0; } // Green
                    if (b > 255) { b = 255; } if (b < 0) { b = 0; } // Blue

                    // Return the resulting color.
                    return (Color.FromArgb(a, r, g, b));
                }

            #endregion

            #region -  private static ToStringFormat(ContentAlignment ca)  -

                private static StringFormat ToStringFormat(ContentAlignment ca)
                {
                    // Create the new StringFormat.
                    StringFormat sf = new StringFormat();

                    // Get the string representation of the integer that represents the enum value.
                    string c = ((int)ca).ToString();

                    // If it ends with 4 then align it to the right.
                    // If it ends with 2 then center it, otherwise align to the left.
                    sf.Alignment = 
                        c.EndsWith("4") ? (StringAlignment)2 : 
                            c.EndsWith("2") ? (StringAlignment)1 : (StringAlignment)0;

                    // If it's greater than 64, align to the bottom.
                    // If it's greater than 4, align to the middle, otherwise align to the left.
                    sf.LineAlignment = 
                        (int)ca > 64 ? (StringAlignment)2 : 
                            (int)(ca) > 4 ? (StringAlignment)1 : (StringAlignment)0;

                    // Return result.
                    return sf;
                }

            #endregion

        #endregion
    }
}