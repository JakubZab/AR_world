using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterClass { Wolf, Griff, Snake, Cat, Bear }

public class Character : MonoBehaviour
{

    public CharacterClass characterClass;
    public int health = 10;  // Bazowe zdrowie
    public int attack;
    public int defense;
    public int alchemy;
    public int specialSkill;
    // Start is called before the first frame update
    void Start()
    {
        switch (characterClass)
        {
            case CharacterClass.Wolf:
                attack = 1;
                defense = 1;
                alchemy = 1;
                specialSkill = 1;
                break;
            case CharacterClass.Griff:
                attack = 1;
                defense = 1;
                alchemy = 1;
                specialSkill = 1; ;
                break;
            case CharacterClass.Snake:
                attack = 1;
                defense = 1;
                alchemy = 1;
                specialSkill = 1;
                break;
            case CharacterClass.Cat:
                attack = 1;
                defense = 1;
                alchemy = 1;
                specialSkill = 1;
                break;
            case CharacterClass.Bear:
                attack = 1;
                defense = 1;
                alchemy = 1;
                specialSkill = 1;
                break;
        }
    }
        public void IncreaseAttack(int amount)
        {
            attack += amount;
        }

        public void IncreaseDefense(int amount)
        {
            defense += amount;
        }

        public void IncreaseAlchemy(int amount)
        {
            alchemy += amount;
        }

        public void IncreaseSpecialSkill(int amount)
        {
            specialSkill += amount;
        }
    

}
