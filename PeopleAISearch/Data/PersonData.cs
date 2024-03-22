namespace PeopleAISearch.Data
{
    public class PersonData
    {
        public List<Person> People = new List<Person>()
        {
            new Person()
            {
                FirstName="Lennie",
                LastName="Busschots",
                DateOfBirth= new DateOnly(1997, 09, 11),
                EmployedSince= new DateOnly(2023, 02, 03),
                Project="intern"
            },
            new Person()
            {
                FirstName="Wouter",
                LastName="Glorian",
                DateOfBirth= new DateOnly(1999, 04, 11),
                EmployedSince= new DateOnly(2023, 02, 03),
                Project="AGC"
            },
            new Person()
            {
                FirstName="Anke",
                LastName="Dubois",
                DateOfBirth= new DateOnly(1993, 11, 14),
                EmployedSince= new DateOnly(2022, 09, 01),
                Project="TalentpoolAPI"
            },
            new Person()
            {
                FirstName="Thomas",
                LastName="Claessens",
                DateOfBirth= new DateOnly(1999, 09, 19),
                EmployedSince= new DateOnly(2020, 09, 15),
                Project="Co-Valent"
            },
            new Person()
            {
                FirstName="Matthias",
                LastName="De Busser",
                DateOfBirth= new DateOnly(1998, 10, 01),
                EmployedSince= new DateOnly(2023, 09, 10),
                Project="Judo Vlaanderen"
            },
        };
    }
}
