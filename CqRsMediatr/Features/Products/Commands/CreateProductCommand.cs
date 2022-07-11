using CqRsMediatr.Domain;
using CqRsMediatr.Infraestructure.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CqRsMediatr.Features.Products.Commands
{
    public class CreateProductCommand :IRequest
    {
        public string Description { get; set; } = default!;
        public double Price { get; set; }
    }

    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly MyAppDbContext _context;

        public CreateProductCommandHandler(MyAppDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateProductCommand requst, CancellationToken cancellationToken)
        {
            var newProduct = new Product
            {
                Description = requst.Description,
                Price  =requst.Price
            };
            _context.Products.Add(newProduct);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }

}
