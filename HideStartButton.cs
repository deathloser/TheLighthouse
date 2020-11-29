using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HideStartButton : MonoBehaviour
{
    public Button buttonToHide;
    // Start is called before the first frame update
    void Start()
    {
        buttonToHide = GetComponent<Button>();
        buttonToHide.onClick.AddListener(() => HideButton());
        
    }

    void HideButton() {
        buttonToHide.gameObject.SetActive(false);
    }
}
