using System;
using System.Collections.Generic;
using Application.Enums;

namespace Application.Entities
{
    public class Pet
    {
        public Pet(string name, int age, EGender gender, ESize size)
        {
            Id = Guid.NewGuid();
            Name = name;
            Age = age;
            Gender = gender;
            Size = size;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public EGender Gender { get; private set; }
        public ESize Size { get; private set; }

        public bool IsValid()
        {
            return (this.Name.Length >= 3
            && this.Name.Length <= 20);
        }       

    }
}