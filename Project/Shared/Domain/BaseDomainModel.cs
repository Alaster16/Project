using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domain
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
    public class Staff : BaseDomainModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int ContactNumber { get; set; }


    }
    public class EventMember: BaseDomainModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int ContactNumber { get; set; }
        public int DOB { get; set; }
        public string Gender { get; set; }

    }
    public class Organizer : BaseDomainModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int ContactNumber { get; set; }
        public int DOB { get; set; }
        public string Gender { get; set; }

    }
    public class Event : BaseDomainModel
    {
        public int OrganizerID { get; set; }
        public int VenueID { get; set; }
        public int StaffID { get; set; }
        public string EventType { get; set; }
        public DateTime Date { get; set; }
        public virtual List<Venue> Venue { get; set; }
    }
    public class Registration:BaseDomainModel
    {
        public DateTime DateTimeRegistered { get; set; }
        public int EventID { get; set; }
        public int PaymentAmount { get; set; }
        public string PaymentType { get; set; }

        public string EventMemberID { get; set; }


    }


  
}