using UnityEngine;
using System.Collections;

public class TowerLocation : MonoBehaviour {
    
    void OnMouseUp() {
        Debug.Log("Tower Location Clicked.");
        TowerManager twrMngr = GameObject.FindObjectOfType<TowerManager>();

        if (twrMngr.selectedTower != null) {
            CurrencySystem cs = GameObject.FindObjectOfType<CurrencySystem>();
            int cost = 100; //Fix this
            if (!cs.BuyTower(cost)) {
                Debug.Log("Not enough monies");
                return;
            }
            Debug.Log("Deselecting all Towers.");
            SelectTower[] selections = GameObject.FindObjectsOfType<SelectTower>();

            for (int i = 0; i < selections.Length; i++) {
                if (selections[i].selected != null)
                    selections[i].selected.enabled = false;
            }
            
            if (transform.parent != null) {
                Instantiate(twrMngr.selectedTower, transform.parent.position, transform.parent.rotation);
                Destroy(transform.parent.gameObject);
                twrMngr.selectedTower = null;
            }
            else if(transform != null) {
                Instantiate(twrMngr.selectedTower, transform.position, transform.rotation);
                Destroy(transform.gameObject);
                twrMngr.selectedTower = null;
            }
        }
        else {
            Debug.Log("No Tower Selected.");
        }
    }
}
