using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatalogueNavigation : MonoBehaviour
{
    public TMPro.TMP_Text Title;
    public TMPro.TMP_Text Information;

    public Text[] InformationText;

    // Start is called before the first frame update
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
