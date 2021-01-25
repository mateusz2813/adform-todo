namespace AdForm.ToDoList.Domain
{
    public abstract class Entity<T>
    {
        public virtual T Id { get; set; }

        protected Entity()
        {
        }

        protected Entity(T id)
        {
            Id = id;
        }

        public override bool Equals(object @object)
        {
            if (@object == null)
            {
                return false;
            }

            if (GetType() != @object.GetType())
            {
                return false;
            }

            var entity = (Entity<T>)@object;

            return Id.Equals(entity.Id);
        }

        public override int GetHashCode()
            => Id.GetHashCode();
    }
}