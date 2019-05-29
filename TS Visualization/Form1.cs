using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loyc.Syntax;
using Loyc.Collections;


namespace TS_Visualization
{
    public partial class Form1 : Form
    {
        float xmin = -3;
        float xmax = 3;
        float ymin = -3;
        float ymax = 3;
        int taylorterms = 0;
        List<Function> func = new List<Function>();

        public Form1()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picGraph.Image = GraphFunc();
        }

        private void dropFunction_onItemSelected(object sender, EventArgs e)
        {
            func.Clear();
            switch (dropFunction.selectedValue)
            {
                case "x^2":
                    func.Add(new Polynomial());
                    lblCenter.Text = "C = 1";
                    break;
                case "e^x":
                    func.Add(new Exponential());
                    lblCenter.Text = "C = 0";
                    break;
                case "sin(x)":
                    func.Add(new Sin());
                    lblCenter.Text = "C = 0";
                    break;
                case "cos(x)":
                    func.Add(new Cos());
                    lblCenter.Text = "C = 0";
                    break;
                case "ln(1+x)":
                    func.Add(new Ln());
                    lblCenter.Text = "C = 0";
                    break;
            }
            picGraph.Image = GraphFunc();
        }

        private void sldTaylor_ValueChanged(object sender, EventArgs e)
        {
            taylorterms = sldTaylor.Value;
            lblTaylorVal.Text = sldTaylor.Value.ToString();
            picGraph.Image = GraphFunc();
        }

        private void btnZoomIN_Click(object sender, EventArgs e)
        {
            xmin += 1;
            xmax -= 1;
            ymin += 1;
            ymax -= 1;
            picGraph.Image = GraphFunc();
        }

        private void btnZoomOUT_Click(object sender, EventArgs e)
        {
            xmin -= 1;
            xmax += 1;
            ymin -= 1;
            ymax += 1;
            picGraph.Image = GraphFunc();
        }

        public Bitmap GraphFunc()
        {
            int w = picGraph.ClientSize.Width;
            int h = picGraph.ClientSize.Height;
            Bitmap bm = new Bitmap(w, h);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                RectangleF rect = new RectangleF(xmin, ymin, xmax - xmin, ymax - ymin);
                PointF[] pts = { new PointF(0, h), new PointF(w, h), new PointF(0, 0) };
                gr.Transform = new System.Drawing.Drawing2D.Matrix(rect, pts);

                using (Pen graph_pen = new Pen(Color.Blue, 0))
                {
                    gr.DrawLine(graph_pen, xmin, 0, xmax, 0);
                    gr.DrawLine(graph_pen, 0, ymin, 0, ymax);
                    for (int x = (int)xmin; x <= xmax; x++)
                    {
                        gr.DrawLine(graph_pen, x, -0.1f, x, 0.1f);
                    }
                    for (int y = (int)ymin; y <= ymax; y++)
                    {
                        gr.DrawLine(graph_pen, -0.1f, y, 0.1f, y);
                    }
                    graph_pen.Color = Color.Red;

                    if (func.Count == 0) return bm;

                    System.Drawing.Drawing2D.Matrix inverse = gr.Transform;
                    inverse.Invert();
                    PointF[] pixel_pts = { new PointF(0, 0), new PointF(1, 0) };
                    inverse.TransformPoints(pixel_pts);
                    float dx = pixel_pts[1].X - pixel_pts[0].X;
                    dx /= 2;

                    List<PointF> points = new List<PointF>();
                    for (float x = xmin; x <= xmax; x += dx)
                    {
                        bool valid_point = false;
                        try
                        {
                            float y = 0;
                            y = func[0].eval(x);

                            if (points.Count == 0) valid_point = true;
                            else
                            {
                                float dy = y - points[points.Count - 1].Y;
                                if (Math.Abs(dy / dx) < 1000)
                                    valid_point = true;
                            }
                            if (valid_point) points.Add(new PointF(x, y));
                        }
                        catch
                        {
                        }

                        if (!valid_point)
                        {
                            if (points.Count > 1)
                                gr.DrawLines(graph_pen, points.ToArray());
                            points.Clear();
                        }
                    }
                    if (points.Count > 1)
                        gr.DrawLines(graph_pen, points.ToArray());

                    Pen tpen = new Pen(Color.Green, 0);
                    List<PointF> tpoints = new List<PointF>();
                    for (float x = xmin; x <= xmax; x += dx)
                    {
                        bool valid_point = false;
                        try
                        {
                            float y = 0;
                            y = func[0].teval(x, taylorterms);

                            if (tpoints.Count == 0) valid_point = true;
                            else
                            {
                                float dy = y - tpoints[tpoints.Count - 1].Y;
                                if (Math.Abs(dy / dx) < 1000)
                                    valid_point = true;
                            }
                            if (valid_point) tpoints.Add(new PointF(x, y));
                        }
                        catch
                        {
                        }

                        if (!valid_point)
                        {
                            if (tpoints.Count > 1)
                                gr.DrawLines(graph_pen, tpoints.ToArray());
                            tpoints.Clear();
                        }
                    }
                    if (tpoints.Count > 1)
                        gr.DrawLines(tpen, tpoints.ToArray());
                }
            }
            return bm;
        }
    }
}
