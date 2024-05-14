using UnityEngine;

[CreateAssetMenu(fileName ="MKRoad", menuName ="ScriptableObjects/MKRoad/New MKRoad")]
public class MKRoad : ScriptableObject
{
    public int id;
    public string roadName;
    public Texture2D image;
    public Texture2D cupImg;
    public bool isFromDLC;
}
