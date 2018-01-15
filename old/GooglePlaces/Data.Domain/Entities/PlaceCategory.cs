﻿using System;
using System.Collections.Generic;

namespace Data.Domain.Entities
{
    public class PlaceCategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Place> Places { get; set; }
    }
}
