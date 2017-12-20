using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLab  : MonoBehaviour
{

    #region Public Members
    public Transform objectToShoot;
    public GameObject cameraTarget;
    public GameObject cameraMan;
    
    float distanceFromTarget;

    public CreateLab(Transform objectToShoot, float distanceFromTarget)
    {
        this.objectToShoot = objectToShoot;
        cameraTarget = new GameObject();
        cameraTarget.name = "cameraTarget";
        cameraMan = new GameObject();
        cameraMan.name = "Camera360";
        cameraTarget.transform.position = objectToShoot.position;
        
        
        cameraMan.transform.parent = cameraTarget.transform;
        cameraMan.transform.Translate(objectToShoot.localPosition.x, objectToShoot.localPosition.y + (distanceFromTarget / 3), objectToShoot.localPosition.z + distanceFromTarget);
        cameraMan.transform.LookAt(cameraTarget.transform);
        cameraMan.AddComponent<Camera>();

    }
    #endregion


    #region Public Void

    
    #endregion


    #region System

    void Start () 
    {

    }
    void Awake () 
    {

	}
	
	void Update () 
    {
		
	}

    #endregion

    #region Private Void

    #endregion

    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members

    #endregion

}
