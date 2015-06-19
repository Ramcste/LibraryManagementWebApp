using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using LibraryManagementSystemWebApp.DAL;
using LibraryManagementSystemWebApp.Model;

namespace LibraryManagementSystemWebApp.BAL
{
    public class MemberManager
    {
        MemberGateway memberGateway=new MemberGateway();
        public string Save(Member member)
        {
            if (member.MemberId.ToString() == string.Empty)
            {
                return "Member Id is missing";
            }

            else if (member.Name == string.Empty)
            {
                return "Name is missing";
            }

            else if (memberGateway.HasThisNumberExists(member.MemberId))
            {
                return "Sorry,Member Already Exists";
            }

            else
            {
                int value = memberGateway.Save(member);

                if (value > 0)
                {
                    return "Member Saved Successfully";
                }

                else
                {
                    return "Operation Failed";
                }
            }
        }


    }
}