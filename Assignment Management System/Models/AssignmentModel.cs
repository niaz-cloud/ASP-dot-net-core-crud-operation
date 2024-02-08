using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment_Management_System.Models
{
    public class AssignmentModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Due date is required.")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        // Add other properties as needed.
    }
}
