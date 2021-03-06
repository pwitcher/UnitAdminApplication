﻿using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Parts
{
    public partial class AddPart : ComponentBase
    {

        public PartModel model { get; set; } = new PartModel();

        private async Task SavePart()
        {
            await parts.SavePartAsync(model);
            navMan.NavigateTo("/Parts");
        }

        public void CancelClicked()
        {
            navMan.NavigateTo("/Parts");
        }

        public void RemovePart()
        {
            parts.DeletePart(model);
            navMan.NavigateTo("/Parts");
        }
    }
}