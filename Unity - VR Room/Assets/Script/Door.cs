using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;


public class Door : MonoBehaviour
{

    public Transform MyDoor;
    public float endPositionY = -90f;
    public GameObject canvas;

    public void openDoor()
    {
        if (MyDoor.transform.rotation.y != endPositionY)
        {
            MyDoor
            .DOLocalRotate(new Vector3(0, endPositionY, 0), 3f);
            canvas.SetActive(false);
        }

    }
}