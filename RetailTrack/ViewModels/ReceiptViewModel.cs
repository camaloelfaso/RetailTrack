using Microsoft.AspNetCore.Mvc.Rendering;
using RetailTrack.Models;
using System;
using System.Collections.Generic;

namespace RetailTrack.ViewModels
{
    public class ReceiptViewModel
    {
        public Receipt Receipt { get; set; } = new Receipt();
        public ReceiptDetailViewModel NewItem { get; set; } = new ReceiptDetailViewModel();
        public ReceiptPaymentViewModel NewPayment { get; set; } = new ReceiptPaymentViewModel();
        public IEnumerable<SelectListItem> MaterialTypes { get; set; } = new List<SelectListItem>();
        public IEnumerable<SelectListItem> Materials { get; set; } = new List<SelectListItem>();
        public IEnumerable<SelectListItem> Sizes { get; set; } = new List<SelectListItem>();
        public IEnumerable<SelectListItem> PaymentMethods { get; set; } = new List<SelectListItem>();
        public List<ReceiptDetailViewModel> Items { get; set; } = new List<ReceiptDetailViewModel>();
        public List<ReceiptPaymentViewModel> Payments { get; set; } = new List<ReceiptPaymentViewModel>();

        // Nuevas propiedades para preseleccionar valores desde la sesión
        public Guid? SelectedMaterialType { get; set; }
        public Guid? SelectedMaterial { get; set; }
        public int? SelectedSize { get; set; }
    }

    public class ReceiptDetailViewModel
    {
        public Guid DetailId { get; set; }
        public Guid MaterialId { get; set; }
        public string MaterialName { get; set; } = string.Empty;
        public string MaterialTypeName { get; set; } = string.Empty;
        public int SizeId { get; set; }
        public string SizeName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public decimal TotalCost => Quantity * UnitCost;

        // Campos adicionales
        public Guid ReceiptId { get; set; }
        public DateTime ReceiptDate { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
    }

    public class ReceiptIndexViewModel
    {
        public List<ReceiptIndexDetailViewModel> Receipts { get; set; } = new List<ReceiptIndexDetailViewModel>();
        public IEnumerable<SelectListItem> PaymentMethods { get; set; } = new List<SelectListItem>();
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? SelectedPaymentMethod { get; set; }
    }

    public class ReceiptIndexDetailViewModel
    {
        public Guid ReceiptId { get; set; }
        public DateTime ReceiptDate { get; set; }
        public string PaymentMethods { get; set; }
        public List<ReceiptDetailViewModel> Details { get; set; } = new List<ReceiptDetailViewModel>();
    }

    public class ReceiptPaymentViewModel
    {
        public int PaymentMethodId { get; set; }
        public string PaymentMethodName { get; set; } = string.Empty;
        public decimal? Percentage { get; set; }
        public decimal Amount { get; set; }
    }

    public class ReceiptCreateViewModel
    {
        public IEnumerable<SelectListItem> MaterialTypes { get; set; } = new List<SelectListItem>();
        public IEnumerable<SelectListItem> Materials { get; set; } = new List<SelectListItem>();
        public IEnumerable<SelectListItem> Sizes { get; set; } = new List<SelectListItem>();
        public IEnumerable<SelectListItem> PaymentMethods { get; set; } = new List<SelectListItem>();
        public List<ReceiptPaymentViewModel> Payments { get; set; } = new List<ReceiptPaymentViewModel>();
        public List<ReceiptItemViewModel> Items { get; set; } = new List<ReceiptItemViewModel>();

        // Campos del formulario de Receipt
        public int PaymentMethodId { get; set; }
        public int Percentage { get; set; }

        // Nuevas propiedades para preseleccionar valores desde la sesión
        public Guid? SelectedMaterialType { get; set; }
        public Guid? SelectedMaterial { get; set; }
        public int? SelectedSize { get; set; }
    }

    public class PaymentViewModel
    {
        public string PaymentMethodName { get; set; } = string.Empty;
        public int? Percentage { get; set; }
        public int Amount { get; set; }
    }

    public class ReceiptItemViewModel
    {
        public string MaterialTypeName { get; set; } = string.Empty;
        public string MaterialName { get; set; } = string.Empty;
        public string SizeName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitCost { get; set; }
    }
}
