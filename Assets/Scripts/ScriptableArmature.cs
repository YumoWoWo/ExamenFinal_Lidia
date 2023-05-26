using UnityEngine;

[CreateAssetMenu(fileName = "New Armature", menuName = "Armature/New Armature")]
public class ScriptableArmature : ScriptableObject
{
    public string armatureName;
    public string armatureDescription;
    public Sprite armatureSprite;
    public float armatureDefense;
    public float armatureMagicDefense;
    public string armaturePrice;
}
