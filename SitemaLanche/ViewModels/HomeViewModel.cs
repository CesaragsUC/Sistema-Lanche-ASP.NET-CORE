﻿using SitemaLanche.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitemaLanche.ViewModels
{
    public class HomeViewModel
    {

        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}
