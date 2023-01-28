using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVC_Card.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "پر کردن این فیلد اجباری میباشد.",AllowEmptyStrings = false)]
        [MinLength(3,ErrorMessage = "حداقل تعداد کاراکتر مورد قبول 3 میباشد")]
        [MaxLength(100,ErrorMessage = "حداکثر تعداد کاراکتر مورد قبول 100 میباشد.")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "فرمت ایمیل وارد شده صحیح نیست")]
        [Required(ErrorMessage = "پر کردن این فیلد اجباری میباشد.", AllowEmptyStrings = false)]

        public string Email { get; set; }
        public int Service { get; set; }
        public string Message { get; set; }

        public SelectList Services { get; set; }
    }
}