using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipScript : MonoBehaviour
{
    public GameObject switchHandleUp;
    public GameObject switchHandleDown;

    public void SwitchTimer() //sets switch to the up position and calls Waiter
    {
        switchHandleDown.SetActive(false);
        switchHandleUp.SetActive(true);
        StartCoroutine(Waiter());
    }

    IEnumerator Waiter() //waits & then reverts switch to down position
    {
        yield return new WaitForSeconds(2);
        switchHandleDown.SetActive(true);
        switchHandleUp.SetActive(false);
    }
}
