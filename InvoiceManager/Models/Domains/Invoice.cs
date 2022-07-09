using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceManager.Models.Domains
{
    public class Invoice
    {
        public Invoice()
        {
            InvoicePositions = new Collection<InvoicePosition>();
        }

        public int Id { get; set; }

        [Required] 
        public string Title { get; set; }

        public decimal Value { get; set; }
        public int PaymentMethodId { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Comments { get; set; }
        public int CliendId { get; set; }

        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }
        
        public PaymentMethod PaymentMethod { get; set; }
        public Client Client { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<InvoicePosition> InvoicePositions { get; set; }
    }
}