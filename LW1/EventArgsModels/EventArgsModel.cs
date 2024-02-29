using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW1.EventArgsModels
{
    public class EventArgsModel(string message) : EventArgs
    {
        public string Message { get; set; } = message;
    }
}
