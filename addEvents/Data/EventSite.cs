﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addEvents.Data
{
    public class EventSite
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public EventSite(int id, string title)
        {
            ID = id;
            Title = title;
        }
    }
}
