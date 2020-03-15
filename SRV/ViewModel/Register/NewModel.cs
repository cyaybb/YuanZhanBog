using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.Register
{
    public class NewModel
    {
        [Required(ErrorMessage ="*邀请人不能为空")]
        public string Inviter { get; set; }
        [Required(ErrorMessage = "*邀请码不能为空")]
        public string InviterCode { get; set; }
        [Required(ErrorMessage = "*用户名不能为空")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "*密码不能为空")]
        public string Password { get; set; }
        [Required(ErrorMessage = "*确认密码不能为空")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "*验证码不能为空")]
        public string VerificationCode { get; set; }
    }
}
