using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApi.Models
{
    public class LibraryItem
    {
        [Key]   //assume identity
        [Column(TypeName = "int")]
        public int Id { get; set; }
        
        [Required]
        [StringLength(200)]
        [Column(TypeName = "nvarchar(200)")]
        public string Title { get; set; }

        [Required]
        [StringLength(200)]
        [Column(TypeName = "nvarchar(200)")]
        public string Author { get; set; }

        [StringLength(150)]
        [Column(TypeName = "nvarchar(150)")]
        public string Edition { get; set; }

        [StringLength(200)]
        [Column(TypeName = "nvarchar(200)")]
        public string CheckedOutByWhom { get; set; }

        [Column(TypeName = "int")]
        public int Condition { get; set; }

        [StringLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string Category { get; set; }

        [StringLength(200)]
        [Column(TypeName = "nvarchar(200)")]
        public string Description { get; set; }
    }
}
