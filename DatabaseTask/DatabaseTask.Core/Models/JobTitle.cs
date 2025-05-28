using System;
using System.Collections.Generic;

namespace DatabaseTask.Core.Models;

public partial class JobTitle
{
    public int JobTitleId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;
}
