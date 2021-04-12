using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _109_2Mid {
    public partial class Sample2 : System.Web.UI.Page {
		public string s_Area = "北區";
		public string[,] sa_Place = new string[2, 3] { { "基隆", "台北", "新北" }, { "苗栗", "台中", "南投" } };

		protected void Page_Load(object sender, EventArgs e) {
		}

		protected void rbl_Res_SelectedIndexChanged(object sender, EventArgs e) {
			if (rbl_Res.SelectedValue == "是") {
				tb_Des.Visible = true;
			}
			else {
				tb_Des.Visible = false;
			}
		}

		protected void ddl_Area_TextChanged(object sender, EventArgs e) {
			s_Area = ddl_Area.SelectedValue;

			ddl_Place.Items.Clear();
			if (s_Area == "北區") {
				for (int i_Ct = 0; i_Ct < 3; i_Ct++) {
					ddl_Place.Items.Add(new ListItem(sa_Place[0, i_Ct], sa_Place[0, i_Ct]));
				}
			}
			else if (s_Area == "中區") {
				for (int i_Ct = 0; i_Ct < 3; i_Ct++) {
					ddl_Place.Items.Add(new ListItem(sa_Place[1, i_Ct], sa_Place[1, i_Ct]));
				}
			}
		}

		protected void btn_Sub_Click(object sender, EventArgs e) {
			lb_Msg.Text = "";
			lb_Msg.Text += ddl_Area.SelectedValue + "<br>";
			lb_Msg.Text += ddl_Place.SelectedValue + "<br>";
			lb_Msg.Text += tb_Name.Text + "<br>";
			if (rbl_Res.SelectedValue == "是") {
				lb_Msg.Text += tb_Des.Text;
			}
		}
	}
}