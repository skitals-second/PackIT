using System;
using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Application.Exceptions
{
    public class PackingListNotFoundException : PackitException
    {
        public Guid Id { get; }
        
        public PackingListNotFoundException(Guid id) : base($"Packing list with Id '{id}' not found.")
        {
            Id = id;
        }
    }
}