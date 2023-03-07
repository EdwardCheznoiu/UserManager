namespace UserInterface
{
    internal static class Forms
    {
        private static readonly MainForm mainForm = new MainForm();
        private static readonly LoginForm loginForm = new LoginForm();
        private static readonly RegisterForm registerForm = new RegisterForm();
        private static readonly SideMenuForm sideMenuForm = new SideMenuForm();
        private static readonly DashboardForm dashboardForm = new DashboardForm(); 
        private static readonly UserForm userForm = new UserForm();

        public static MainForm MainForm => mainForm;

        public static LoginForm LoginForm => loginForm;

        public static RegisterForm RegisterForm => registerForm;

        public static SideMenuForm SideMenuForm => sideMenuForm;

        public static DashboardForm DashboardForm => dashboardForm;

        public static UserForm UserForm => userForm;
    }
}
