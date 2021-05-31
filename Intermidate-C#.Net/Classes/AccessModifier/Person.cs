using System;

namespace AccessModifier
{
    public class Person
    {
        private DateTime _birthDate;

        public DateTime GetBirthDate()
        {
            return this._birthDate;
        }

        public void SetBirthDate(DateTime birthDate)
        {
            this._birthDate = birthDate;
        }
    }
}