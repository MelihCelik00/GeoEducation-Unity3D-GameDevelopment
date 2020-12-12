using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{
    private void Update()
    {
        this.transform.Rotate(new Vector3(5,10,17)*Time.deltaTime);
    }
}
