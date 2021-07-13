using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Sphere : CharacterBase
{
    [SerializeField] float BounceHeight = 2f;
    [SerializeField] AnimationCurve BounceCurve;

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void Update_Intro()
    {
        transform.position = InitialPosition + Vector3.up * BounceHeight * BounceCurve.Evaluate(IntroProgress);
    }    

    public void DoSphereThings()
    {
        Debug.Log("Sphere Things!");
    }
}
