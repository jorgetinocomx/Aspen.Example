using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aspen.Example.Entities
{
    /// <summary>
    /// Represents the table Role on the database.
    /// </summary>
    [Table("Role")]
    public class Role
    {
        /// <summary>
        /// Unique identifier.
        /// </summary>
        [Key]
        public int RoleId { get; set; }

        /// <summary>
        /// Role name.
        /// </summary>
        public string Name { get; set; }

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

    }
}
