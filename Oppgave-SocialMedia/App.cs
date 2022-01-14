using System;
using System.Collections.Generic;

namespace Oppgave_SocialMedia
{
    public class App
    {
        public string Name;
        public string CurrentUser;
        public List<Person> Users = new List<Person>();

        public App(string name)
        {
            Name = name;
        }
    }
}