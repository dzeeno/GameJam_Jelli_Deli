using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSelection : MonoBehaviour
{
    public string selectabletag = "Selectable";
    public Material selectedMat;
    public Material normalMat;
    public playermover playermover;

    private Transform _selection;
    // Update is called once per frame
    void Update()
    {
        if (_selection != null) {
            var selectionRender = _selection.GetComponent<Renderer>();
            selectionRender.material = normalMat;
            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)){

            var selection = hit.transform;
            if (selection.CompareTag(selectabletag)) {

                var selectionRender = selection.GetComponent<Renderer>();
                if (selectionRender != null) {

                    selectionRender.material = selectedMat;
                    if (Input.GetMouseButton(0)) {

                        playermover.CurrentPos = playermover.pos2;

                    }
                }
                _selection = selection;
            }

        }
    }

}
