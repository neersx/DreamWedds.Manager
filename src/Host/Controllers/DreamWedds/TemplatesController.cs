﻿using DreamWedds.Manager.Application.Blogs;
using DreamWedds.Manager.Application.Template;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DreamWedds.Manager.Host.Controllers.DreamWedds;

public class TemplatesController : VersionedApiController
{
    [HttpPost("search")]
    [AllowAnonymous]
    [OpenApiOperation("Search templates using available filters.", "")]
    public Task<PaginationResponse<TemplateDto>> SearchAsync(SearchTemplateRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpGet("{id:int}")]
    [AllowAnonymous]
    [OpenApiOperation("Get template details.", "")]
    public Task<TemplateDto> GetAsync(int id)
    {
        return Mediator.Send(new GetTemplateRequest(id));
    }

    [HttpGet("{name}")]
    [AllowAnonymous]
    [OpenApiOperation("Get template details by tempate name.", "")]
    public Task<TemplateDto> GetByNameAsync(string name)
    {
        return Mediator.Send(new GetTemplateByNameRequest(name));
    }
}
