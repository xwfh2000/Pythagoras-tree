using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//test “源代码管理2.0”
namespace 毕达哥拉斯树
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // If there is an image and it has a location, 
            // paint it when the Form is repainted.
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Draw(g, a * PI / 180, new PointF(x1, y1), new PointF(x2, y2));
        }


        int x1 = 390, y1 = 600, x2 = 540, y2 = 600,a=60;
      
        
        const float PI = 3.1415926536f;
        int color_H = 270;
        // 直线的旋转（p1 是定点）
        PointF Rotate(PointF p1, PointF p2, double angle)
        {
            PointF r=new PointF(1,2);
            r.X = p1.X + (p2.X - p1.X) * (float)Math.Cos(angle) + (p2.Y - p1.Y) * (float)Math.Sin(angle);
            r.Y = p1.Y + (p2.Y - p1.Y) * (float)Math.Cos(angle) - (p2.X - p1.X) * (float)Math.Sin(angle);
            return r;
        }

        // 直线的缩放（p1 是定点）
        PointF Zoom(PointF p1, PointF p2, float ratio)
        {
            PointF r=new PointF(1,2);
            r.X = p1.X + (p2.X - p1.X) * ratio;
            r.Y = p1.Y + (p2.Y - p1.Y) * ratio;
            return r;
        }

        int Clamp(int i)
        {
            if (i < 0) return 0;
            if (i > 255) return 255;
            return i;
        }
        void HsvToRgb(double h, double S, double V, out int r, out int g, out int b)
        {
            double H = h;
            while (H < 0) { H += 360; };
            while (H >= 360) { H -= 360; };
            double R, G, B;
            if (V <= 0)
            { R = G = B = 0; }
            else if (S <= 0)
            {
                R = G = B = V;
            }
            else
            {
                double hf = H / 60.0;
                int i = (int)Math.Floor(hf);
                double f = hf - i;
                double pv = V * (1 - S);
                double qv = V * (1 - S * f);
                double tv = V * (1 - S * (1 - f));
                switch (i)
                {

                    // Red is the dominant color

                    case 0:
                        R = V;
                        G = tv;
                        B = pv;
                        break;

                    // Green is the dominant color

                    case 1:
                        R = qv;
                        G = V;
                        B = pv;
                        break;
                    case 2:
                        R = pv;
                        G = V;
                        B = tv;
                        break;

                    // Blue is the dominant color

                    case 3:
                        R = pv;
                        G = qv;
                        B = V;
                        break;
                    case 4:
                        R = tv;
                        G = pv;
                        B = V;
                        break;

                    // Red is the dominant color

                    case 5:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    // Just in case we overshoot on our math by a little, we put these here. Since its a switch it won't slow us down at all to put these here.

                    case 6:
                        R = V;
                        G = tv;
                        B = pv;
                        break;
                    case -1:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    // The color is not defined, we should throw an error.

                    default:
                        //LFATAL("i Value error in Pixel conversion, Value is %d", i);
                        R = G = B = V; // Just pretend its black/white
                        break;
                }
            }
            r = Clamp((int)(R * 255.0));
            g = Clamp((int)(G * 255.0));
            b = Clamp((int)(B * 255.0));
        }

        // 画出正方形
        void Draw(Graphics g,double a, PointF p1, PointF p2)
        {
	        PointF p11 = Rotate(p1, p2, 90 * PI / 180);
	        PointF p22 = Rotate(p2, p1, 270 * PI / 180);

	        Point[] pts = { new Point( (int)(p1.X + 0.5),  (int)(p1.Y + 0.5)),					// +0.5 是为了四舍五入
					        new Point( (int)(p2.X + 0.5),  (int)(p2.Y + 0.5) ),
					        new Point( (int)(p22.X + 0.5), (int)(p22.Y + 0.5) ), 
					        new Point( (int)(p11.X + 0.5), (int)(p11.Y + 0.5) ) };

	         
            
            int R,G,B;
            HsvToRgb(color_H, 1, 1, out R, out G, out B);
            g.FillPolygon(new SolidBrush(Color.FromArgb(R, G, B)), pts);// 设置正方形的填充颜色


            int R1,G1,B1;
            HsvToRgb((color_H + 80) % 360, 0.5, 0.5, out R1, out G1, out B1);
            g.DrawPolygon(new Pen(Color.FromArgb(R1,G1,B1)),pts);// 设置正方形的边框颜色
		
	        color_H = (color_H + 1) % 360;
												// 填充正方形颜色

	        if (((p22.X - p11.X) * (p22.X - p11.X) + (p22.Y - p11.Y) * (p22.Y - p11.Y)) > 3 * 3 )	// 正方形的边长 >3 时递归
	        {
		       // double a = 60 * PI / 180;					// 60 度形式
        	//	double a = 45 * PI / 180;					// 45 度形式
		        PointF p = Rotate(p11, p22, a);
		        p = Zoom(p11, p, (float)Math.Cos(a));

		        Draw(g,a,p, p22);
		        Draw(g,a,p11, p);
	        }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToInt32(tbx1.Text);
            y1 = Convert.ToInt32(tby1.Text);
            x2 = Convert.ToInt32(tbx2.Text);
            y2 = Convert.ToInt32(tby2.Text);
            a = Convert.ToInt32(tba.Text);
            this.Invalidate();
        }
    }
}
