using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButton : MonoBehaviour
{
    public string locState;
    public GameObject movePanelBedroom;
    public GameObject movePanelBathroom;
    public GameObject movePanelKitchen;
    public GameObject movePanelFFloor;
    public bool isDialogueFinished;


    // Start is called before the first frame update
    void Start()
    {
        locState = "bedroom";
        movePanelBedroom.SetActive(false);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (locState=="bedroom") {

        }

        if (locState=="bathroom") {

        }

        if (locState=="firstfloor") {

        }

        if (locState=="kitchen") {

        }

        
    }
    public void ShowMovePanel() {
        if (movePanelBedroom.activeSelf==false) {
            movePanelBedroom.SetActive(true);
            Debug.Log("Button clicked!");
        }
        else {
            if (movePanelBedroom.activeSelf==true) {
                movePanelBedroom.SetActive(false);
            }
        }
    }
}
