using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Cube : CharacterBase
{
    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void Update_Intro()
    {
        transform.eulerAngles = new Vector3(0f, 360f * IntroProgress, 0f);
    }      
}
