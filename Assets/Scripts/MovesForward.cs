using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovesForward : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;

    private void Update()
    {
        transform.Translate(_movementDirection, Space.World);
    }
}