using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : Animal
{
    //POLYMORPHISM
    public override void Move()
    {
        base.Move();
    }

    public override void Sound()
    {
        base.Sound();
    }

    public override void Eat()
    {
        base.Eat();
    }
}
