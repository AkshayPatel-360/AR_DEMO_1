using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectToPlane : MonoBehaviour
{

    private FindPlane PlaneFinder;
    void Awake() { PlaneFinder = FindObjectOfType<FindPlane>(); }
    void Start()
    {
        DisableObject();
        //PlaneFinder.OnValidPlaneFound += UpdateTransform; PlaneFinder.OnValidPlaneNotFound += DisableObject;
    }

   /* private void UpdateTransform(PlaneData Plane)   
    {        gameObject.SetActive(true);       
        transform.SetPositionAndRotation(Plane.Position,Plane.Rotation);  
    }*/
    private void DisableObject()  
    {
        gameObject.SetActive(false);   
    } 


}
