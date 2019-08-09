using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Memberships.Entities
{
    [Table("Item")]
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //value incremented for each row added to the table, will be a Primary Key  and cannot be nullable
        public int Id { get; set; }

        [MaxLength(255)]
        [Required]
        public string Tittle { get; set; }

        [MaxLength(2048)]
        public string Description { get; set; }

        [MaxLength(1024)] //maximum lentgh a URL can have
        public string Url { get; set; }

        [MaxLength(1024)]
        public string ImageUrl { get; set; }
        
        [AllowHtml]
        public string HTML { get; set; }

        [DefaultValue(0)]
        public int WaitDays { get; set; }

        public string HtmlShort {
            get { return HTML == null || HTML.Length < 50 ? 
                    HTML : HTML.Substring(0, 5);
                }
                                 }

    public int ProductId { get; set; }
    public int ItemTypeId { get; set; }

    [DisplayName("Item Type")]
    public int SectionId { get; set; }
    public int PartId { get; set; }
    public int IsFree { get; set; }

    [DisplayName("Item Types")]
    public ICollection<ItemType> ItemTypes { get; set; }

    [DisplayName("Sections")] //just to keep a uniform display with the "Item Types" view
    public ICollection<Section> Sections { get; set; }

    [DisplayName("Parts")] //just to keep a uniform display with the other 2 above views
    public ICollection<Part> Parts { get; set; }

    }

}