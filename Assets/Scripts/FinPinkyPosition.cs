using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinPinkyPosition : MonoBehaviour
{
	public ReqJoints requiredJointValues;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = requiredJointValues.fortyOnePointPosition;
    }
}
