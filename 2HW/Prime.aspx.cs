using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2HW
{
    public partial class Prime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int N = 9;
            int sum = 0;
            Response.Write("2或3的倍數加總:"+ N +"</br>");
            for (int i =1; i <= N; i++)
            {
                if((i % 2 ==0) || (i % 3 == 0))
                {
                    if ((i % 2 == 0) && (i % 3 == 0))
                    {
                        sum += i;
                    }
                    else
                    {
                        sum += i;
                    }
                }
            }
            Response.Write(sum);
        }
    }
}