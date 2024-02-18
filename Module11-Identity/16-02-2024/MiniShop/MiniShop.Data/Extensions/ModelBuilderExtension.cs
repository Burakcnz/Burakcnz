using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MiniShop.Entity.Concrete;
using MiniShop.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            #region Rol Bilgileri

            List<Role> roles = new List<Role>
            {
                new Role{ Name="SuperAdmin", Description="Tüm yönetici yetkilerine sahip kullanıcıların rolü", NormalizedName="SUPERADMIN"},
                new Role{ Name="Admin", Description="Sınırlı yönetici yetkilerine sahip kullanıcıların rolü", NormalizedName="ADMIN"},
                new Role{ Name="Customer", Description="Müşteri tipindeki kullanıcıların rolü", NormalizedName="CUSTOMER"}
            };
            modelBuilder.Entity<Role>().HasData(roles);

            #endregion

            #region Kullanıcı Bilgileri

            List<User> users = new List<User>
            {
                new User
                {
                    FirstName="Deniz",
                    LastName="Foça",
                    UserName="superadmin",
                    NormalizedUserName="SUPERADMIN",
                    Email="denizfoca@gmail.com",
                    NormalizedEmail="DENIZFOCA@GMAIL.COM",
                    Gender="Kadın",
                    DateOfBirth=new DateTime(1990, 6, 27),
                    Address="Rasimpaşa Mh. Hancı Sk. No:4 Kadıköy",
                    City="İstanbul",
                    PhoneNumber="555-444-55-44",
                    EmailConfirmed=true
                },
                new User
                {
                    FirstName="Selin",
                    LastName="Mete",
                    UserName="admin",
                    NormalizedUserName="ADMIN",
                    Email="selinmete@gmail.com",
                    NormalizedEmail="SELINMETE@GMAIL.COM",
                    Gender="Kadın",
                    DateOfBirth=new DateTime(1993, 3, 21),
                    Address="Rasimpaşa Mh. Hancı Sk. No:4 Kadıköy",
                    City="İstanbul",
                    PhoneNumber="555-444-55-44",
                    EmailConfirmed=true
                },
                new User
                {
                    FirstName="Kemal",
                    LastName="Durukan",
                    UserName="customer",
                    NormalizedUserName="CUSTOMER",
                    Email="kemaldurukan@gmail.com",
                    NormalizedEmail="KEMALDURUKAN@GMAIL.COM",
                    Gender="Erkek",
                    DateOfBirth=new DateTime(1988, 9, 12),
                    Address="Rasimpaşa Mh. Hancı Sk. No:4 Kadıköy",
                    City="İstanbul",
                    PhoneNumber="555-444-55-44",
                    EmailConfirmed=true
                }
            };
            modelBuilder.Entity<User>().HasData(users);

            #endregion

            #region Şifre Belirleme İşlemleri

            var passwordHasher = new PasswordHasher<User>();
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Qwe123.");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "Qwe123.");
            users[2].PasswordHash = passwordHasher.HashPassword(users[2], "Qwe123.");

            #endregion

            #region Kullanıcılara Rol Atama İşlemleri

            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    UserId=users[0].Id,
                    RoleId=roles[0].Id,
                    //RoleId = roles.Where(r=>r.Name=="SuperAdmin").FirstOrDefault().Id
                },
                new IdentityUserRole<string>
                {
                    UserId=users[1].Id,
                    RoleId=roles[1].Id,
                },
                new IdentityUserRole<string>
                {
                    UserId=users[1].Id,
                    RoleId=roles[2].Id,
                },
                new IdentityUserRole<string>
                {
                    UserId=users[2].Id,
                    RoleId=roles[2].Id,
                }
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);

            #endregion

            #region Alışveriş Sepeti İşlemleri

            List<Cart> carts = new List<Cart>
            {
                new Cart { Id=1, UserId=users[0].Id },
                new Cart { Id=2, UserId=users[1].Id },
                new Cart { Id=3, UserId=users[2].Id }
            };
            modelBuilder.Entity<Cart>().HasData(carts);

            #endregion
        }
    }
}
