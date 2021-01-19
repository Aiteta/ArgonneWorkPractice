using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour
{
    public GameObject myPrefab;

    // Start is called before the first frame update
    void Start() {

		float x;
    	float y = 5.0f;
    	float z = 0.0f;
    	int numCubes = 30;
    	float totalWidth = 2.9f;
		// sine
       	for (int i = 0; i < numCubes; i++) {
       		float perc = i/(float)numCubes;
       		float sin = Mathf.Sin(perc*Mathf.PI/2);

       		x = 1.8f+totalWidth*sin;

	        var newCube = (GameObject)Instantiate(myPrefab,new Vector3(x,y,z), Quaternion.identity);
	       	newCube.GetComponent<CubeScript>().setSize((1-perc)*0.35f);
	       	newCube.GetComponent<CubeScript>().rotateSpeed = 0.2f + 0.8f*perc;
	       	// newCube.GetComponent<CubeScript>().rotateSpeed *= prec;
       	}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
