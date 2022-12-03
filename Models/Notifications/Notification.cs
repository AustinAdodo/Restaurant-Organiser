using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Menu_Organiser.Models.Notifications
{
    public class Notification
    {
        public int Id { get; set; }
        public string NameHeader { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string Status { get; set; }
        public string ConsumerId { get; set; }
        public string Department { get; set; }
        public string  DateandTime { get; set; }
    }
}
