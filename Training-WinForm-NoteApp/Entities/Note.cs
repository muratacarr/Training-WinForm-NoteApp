﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_WinForm_NoteApp.Entities
{
    public class Note
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
    }
}
