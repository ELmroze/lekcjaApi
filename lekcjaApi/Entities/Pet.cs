﻿using System.ComponentModel.DataAnnotations;

namespace lekcjaApi.Entities
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int ShelterId { get; set; }
        [Required]
        public virtual Shelter Shelter { get; set; }

        public Pet(){   }

        public Pet(int id, string name,int age, int idShelter)
        {
            (Id,Name, Age, ShelterId) = (id,name, age, idShelter);
        }
        public Pet( string name, int age, int idShelter)
        {
            ( Name, Age, ShelterId) = ( name, age, idShelter);
        }
    }
}
