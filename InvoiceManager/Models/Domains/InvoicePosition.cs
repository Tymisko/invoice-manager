using System;

namespace InvoiceManager.Models.Domains
{
    public class InvoicePosition
    {
        public int Id { get; set; }
        public int No { get; set; }
        public int InvoiceId { get; set; }
        public Decimal Value { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public Invoice Invoice { get; set; }
        public Product Product { get; set; }
    }
}