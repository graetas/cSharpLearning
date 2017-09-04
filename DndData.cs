// DnD Data
using System;

namespace DndData
{
	public class Character
	{
		public string Name { get; set; }

		public int Strength { get; set; }
		public int Dexterity { get; set; }
		public int Constitution { get; set; }
		public int Intelligence { get; set; }
		public int Wisdom { get; set; }
		public int Charisma { get; set; }

		public string Race { get; set; }
		public string Class { get; set; }

		
	}

	public class Data
	{
		public string[] StatTitles = {"Strength", "Dexterity", "Constitution", 
									"Intelligence", "Wisdom", "Charisma"};


		public string[] Classes = new string[] {"Barbarian", "Bard", "Cleric", "Druid", "Fighter", 
												"Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", 
												"Warlock", "Wizard"};

		public int[,] ClassData = new int[,] {	{1, 0, 1, 3}, 
												{6, 0, 1, 6}, 
												{5, 0, 5, 6}, 
												{5, 0, 4, 5}, 
												{1, 2, 1, 3},
												{2, 5, 1, 2},
												{1, 6, 5, 6}, 
												{2, 5, 1, 2}, 
												{2, 0, 2, 4}, 
												{6, 0, 3, 6},
												{6, 0, 5, 6},
												{4, 0, 4, 5}} 


	}
	/*
				Barbarian	Strength			Strength + Constitution
				Bard		Charisma			Dexterity + Charisma
				Cleric		Wisdom				Wisdom + Charisma
				Druid		Wisdom				Intelligence + Wisdom
				Fighter		Strength/Dexterity	Strength + Constitution
				Monk		Dexterity+Wisdom	Strength + Dexterity
				Paladin		Strength+Charisma	Wisdom + Charisma
				Ranger		Dexterity+Wisdom	Strength + Dexterity
				Rogue		Dexterity			Dexterity + Intelligence
				Sorcerer	Charisma			Constitution + Charisma
				Warlock		Charisma			Wisdom + Charisma
				Wizard		Intelligence		Intelligence + Wisdom
	*/
}
