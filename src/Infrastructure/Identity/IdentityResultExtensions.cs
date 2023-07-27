﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;

namespace DreamWedds.Manager.Infrastructure.Identity;

internal static class IdentityResultExtensions
{
    public static List<string> GetErrors(this IdentityResult result, IStringLocalizer T) =>
        result.Errors.Select(e => T[e.Description].ToString()).ToList();
}