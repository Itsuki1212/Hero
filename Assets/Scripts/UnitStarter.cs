using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using rpgkit;

public class UnitStarter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CinemachineVirtualCamera vcam = null;

        Room[] rooms = GameObject.FindObjectsOfType<Room>();
        //Debug.Log(rooms.Length);
        if (rooms.Length == 0)
        {
            vcam = GameObject.FindObjectOfType<Cinemachine.CinemachineVirtualCamera>();
        }
        else
        {
            foreach (Room r in rooms)
            {
                r.m_vcam.Priority = 0;
                if (r.GetComponent<Collider>().bounds.Contains(transform.position))
                {
                    vcam = r.m_vcam;
                }
            }
            if (vcam == null)
            {
                Debug.LogError("だめ");
            }
        }
        if (vcam != null)
        {
            vcam.Priority = 10;
            vcam.Follow = transform;
        }
    }

   
}
