using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private Vector3 mScale;

    private void Update()
    {
        transform.localScale += mScale;
    }
}
