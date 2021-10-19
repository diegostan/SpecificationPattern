using Application.Entities;

namespace Application.Specs
{
    public class IsPetMostValue_On_2021 : ISpecification<Pet>
    {
        public bool IsSatisfiedBy(Pet candidate)
        {
            return
                (candidate.Age > 25 && candidate.Gender == Enums.EGender.Female && candidate.Size >= Enums.ESize.Medium)
                ||
                (candidate.Age > 26 && candidate.Gender == Enums.EGender.Male && candidate.Size >= Enums.ESize.Large);
        }
    }
}