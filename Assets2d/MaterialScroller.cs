using UnityEngine;
public class MaterialScroller : MonoBehaviour {
    public float scrollSpeedX = 0.1f;
    public float scrollSpeedY = 0.1f;
    new private Renderer renderer;
    void Start() {
        renderer = GetComponent<Renderer>();
    }
    void Update() {
        float offsetX = scrollSpeedX * Time.time;
        float offsetY = scrollSpeedY * Time.time;
        renderer.material.mainTextureOffset = new Vector2(offsetX, offsetY);
    }
}