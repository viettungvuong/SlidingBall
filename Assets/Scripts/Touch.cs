using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Touch : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public float speed;
    public GameObject player;
    float halfScreenWidth;

    public void OnEndDrag(PointerEventData eventData)
    {
        Vector3 dragVectorDirection = (eventData.position - eventData.pressPosition).normalized;
        DraggedDirection direction = GetDragDirection(dragVectorDirection);
        switch (direction)
        {
            case DraggedDirection.Up: //vuot len
                {
                    player.transform.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 5, 0));
                    break;
                }
            case DraggedDirection.Right:
                {
                    player.transform.position = Vector3.Lerp(player.transform.position, player.transform.position + new Vector3(0, 0, -speed * Time.deltaTime), 1);
                    break;
                }
            case DraggedDirection.Left:
                {
                    player.transform.position = Vector3.Lerp(player.transform.position, player.transform.position + new Vector3(0, 0, speed * Time.deltaTime), 1);
                    break;
                }
        }
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragged");
    }

    private enum DraggedDirection
    {
        Up,
        Down,
        Right,
        Left
    }
    private DraggedDirection GetDragDirection(Vector3 dragVector)
    {
        float positiveX = Mathf.Abs(dragVector.x); //lay huong vuot theo x
        float positiveY = Mathf.Abs(dragVector.y);
        DraggedDirection draggedDir;
        if (positiveX > positiveY)
        {
            draggedDir = (dragVector.x > 0) ? DraggedDirection.Right : DraggedDirection.Left;
        }
        else
        {
            draggedDir = (dragVector.y > 0) ? DraggedDirection.Up : DraggedDirection.Down;
        }
        Debug.Log(draggedDir);
        return draggedDir;
    }
    /*private void Awake()
    {
        halfScreenWidth = Screen.width * 0.5f;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            UnityEngine.Touch touch = Input.touches[0];
            if (touch.position.x > halfScreenWidth)
            {
                Debug.Log("Left");
                player.transform.position=Vector3.Lerp(player.transform.position, player.transform.position + new Vector3(0,0,speed*Time.deltaTime),1);
            }
            else
            {
                Debug.Log("Right");
                player.transform.position=Vector3.Lerp(player.transform.position, player.transform.position + new Vector3(0, 0, -speed*Time.deltaTime), 1);
            }
        }
    }
    */

}



