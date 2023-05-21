using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    [SerializeField]
    private Transform desination;

    public Transform GetDestination()
    {
        return desination;
    }
    
}
