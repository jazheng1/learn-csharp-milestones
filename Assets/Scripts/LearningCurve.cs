using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    //simple variables
    public int currentAge = 20;
    public int addedAge = 1;

    public float money = 23.01f;
    public string firstName = "Jason";
    public bool hasKey = true;
    public bool weaponEquipped = true;
    public string weaponType = "sword";

    public bool pureOfHeart = true;
    public bool hasSecretIncantation  = false;
    public string rareItem = "seed";

    private Transform camTransform;
    public GameObject directionLight;
    private Transform lightTransform;

    /* Start is called before the first frame update
        When the play button is pressed it will print the following the console log
    */
    void Start()
    {
        // chapter 6 below
        camTransform = this.GetComponent<Transform>();
        
        Debug.Log(camTransform.localPosition);
        //directionLight = GameObject.Find("Directional Light");
        lightTransform = directionLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);

        // chapter 5 below
        Character hero = new Character();
        hero.PrintStatsInfo();
        Character heroine = new Character("Agatha");
        heroine.PrintStatsInfo();

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        huntingBow.PrintWeaponStats();
        Weapon warBow = new Weapon("War Bow", 155);
        warBow.PrintWeaponStats();


        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();


        // chapters up to 4 below
        if (!hasKey)
        {
            Debug.Log("You ahve the key - enter.");
        } else
        {
            Debug.Log("Go look for the key man...");
        }

        if(money > 10)
        {
            Debug.Log("Nice! Go buy yourself lunch!");
        } else if (money > 50)
        {
            Debug.Log("Careful Now....");
        } else
        {
            Debug.Log("Meh");
        }

        if(weaponEquipped)
        {
            if(weaponType == "sword")
            {
                Debug.Log("He is a knight!");
            }
        } else
        {
            Debug.Log("You have no weapon");
        }

        OpenTreasureChamber();

        string characterAction = "Attack";

        switch (characterAction)
        {
            case "Heal":
                Debug.Log("Potion sent.");
                break;
            case "Attack":
                Debug.Log("FIGHTTT");
                break;
            default:
                Debug.Log("Shields Up");
                break;
        }

        List<string> questPartyMembers = new List<string>() { "Grim the Barbarian", "Merlin the Wise", "Sterlin the Knight" };
        questPartyMembers.Add("Craven the Necromancer");
        questPartyMembers.Insert(1, "Tanis the Thief");
        Debug.LogFormat("Party Members: {0}", questPartyMembers.Count);

        Dictionary<string, int> itemInventory = new Dictionary<string, int>()
        {
            {"Potion", 5},
            {"Antidote", 7},
        };
        Debug.LogFormat("Items: {0}", itemInventory.Count);
        for (int i = 0; i < questPartyMembers.Count; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, questPartyMembers[i]);
        }

        int playerLives = 3;
        while (playerLives > 0)
        {
            Debug.Log("Still alive!");
            playerLives--;
        }
        Debug.Log("Player KO'd...");

        int characterLevel = 32;

        int nextSkillLevel = GenerateCharacter("Z", characterLevel);
        //ComputeAge();
        Debug.Log(nextSkillLevel);
        Debug.Log(GenerateCharacter("Bee", characterLevel));
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    ///  Computes a modified age integer
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(currentAge + addedAge);
        Debug.Log($"A string can have variables like {firstName} inserted directly!");
        Debug.LogFormat("Current Age: {0}, Added Age: {1}", currentAge, addedAge);
    }

    public int GenerateCharacter(string name, int level)
    {
        //Debug.Log("Character: {0}, Level: {1}", name, level);
        return level + 5; 
    }

    public void OpenTreasureChamber()
    {
        if(pureOfHeart == true && rareItem == "seed")
        {
            if(hasSecretIncantation)
            {
                Debug.Log("Welcome to the Chamber of Secrets");
            } else
            {
                Debug.Log("How dare you!");
            }
        } else
        {
            Debug.Log("You are not worthy");
        }
    }
}
