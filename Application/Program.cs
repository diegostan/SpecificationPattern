using System.Collections.Generic;
using Application.Entities;
using Application.Enums;
using System;
using System.Linq;
using Application.Specs;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Pet> _pets = new List<Pet>();

            _pets = new List<Pet>()
            {
                new Pet(name: "Bruce", age: 42, gender: EGender.Male, size: ESize.Large),
                new Pet(name: "Kira", age: 36, gender: EGender.Female, size: ESize.Large),
                new Pet(name: "Candy", age: 29, gender: EGender.Female, size: ESize.Small),
                new Pet(name: "Mufasa", age: 8, gender: EGender.Male, size: ESize.Large),
                new Pet(name: "Bob", age: 12, gender: EGender.Male, size: ESize.Medium),
            };

            _pets
            .Where(pet => pet.IsValid())
            .Where(pet => new IsPetMostValue_On_2021().IsSatisfiedBy(pet))            
            .ToList()
            .ForEach(s => Console.WriteLine(s.Name));
        }
    }
}
