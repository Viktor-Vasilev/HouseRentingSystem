using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseRentingSystem.Infrastructure.Data
{
    public class House
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string Address { get; set; } = null!;

        [Required]
        [StringLength(500)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(200)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Column(TypeName = "money")]
        [Precision(18,2)]
        public decimal PricePerMonth { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        public int AgentId { get; set; }

        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; } = null!;

        public string? RenterId { get; set; }

        [ForeignKey(nameof(RenterId))]
        public ApplicationUser? Renter { get; set; }

        public bool IsActive { get; set; } = true;
    }
}

//•	Id – a unique integer, Primary Key
//•	Title – a string with min length 10 and max length 50 (required)
//•	Address – a string with min length 30 and max length 150 (required)
//•	Description – a string with min length 50 and max length 500 (required)
//•	ImageUrl – a string(required)
//•	PricePerMonth – a decimal with min value 0 and max value 2000 (required)
//•	CategoryId – an integer(required)
//•	Category – a Category object
//•	AgentId – an integer (required)
//•	Agent – an Agent object
//•	RenterId – a string

