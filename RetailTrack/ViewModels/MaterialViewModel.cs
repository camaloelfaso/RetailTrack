using Microsoft.AspNetCore.Mvc.Rendering;
using RetailTrack.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace RetailTrack.ViewModels

{
    public class MaterialIndexViewModel
    {
        public IEnumerable<Material> Materials { get; set; } = new List<Material>();
        public IEnumerable<SelectListItem> MaterialTypes { get; set; } = new List<SelectListItem>();
        public string? SelectedMaterialTypeId { get; set; }
        public string? NameFilter { get; set; }
    }

    public class MaterialViewModel
    {
        [Required(ErrorMessage = "El nombre del material es obligatorio.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un tipo de material.")]
        public Guid MaterialTypeId { get; set; }

        public IEnumerable<SelectListItem> MaterialTypes { get; set; } = new List<SelectListItem>();

        [Required(ErrorMessage = "Debe seleccionar un tamaño.")]
        public int SizeId { get; set; }

        public IEnumerable<SelectListItem> Sizes { get; set; } = new List<SelectListItem>();
    }
}    