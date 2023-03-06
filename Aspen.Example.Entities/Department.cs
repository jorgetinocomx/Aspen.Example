using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aspen.Example.Entities
{
    /// <summary>
    /// Represents the table Department on the database.
    /// </summary>
    [Table("Department")]
    public class Department
    {
        /// <summary>
        /// Unique identifier.
        /// </summary>
        [Key]
        public int DepartmentId { get; set; }

        /// <summary>
        /// Department name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Department  description.
        /// </summary>
        public string Desciption { get; set; }

        /// <summary>
        /// Department status. When true, department is active. w
        /// </summary>
        public bool Active { get; set; }


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



        #region Navitation properties
        /// <summary>
        /// Contains all the users that belongs to these department.
        /// </summary>
        public ICollection<User> Users { get; set; }
        #endregion
    }
}
