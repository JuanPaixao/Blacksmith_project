using UnityEngine;

public class BinControl : MonoBehaviour
{
    public Transform bottomBreadObj, topBreadObj, burgerObj, backHotDogBreadObj, topHotDogBreadObj, hotDogObj;

    private void OnMouseDown()
    {
        if (gameObject.name == "bread")
        {
            if (Gameplay.cuttingBoardS1 == "empty")
            {
                Instantiate(bottomBreadObj, new Vector2(-0.6f, -0.5f), Quaternion.identity);
                Instantiate(topBreadObj, new Vector2(-0.6f, -0.4f), Quaternion.identity);
                Gameplay.cuttingBoardS1 = "full";
            }
            else if (Gameplay.cuttingBoardS2 == "empty")
            {
                Instantiate(bottomBreadObj, new Vector2(0.5f, -0.5f), Quaternion.identity);
                Instantiate(topBreadObj, new Vector2(0.5f, -0.4f), Quaternion.identity);
                Gameplay.cuttingBoardS2 = "full";
            }
        }

        if (gameObject.name == "hamburgers")
        {
            if (Gameplay.grillS1 == "empty")
            {
                Instantiate(burgerObj, new Vector2(-7.45f, -1.10f), Quaternion.identity);
                Gameplay.grillS1 = "full";
            }
            else if (Gameplay.grillS2 == "empty")
            {
                Instantiate(burgerObj, new Vector2(-5.75f, -1.10f), Quaternion.identity);
                Gameplay.grillS2 = "full";
            }
        }
    }
}
