using UnityEngine;
using UnityEngine.UI;

public class ClientOrder : MonoBehaviour
{
    public RecipeScriptable[] recipes;
    public SpriteRenderer spriteRenderer;
    public float timeOrder;
    public Slider timeSlider;

    private void Start()
    {
        int randomRecipe = Random.Range(0, recipes.Length);
        spriteRenderer.sprite = recipes[randomRecipe].itemSprite;
        timeSlider.maxValue = timeOrder;
    }
    private void Update()
    {
        timeOrder -= Time.deltaTime;
        timeSlider.value = timeOrder;
    }
}
