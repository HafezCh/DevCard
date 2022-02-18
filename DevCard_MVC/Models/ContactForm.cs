using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DevCard_MVC.Models
{
    public class ContactForm
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(3,ErrorMessage = "حداقل طول نام ، 3 کاراکتر است")]
        [MaxLength(100, ErrorMessage = "طول نام ، بیش از حد مجاز است")]
        public string name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress(ErrorMessage = "عبارت وارد شده ایمیل صحیحی نیست")]
        public string email { get; set; }

        [Required(ErrorMessage = "لطفا پیام موردنظرتون را وارد کنید")]
        public string message { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        public string services { get; set; }
    }
}
