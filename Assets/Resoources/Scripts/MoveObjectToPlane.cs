using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectToPlane : MonoBehaviour
{

    private FindPlane PlaneFinder;
    void Awake() { PlaneFinder = FindObjectOfType<FindPlane>(); }
   
}
