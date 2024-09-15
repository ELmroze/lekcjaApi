using System.ComponentModel.DataAnnotations;

namespace lekcjaApi.Entities
{
    public class Shelter
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Adress {  get; set; }
        public virtual ICollection<Pet> Pets { get; set; }

        public Shelter() { }

        public Shelter(int id,string name, string adress)
        {
            (Id,Name, Adress) = (id,name, adress);

        }

    }
}
