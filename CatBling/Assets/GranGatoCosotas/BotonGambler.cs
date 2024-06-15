using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonGambler : MonoBehaviour
{
    public GamblingManager gamblingManager;
    public void OnClick()
    {
        gamblingManager.Gambling();
    }
}
