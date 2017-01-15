using AutoMapper;
using CQRSlite.Events;
using PolitehnicUniversity.Domain.Events.Students;
using PolitehnicUniversity.Domain.ReadModel;
using PolitehnicUniversity.Domain.ReadModel.Repositories.Interfaces;
using PolitehnicUniversity.Domain.WriteModel;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitehnicUniversity.Domain.EventHandlers
{
    public class StudentEventHandler : IEventHandler<StudentCreatedEvent>
    {
        private readonly IMapper _mapper;
        private readonly IStudentRepository _StudentRepo;
        public StudentEventHandler(IMapper mapper, IStudentRepository StudentRepo)
        {
            _mapper = mapper;
            _StudentRepo = StudentRepo;
        }

        public void Handle(StudentCreatedEvent message)
        {
            StudentRM Student = _mapper.Map<StudentRM>(message);
            _StudentRepo.Save(Student);
        }
    }
}
