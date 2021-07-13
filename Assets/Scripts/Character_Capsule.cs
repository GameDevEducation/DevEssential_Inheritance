using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Capsule : CharacterBase
{
    [SerializeField] AnimationCurve ScaleCurve;
    protected Vector3 InitialScale;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();

        InitialScale = transform.localScale;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void Update_Intro()
    {
        transform.localScale = InitialScale * (1f + ScaleCurve.Evaluate(IntroProgress));
    }   

    public override void DemoFunction()
    {
        Debug.Log("Capsule DemoFunction called on " + gameObject.name);
    }       
}
