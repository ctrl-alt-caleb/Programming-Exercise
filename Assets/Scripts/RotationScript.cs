using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotationScript : MonoBehaviour, IPointerClickHandler
{
    public GameObject rotatedObject;
    public float rotationSpeed = 250f;
    private float rotationZ;
    public bool clockwiseRotation = true;
    bool isRotating = false;


    [SerializeField] TextMeshProUGUI leftScoreText;
    [SerializeField] TextMeshProUGUI rightScoreText;

    void FixedUpdate()
    {
        if (isRotating == false) 
            return;


        if (clockwiseRotation == false) //handles direction of rotation
        {
            rotationZ += -Time.deltaTime * rotationSpeed;
        }
        else
        {
            rotationZ += Time.deltaTime * rotationSpeed;
        }

        rotatedObject.transform.rotation = Quaternion.Euler(0, 0, rotationZ); //handles rotation of middle rectangle

    }

    public void OnPointerClick(PointerEventData pointerEventData) //if the button is clicked-- middle will rotate and left counter will increase
    {
        Scoring.leftScore += 1;
        leftScoreText.text = Scoring.leftScore.ToString();

        if (isRotating == false)
        {
            isRotating = true;
        }
        else
        {
            isRotating = false;
        }
    }
}

