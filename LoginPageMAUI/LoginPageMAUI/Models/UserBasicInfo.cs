using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPageMAUI.Models
{
    public class UserBasicInfo
    {

        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Password {  get; set; }
        public int RoleID { get; set; } 
        public string RoleText {  get; set; }
    }
}
