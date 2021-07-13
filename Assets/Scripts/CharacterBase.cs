using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    [SerializeField] protected float IntroTime = 2f;

    protected bool IntroUnderway = false;
    protected float IntroProgress = 0f;
    protected Vector3 InitialPosition;
    
    // Start is called before the first frame update
    protected virtual void Start()
    {
        InitialPosition = transform.position;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        // intro in progress
        if (IntroUnderway)
        {
            IntroProgress += Time.deltaTime / IntroTime;

            Update_Intro();

            // intro complete
            if (IntroProgress >= 1f)
                IntroUnderway = false;
        }        
    }

    protected virtual void Update_Intro()
    {

    }

    public virtual void PerformIntro()
    {
        IntroUnderway = true;
        IntroProgress = 0f;
    }

    public virtual void DemoFunction()
    {
        Debug.Log("Base DemoFunction called on " + gameObject.name);
    }
}
