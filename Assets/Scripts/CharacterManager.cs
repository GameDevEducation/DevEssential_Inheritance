using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    List<CharacterBase> AllCharacters;

    // Start is called before the first frame update
    void Start()
    {
        // find all CharacterBase instances in the scene that are active
        AllCharacters = new List<CharacterBase>(FindObjectsOfType<CharacterBase>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PerformIntros()
    {
        // tell all characters to perform their intro
        foreach(var character in AllCharacters)
        {
            // check if this is a sphere
            if (character is Character_Sphere)
                (character as Character_Sphere).DoSphereThings();

            // casting (ie. putting type in parentheses before a variable) will fail (and cause an exception) if the type does not match
            // if ((Character_Sphere)character != null)
            //     ((Character_Sphere)character).DoSphereThings();

            character.PerformIntro();

            character.DemoFunction();
        }
    }
}
