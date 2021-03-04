using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.WebUI.Models
{
    public class WebCustomer
    {
        /// <summary>
        /// Customer First Name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Customer Last Name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Customer Email to login to store.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Customer password to login to store.
        /// </summary>
        public string Password { get; set; }
    }
}
