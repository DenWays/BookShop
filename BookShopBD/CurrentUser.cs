namespace BookShopBD
{
    internal class CurrentUser
    {
        static string lastName;
        static string firstName;
        static string middleName;
        static string role;
        static string login;
        static int id_account;

        public static string LastName { get; set; }
        public static string FirstName { get; set; }
        public static string MiddleName { get; set; }
        public static string Role { get; set; }
        public static string Login { get; set; }
        public static int Id_account { get; set; }
    }
}
