using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabProductUI.Models
{
    [Table("Production.Product")]
    public partial class Product
    {
        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "money")]
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }
        
        public CategoryEnum Category { get; set; }
        
        public string PictureLink { get; set; }

        //[Column(TypeName = "money")]
        //public decimal ListPrice { get; set; }

        //[StringLength(5)]
        //public string Size { get; set; }

        //[StringLength(3)]
        //public string SizeUnitMeasureCode { get; set; }

        //[StringLength(3)]
        //public string WeightUnitMeasureCode { get; set; }

        //public decimal? Weight { get; set; }

        //public int DaysToManufacture { get; set; }

        //[StringLength(2)]
        //public string ProductLine { get; set; }

        //[StringLength(2)]
        //public string Class { get; set; }

        //[StringLength(2)]
        //public string Style { get; set; }

        //public int? ProductSubcategoryID { get; set; }

        //public int? ProductModelID { get; set; }

        //public DateTime SellStartDate { get; set; }

        //public DateTime? SellEndDate { get; set; }

        //public DateTime? DiscontinuedDate { get; set; }

        //public Guid rowguid { get; set; }

        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
