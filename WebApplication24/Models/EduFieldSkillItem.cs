﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Models
{
    public partial class EduFieldSkillItem
    {
        public int SkillItemId { get; set; }
        public int SkillD { get; set; }
        public string ItemName { get; set; }

        public virtual EduFieldSkill SkillDNavigation { get; set; }
    }
}
