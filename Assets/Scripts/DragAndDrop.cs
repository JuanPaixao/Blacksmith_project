using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public bool isSelected;
    private GameManager _gameManager;
    private void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if (isSelected)
        {
            Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(cursorPosition.x, cursorPosition.y);
        }
        if (Input.GetMouseButtonUp(0))
        {
            isSelected = false;
            _gameManager.objectSelected = false;
        }
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButton(0) && !_gameManager.objectSelected)
        {
            isSelected = true;
            _gameManager.objectSelected = true;
        }
    }
}
