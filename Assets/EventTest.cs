using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class EventTest : MonoBehaviour
{
    public UnityEvent Test;
    // Start is called before the first frame update
    void Start()
    {
        Test.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void ChangePosition()
    {
        this.gameObject.transform.position = new Vector3(35, 4, 16);
    }
}
