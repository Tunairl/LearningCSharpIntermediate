namespace Properties
{
    public class Person
    {
        //use the code snippet "prop" to create a auto-implemented property
        //auto-implemented properties are should be at the top 
        //calculated properties should be at the bottom
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public float Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365f;

                return years;
            }
        }
    }
}
