using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspen.Example.Entities
{
    /// <summary>
    /// Represents the relationship between the user and the different roles..
    /// </summary>
    [Table("UserRoles")]
    public class UserRoles
    {
        /// <summary>
        /// Unique identifier.
        /// </summary>
        public int UserRolesId { get; set; }

        /// <summary>
        /// When this role started.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// When the role will finish.
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
        [Display(Name = "User")]
        public virtual int UserId { get; set; }


        /// <summary>
        /// Related user.
        /// </summary>
        [ForeignKey("UserId")]
        public virtual User User { get; set; }


        // Foreign key   
        [Display(Name = "Role")]
        public virtual int RoleId { get; set; }


        /// <summary>
        /// Related role
        /// </summary>
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        #endregion
    }
}
