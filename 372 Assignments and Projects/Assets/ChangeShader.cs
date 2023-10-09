using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShaderProperty : MonoBehaviour
{

    [SerializeField] private Material material;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            material.SetColor("_Color", Color.blue);
        }
    }


}