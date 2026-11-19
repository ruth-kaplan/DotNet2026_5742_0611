
namespace Dal.Exceptions
{
    internal class DalException : Exception
    {
        public DalException(string message) : base(message)
        {
        }
    }

    internal class DuplicateIdException : DalException
    {
        public DuplicateIdException(int id)
            : base($"An entity with ID {id} already exists.")
        {
        }
    }

    internal class EntityNotFoundException : DalException
    {
        public EntityNotFoundException(int id)
            : base($"An entity with ID {id} was not found.")
        {
        }
    }
}
