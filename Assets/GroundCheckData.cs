using System;
using UnityEngine;

[Serializable]

public struct GroundCheckData
{
    public Transform originTransform;
    public float checkGroundRadius;
    public LayerMask groundLayer;
}
