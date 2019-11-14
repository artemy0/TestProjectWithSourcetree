using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    void Start()
    {
        GameObject.Destroy(this.gameObject, 2f);
    }
}
