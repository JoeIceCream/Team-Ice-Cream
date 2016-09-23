using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class SelectTower : MonoBehaviour, IPointerDownHandler {
    public GameObject slottedTower;
    public Image selected;
    Sprite slottedImage;

    public void OnPointerDown(PointerEventData eventData) {
        TowerManager twrMngr = GameObject.FindObjectOfType<TowerManager>();

        if(twrMngr.selectedTower == slottedTower) {
            twrMngr.selectedTower = null;
            deselectAllTowers();
            Debug.Log("Tower Deselected.");
        }
        else if(slottedTower != null) {

            Debug.Log("Tower Selected.");
            twrMngr.selectedTower = slottedTower;
            if(selected != null)
                selected.enabled = true;
        }
        else {
            Debug.Log("Empty Slot selected Deselecting towers");
            twrMngr.selectedTower = null;
            deselectAllTowers();
        }
    }

    void deselectAllTowers() {
        SelectTower[] selections = GameObject.FindObjectsOfType<SelectTower>();

        for (int i = 0; i < selections.Length; i++)
        {
            if (selections[i].selected != null)
                selections[i].selected.enabled = false;
        }
    }

    // Use this for initialization
    void Start() {
        if(selected != null)
            selected.enabled = false;
        if(slottedTower != null) {
            slottedImage = slottedTower.GetComponentInChildren<Image>().sprite;
            gameObject.GetComponentInChildren<Image>().sprite = slottedImage;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
