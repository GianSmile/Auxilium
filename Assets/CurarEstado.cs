using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurarEstado : MonoBehaviour
{
    public bool curado = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Botiquin"))
        {
            curado = true;
            GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
}
