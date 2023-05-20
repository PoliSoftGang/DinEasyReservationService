using System;

namespace Domain.Exceptions
{
    public sealed class PaculiarityNotFoundException : NotFoundException
    {
        public PaculiarityNotFoundException(int PaculiarityId)
            : base($"The paculiarity with the identifier {PaculiarityId} was not found.")
        {
        }
    }
}
