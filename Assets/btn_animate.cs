using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class btn_animate : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbBtnObj;
    public Animator modelAnimation;

    // Start is called before the first frame update
    void Start()
    {
        
        modelAnimation.GetComponent<Animator>();
        //model.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //cubeAni.Play("cube_animation");
        Debug.Log("BTN Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //cubeAni.Play("none");
        Debug.Log("BTN Released");
    }

    // Update is called once per frame
    void Update()
    {
        //modelAnimation.Play("Jog In Circle");
        //model.Play("cube_animation");
        //cubeAni.Play("cube_animation");
        Debug.Log("Update Entro posicion: x : " + transform.position.x + " y: " + +transform.position.y + " z: " + +transform.position.z);
        float limit = -0.03F;
        if (transform.position.y < limit)
        {
            modelAnimation.Play("Jog In Circle");
            Debug.Log("Abajo");
        }
        else
        {
            modelAnimation.Play("None");
            //modelAnimation.Play("mixamo.com");
            //    //    cubeAni.Play("none");
        }
    }
}
