using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popout3 : MonoBehaviour
{
    [SerializeField] private GameObject toggle1;
    [SerializeField] private GameObject toggle2;
    [SerializeField] private GameObject toggle3;

    public void SetTogglesOn()
    {
        toggle1.SetActive(true);
        toggle2.SetActive(true);
        toggle3.SetActive(true);
    }
    public void SetTogglesOff()
    {
        toggle1.SetActive(false);
        toggle2.SetActive(false);
        toggle3.SetActive(false);
    }
}
