using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipCard : MonoBehaviour
{
    public void FilpAll()
    {
        MasterDeckManager.g_bFlip = !MasterDeckManager.g_bFlip;
        MasterDeckManager.RefleshOnBoardCard();
    }
}
