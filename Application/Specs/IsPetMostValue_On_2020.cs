using Application.Entities;

namespace Application.Specs
{
    public partial class IsPetMostValue_On_2020 : ISpecification<Pet>
    {
         public bool IsSatisfiedBy(Pet candidate)
        {
            return 
                (candidate.Age > 24 && candidate.Gender == Enums.EGender.Female && candidate.Size >= Enums.ESize.Large);               
        }
        
    }

}