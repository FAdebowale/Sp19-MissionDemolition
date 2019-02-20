using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour {
    [Header("Set in Inspector")]
    public GameObject prefabProjectile;

    [Header("Set Dynamically")]
    public GameObject launchPoint;
    public Vector3 launchPos;
    public GameObject projectile;
    public bool aimingMode;

    void Awake(){
        Transform launchPointTrans = transform.Find("LaunchPoint"); 
        //searches for slingshot named launchpoint and returns its transform (position, rotation, scale)
        launchPoint = launchPointTrans.gameObject;
        launchPoint.SetActive(false);
        launchPos = launchPointTrans.position;
    }

    void OnMouseEnter() {
        print("Slingshot:OnMouseEnter()"); //detects that we are in sphere collider
        launchPoint.SetActive(true); //sets it as active in game, actives halo
    }

    void OnMouseExit() {
        print("Slingshot:OnMouseExit()"); //detects that we are out of sphere collider
        launchPoint.SetActive(false); //removes it from being active in the game, deactivates halo
    }

    void OnMouseDown(){
        //  The player has pressed the mouse button while over Slingshot
        aimingMode = true;
        //Instantiate a Projectile
        projectile = Instantiate(prefabProjectile) as GameObject;
        //Start it at LaunchPoint
        projectile.transform.position = launchPos;
        //Set it to isKinematic for now
        projectile.GetComponent<Rigidbody>().isKinematic = true;
    }

}
