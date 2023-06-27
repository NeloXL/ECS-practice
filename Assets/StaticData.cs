using System;
using UnityEngine;

[Serializable]

public class StaticData : MonoBehaviour
{
    public GameObject playerPrefab;
    public float playerSpeed;
    public float playerJumpForce;
    public float checkGroundRadius;
    public LayerMask groundLayer;
}
