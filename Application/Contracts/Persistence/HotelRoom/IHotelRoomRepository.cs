using Application.Features.HotelRoom;

namespace Application.Contracts.Persistence.HotelRoom;

public interface IHotelRoomRepository
{
    Task<Domain.Entities.HotelRoom> CreateHotelRoomAsync(Domain.Entities.HotelRoom model);
}