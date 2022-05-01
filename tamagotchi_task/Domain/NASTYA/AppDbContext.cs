﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using tamagotchi_task.Domain.Entities;

namespace tamagotchi_task.Domain
{
    //Всё перечисленное ниже может не сработать, если не установить специальные расширения
    //Этот класс - дар Microsoft и заодно главный элемент в EF Core
    public partial class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<CharacterTask> CharacterTasks { get; set; }
        //Всё остальное есть уже в папке SEMEN, осталось только доделать этот класс
        public DbSet<Accessories> Accessories { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Avatar> Avatars { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Chats_Users> Chats_Users { get; set; }
        public DbSet<Fur> Furs { get; set; }
        public DbSet<LoginUser> LoginUsers { get; set; }
        public DbSet<Massage> Massages { get; set; }
        public DbSet<Wallpaper> Wallpapers { get; set; }

    }
}
