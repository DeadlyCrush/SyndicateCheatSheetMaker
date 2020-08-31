using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PagingButton : MonoBehaviour
{
    public void ShowPreviousPage()
    {
        MasterDeckManager.ShowPreviousPage();
    }

    public void ShowNextPage()
    {
        MasterDeckManager.ShowNextPage();
    }
}
