using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions
{
    public class EmptyPackingListItemNameException :PackitException
    {
        public EmptyPackingListItemNameException() : base("Packing item name cannot be empty.")
        {
        }
    }
}