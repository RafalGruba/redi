using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popout2 : MonoBehaviour
{
    public void BringBackButtons()
    {
        FindObjectOfType<Buttons>().BringBackButtons();
    }

}
