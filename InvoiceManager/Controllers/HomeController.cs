using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InvoiceManager.Models.Domains;
using InvoiceManager.Models.ViewModels;

namespace InvoiceManager.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var invoices = new List<Invoice>
            {
                new Invoice
                {
                    Id = 1,
                    Title = "In/01/2022",
                    CreatedDate = DateTime.Now,
                    PaymentDate = DateTime.Now,
                    Value = 999,
                    Client = new Client
                    {
                        Name = "Client 1"
                    }
                },

                new Invoice
                {
                    Id = 2,
                    Title = "In/02/2022",
                    CreatedDate = DateTime.Now,
                    PaymentDate = DateTime.Now,
                    Value = 9919,
                    Client = new Client
                    {
                        Name = "Client 2"
                    }
                },
            };

            return View(invoices);
        }

        public ActionResult Invoice(int id = 0)
        {
            EditInvoiceViewModel vm = null;
            if (id == 0)
            {
                vm = new EditInvoiceViewModel
                {
                    Clients = new List<Client>
                    {
                        new Client
                        {
                            Id = 1,
                            Name = "Client1"
                        },

                    },
                    MethodOfPayments = new List<PaymentMethod>
                    {
                        new PaymentMethod
                        {
                            Id = 1,
                            Name = "Transaction"
                        }
                    },
                    Heading = "Editing Invoice",
                    Invoice = new Invoice()
                };
            }
            else
            {
                vm = new EditInvoiceViewModel
                {
                    Clients = new List<Client>
                    {
                        new Client
                        {
                            Id = 1,
                            Name = "Client1"
                        },

                    },
                    MethodOfPayments = new List<PaymentMethod>
                    {
                        new PaymentMethod
                        {
                            Id = 1,
                            Name = "Transaction"
                        }
                    },
                    Heading = "Editing Invoice",
                    Invoice = new Invoice
                    {
                        CliendId = 1,
                        Comments = "Lorem ipsum dolor sit amet.",
                        CreatedDate = DateTime.Now,
                        PaymentDate = DateTime.Now,
                        PaymentMethodId = 1,
                        Id = 1,
                        Value = 100,
                        Title = "IN/07/2022",
                        InvoicePositions = new List<InvoicePosition>
                        {
                            new InvoicePosition
                            {
                                No = 1,
                                Product = new Product
                                {
                                    Name = "Sample Product 1",
                                },
                                Quantity = 2,
                                Value = 50
                            },
                            new InvoicePosition
                            {
                                No = 1,
                                Product = new Product
                                {
                                    Name = "Sample Product 2",
                                },
                                Quantity = 3,
                                Value = 510
                            }   
                        }
                    }
                };
            }

            return View(vm);
        }

        [AllowAnonymous]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [AllowAnonymous]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}