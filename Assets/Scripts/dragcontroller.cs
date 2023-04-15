using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragcontroller : MonoBehaviour
{
    private bool _isDragActive = false;
    private Vector2 _ScreenPosition;
    private Vector3 _worldPosition;
    private Draggable _lastDraggedItem;
    private GameObject itemObject;
    private bool interactableEnabled = false;

    // Update is called once per frame
    void Awake(){
        dragcontroller[] controllers = FindObjectsOfType<dragcontroller>();
        if(controllers.Length > 1){
            Destroy(gameObject);
        }
    }
    void Update()
    {
        if(_isDragActive && (Input.GetMouseButtonUp(0) || (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended))){
            Drop();
            return;
        }
        if (Input.GetMouseButton(0)){
            Vector3 mousePos = Input.mousePosition;
            _ScreenPosition = new Vector2(mousePos.x, mousePos.y);

        } else if (Input.touchCount > 0){
            _ScreenPosition = Input.GetTouch(0).position;
        } else {
            return;
        }


        _worldPosition = Camera.main.ScreenToWorldPoint(_ScreenPosition);

        if(_isDragActive) {
            Drag();
        } else {
            RaycastHit2D hit = Physics2D.Raycast(_worldPosition, Vector2.zero);
            if(hit.collider != null){
                Draggable draggable = hit.transform.gameObject.GetComponent<Draggable>();
                if(draggable != null){
                    _lastDraggedItem = draggable;
                    InitDrag();
                }
            }
        }
    }

    void InitDrag(){
        _isDragActive = true;
    }

    void Drag(){
        _lastDraggedItem.transform.position = new Vector2(_worldPosition.x, _worldPosition.y);
        _lastDraggedItem.disable();
    }

    void Drop(){
        _isDragActive = false;
        _lastDraggedItem.enable();
    }
}
