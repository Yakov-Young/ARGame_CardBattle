 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSharpScript : MonoBehaviour
{

    public GameObject Character;

    private void OnCollisionEnter(Collision collision)
    {
        Character.GetComponent<Animator>().Play("punch");
    }

    private void OnCollisionExit(Collision collision)
    {
        Character.GetComponent<Animator>().Play("idle");
    }
}
