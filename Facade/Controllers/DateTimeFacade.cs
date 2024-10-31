using Facade.DTOs.Time;
using Microsoft.AspNetCore.Mvc;

namespace Facade.Controllers;

public interface DateTimeFacade
{
    ActionResult<GetDateTimeResponse> GetDateTime(GetDateTimeRequest request);
}