using FluentValidation;

namespace CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;

public sealed class CreateCarCommandValidator: AbstractValidator<CreateCarCommand>
{
    public CreateCarCommandValidator()
    {
        RuleFor(p=>p.Name).NotEmpty().WithMessage("Araç adı boş olamaz!");
        RuleFor(p=>p.Name).NotNull().WithMessage("Araç adı boş olamaz!");
        RuleFor(p=>p.Name).MinimumLength(2).WithMessage("Araç adı en az 2 karakter olmalıdır!");
        
        RuleFor(p=>p.Model).NotEmpty().WithMessage("Model adı boş olamaz!");
        RuleFor(p=>p.Model).NotNull().WithMessage("Model adı boş olamaz!");
        RuleFor(p=>p.Model).MinimumLength(2).WithMessage("Model adı en az 2 karakter olmalıdır!");
       
        RuleFor(p=>p.EnginePower).NotEmpty().WithMessage("Motor gücü boş olamaz!");
        RuleFor(p => p.EnginePower).NotNull().WithMessage("Motor gücü boş olamaz!");
        RuleFor(p => p.EnginePower).GreaterThan(0).WithMessage("Motor gücü 0 dan büyük olmalıdır");
        

    }
}
