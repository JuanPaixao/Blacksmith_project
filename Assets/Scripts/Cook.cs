using UnityEngine;

public class Cook : MonoBehaviour
{
    public float cookingTime = 0;

    private void Update()
    {
        cookingTime += Time.deltaTime;
        if (cookingTime > 5 && cookingTime < 10)
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 0.25f);
        }
        if (cookingTime > 10)
        {
            GetComponent<SpriteRenderer>().color = new Color(0.25f, 0.25f, 0.25f);
        }
    }
}
