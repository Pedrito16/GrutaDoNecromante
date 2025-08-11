using UnityEngine;

public class MoveWater : MonoBehaviour
{
    [SerializeField] Material waterMaterial;
    [SerializeField] float speedY = 0.1f;
    [SerializeField] float speedX = 0.1f;
    void Start()
    {
        waterMaterial.mainTextureOffset = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        waterMaterial.mainTextureOffset += new Vector2(speedX * Time.deltaTime, speedY * Time.deltaTime);
    }
}
