namespace lekcjaApi.Dto
{
    public class ShelterDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<PetDto> Pet { get; set; }
    }
}
