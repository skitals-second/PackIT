using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions
{
    public class PackingItemAlreadyExistsException :PackitException
    {
        public string ListName { get;}
        public string ItemName { get;}
        
        public PackingItemAlreadyExistsException(string listName, string itemname) 
            : base($"Packing list '{listName}' already defined item '{itemname}'")
        {
            ListName = listName;
            ItemName = itemname;
        }
    }
}