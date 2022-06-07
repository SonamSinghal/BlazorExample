using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExample
{
    public class DateTimeBaseComponent : ComponentBase
    {
        public string dateTime { get; set; } = DateTime.Today.ToShortDateString();

    }
}
