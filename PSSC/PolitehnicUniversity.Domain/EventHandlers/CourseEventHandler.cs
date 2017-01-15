using AutoMapper;
using CQRSlite.Events;
using PolitehnicUniversity.Domain.Events.Courses;
using PolitehnicUniversity.Domain.ReadModel;
using PolitehnicUniversity.Domain.ReadModel.Repositories.Interfaces;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitehnicUniversity.Domain.EventHandlers
{
    public class CourseEventHandler : IEventHandler<CourseCreatedEvent>,
                                        IEventHandler<StudentAssignedToCourseEvent>,
                                        IEventHandler<StudentRemovedFromCourseEvent>
    {
        private readonly IMapper _mapper;
        private readonly ICourseRepository _CourseRepo;
        private readonly IStudentRepository _StudentRepo;
        public CourseEventHandler(IMapper mapper, ICourseRepository CourseRepo, IStudentRepository StudentRepo)
        {
            _mapper = mapper;
            _CourseRepo = CourseRepo;
            _StudentRepo = StudentRepo;
        }

        public void Handle(CourseCreatedEvent message)
        {
            //Create a new CourseDTO object from the CourseCreatedEvent
            CourseRM Course = _mapper.Map<CourseRM>(message);

            _CourseRepo.Save(Course);
        }

        public void Handle(StudentAssignedToCourseEvent message)
        {
            var Course = _CourseRepo.GetByID(message.NewCourseID);
            Course.Students.Add(message.StudentID);
            _CourseRepo.Save(Course);

            //Find the Student which was assigned to this Course
            var Student = _StudentRepo.GetByID(message.StudentID);
            Student.CourseID = message.NewCourseID;
            _StudentRepo.Save(Student);
        }

        public void Handle(StudentRemovedFromCourseEvent message)
        {
            var Course = _CourseRepo.GetByID(message.OldCourseID);
            Course.Students.Remove(message.StudentID);
            _CourseRepo.Save(Course);
        }
    }
}
