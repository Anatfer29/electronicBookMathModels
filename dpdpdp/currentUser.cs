namespace dpdpdp
{
    public static class currentUser
    {
        static int id = 0;
        static int role;

        public static int GetId()
        {
            return id;
        }

        public static int GetRole()
        {
            return role;
        }

        public static void SetId(int idUser)
        {
            id = idUser;
        }

        public static void SetRole(int rolers)
        {
            role = rolers;
        }
    }
}
