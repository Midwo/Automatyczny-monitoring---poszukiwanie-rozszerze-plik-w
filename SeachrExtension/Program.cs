using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeachrExtension
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public class ExtensionContext : DbContext
        {

            public ExtensionContext() : base("BaseWithExtensions")
            {
                Database.SetInitializer<ExtensionContext>(new ExtensionSeed());

                //Database.SetInitializer<BloggingContext>(new CreateDatabaseIfNotExists<BloggingContext>());
                //Database.SetInitializer<BloggingContext>(new DropCreateDatabaseIfModelChanges<BloggingContext>());
                //Database.SetInitializer<BloggingContext>(new DropCreateDatabaseAlways<BloggingContext>());
                // Database.SetInitializer<BloggingContext>(new BloggingContextInitializer());
            }
          
            public DbSet<ListExtension.List> ExtensionDB { get; set; }

        }
        public class ExtensionSeed : DropCreateDatabaseIfModelChanges<ExtensionContext>
        {

            protected override void Seed(ExtensionContext context)
            {

                //IList<TableUser.UsersInformations> defaultStandards = new List<TableUser.UsersInformations>();

                //defaultStandards.Add(new TableUser.UsersInformations() { email = "Standard 1", name = "First Standard" });
                //defaultStandards.Add(new TableUser.UsersInformations() { email = "Standard 2", name = "Second Standard" });
                //defaultStandards.Add(new TableUser.UsersInformations() { email = "Standard 3", name = "Third Standard" });

                //  foreach (TableUser.UsersInformations std in defaultStandards)
                //context.Blogs.Add(std);

                base.Seed(context);
            }
        }
        public class EmailContext : DbContext
        {

            public EmailContext() : base("BaseWithExtensions")
            {
                Database.SetInitializer<EmailContext>(new EmailSeed());

                //Database.SetInitializer<BloggingContext>(new CreateDatabaseIfNotExists<BloggingContext>());
                //Database.SetInitializer<BloggingContext>(new DropCreateDatabaseIfModelChanges<BloggingContext>());
                //Database.SetInitializer<BloggingContext>(new DropCreateDatabaseAlways<BloggingContext>());
                // Database.SetInitializer<BloggingContext>(new BloggingContextInitializer());
            }
            public DbSet<ListEmails.EmailsList> ListEmailsDB { get; set; }
    

        }

        public class EmailSeed : DropCreateDatabaseIfModelChanges<EmailContext>
        {

            protected override void Seed(EmailContext context)
            {

                //IList<TableUser.UsersInformations> defaultStandards = new List<TableUser.UsersInformations>();

                //defaultStandards.Add(new TableUser.UsersInformations() { email = "Standard 1", name = "First Standard" });
                //defaultStandards.Add(new TableUser.UsersInformations() { email = "Standard 2", name = "Second Standard" });
                //defaultStandards.Add(new TableUser.UsersInformations() { email = "Standard 3", name = "Third Standard" });

                //  foreach (TableUser.UsersInformations std in defaultStandards)
                //context.Blogs.Add(std);

                base.Seed(context);
            }
        }

    }
}
