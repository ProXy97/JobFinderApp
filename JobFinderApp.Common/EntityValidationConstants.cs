namespace JobFinderApp.Common
{
    public static class EntityValidationConstants
    {
        public static class User
        {
            public const int FirstNameMinLength = 2;
            public const int FirstNameMaxLength = 25;

            public const int LastNameMinLength = 2;
            public const int LastNameMaxLength = 25;

            public const int AddressMinLength = 5;
            public const int AddressMaxLength = 50;

            public const int PhoneMaxLength = 15;
        }

        public static class Job
        {
            public const int TitleMinLength = 5;
            public const int TitleMaxLength = 50;

            public const int DescriptionMinLength = 25;
            public const int DescriptionMaxLength = 5000;

            public const int CompanyMinLength = 2;
            public const int CompanyMaxLength = 30;

            public const int LocationMinLength = 5;
            public const int LocationMaxLength = 50;

        }

        public static class Category
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 30;
        }

        public static class Resumee
        {
            public const int FileMaxLength = 260;
        }
        public static class Skill
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;
        }
    }
}