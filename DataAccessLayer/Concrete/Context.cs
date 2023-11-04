using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GymDB;Trusted_Connection=True");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<MemberCategory>()
                .HasKey(x => new {x.MemberId, x.CategoryId});

            modelBuilder.Entity<MemberTrainer>()
                .HasKey(x => new { x.MemberId, x.TrainerId });

            modelBuilder.Entity<Category>()
                .HasData(
                    new Category() { CategoryId = 1, CategoryName = "Fitness", CategoryInfo = "üiğiüğğşğşsğaüğ", CategoryPrice=1200},
                    new Category() { CategoryId = 2, CategoryName = "Kickbox", CategoryInfo = "üiğiüğğşğşsğaüğ", CategoryPrice = 1700 },
                    new Category() { CategoryId = 3, CategoryName = "Zumba", CategoryInfo = "üiğiüğğşğşsğaüğ", CategoryPrice = 1500 },
                    new Category() { CategoryId = 4, CategoryName = "Pilates", CategoryInfo = "üiğiüğğşğşsğaüğ", CategoryPrice = 700 },
                    new Category() { CategoryId = 5, CategoryName = "Coaching", CategoryInfo = "üiğiüğğşğşsğaüğ", CategoryPrice = 15.700 }
                );

            modelBuilder.Entity<Description>()
                .HasData(
                    new Description() { DescriptionId=1, CategoryId= 1, DescriptionName="Fitnes-1sweıpüqrıpoıqwmskdf"},
                    new Description() { DescriptionId =2, CategoryId = 1, DescriptionName = "Fitnes-2weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId =3, CategoryId = 1, DescriptionName = "Fitnes-3weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 4, CategoryId = 2, DescriptionName = "Kickbox-1sweıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 5, CategoryId = 2, DescriptionName = "Kickbox-2sweıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 6, CategoryId = 2, DescriptionName = "Kickbox-3weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 7, CategoryId = 3, DescriptionName = "Zumba-1weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 8, CategoryId = 3, DescriptionName = "Zumba-2weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 9, CategoryId = 3, DescriptionName = "Zumba-3weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 10, CategoryId = 4, DescriptionName = "Pilates-1weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 11, CategoryId = 4, DescriptionName = "Pilates-2weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 12, CategoryId = 4, DescriptionName = "Pilates-3weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 13, CategoryId = 5, DescriptionName = "Coaching-1weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 14, CategoryId = 5, DescriptionName = "Coaching-2weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 15, CategoryId = 5, DescriptionName = "Coaching-3weıpüqrıpoıqwmskdf" }

                );

            modelBuilder.Entity<Image>()
                .HasData(
                    new Image() { ImageId = 1, CategoryId = 1, ImageName = "fitness1.jpg"},
                    new Image() { ImageId = 2, CategoryId = 1, ImageName = "fitness2.jpg" },
                    new Image() { ImageId = 3, CategoryId = 1, ImageName = "fitness3.jpg" },
                    new Image() { ImageId = 4, CategoryId = 2, ImageName = "kickbox1.jpg" },
                    new Image() { ImageId = 5, CategoryId = 2, ImageName = "kickbox2.jpg" },
                    new Image() { ImageId = 6, CategoryId = 2, ImageName = "kickbox3.jpg" },
                    new Image() { ImageId = 7, CategoryId = 3, ImageName = "zumba1.jpg" },
                    new Image() { ImageId = 8, CategoryId = 3, ImageName = "zumba2.jpg" },
                    new Image() { ImageId = 9, CategoryId = 3, ImageName = "zumba3.jpg" },
                    new Image() { ImageId = 10, CategoryId = 4, ImageName = "pilates1.jpg" },
                    new Image() { ImageId = 11, CategoryId = 4, ImageName = "pilates2.jpg" },
                    new Image() { ImageId = 12, CategoryId = 4, ImageName = "pilates3.jpg" },
                    new Image() { ImageId = 13, CategoryId = 5, ImageName = "coaching1.jpg" },
                    new Image() { ImageId = 14, CategoryId = 5, ImageName = "coaching2.jpg" },
                    new Image() { ImageId = 15, CategoryId = 5, ImageName = "coaching3.jpg" }
                );
            modelBuilder.Entity<Trainer>()
                .HasData(
                    new Trainer() { TrainerId=1, CategoryId=1, NameSurname="Yusuf Dilekci", TrainerDescription="Fitness - Trainer - 1", TrainerImage="trainer1.jpg"},
                    new Trainer() { TrainerId = 2, CategoryId = 1, NameSurname = "Savas Cebeci", TrainerDescription = "Fitness - Trainer - 2", TrainerImage = "trainer2.jpg" },
                    new Trainer() { TrainerId = 3, CategoryId = 2, NameSurname = "Birol E.", TrainerDescription = "Kickbox - Trainer - 1", TrainerImage = "trainer3.jpg" },
                    new Trainer() { TrainerId = 4, CategoryId = 3, NameSurname = "Mert A.", TrainerDescription = "Zumba - Trainer - 1", TrainerImage = "trainer4.jpg" },
                    new Trainer() { TrainerId = 5, CategoryId = 3, NameSurname = "Azat T.", TrainerDescription = "Zumba - Trainer - 2", TrainerImage = "trainer5.jpg" },
                    new Trainer() { TrainerId = 6, CategoryId = 4, NameSurname = "Oguz R.", TrainerDescription = "Pilates - Trainer - 1", TrainerImage = "trainer6.jpg" },
                    new Trainer() { TrainerId = 7, CategoryId = 5, NameSurname = "Sadik S.", TrainerDescription = "Coaching - 1", TrainerImage = "trainer7.jpg" }

                );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<MemberCategory> MemberCategories { get; set; }
        public DbSet<MemberTrainer> MemberTrainers { get; set; }
    }
}
