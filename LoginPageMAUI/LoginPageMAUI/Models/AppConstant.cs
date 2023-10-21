using LoginPageMAUI.Controls;
using LoginPageMAUI.Models.SD;
using LoginPageMAUI.Views.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPageMAUI.Models
{
    public class AppConstant
    {
        public static async Task AddFlyoutMenusDetails()
        {
            AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();


            var studentProfileInfo = AppShell.Current.Items.Where(data => data.Route == nameof(StudentDashboardPage)).FirstOrDefault();
            if (studentProfileInfo != null) AppShell.Current.Items.Remove(studentProfileInfo);

            var teacherProfileInfo = AppShell.Current.Items.Where(data => data.Route == nameof(TeacherDashboardPage)).FirstOrDefault();
            if (teacherProfileInfo != null) AppShell.Current.Items.Remove(teacherProfileInfo);

            var adminProfileInfo = AppShell.Current.Items.Where(data => data.Route == nameof(AdminDashboardPage)).FirstOrDefault();
            if (adminProfileInfo != null) AppShell.Current.Items.Remove(adminProfileInfo);

            //AppShell.Current.Items.Clear();
            if (App.UserDetails.RoleID == (int)RoleDetails.Student)
            {
                var flyoutItem = new FlyoutItem()
                {
                    Title = "Dashboard",
                    Route = nameof(StudentDashboardPage),
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                    Items =
                        {
                            new ShellContent
                            {
                                Icon=Icons.Dashboard,
                                Title   ="Student Dashboard",
                                ContentTemplate =new DataTemplate(typeof(StudentDashboardPage)),
                            },
                            new ShellContent
                            {
                                 Icon=Icons.AboutUs,
                                Title   ="Student Profile",
                                ContentTemplate =new DataTemplate(typeof(StudentDashboardPage)),
                            },
                        }
                };
                if (!AppShell.Current.Items.Contains(flyoutItem))
                {
                    AppShell.Current.Items.Add(flyoutItem);
                    await Shell.Current.GoToAsync($"//{nameof(StudentDashboardPage)}");

                }

            }
            if (App.UserDetails.RoleID == (int)RoleDetails.Teacher)
            {
                var flyoutItem = new FlyoutItem()
                {

                    Title = "Dashboard",
                    Route = nameof(TeacherDashboardPage),
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                    Items =
                        {
                            new ShellContent
                            {
                                Icon=Icons.Dashboard,
                                Title   ="Teacher Dashboard",
                                ContentTemplate =new DataTemplate(typeof(TeacherDashboardPage)),
                            },
                            new ShellContent
                            {
                                Icon=Icons.AboutUs,
                                Title   ="Teacher Profile",
                                ContentTemplate =new DataTemplate(typeof(TeacherDashboardPage)),
                            },
                        }
                };
                if (!AppShell.Current.Items.Contains(flyoutItem))
                {
                    AppShell.Current.Items.Add(flyoutItem);
                    await Shell.Current.GoToAsync($"//{nameof(TeacherDashboardPage)}");

                }

            }
            if (App.UserDetails.RoleID == (int)RoleDetails.Admin)
            {
                var flyoutItem = new FlyoutItem()
                {
                    Title = "Dashboard",
                    Route = nameof(AdminDashboardPage),
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                    Items =
                        {
                            new ShellContent
                            {
                                 Icon=Icons.Dashboard,
                                Title   ="Admin Dashboard",
                                ContentTemplate =new DataTemplate(typeof(AdminDashboardPage)),
                            },
                            new ShellContent
                            {
                                 Icon=Icons.AboutUs,
                                Title   ="Admin Profile",
                                ContentTemplate =new DataTemplate(typeof(AdminDashboardPage)),
                            },
                        }
                };
                if (!AppShell.Current.Items.Contains(flyoutItem))
                {
                    AppShell.Current.Items.Add(flyoutItem);
                    await Shell.Current.GoToAsync($"//{nameof(AdminDashboardPage)}");

                }

            }
        }
    }
}
