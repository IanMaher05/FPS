using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//makes camera always move with character
public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosition;

    private void Update()
    {
        transform.position = cameraPosition.position;
    }
}
