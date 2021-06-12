using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
namespace WebApplication1
{
    public partial class terminal : System.Web.UI.Page
    {
        
        Random r = new Random();

        List<string> img = new List<string>{ 
            "Resources/1.png", "Resources/2.png", "Resources/3.png", "Resources/4.png",
            "Resources/5.png","Resources/6.png","Resources/7.png","Resources/8.png"
        };

        protected void Page_Load(object sender, EventArgs e)
        {

            ImageButton[] imageButtons = {ImageButton1,ImageButton2, ImageButton3, ImageButton4,
                ImageButton5, ImageButton6, ImageButton7, ImageButton8,
                ImageButton9, ImageButton10, ImageButton11, ImageButton12,
                ImageButton13, ImageButton14, ImageButton15, ImageButton16,
            };

            int count = 0;
            int[] ran = { 0, 0, 0, 0, 0, 0, 0, 0, 
                          0, 0, 0, 0, 0, 0, 0, 0 };
            List<int> rrr = new List<int>();


            while (true) {
                if (ran.Average()==1)
                {
                    break;
                }
                else
                {
                    int rnd = r.Next(0, 8);
                    ran[rnd] += 1;
                }
            }

           

            
            //if (rrr.Exists(t => t == rnd))
            //{
            //    rnd = r.Next(0, 8);
                
            //}

            
            
            foreach (int a in ran)
            {
                Response.Write(a+"<br/>");
            }
        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton2_Click1(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton3_Click1(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}