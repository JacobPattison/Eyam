using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatalogueNavigation : MonoBehaviour
{
    [SerializeField] TMPro.TMP_Text Title;
    [SerializeField] TMPro.TMP_Text Information;

    public Text[] InformationText;

    void Start()
    {
        string title = InformationText[0].text.Split('@')[0];
        string information = InformationText[0].text.Split('@')[1];
        Title.text = title;
        Information.text = information;
    }

    public void ChangeInformation(int section)
    {
        string title = InformationText[section].text.Split('@')[0];
        string information = InformationText[section].text.Split('@')[1];
        Title.text = title;
        Information.text = information;
    }
}
