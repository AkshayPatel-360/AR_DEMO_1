using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARPlacement : MonoBehaviour
{

    public GameObject arObjectToSpawn; 
    public GameObject placementIndicator;
    private GameObject spawndObject;
    private Pose PlacementPose;
    private ARRaycastManager aRRayCastManager;

    private bool placementPoseIsValid = false;

    void Start()
    {

        aRRayCastManager = FindObjectOfType<ARRaycastManager>();
        
    }

    
    void Update()
    {
        UpdatePlacementIndicator();
    }


    void UpdatePlacementIndicator()
    {
        if (spawndObject == null && placementPoseIsValid)
        {
            placementIndicator.SetActive(true);
            placementIndicator.transform.SetPositionAndRotation(PlacementPose.position, PlacementPose.rotation);
        }
        else
        {
            placementIndicator.SetActive(false);
        }
    }

}
