using _02_Builder.Exercice;
using Xunit;

namespace _01_Builder
{
    public class Enonce
    {
        [Fact]
        public void _01_Creer_une_classe_User()
        {
            var firstname = "Mickael";
            var lastname = "Metesreau";
            var email = "mickael.metesreau@softcraft.fr";
            var birthYear = 1988;
            var birthMonth = 1;
            var birthDay = 17;

            var user = new _02_Builder.Exercice.User(firstname, lastname, email, birthYear, birthMonth, birthDay);

            Assert.Equal(firstname, user.Firstname);
            Assert.Equal(lastname, user.Lastname);
            Assert.Equal(email, user.Email);
            Assert.Equal(birthYear, user.BirthYear);
            Assert.Equal(birthMonth, user.BirthMonth);
            Assert.Equal(birthDay, user.BirthDay);
        }

         [Fact]
         public void _02_Creer_une_classe_UserBuilder()
         {
             var userBuilder = new _02_Builder.Exercice.UserBuilder();

             Assert.True(true);
         }

         [Fact]
         public void _03_Creer_une_methode_pour_stocker_le_prenom_d_un_user()
         {
             var userBuilder = new _02_Builder.Exercice.UserBuilder();
             userBuilder
                 .WithFirstname("Mickael");

             Assert.True(true);
         }

        [Fact]
        public void _04_Creer_une_methode_build_qui_renvoit_un_user_initialise_avec_le_prenom_d_un_user()
        {
            var firstname = "Mickael";

            var userBuilder = new _02_Builder.Exercice.UserBuilder();

            var user =
                    userBuilder
                        .WithFirstname(firstname)
                        .Build();

            Assert.Equal(firstname, user.Firstname);
        }

        /*[Fact]
        public void _05_Repeter_pour_les_proprietes_manquantes()
        {
            var firstname = "Mickael";
            var lastname = "Metesreau";
            var email = "mickael.metesreau@softcraft.fr";
            var birthYear = 1988;
            var birthMonth = 1;
            var birthDay = 17;

            var userBuilder = new _02_Builder.Exercice.UserBuilder();

            var user =
                    userBuilder
                        .WithFirstname(firstname)
                        .WithLastname(lastname)
                        .WithEmail(email)
                        .WithBirthYear(birthYear)
                        .WithBirthMonth(birthMonth)
                        .WithBirthDay(birthDay)
                        .Build();

            Assert.Equal(firstname, user.Firstname);
            Assert.Equal(lastname, user.Lastname);
            Assert.Equal(email, user.Email);
            Assert.Equal(birthYear, user.BirthYear);
            Assert.Equal(birthMonth, user.BirthMonth);
            Assert.Equal(birthDay, user.BirthDay);
        }*/
    }
}
