using Restaurant_Menu_Organiser.Models.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Menu_Organiser.Models.Notifications
{
    public interface INotificationsService
    {
        public  Task<Notification> Add(Notification NewNotifications);
        public Task<Notification> Update(Notification notificationChanges);
    }
}
