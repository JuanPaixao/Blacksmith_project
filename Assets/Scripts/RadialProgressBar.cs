using UnityEngine;
using UnityEngine.UI;

public class RadialProgressBar : MonoBehaviour
{
    public float currentCooldownTime, initialCooldownTime;
    [SerializeField] private Image _image;

    void Awake()
    {
        _image = GetComponent<Image>();
        initialCooldownTime = currentCooldownTime;
    }
    private void Update()
    {
        currentCooldownTime += Time.deltaTime * 20;
        this._image.fillAmount = currentCooldownTime / 100f; //because its go from 0 to 1 (0 to 100%)

        if (this._image.fillAmount >= 1)
        {
            ResetBar();
        }
    }
    public void ResetBar()
    {
        this._image.fillAmount = 0;
        this.currentCooldownTime = initialCooldownTime;
        this.gameObject.SetActive(false);
    }
}
