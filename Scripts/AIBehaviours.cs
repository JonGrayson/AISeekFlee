using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIBehaviours : MonoBehaviour
{
    public float moveSpeed = 2f;

    public string AIStatus;

    public Transform playerTarget;

    public Rigidbody rig;

    Vector3 direction;

    Vector3 moveDirection;

    private void Update()
    {
        if(AIStatus == "Flee")
        {
            Flee();
        }

        else if(AIStatus == "Seek")
        {
            Seek();
        }
    }

    public void Flee()
    {
        direction = transform.position - playerTarget.position;
        transform.rotation = Quaternion.LookRotation(direction);
        transform.position += transform.TransformDirection(Vector3.forward) * moveSpeed * Time.deltaTime;
        //rig.AddForce(moveDirection);
    }

    public void Seek()
    {
        direction = playerTarget.position - transform.position;
        transform.rotation = Quaternion.LookRotation(direction);
        transform.position += transform.TransformDirection(Vector3.forward) * moveSpeed * Time.deltaTime;

        //moveDirection = direction.normalized * moveSpeed * Time.deltaTime;
        //transform.LookAt(moveDirection);
        //rig.AddForce(moveDirection);
    }
}
