using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPRScript : MonoBehaviour
{
    public bool handsOnBody;
    public Transform target;
    public float range;
    private GameObject handModel;
    private Transform originalPosition;

    private void Awake()
    {
        handModel = GameObject.Find("r_hand_skeletal_lowres");
    }

    void Update()
    {
        originalPosition = GameObject.Find("TruePositionRightHand").GetComponent<Transform>();
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance <= range)
        {
            handsOnBody = true;
            Debug.Log("Object within range.");
            LockHands();
        }
        else
        {
            handsOnBody = false;
            Debug.Log("Object out of range.");
            handModel.transform.position = originalPosition.position;
        }
    }
    
    public void LockHands()
    {
        handModel.transform.position = new Vector3(gameObject.transform.position.x, target.position.y, gameObject.transform.position.z);
        //handModel.transform.rotation = Quaternion.LookRotation(new Vector3());
    }
}
