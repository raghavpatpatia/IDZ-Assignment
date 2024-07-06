using UnityEngine;

[CreateAssetMenu(fileName = "TileSO", menuName = "ScriptableObjects/Tile/TileSO")]
public class TileSO : ScriptableObject
{
    public GameObject HighlightPrefab;
    public GameObject CaptureHighlightPrefab;
}