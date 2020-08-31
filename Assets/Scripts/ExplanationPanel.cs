using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using TMPro;
using System;
using UnityEditor;
using System.Linq;
using TMPro;

public class ExplanationPanel : MonoBehaviour
{
    [SerializeField]
    Camera uiCamera;

    [SerializeField]
    TextMeshProUGUI MasterNameArea;

    private static ExplanationPanel explantionInsatance;

    private Sprite spriteTemp;

    private void Awake()
    {
        explantionInsatance = this;
    }

    private void ShowPanel(string strMasterName)
    {
        SyndicateCommon.BetrayerMaster masterInform = MasterDeckManager.masterRoot.BetrayerMaster.Find(x => x.en == strMasterName || x.kr == strMasterName);

        string strTemp = "normal";
        #region [[[[[ Set Information ]]]]]
        // TValuable
        switch (Convert.ToInt32(masterInform.TV))
        {
            case (int)ValubalTypes.bad:
                strTemp = "bad";
                transform.GetChild(0).transform.GetChild(8).GetComponent<TextMeshProUGUI>().color = new Color32(195, 25, 40, 255);
                break;
            case (int)ValubalTypes.normal:
                strTemp = "normal";
                transform.GetChild(0).transform.GetChild(8).GetComponent<TextMeshProUGUI>().color = new Color32(243, 233, 234, 255);
                break;
            case (int)ValubalTypes.good:
                strTemp = "good";
                transform.GetChild(0).transform.GetChild(8).GetComponent<TextMeshProUGUI>().color = new Color32(25, 126, 195, 255);
                break;
            case (int)ValubalTypes.verygood:
                strTemp = "verygood";
                transform.GetChild(0).transform.GetChild(8).GetComponent<TextMeshProUGUI>().color = new Color32(255, 226, 0, 255);
                break;
            default:
                break;
        }
        spriteTemp = Resources.Load<Sprite>(strTemp);
        transform.GetChild(0).transform.GetChild(0).GetComponent<Image>().sprite = spriteTemp;


        // FValuable
        switch (Convert.ToInt32(masterInform.FV))
        {
            case (int)ValubalTypes.bad:
                strTemp = "bad";
                transform.GetChild(0).transform.GetChild(9).GetComponent<TextMeshProUGUI>().color = new Color32(195, 25, 40, 255);
                break;
            case (int)ValubalTypes.normal:
                strTemp = "normal";
                transform.GetChild(0).transform.GetChild(9).GetComponent<TextMeshProUGUI>().color = new Color32(243, 233, 234, 255);
                break;
            case (int)ValubalTypes.good:
                strTemp = "good";
                transform.GetChild(0).transform.GetChild(9).GetComponent<TextMeshProUGUI>().color = new Color32(25, 126, 195, 255);
                break;
            case (int)ValubalTypes.verygood:
                strTemp = "verygood";
                transform.GetChild(0).transform.GetChild(9).GetComponent<TextMeshProUGUI>().color = new Color32(255, 226, 0, 255);
                break;
            default:
                break;
        }
        spriteTemp = Resources.Load<Sprite>(strTemp);
        transform.GetChild(0).transform.GetChild(1).GetComponent<Image>().sprite = spriteTemp;

        // RValuable
        switch (Convert.ToInt32(masterInform.RV))
        {
            case (int)ValubalTypes.bad:
                strTemp = "bad";
                transform.GetChild(0).transform.GetChild(10).GetComponent<TextMeshProUGUI>().color = new Color32(195, 25, 40, 255);
                break;
            case (int)ValubalTypes.normal:
                strTemp = "normal";
                transform.GetChild(0).transform.GetChild(10).GetComponent<TextMeshProUGUI>().color = new Color32(243, 233, 234, 255);
                break;
            case (int)ValubalTypes.good:
                strTemp = "good";
                transform.GetChild(0).transform.GetChild(10).GetComponent<TextMeshProUGUI>().color = new Color32(25, 126, 195, 255);
                break;
            case (int)ValubalTypes.verygood:
                strTemp = "verygood";
                transform.GetChild(0).transform.GetChild(10).GetComponent<TextMeshProUGUI>().color = new Color32(255, 226, 0, 255);
                break;
            default:
                break;
        }
        spriteTemp = Resources.Load<Sprite>(strTemp);
        transform.GetChild(0).transform.GetChild(2).GetComponent<Image>().sprite = spriteTemp;

        // IValuable
        switch (Convert.ToInt32(masterInform.IV))
        {
            case (int)ValubalTypes.bad:
                strTemp = "bad";
                transform.GetChild(0).transform.GetChild(11).GetComponent<TextMeshProUGUI>().color = new Color32(195, 25, 40, 255);
                break;
            case (int)ValubalTypes.normal:
                strTemp = "normal";
                transform.GetChild(0).transform.GetChild(11).GetComponent<TextMeshProUGUI>().color = new Color32(243, 233, 234, 255);
                break;
            case (int)ValubalTypes.good:
                strTemp = "good";
                transform.GetChild(0).transform.GetChild(11).GetComponent<TextMeshProUGUI>().color = new Color32(25, 126, 195, 255);
                break;
            case (int)ValubalTypes.verygood:
                strTemp = "verygood";
                transform.GetChild(0).transform.GetChild(11).GetComponent<TextMeshProUGUI>().color = new Color32(255, 226, 0, 255);
                break;
            default:
                break;
        }
        spriteTemp = Resources.Load<Sprite>(strTemp);
        transform.GetChild(0).transform.GetChild(3).GetComponent<Image>().sprite = spriteTemp;

        // T, F, R, I Reward Image
        spriteTemp = Resources.Load<Sprite>(masterInform.TReward);
        transform.GetChild(0).transform.GetChild(4).GetComponent<Image>().sprite = spriteTemp;
        spriteTemp = Resources.Load<Sprite>(masterInform.FReward);
        transform.GetChild(0).transform.GetChild(5).GetComponent<Image>().sprite = spriteTemp;
        spriteTemp = Resources.Load<Sprite>(masterInform.RReward);
        transform.GetChild(0).transform.GetChild(6).GetComponent<Image>().sprite = spriteTemp;
        spriteTemp = Resources.Load<Sprite>(masterInform.IReward);
        transform.GetChild(0).transform.GetChild(7).GetComponent<Image>().sprite = spriteTemp;

        // T, F, R, I Reward Description
        transform.GetChild(0).transform.GetChild(4).transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = masterInform.T;
        transform.GetChild(0).transform.GetChild(5).transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = masterInform.F;
        transform.GetChild(0).transform.GetChild(6).transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = masterInform.R;
        transform.GetChild(0).transform.GetChild(7).transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = masterInform.I;

        MasterNameArea.transform.GetComponent<TextMeshProUGUI>().text = strMasterName;
        #endregion

        gameObject.SetActive(true);
    }

    private void HidePanel()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        //Vector2 localPoint;
        //RectTransformUtility.ScreenPointToLocalPointInRectangle(transform.parent.GetComponent<RectTransform>(), Input.mousePosition, uiCamera, out localPoint);
        //transform.localPosition = localPoint;
        transform.position = new Vector3(Input.mousePosition.x, transform.position.y, transform.position.z);
    }

    public static void ShowExplanationPanel(string strMasterName)
    {
        explantionInsatance.ShowPanel(strMasterName);
    }

    public static void HideExplanationPanel()
    {
        explantionInsatance.HidePanel();
    }
}
