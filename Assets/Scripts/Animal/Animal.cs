using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    // ENCAPSULATION
    [SerializeField] protected float speed;
    [SerializeField] protected float starvation;
    [SerializeField] protected int counter;

    public virtual void Move() { }
    public virtual void Sound() { }
    public virtual void Eat() { }

    public virtual void SetTitle() { }

    public virtual void SetInformation()
    {
        InGameUI.Instance.Information.text = string.Format("Speed: {0} \nStarvation: {1}", speed.ToString(), starvation.ToString());
    }

}
