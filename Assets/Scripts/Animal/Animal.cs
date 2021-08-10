using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    // ENCAPSULATION
    protected float speed;
    protected float starvation;

    public virtual void Move() { }
    public virtual void Sound() { }
    public virtual void Eat() { }

}
