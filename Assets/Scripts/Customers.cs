using UnityEngine;

public class Customers : MonoBehaviour
{
    public Sprite[] sprites;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        int spriteSelector = Random.Range(0, sprites.Length);
        _spriteRenderer.sprite = sprites[spriteSelector];
    }
}
