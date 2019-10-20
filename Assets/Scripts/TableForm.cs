using UnityEngine;

public class TableForm : MonoBehaviour
{
    public bool isUsed;
    private GameManager _gameManager;
    private DragAndDrop _dragAndDrop;
    public GameObject fill;
    private void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _dragAndDrop = GetComponent<DragAndDrop>();
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            isUsed = false;
            _gameManager.formsOnTable--;
            this.gameObject.SetActive(false);
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Water"))
        {
            if (isUsed)
            {
                if (!_dragAndDrop.isSelected)
                {
                    isUsed = false;
                    fill.SetActive(false);
                }
            }
        }
    }
}
