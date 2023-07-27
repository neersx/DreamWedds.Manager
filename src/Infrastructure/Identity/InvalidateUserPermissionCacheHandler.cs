using DreamWedds.Manager.Application.Common.Events;
using DreamWedds.Manager.Application.Identity.Users;
using DreamWedds.Manager.Domain.Identity;
using Microsoft.AspNetCore.Identity;

namespace DreamWedds.Manager.Infrastructure.Identity;

internal class InvalidateUserPermissionCacheHandler :
    IEventNotificationHandler<ApplicationUserUpdatedEvent>,
    IEventNotificationHandler<ApplicationRoleUpdatedEvent>
{
    private readonly IUserService _userService;
    private readonly UserManager<ApplicationUser> _userManager;

    public InvalidateUserPermissionCacheHandler(IUserService userService, UserManager<ApplicationUser> userManager) =>
        (_userService, _userManager) = (userService, userManager);

    public async Task Handle(EventNotification<ApplicationUserUpdatedEvent> notification, CancellationToken cancellationToken)
    {
        if (notification.Event.RolesUpdated)
        {
            await _userService.InvalidatePermissionCacheAsync(notification.Event.UserId, cancellationToken);
        }
    }

    public async Task Handle(EventNotification<ApplicationRoleUpdatedEvent> notification, CancellationToken cancellationToken)
    {
        if (notification.Event.PermissionsUpdated)
        {
            foreach (var user in await _userManager.GetUsersInRoleAsync(notification.Event.RoleName))
            {
                await _userService.InvalidatePermissionCacheAsync(user.Id, cancellationToken);
            }
        }
    }
}