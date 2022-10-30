using efday1.Models;
using efday1.DTOs;
using efday1.Services;
using Microsoft.AspNetCore.Mvc;
namespace efday1.Controllers;


[ApiController]
[Route("[controller]")]

    public class StdController : ControllerBase
    {
        private readonly IStdService _studentService;

    public StdController(IStdService studentService)
    {
        _studentService = studentService;
    }

    [HttpPost]
    public AddStdResponse Add([FromBody] AddStdRequest addRequest)
    {
        return _studentService.Create(addRequest);
    }

    [HttpGet]
    public IEnumerable<Student>? GetAll()
    {
        try
        {
            var student = _studentService.GetAll();

            return student;
        }
        catch (Exception)
        {
            return null;
        }
    }

    [HttpDelete("{id}")]
    public bool Delete(int id)
    {
        var student = _studentService.Delete(id);

        return student;
    }

    [HttpPut("update")]
    public UpdateResponse Update(int id, UpdateRequest updateRequest)
    {
        return _studentService.Update(id, updateRequest);
    }
    }
