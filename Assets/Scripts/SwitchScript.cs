using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class SwitchScript : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    
    public GameObject switchHandleUp; //reference to Game Object - switch in up position
    public GameObject switchHandleDown; //reference to Game Object - switch in down position

    public FlipScript FlipScript;
    public GameObject playAgainMenu;
    public RotationScript ButtonScript;

    [SerializeField] TextMeshProUGUI rightScoreText;


    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
    }

    public void OnEndDrag(PointerEventData eventData) //when the user clicks on the switch and drags upwards, the switch flips to the up position
    {
        Debug.Log("OnEndDrag");
        if (!playAgainMenu.activeSelf)
        {
            if (Input.mousePosition.y > 585) //value roughly in the middle of the switch body-- if mouse is higher on button release, switch flips
            {
                Debug.Log(Input.mousePosition.y);

                Scoring.rightScore += 1; //updates right counter in Scoring class
                rightScoreText.text = Scoring.rightScore.ToString(); // updates counter above switch

                if (ButtonScript.clockwiseRotation == true) //handles which direction for the center rectangle to rotate after a flip
                {
                    ButtonScript.clockwiseRotation = false;
                }
                else
                {
                    ButtonScript.clockwiseRotation = true;
                }

                FlipScript.SwitchTimer(); //calls a timer in FlipScript to wait a few seconds before reverting to the flipped down position

            }
        }
    }
}
