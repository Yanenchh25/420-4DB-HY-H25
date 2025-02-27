﻿using System;
using System.Collections.Generic;

namespace JeuxOlympiques2025;

public partial class Record
{
    public int Id { get; set; }

    public int IdCoureur { get; set; }

    public decimal Record1 { get; set; }

    public virtual Coureur IdCoureurNavigation { get; set; } = null!;
}
