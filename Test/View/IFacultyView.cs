﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.Controller;

namespace Proiect.View
{
    public interface IFacultyView
    {
        void LoadView();
        void SetController(IFacultyController cont);
        void Enable();
        void Disable();
    }
}
