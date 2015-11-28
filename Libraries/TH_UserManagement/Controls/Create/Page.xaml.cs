﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Collections.ObjectModel;

using TH_Configuration;
using TH_Global;
using TH_UserManagement;
using TH_WPF;

using TH_UserManagement.Management;


namespace TH_UserManagement.Create
{
    /// <summary>
    /// Interaction logic for Page.xaml
    /// </summary>
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
            DataContext = this;

            // Fill Country List
            foreach (string country in Countries.Names) CountryList.Add(country);

            // Fill State List
            foreach (string state in States.Abbreviations) StateList.Add(state);
            
        }

        Database_Settings userDatabaseSettings = null;

        public void LoadProfile(UserConfiguration userConfig)
        {

        }

        public void CleanForm()
        {

            FirstName = null;
            LastName = null;
            Username = null;
            Email = null;
            Phone = null;
            Address1 = null;
            Address2 = null;
            City = null;
            ZipCode = null;

            int US = CountryList.ToList().FindIndex(x => x == "United States");
            if (US >= 0) country_COMBO.SelectedIndex = US;

            state_COMBO.SelectedIndex = -1;

        }

        public string PageName { get { return "Create Account"; } }

        public ImageSource Image { get { return new BitmapImage(new Uri("pack://application:,,,/TH_UserManagement;component/Resources/AddUser_01.png")); } }


        #region "Properties"

        public string FirstName
        {
            get { return (string)GetValue(FirstNameProperty); }
            set { SetValue(FirstNameProperty, value); }
        }

        public static readonly DependencyProperty FirstNameProperty =
            DependencyProperty.Register("FirstName", typeof(string), typeof(Page), new PropertyMetadata(null));



        public string LastName
        {
            get { return (string)GetValue(LastNameProperty); }
            set { SetValue(LastNameProperty, value); }
        }

        public static readonly DependencyProperty LastNameProperty =
            DependencyProperty.Register("LastName", typeof(string), typeof(Page), new PropertyMetadata(null));




        public string Username
        {
            get { return (string)GetValue(UsernameProperty); }
            set { SetValue(UsernameProperty, value); }
        }

        public static readonly DependencyProperty UsernameProperty =
            DependencyProperty.Register("Username", typeof(string), typeof(Page), new PropertyMetadata(null));




        public string Company
        {
            get { return (string)GetValue(CompanyProperty); }
            set { SetValue(CompanyProperty, value); }
        }

        public static readonly DependencyProperty CompanyProperty =
            DependencyProperty.Register("Company", typeof(string), typeof(Page), new PropertyMetadata(null));




        public string Email
        {
            get { return (string)GetValue(EmailProperty); }
            set { SetValue(EmailProperty, value); }
        }

        public static readonly DependencyProperty EmailProperty =
            DependencyProperty.Register("Email", typeof(string), typeof(Page), new PropertyMetadata(null));


        public string Phone
        {
            get { return (string)GetValue(PhoneProperty); }
            set { SetValue(PhoneProperty, value); }
        }

        public static readonly DependencyProperty PhoneProperty =
            DependencyProperty.Register("Phone", typeof(string), typeof(Page), new PropertyMetadata(null));

        

        public string Address1
        {
            get { return (string)GetValue(Address1Property); }
            set { SetValue(Address1Property, value); }
        }

        public static readonly DependencyProperty Address1Property =
            DependencyProperty.Register("Address1", typeof(string), typeof(Page), new PropertyMetadata(null));


        public string Address2
        {
            get { return (string)GetValue(Address2Property); }
            set { SetValue(Address2Property, value); }
        }

        public static readonly DependencyProperty Address2Property =
            DependencyProperty.Register("Address2", typeof(string), typeof(Page), new PropertyMetadata(null));




        public string City
        {
            get { return (string)GetValue(CityProperty); }
            set { SetValue(CityProperty, value); }
        }

        public static readonly DependencyProperty CityProperty =
            DependencyProperty.Register("City", typeof(string), typeof(Page), new PropertyMetadata(null));



        public string ZipCode
        {
            get { return (string)GetValue(ZipCodeProperty); }
            set { SetValue(ZipCodeProperty, value); }
        }

        public static readonly DependencyProperty ZipCodeProperty =
            DependencyProperty.Register("ZipCode", typeof(string), typeof(Page), new PropertyMetadata(null));

        

        #endregion

        private void TXT_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        public bool PasswordEntered
        {
            get { return (bool)GetValue(PasswordEnteredProperty); }
            set { SetValue(PasswordEnteredProperty, value); }
        }

        public static readonly DependencyProperty PasswordEnteredProperty =
            DependencyProperty.Register("PasswordEntered", typeof(bool), typeof(Page), new PropertyMetadata(false));


        public bool ConfirmPasswordEntered
        {
            get { return (bool)GetValue(ConfirmPasswordEnteredProperty); }
            set { SetValue(ConfirmPasswordEnteredProperty, value); }
        }

        public static readonly DependencyProperty ConfirmPasswordEnteredProperty =
            DependencyProperty.Register("ConfirmPasswordEntered", typeof(bool), typeof(Page), new PropertyMetadata(false));

        

        private void password_TXT_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (password_TXT.PasswordText != "") PasswordEntered = true;
            else PasswordEntered = false;

            PasswordShort = false;
            PasswordLong = false;

            VerifyPassword();
            ConfirmPassword();
        }

        private void confirmpassword_TXT_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (confirmpassword_TXT.PasswordText != "") ConfirmPasswordEntered = true;
            else ConfirmPasswordEntered = false;

            ConfirmPassword();
        }


        ObservableCollection<string> countrylist;
        public ObservableCollection<string> CountryList
        {
            get
            {
                if (countrylist == null)
                    countrylist = new ObservableCollection<string>();
                return countrylist;
            }

            set
            {
                countrylist = value;
            }
        }

        ObservableCollection<string> statelist;
        public ObservableCollection<string> StateList
        {
            get
            {
                if (statelist == null)
                    statelist = new ObservableCollection<string>();
                return statelist;
            }

            set
            {
                statelist = value;
            }
        }

        public bool ShowStates
        {
            get { return (bool)GetValue(ShowStatesProperty); }
            set { SetValue(ShowStatesProperty, value); }
        }

        public static readonly DependencyProperty ShowStatesProperty =
            DependencyProperty.Register("ShowStates", typeof(bool), typeof(Page), new PropertyMetadata(false));


        private void country_COMBO_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender.GetType() == typeof(ComboBox))
            {
                ComboBox cb = (ComboBox)sender;

                if (cb.SelectedItem.ToString() == "United States") ShowStates = true;
                else ShowStates = false;

            }
        }

        private void state_COMBO_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CreateAccount_Clicked(Button_01 bt)
        {
            CreateAccount();
        }

        void CreateAccount()
        {
            // Create new UserConfiguration object with new data
            UserConfiguration userConfig = new UserConfiguration();

            userConfig.first_name = FirstName;
            userConfig.last_name = LastName;

            userConfig.username = Username;

            userConfig.company = Company;

            userConfig.email = Email;
            userConfig.phone = Phone;

            userConfig.address1 = Address1;
            userConfig.address2 = Address2;
            userConfig.city = City;

            if (country_COMBO.SelectedItem != null) userConfig.country = country_COMBO.SelectedItem.ToString();
            if (state_COMBO.SelectedItem != null) userConfig.state = state_COMBO.SelectedItem.ToString();

            userConfig.zipcode = ZipCode;


            Users.CreateUser(userConfig, password_TXT.PasswordText, userDatabaseSettings);

            ConfirmUserCreation();    
        }

        System.Timers.Timer create_TIMER;

        void ConfirmUserCreation()
        {
            if (create_TIMER != null) create_TIMER.Enabled = false;

            create_TIMER = new System.Timers.Timer();
            create_TIMER.Interval = 2000;
            create_TIMER.Elapsed += create_TIMER_Elapsed;
            create_TIMER.Enabled = true;
        }

        void create_TIMER_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            create_TIMER.Enabled = false;

            this.Dispatcher.BeginInvoke(new Action(ConfirmUserCreation_GUI));
        }

        void ConfirmUserCreation_GUI()
        {

            //mw.LoginMenu.username_TXT.Text = username_TXT.Text;
            //mw.LoginMenu.password_TXT.Password = password_TXT.Password;

            //mw.LoginMenu.Login(username_TXT.Text, password_TXT.Password);

            //CleanForm();
            //mw.ClosePage("Create Account");
            //mw.LoginMenu.Shown = true;

            //if (mw.LoginMenu.Login())
            //{
            //    CleanForm();
            //    mw.ClosePage("Create Account");
            //    mw.LoginMenu.Shown = true;
            //}
            //else
            //{

            //}
        }


        #region "Username"

        public bool UsernameVerified
        {
            get { return (bool)GetValue(UsernameVerifiedProperty); }
            set { SetValue(UsernameVerifiedProperty, value); }
        }

        public static readonly DependencyProperty UsernameVerifiedProperty =
            DependencyProperty.Register("UsernameVerified", typeof(bool), typeof(Page), new PropertyMetadata(false));

        public string UsernameMessage
        {
            get { return (string)GetValue(UsernameMessageProperty); }
            set { SetValue(UsernameMessageProperty, value); }
        }

        public static readonly DependencyProperty UsernameMessageProperty =
            DependencyProperty.Register("UsernameMessage", typeof(string), typeof(Page), new PropertyMetadata(null));
    

        System.Timers.Timer username_TIMER;

        private void username_TXT_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (username_TIMER != null) username_TIMER.Enabled = false;

            username_TIMER = new System.Timers.Timer();
            username_TIMER.Interval = 500;
            username_TIMER.Elapsed += username_TIMER_Elapsed;
            username_TIMER.Enabled = true;
        }

        void username_TIMER_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            username_TIMER.Enabled = false;

            this.Dispatcher.BeginInvoke(new Action(VerifyUsername));
        }

        void VerifyUsername()
        {
            // If no userconfiguration database configuration found then use default TrakHound User Database
            if (userDatabaseSettings == null)
            {
                VerifyUsernameReturn usernameReturn = Remote.Users.VerifyUsername(Username);
                if (usernameReturn != null)
                {
                    UsernameVerified = usernameReturn.available;
                    UsernameMessage = usernameReturn.message;
                }
                else
                {
                    UsernameVerified = false;
                    UsernameMessage = null;
                }
            }
        }

        #endregion

        #region "Password"

        public bool PasswordVerified
        {
            get { return (bool)GetValue(PasswordVerifiedProperty); }
            set { SetValue(PasswordVerifiedProperty, value); }
        }

        public static readonly DependencyProperty PasswordVerifiedProperty =
            DependencyProperty.Register("PasswordVerified", typeof(bool), typeof(Page), new PropertyMetadata(false));


        public bool PasswordShort
        {
            get { return (bool)GetValue(PasswordShortProperty); }
            set { SetValue(PasswordShortProperty, value); }
        }

        public static readonly DependencyProperty PasswordShortProperty =
            DependencyProperty.Register("PasswordShort", typeof(bool), typeof(Page), new PropertyMetadata(false));


        public bool PasswordLong
        {
            get { return (bool)GetValue(PasswordLongProperty); }
            set { SetValue(PasswordLongProperty, value); }
        }

        public static readonly DependencyProperty PasswordLongProperty =
            DependencyProperty.Register("PasswordLong", typeof(bool), typeof(Page), new PropertyMetadata(false));

        System.Timers.Timer password_TIMER;

        void VerifyPassword()
        {
            if (password_TIMER != null) password_TIMER.Enabled = false;

            password_TIMER = new System.Timers.Timer();
            password_TIMER.Interval = 500;
            password_TIMER.Elapsed += password_TIMER_Elapsed;
            password_TIMER.Enabled = true;
        }

        void password_TIMER_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            password_TIMER.Enabled = false;

            this.Dispatcher.BeginInvoke(new Action(VerifyPassword_GUI));
        }

        void VerifyPassword_GUI()
        {
            System.Security.SecureString pwd = password_TXT.SecurePassword;

            if (!Security_Functions.VerifyPasswordMinimum(pwd)) PasswordShort = true;
            else if (!Security_Functions.VerifyPasswordMaximum(pwd)) PasswordLong = true;
        }

        System.Timers.Timer confirmpassword_TIMER;

        void ConfirmPassword()
        {
            if (confirmpassword_TIMER != null) confirmpassword_TIMER.Enabled = false;

            confirmpassword_TIMER = new System.Timers.Timer();
            confirmpassword_TIMER.Interval = 500;
            confirmpassword_TIMER.Elapsed += confirmpassword_TIMER_Elapsed;
            confirmpassword_TIMER.Enabled = true;
        }

        void confirmpassword_TIMER_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            confirmpassword_TIMER.Enabled = false;

            this.Dispatcher.BeginInvoke(new Action(ConfirmPassword_GUI));
        }

        void ConfirmPassword_GUI()
        {
            if (PasswordEntered && ConfirmPasswordEntered)
            {
                if (password_TXT.PasswordText == confirmpassword_TXT.PasswordText) PasswordVerified = true;
                else PasswordVerified = false;
            }
        }

        #endregion

    }
}
