using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Aspen.Example.Entities
{
    /// <summary>
    /// Represents the table User on the database.
    /// </summary>
    [Table("User")]
    public class User
    {
        /// <summary>
        /// Unique identifier.
        /// </summary>
        [Key]
        public int UserId { get; set; }

        /// <summary>
        /// User first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// User last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// When the user started.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// When the user will finish.
        /// </summary>
        public DateTime EndDate { get; set; }


        #region Tracking columns

        /// <summary>
        /// User who inserts this entry.
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// When this entry was  inserted.
        /// </summary>

        public DateTime CreatedDate { get; set; }


        /// <summary>
        /// The last time this entry was updated.
        /// </summary>
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// Last user who updates this entry.
        /// </summary>
        public DateTime? UpdateDate { get; set; }
        #endregion

        #region Navigation properties

        // Foreign key   
        [Display(Name = "Department")]
        public virtual int DepartmentId { get; set; }


        /// <summary>
        /// User belongs to this department.
        /// </summary>
        [ForeignKey("DepartmentId")]
        public virtual Department UserDepartment { get; set; }

        #endregion
    }
}
