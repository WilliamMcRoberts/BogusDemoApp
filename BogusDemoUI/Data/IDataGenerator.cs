namespace BogusDemoUI.Data
{
    public interface IDataGenerator
    {
        IEnumerable<PersonModel> GeneratePeople();
        PersonModel GeneratePerson();
    }
}