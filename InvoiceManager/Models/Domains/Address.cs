using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Threading;

namespace InvoiceManager.Models.Domains
{
    public class Address
    {
        public Address()
        {
            Clients = new Collection<Client>();
            Users = new Collection<ApplicationUser>();
        }

        public int Id { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        public ICollection<Client> Clients { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }
    }
}