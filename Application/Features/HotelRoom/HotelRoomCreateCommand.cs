using Application.Models.Common;
using Application.Profiles;
using MediatR;

namespace Application.Features.HotelRoom;

public class HotelRoomCreateCommand:IRequest<OperationResult<HotelRoomCreateCommand>>,ICreateMapper<Domain.Entities.HotelRoom>
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Occupancy { get; set; }

    public double RegularRate { get; set; }
    public string Details { get; set; }
    public string SqFt { get; set; }

    public double TotalDays { get; set; }
    public double TotalAmount { get; set; }
}