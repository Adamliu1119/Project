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
        protected void Page_Load(object sender, EventArgs e)
        {
            Random r = new Random() ;
            string[] imgbtn = {"ImageButton1.ImageUrl", "ImageButton2.ImageUrl", "ImageButton3.ImageUrl", "ImageButton4.ImageUrl", "ImageButton5.ImageUrl", "ImageButton6.ImageUrl", "ImageButton7.ImageUrl", "ImageButton8.ImageUrl" };
            Bitmap[] img = {Resource1._1,Resource1._2, Resource1._3, Resource1._4, Resource1._5,Resource1 ._6, Resource1 ._7};
            int count = 0;

           





        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            
        }
    }
}