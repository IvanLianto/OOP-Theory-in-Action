using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : Animal
{
    //POLYMORPHISM
    public override void Move()
    {
        InGameUI.Instance.InformationMethod.text = "Duck is Walking";
        base.Move();
    }

    public override void Sound()
    {
        InGameUI.Instance.InformationMethod.text = "Duck is Sounding";
        base.Sound();
    }

    public override void Eat()
    {
        InGameUI.Instance.InformationMethod.text = "Duck is Eating";
        base.Eat();
    }

    public override void SetTitle()
    {
        InGameUI.Instance.Title.text = gameObject.name;
    }

    public override void SetInformation()
    {
        base.SetInformation();
    }

    private void OnMouseDown()
    {
        InGameUI.Instance.Panel.SetActive(true);
        SetTitle();
        SetInformation();

        switch (counter)
        {
            case 0:
                Move();
                break;
            case 1:
                Sound();
                break;
            case 2:
                Eat();
                break;
            default:
                break;
        }

        if (counter < 3)
        {
            counter++;
        }
        else
        {
            counter = 0;
        }
    }
}
