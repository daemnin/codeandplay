﻿using CodeAndPlay.Model.Entities;
using System;

namespace CodeAndPlay.Data.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IEntityRepository<Attendance> AttendanceRepository { get; }
        IEntityRepository<Contact> ContactRepository { get; }
        IEntityRepository<Event> EventRepository { get; }
        IEntityRepository<Organizer> OrganizerRepository { get; }
        IEntityRepository<Requirement> RequirementRepository { get; }
        IEntityRepository<Role> RoleRepository { get; }
        IEntityRepository<Rule> RuleRepository { get; }
        IEntityRepository<School> SchoolRepository { get; }
        IEntityRepository<Student> StudentRepository { get; }
        IEntityRepository<Talk> TalkRepository { get; }
        IEntityRepository<Team> TeamRepository { get; }
        IEntityRepository<TeamMember> TeamMemberRepository { get; }
        IEntityRepository<Workshop> WorkshopRepository { get; }

        int Save();
    }
}