namespace ReProject.Core.Entities;

public abstract class EntityBase
{
    public virtual Guid Id { get; set; }


}

public abstract class EntityBase<T>
{

    public virtual T Id { get; set; }
}