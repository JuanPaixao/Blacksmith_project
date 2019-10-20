using UnityEngine;

public class RawMaterial : MonoBehaviour
{
    public bool isFull, canBeUsed;
    public string materialName;
    public GameObject fullImage;
    public float timeOnFire, timeToPrepare;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(materialName))
        {
            this.isFull = true;
            fullImage.SetActive(true);
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Fire") && isFull)
        {
            this.timeOnFire += Time.deltaTime;
        }
        if (timeOnFire >= timeToPrepare)
        {
            canBeUsed = true;
        }
        if (other.CompareTag("Form") && isFull && canBeUsed)
        {
            this.isFull = false;
            fullImage.SetActive(false);
            var form = other.GetComponent<TableForm>();
            if (form.isUsed == false)
            {
                form.fill.SetActive(true);
                form.isUsed = true;
            }
        }
    }
}
