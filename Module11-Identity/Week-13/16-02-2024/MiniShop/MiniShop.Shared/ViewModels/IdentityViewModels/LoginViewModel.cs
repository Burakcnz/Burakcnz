using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Shared.ViewModels.IdentityViewModels
{
    public class LoginViewModel
    {
        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage ="Kullanıcı adı boş bırakılamaz")]
        public string UserName { get; set; }

        [DisplayName("Parola")]
        [Required(ErrorMessage = "Parola boş bırakılamaz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
