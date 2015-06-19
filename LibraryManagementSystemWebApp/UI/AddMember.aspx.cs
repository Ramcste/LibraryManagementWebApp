using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryManagementSystemWebApp.BAL;
using LibraryManagementSystemWebApp.Model;

namespace LibraryManagementSystemWebApp
{
    public partial class AddMember : System.Web.UI.Page
    {
        MemberManager memberManager=new MemberManager();

        Member member=new Member();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveMemberButton_OnClick(object sender, EventArgs e)
        {
            member.MemberId = int.Parse(memberIdTextBox.Text);

            member.Name = nameTextBox.Text;

            string message = memberManager.Save(member);
            GetMemberTextBoxesClear();

            label3.Text = message;

        }

        public void GetMemberTextBoxesClear()
        {
            nameTextBox.Text = "";
            memberIdTextBox.Text = "";
        }
    }
}