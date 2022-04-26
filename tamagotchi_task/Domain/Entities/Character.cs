﻿using System.ComponentModel.DataAnnotations;
using tamagotchi_task.Domain.Entities;

namespace tamagotchi_task.Domain
{
    public class Character: DomainEntity
    {
        [Required(ErrorMessage = "У персонажа должно быть имя!")]
        [Display(Name = "Имя персонажа")]
        public override string Name { get; set; } //Перегружаем, так как есть ErrorMessage и Name

        public int Level { get; set; } = 0;

        public string Rank { get; set; } = "Noob"; //Возможно, сделаем как-то иначе
        public int HP { get; set; } = 6; //Пусть у животного будет пока 3 сердечка, а отнимается половина
        public int XP { get; set; } = 0;
        public int Strength { get; set; } = 0;
        public int Intellect { get; set; } = 0;
        public List<CharacterTask> CharacterTasks { get; set; } = new List<CharacterTask>(); //Нужна для создания связи "Один ко многим"

        //Ссылка на пользователя
        public User User { get; set; }
    }
}