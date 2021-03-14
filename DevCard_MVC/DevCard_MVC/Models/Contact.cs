using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(3 , ErrorMessage = "حداقل طول 3 کارکتر است")]
        [MaxLength(70 , ErrorMessage = "حداکثر طول 70 کارکتر است")]
        public string Name { get; set; }

        public string Message { get; set; }

        public string Services { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نیست")]
        public string Email { get; set; }
    }
}
