using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPRScript : MonoBehaviour
{
    public bool handsOnBody;    //registers if hands are in position still unusable
    public bool handsBackUp = true;    //registers when hands come back up after compressing
    public bool headOnPosition;     //registers if head is in good position
    //public float depth;     //how low do you need to go needs to be fix acording to red cross preferences
    public float heightRange;   //how tall should the range be from body (does not affect its size)
    public int compressions = 0;    //the amount of compressions this value will be displayed on canvas
    private GameObject handModel;   //the model of the hand
    public Transform head;     //the head transform of the person used to adjust its rotation
    public Transform target;    //your invisible hand in the space
    private Transform originalPosition;     //the position desired for the hands to be when they come back
    public Transform start;
    public Transform end;

    private float lastActionTime;
    private float currentActionTime;
    private float timeInterval;
    public float bpm;

    private void Awake()
    {
        handModel = GameObject.Find("r_hand_skeletal_lowres");
        head = GameObject.FindGameObjectWithTag("Head").GetComponent<Transform>();

        lastActionTime = 0f;
        currentActionTime = 0f;
        timeInterval = 0f;
    }

    void Update()
    {
        originalPosition = GameObject.Find("TruePositionRightHand").GetComponent<Transform>();

        Debug.Log("Head rotation: " + head.rotation.x);

        /*float distance = Vector3.Distance(transform.position, target.position);
        if (distance <= range)
        {
            handsOnBody = true;
            Debug.Log("Object within range.");
            LockHands();

            if (handsBackUp == false && target.position.y == heightRange)
            {
                handsBackUp = true;
                compressions += 1;
            }
            if (target.position.y == heightRange)
            {
                handsBackUp = false;
            }
        }
        else
        {
            handsOnBody = false;
            Debug.Log("Object out of range.");
            handModel.transform.position = originalPosition.position;
        }*/
        if (head.rotation.x <= -23f)
        {
            Debug.Log("Head in position."); 
            headOnPosition = true;
        }
        else
        {
            headOnPosition = false;
        }
        if (handsOnBody == false)
        {
            //Debug.Log("Object out of range.");
        }
        if (handsOnBody)
        {
            if (target.position.y >= start.position.y && handsBackUp == false)
            {
                handsBackUp = true;
                CalculateBPM();
                compressions++;
            }
            else if (target.position.y <= end.position.y)
            {
                handsBackUp = false;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Right Hand" && headOnPosition)
        {
            handsOnBody = true;
            Debug.Log("Object within range.");
            LockHands();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Right Hand" && headOnPosition)
        {
            handsOnBody = false;
            handModel.transform.position = originalPosition.position;
        }
    }

    public void LockHands()
    {
        handModel.transform.position = new Vector3(gameObject.transform.position.x, target.position.y, gameObject.transform.position.z);
        //handModel.transform.rotation = Quaternion.LookRotation(new Vector3());
    }

    public void CalculateBPM()
    {
        currentActionTime = Time.time;

        if (lastActionTime != 0)
        {
            timeInterval = currentActionTime - lastActionTime;

            if (timeInterval > 0)
            {
                bpm = 60f / timeInterval;
            }
        }

        lastActionTime = currentActionTime;
    }
}