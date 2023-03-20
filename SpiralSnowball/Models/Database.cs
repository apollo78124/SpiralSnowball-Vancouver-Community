using Microsoft.AspNetCore.Html;
using System.ComponentModel.DataAnnotations;

namespace SpiralSnowball.Models
{
    public class PopularPost
    {
        [Key]
        public int PostId { get; set; }

        [Required]
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime PostedDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime LastEdit { get; set; }
        public string? Content { get; set; }
        [Required]
        public string UserID { get; set; } = "";
    }

    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [Required]
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime PostedDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime LastEdit { get; set; }
        public string? Content { get; set; }
        [Required]
        public string UserID { get; set; } = "";
    }

    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        public int PostId { get; set; }

        [DataType(DataType.Date)]
        public DateTime PostedDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime LastEdit { get; set; }
        public string? Content { get; set; }
        [Required]
        public string UserID { get; set; } = "";
    }
}
