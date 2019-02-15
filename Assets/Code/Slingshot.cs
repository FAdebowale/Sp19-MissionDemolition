using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour {
    public GameObject launchPoint;

    void Awake(){
        Transform launchPointTrans = transform.Find("LaunchPoint"); 
        //searches for slingshot named launchpoint and returns its transform (position, rotation, scale)
        launchPoint = launchPointTrans.gameObject;
        launchPoint.SetActive(false);
    }

    void OnMouseEnter() {
        print("Slingshot:OnMouseEnter()"); //detects that we are in sphere collider
        launchPoint.SetActive(true); //sets it as active in game, actives halo
    }

    void OnMouseExit() {
        print("Slingshot:OnMouseExit()"); //detects that we are out of sphere collider
        launchPoint.SetActive(false); //removes it from being active in the game, deactivates halo
    }

}
