using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ModernButton : Button
{
    public int BorderRadius { get; set; } = 15;
    public Color BackgroundColor { get; set; } = Color.FromArgb(52, 152, 219);
    public Color TextColor { get; set; } = Color.White;

    public ModernButton()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        ForeColor = TextColor;
        BackColor = BackgroundColor;
        Font = new Font("Segoe UI", 11F, FontStyle.Bold);
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        using (GraphicsPath path = GetRoundedPath(ClientRectangle, BorderRadius))
        using (SolidBrush brush = new SolidBrush(BackgroundColor))
        using (SolidBrush textBrush = new SolidBrush(TextColor))
        {
            pevent.Graphics.FillPath(brush, path);
            TextRenderer.DrawText(pevent.Graphics, Text, Font, ClientRectangle, TextColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }

    private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        int diameter = radius * 2;
        Size size = new Size(diameter, diameter);
        Rectangle arc = new Rectangle(rect.Location, size);

        // top left
        path.AddArc(arc, 180, 90);

        // top right
        arc.X = rect.Right - diameter;
        path.AddArc(arc, 270, 90);

        // bottom right
        arc.Y = rect.Bottom - diameter;
        path.AddArc(arc, 0, 90);

        // bottom left
        arc.X = rect.Left;
        path.AddArc(arc, 90, 90);

        path.CloseFigure();
        return path;
    }
}
