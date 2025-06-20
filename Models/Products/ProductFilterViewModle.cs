﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace Html2ViewsConversion.Models.Products
{
    public class ProductFilterViewModel
    {
        public string SearchTerm { get; set; } = string.Empty;
        public string CategoryId { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 3;

        // For dropdowns
        public IEnumerable<SelectListItem> Categories { get; set; } = new List<SelectListItem>();
        public IEnumerable<SelectListItem> Statuses { get; set; } = new List<SelectListItem>();
    }
}
