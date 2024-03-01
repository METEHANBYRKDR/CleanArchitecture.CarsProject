using AutoMapper;
using CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Persistance.Context;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CleanArchitecture.Persistance.Services;

public class CarService : ICarService
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public CarService(AppDbContext context,IMapper mapper)
    {
        _mapper = mapper;
        _context = context;
    }
    public async Task CreateAsync(CreateCarCommand request, CancellationToken cancellationToken)
    {
        Car car = _mapper.Map<Car>(request);
        await _context.Set<Car>().AddAsync(car, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
