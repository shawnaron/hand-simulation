using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using TensorFlowLite;
using Cysharp.Threading.Tasks;

public class connectionsFinding : MonoBehaviour
{
	public GameObject triAxis;
	
	// float threshold = 0.5f;
	// string fileName = "posenet_mobilenet_v1_100_257x257_multi_kpt_stripped.tflite";
	// PoseNet poseNet;
    // PoseNet.Result[] results;
	
	// void Start()
    // {
        // string path = Path.Combine(Application.streamingAssetsPath, fileName);
        // poseNet = new PoseNet(path);
	// }
	
	// public void TestFunction()
	// void Update()
	// {
		// var connections = PoseNet.Connections;
				// int len = connections.GetLength(0);
				// for (int i = 0; i < len; i++)
				// {
					// var a = results[(int)connections[i, 0]];
					// var b = results[(int)connections[i, 1]];
					// if (a.confidence >= threshold && b.confidence >= threshold)
					// {
						// triAxis.transform.position = new Vector3(a.x, a.y, -8);
						
					// }
				// }
	// }
}
