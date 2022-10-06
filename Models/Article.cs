using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace razorweb.models
{
    // [Table("posts")]
    public class Article
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255, MinimumLength = 5, ErrorMessage = "{0} phải từ {2} đến {1}")]
        [Column(TypeName = "nvarchar")]
        public string Title { set; get; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime Created { get; set; }
        [Column(TypeName = "ntext")]
        public string Content { get; set; }
    }
}