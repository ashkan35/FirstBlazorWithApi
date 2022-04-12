using Domain.Common;

namespace Domain.Entities;

public class HotelRoom:BaseEntity
{



    public string Name { get; set; }
    public int Occupancy { get; set; }
    public double RegularRate { get; set; }
    public string Details { get; set; }
    public string SqFt { get; set; }
    public string CreatedBy { get; set; }
    public string UpdatedBy { get; set; }

}