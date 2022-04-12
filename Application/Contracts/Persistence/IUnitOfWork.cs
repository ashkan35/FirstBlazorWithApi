using Application.Contracts.Persistence.HotelRoom;

namespace Application.Contracts.Persistence
{
    public interface IUnitOfWork
    {
        public IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
        public IHotelRoomRepository HotelRoomRepository { get; }
        Task CommitAsync();
        ValueTask RollBackAsync();
    }
}
