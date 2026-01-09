using UnityEngine;
using TMPro;

public class NeonFlicker : MonoBehaviour
{
    [Header("Flicker Settings")]
    public float minIntensity = 0.5f;
    public float maxIntensity = 3f;
    public bool randomFlicker = true;
    public float flickerSpeed = 5f;

    [Header("Colors")]
    public Color glowColor = Color.cyan;

    private TextMeshPro textMesh;
    private Material textMaterial;
    private float nextFlickerTime = 0f;
    private float targetIntensity;
    private float currentIntensity;

    void Start()
    {
        // Get the TextMeshPro component
        textMesh = GetComponent<TextMeshPro>();

        if (textMesh != null)
        {
            // Create a unique material instance for this text
            textMaterial = textMesh.fontMaterial;
            textMesh.fontMaterial = new Material(textMaterial);
            textMaterial = textMesh.fontMaterial;
        }

        targetIntensity = maxIntensity;
        currentIntensity = maxIntensity;
    }

    void Update()
    {
        if (textMaterial == null) return;

        // Determine target intensity
        if (randomFlicker)
        {
            // Random flickering (broken neon effect)
            if (Time.time > nextFlickerTime)
            {
                // 70% chance of being bright, 30% chance of being dim
                targetIntensity = Random.Range(0, 10) > 3 ? maxIntensity : minIntensity;
                nextFlickerTime = Time.time + Random.Range(0.05f, 0.3f);
            }
        }
        else
        {
            // Smooth pulsing
            targetIntensity = Mathf.Lerp(minIntensity, maxIntensity,
                (Mathf.Sin(Time.time * flickerSpeed) + 1f) / 2f);
        }

        // Smoothly transition to target intensity
        currentIntensity = Mathf.Lerp(currentIntensity, targetIntensity, Time.deltaTime * 10f);

        // Apply glow to material
        if (textMaterial.HasProperty("_GlowPower"))
        {
            textMaterial.SetFloat("_GlowPower", currentIntensity);
        }

        // Also try setting glow color (if your shader supports it)
        if (textMaterial.HasProperty("_GlowColor"))
        {
            textMaterial.SetColor("_GlowColor", glowColor);
        }
    }
}