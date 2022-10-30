using efday1.DTOs;
using efday1.Models;
using efday1.Repositories;


namespace efday1.Services;

public class StdService : IStdService
{
    private readonly IStdRepository _studentRepository;

    public StdService(IStdRepository studentRepository)
    {
        _studentRepository = studentRepository;
    } 

    public AddStdResponse Create(AddStdRequest createModel)
    {
        var createStudent = new Student
        {
            FirstName = createModel.FirstName,
            LastName = createModel.LastName,
            City = createModel.City,
            State = createModel.State
        };

        var student = _studentRepository.Create(createStudent);

        _studentRepository.SaveChanges();

        return new AddStdResponse
        {
            Id = student.Id,
            FirstName = student.FirstName
        };
    }

    public bool Delete(int id)
    {
        var student = _studentRepository.Get(x => x.Id == id);

        if (student == null)
        {
            return false;
        }
        _studentRepository.Delete(student);

        _studentRepository.SaveChanges();

        return true;
    }

    public IEnumerable<Student> GetAll()
    {
        var students = _studentRepository.GetAll(x => true);

        return students;
    }

    public UpdateResponse Update(int id, UpdateRequest updateRequest)
    {
        var student = _studentRepository.Get(x => x.Id == id);

        if (student == null)
        {
            return null;
        }

        student.FirstName = updateRequest.FirstName;
        student.LastName = updateRequest.LastName;
        student.City = updateRequest.City;
        student.State = updateRequest.State;

        student = _studentRepository.Update(student);

        _studentRepository.SaveChanges();

        return new UpdateResponse
        {
            FirstName = student.FirstName,
            LastName = student.LastName,
            City = student.City,
            State = student.State
        };
    }

}
