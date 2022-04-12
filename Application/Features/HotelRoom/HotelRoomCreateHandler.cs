using Application.Contracts.Persistence;
using Application.Models.Common;
using AutoMapper;
using MediatR;

namespace Application.Features.HotelRoom;

public class HotelRoomCreateHandler:IRequestHandler<HotelRoomCreateCommand,OperationResult<HotelRoomCreateCommand>>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;


    public HotelRoomCreateHandler(IMapper mapper,IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }
    public async Task<OperationResult<HotelRoomCreateCommand>> Handle(HotelRoomCreateCommand request, CancellationToken cancellationToken)
    {
        var room = _mapper.Map<Domain.Entities.HotelRoom>(request);
        var result = await _unitOfWork.HotelRoomRepository.CreateHotelRoomAsync(room);
        return  OperationResult<HotelRoomCreateCommand>.SuccessResult(_mapper.Map<HotelRoomCreateCommand>(room));

    }
}