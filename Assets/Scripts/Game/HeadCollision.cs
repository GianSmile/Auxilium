using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadCollision : MonoBehaviour
{
    public bool ended; 
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Head") 
        {
            StartCoroutine(Temporizador());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        StopAllCoroutines();
    }

    IEnumerator Temporizador()
    {
        yield return new WaitForSeconds(10f);
        ended = true;
    }
}
