using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour {
    static public GameObject POI; //static point of interest (POI = point of interest)

    [Header("Set Dynamically")]
    public float camZ; //Desired Z pos of camera

    void Awake() {
        camZ = this.transform.position.z;
    }

    void FixedUpdate(){
        // If there's only one line following an if, it doesn't need brackes
        if (POI == null) return; //return if there is no poi

        // Get position of the poi
        Vector3 destination = POI.transform.position;
        //Force destination.z to be camZ to keep the camera far enough awayd
        destination.z = camZ;
        //Set camera to destination
        transform.position = destination;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
