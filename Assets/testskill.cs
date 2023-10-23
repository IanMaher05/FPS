using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class testskill : MonoBehaviour
{
    public UnityEvent Testing;
    // Start is called before the first frame update
    void Start()
    {
        Testing.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        Testing.Invoke();
    }
}
