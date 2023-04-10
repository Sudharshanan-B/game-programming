using UnityEngine;
using UnityEngine.UI;
public class PlayerWeightController : MonoBehaviour {
    public Slider weightSlider;
    public float minWeight = 1f;
    public float maxWeight = 20f;
    private Rigidbody2D playerRigidbody;
    void Start() {
        playerRigidbody = GetComponent<Rigidbody2D>();
        weightSlider.onValueChanged.AddListener(OnWeightChanged);
    }
    void OnWeightChanged(float value) {
        float weight = Mathf.Lerp(minWeight, maxWeight, value);
        playerRigidbody.mass = weight;
    }
}