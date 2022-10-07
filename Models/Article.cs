using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace razorweb.models
{
    // [Table("posts")]
    public class Article
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} phải nhập")]
        [StringLength(255, MinimumLength = 5, ErrorMessage = "{0} phải dài từ {2} đến {1} ký tự")]
        [Column(TypeName = "nvarchar")]
        [DisplayName("Tiêu đề")]
        public string Title { set; get; }
        [DataType(DataType.Date)]
        [Required]
        [DisplayName("Ngày tạo")]
        public DateTime Created { get; set; }
        [Column(TypeName = "ntext")]
        [DisplayName("Nội dung")]
        public string Content { get; set; }
    }
}