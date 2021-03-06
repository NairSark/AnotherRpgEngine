﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static partial class Controller
    {
        private static void PopulateQuests()
        {
            Quest clearForest = new Quest(quest_bring_rat_tails, "Новая эпока веровковязания",
                "Привет, путник. Сделаешь мне одолжение? Я планирую изготовить новый прототип" +
                " веревок из крысиных хвостов. Можешь принести мне пару тройку штук? . Награда: 5 Малое зелье исцеления, 30 золота, 100 опыта.",
                100, 30);
            clearForest.RewardItems = new List<Item> { ItemParse(potion_lesser_hp_pot) };
            clearForest.RewardQuanity = new List<int> { 5 };
            clearForest.ItemsNeeded.Add(new QuestConditionsCollection(ItemParse(misc_rat_tail), 3));

            Quests.Add(clearForest);
        }
    }
}
