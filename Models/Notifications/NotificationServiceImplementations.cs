using Restaurant_Menu_Organiser.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Menu_Organiser.Models.Notifications
{
    public class NotificationServiceImplementations : INotificationsService
    {
        private readonly ApplicationDbContext _notificationsContext;

        public NotificationServiceImplementations(ApplicationDbContext notificationsContext)
        {
            _notificationsContext = notificationsContext;
        }
        public async Task<Notification> Add(Notification NewNotifications)
        {
            _notificationsContext.Add(NewNotifications);
            await _notificationsContext.SaveChangesAsync();
            return NewNotifications;
        }
        public async Task<Notification> Update(Notification notificationChanges)
        {
            var Editednotification = _notificationsContext.Notifications.Attach(notificationChanges);
            Editednotification.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _notificationsContext.SaveChangesAsync();
            return notificationChanges;

        }
    }
}
