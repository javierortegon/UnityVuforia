using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class EventCustom : DefaultTrackableEventHandler
{
    public Animator cubeAni;

    protected override void OnTrackingFound()
    {
        //cubeAni.Play("cube_animation");
        //Debug.Log("Entro posicion: x : " + transform.position.x + " y: " + +transform.position.y + " z: " + +transform.position.z);
        Debug.Log("entro");
        base.OnTrackingFound();

    }

    protected override void OnTrackingLost()
    {
       
        Debug.Log("salio");
        base.OnTrackingLost();
    }
}

