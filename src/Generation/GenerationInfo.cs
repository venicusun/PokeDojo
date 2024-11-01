﻿using PokeDojo.src.Descriptor;
using PokeDojo.src.Stats;
using PokeDojo.src.Type;

namespace PokeDojo.src.Generation
{
    public class GenerationInfo
    {
        int generation;
        Description description;
        Gender gender;
        PokemonType hiddenPower;
        int happiness;

        public GenerationInfo()
        {
            generation = 1;
            description = new Description();
            gender = new Gender();
            hiddenPower = new PokemonType("");
            happiness = 0;
        }
        public Gender GetGender()
        {
            return gender;
        }

        public Description GetDescription()
        {
            return description;
        }

        public void SetHappiness(int happiness)
        {
            if (happiness >= 0 && happiness <= 255)
            {
                this.happiness = happiness;
            }
        }

        public void SetHiddenPower(PokemonType type)
        {
            if(hiddenPower is PokemonType)
            {
                hiddenPower = type;
            }
        }

        public void SetGeneration(int generation)
        {
            if (generation >= 1 && generation <= 2)
            {
                this.generation = generation;
            }
        }
        public int GetHappiness()
        {
            return happiness;
        }

        public PokemonType GetHiddenPower()
        {
            return hiddenPower;
        }

        public int GetGeneration()
        {
            return generation;
        }
    }
}
