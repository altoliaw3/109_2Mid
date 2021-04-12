using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _109_2Mid {
    public partial class Sample1Com : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            lb_Res.Text += Request.Form.Get("tb_Acc") + "<br />";
            lb_Res.Text += Request.Form.Get("tb_Pass") + "<br />";            
            if (Request.Form.Get("rbg_Interest") == "rb_Ch1") {
                lb_Res.Text += "看書" + "<br />";
            }
            else if (Request.Form.Get("rbg_Interest") == "rb_Ch2") {
                lb_Res.Text += "打電動" + "<br />";
            }
            else if (Request.Form.Get("rbg_Interest") == "rb_Ch3") {
                lb_Res.Text += "其他" + "<br />";
            }
        }
    }
}