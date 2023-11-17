using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoDMS.Models
{
    public class Document: Item
    {
        public int Id { get; set; }

        public bool IsComposite() {
            return false;
        }

        [Required]
        public string? Name { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateModified { get; set; }

        public string? Extension { get; set;}

        public double? Size { get; set;}
        
        public string? FilePath { get; set; }

        public string? FileType { get; set; }
   
        [DataType(DataType.DateTime)]
        public DateTime PublicationDate { get; set; }

        public int ParentId {get; set;}
    }
}