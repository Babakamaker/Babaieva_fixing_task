using UnityEngine;
using DG.Tweening;

public class CubeController : MonoBehaviour
{
    [Header("Rotation Settings")]
    [SerializeField] private float rotationDuration = 1f;
    [SerializeField] private Ease rotationEase = Ease.InOutElastic;

    [Header("Scale Settings")]
    [SerializeField] private float punchScaleDuration = 0.5f;
    [SerializeField] private Vector3 punchScaleStrength = new Vector3(1, 1, 1);
    [SerializeField] private int punchScaleVibrato = 5;
    [SerializeField] private float punchScaleElasticity = 1f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log($"<color=yellow>Key:</color> <color=cyan>1</color> - <color=green>Rotating cube</color>");
            RotateCube();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log($"<color=yellow>Key:</color> <color=cyan>2</color> - <color=green>Punch scale animation</color>");
            PunchScaleCube();
        }
    }

    private void RotateCube()
    {
        transform.DORotate(new Vector3(0, 360, 0), rotationDuration, RotateMode.FastBeyond360)
                .SetEase(rotationEase);
    }

    private void PunchScaleCube()
    {
        transform.DOPunchScale(punchScaleStrength, punchScaleDuration, punchScaleVibrato, punchScaleElasticity);
    }
}
