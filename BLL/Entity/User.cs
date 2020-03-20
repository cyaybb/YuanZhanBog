using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="*用户名不能为空")]
        public string Name { get; set; }
        [Required(ErrorMessage = "*密码不能为空")]
        public string Password { get; set; }
        [Required(ErrorMessage = "*邀请人不能为空")]
        public int InviterId { get; set; }
        [Required(ErrorMessage = "*邀请码不能为空")]
        public int InviteCode { get; set; }
    }
}
                