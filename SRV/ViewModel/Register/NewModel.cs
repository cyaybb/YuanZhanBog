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
        [RegularExpression("[0-9]{4}",ErrorMessage = "*邀请码只能是4位数字")]
        public string InviterCode { get; set; }

        [Required(ErrorMessage = "*用户名不能为空")]
        public string UserName { get; set; }

        [MinLength(4,ErrorMessage = "*密码的长度不能小于4，大于20")]
        [MaxLength(20, ErrorMessage = "*密码的长度不能小于4，大于20")]
        [Required(ErrorMessage = "*密码不能为空")]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage = "*确认密码和密码不一致")]
        [Required(ErrorMessage = "*确认密码不能为空")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "*验证码不能为空")]
        [StringLength(4, ErrorMessage = "*验证码的长度只能等于4",MinimumLength =4)]
        public string VerificationCode { get; set; }
    }
}
