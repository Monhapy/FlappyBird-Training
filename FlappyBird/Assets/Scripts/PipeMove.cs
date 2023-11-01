using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    private Vector3 _leftMoveVector; 
    private float moveSpeed= 2.5f;
    private void Update()
    {
        LeftMove();
        PipeDestroy();
    }

    private void LeftMove()
    {
        _leftMoveVector = Vector3.left;
        gameObject.transform.position += _leftMoveVector * (moveSpeed * Time.deltaTime);
    }

    private void PipeDestroy()
    {
        if (gameObject.transform.position.x < -7)
        {
            Destroy(gameObject);
        }
    }
}
