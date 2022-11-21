using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.DataModel
{
    [Table("image_product")]
    public class ImageProduct
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }

        [Column("image")]
        public string Image { get; set; }

        // khóa ngoại tham chiếu đến bảng itemProduct 
        [Column("productId")]
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual ItemProduct ItemProduct { get; set; }

        /// <summary>
        /// khóa ngoại tham chiếu đến bảng đá 
        /// </summary>
        [Column("stoneId")]
        public Guid StoneMstId { get; set; }
        [ForeignKey("StoneMstId")]
        public virtual StoneMst StoneMst { get; set; }

        /// <summary>
        /// khóa ngoại tham chiếu đến bảng kim cương 
        /// </summary>
        [Column("dimId")]
        public Guid DimMsId { get; set; }
        [ForeignKey("DimMsId")]
        public virtual DimMst DimMst { get; set; }

    }
}
