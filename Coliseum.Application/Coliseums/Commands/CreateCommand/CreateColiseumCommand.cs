using MediatR;

namespace Coliseum.Modules.Coliseums.Application.Coliseums.Commands.CreateCommand
{
    public record CreateColiseumCommand : IRequest<Guid>;

    public class CreateColiseumCommandHanlder : IRequestHandler<CreateColiseumCommand, Guid>
    {
        public async Task<Guid> Handle(CreateColiseumCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
