using System.Collections.Generic;
using InvoiceManager.Models.Domains;

namespace InvoiceManager.Models.ViewModels
{
    public class EditInvoiceViewModel
    {
        public Invoice Invoice { get; set; }
        public List<Client> Clients { get; set; }
        public List<PaymentMethod> MethodOfPayments { get; set; }
        public string Heading { get; set; }
    }
}