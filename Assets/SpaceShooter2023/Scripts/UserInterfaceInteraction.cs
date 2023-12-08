using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UserInterfaceInteraction : MonoBehaviour, IRaycastInterface
{
    public UnityEvent onHitByRayCast;


    public void HitByrayCast()
    {
        onHitByRayCast.Invoke();


    }

}
