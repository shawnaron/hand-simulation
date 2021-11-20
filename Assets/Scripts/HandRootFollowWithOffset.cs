using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandRootFollowWithOffset : MonoBehaviour
{
	public ReqJoints requiredJointValues;
	Plane plane;
		
	
	/* 
	<summary>
		Hit and trial data
		Scale RightHand_Root (16, 16, 16)
		For position offset RightHand > RightHand_Root (-0.02, 0.6, 0)
		For rotation offset RightHand > RightHand_Root (-90, 0, 0)
		RightHand > RightHand_Root Scale(0.0625, 0.0625, 0.0625)
	</summary>
	*/   
	
    // Start is called before the first frame update
    void Start()
    {
        plane = new Plane ();
    }

    // Update is called once per frame
    void Update()
    {
		// transform.LookAt(requiredJointValues.ninePointPosition);
		// transform.rotation = Quaternion.Euler(0f, offsetRotY, 0f) * transform.rotation;

		transform.position = requiredJointValues.zeroPointPosition;	
		
		plane.Set3Points(requiredJointValues.zeroPointPosition, requiredJointValues.thirtyFivePointPosition, requiredJointValues.ninePointPosition);
		transform.rotation = Quaternion.LookRotation(plane.normal);
		
   }
}
