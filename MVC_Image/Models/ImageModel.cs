using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Image.Models
{
    public class ImageModel
    {
        [Key]

        public int Image_Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "This Field is required.")]
        [DisplayName("Image Title")]
        public string? Title { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "This Field is required.")]
        [DisplayName("Image Name")]
        public string? Name { get; set; }   

        public string? Folder { get; set; }

        [NotMapped]
        [DisplayName("Upload Image File")]
        public IFormFile? ImageFile { get; set; }
    }
}
