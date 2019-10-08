using UnityEngine;


[CreateAssetMenu(fileName = "Recipe", menuName = "RecipeScriptable", order = 0)]
public class RecipeScriptable : ScriptableObject
{

    public string objectName;
    public int itemsQuantity;
    public string[] ingredients;
    public Sprite itemSprite;

}
