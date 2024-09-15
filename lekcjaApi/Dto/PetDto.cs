namespace lekcjaApi.Dto
{
    public class PetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public ShelterDto Shelter { get; set; }
    }
}
