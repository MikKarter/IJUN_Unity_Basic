using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _mScale;

    private void Update()
    {
        transform.localScale += _mScale;
    }
}
