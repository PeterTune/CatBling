using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonGamblerScript : MonoBehaviour
{
    public GamblingManager gamblingManager;
    public void OnClick() 
    {
        gamblingManager.Gambling();
    }
    
}
