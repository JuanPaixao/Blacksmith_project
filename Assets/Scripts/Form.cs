using UnityEngine;

public class Form : MonoBehaviour
{
    public GameObject form;
    public string objectName;
    private GameManager _gameManager;
    private void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>();
        objectName = this.gameObject.name;
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_gameManager.formsOnTable == 0)
            {
                TableForm tableForm = form.GetComponent<TableForm>();
                tableForm.isUsed = false;
                form.SetActive(true);
                _gameManager.formsOnTable++;
            }
        }
    }
}
