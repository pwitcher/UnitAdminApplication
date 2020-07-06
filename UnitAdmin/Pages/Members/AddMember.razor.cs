﻿using DataLibrary.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitAdmin.Pages.Members
{
    public partial class AddMember : ComponentBase
    {
        private MemberModel newMember = new MemberModel();

        public void SaveMember()
        {
            _context.AddMember(newMember);
            navMan.NavigateTo("/members");
        }

        public void CancelClicked()
        {
            navMan.NavigateTo("/members");
        }
    }
}
