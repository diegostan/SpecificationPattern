using Application.Entities;

namespace Application.Specs
{
    public interface ISpecification<in T> where T : class
    {
        bool IsSatisfiedBy(T candidate);
    }
}