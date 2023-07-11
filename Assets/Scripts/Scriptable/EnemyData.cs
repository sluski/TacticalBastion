using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Characters/Enemy")]
public class EnemyData : ScriptableObject {

    public new string name;
    public int health;
    public int damage;
    public float speed;

    public GameObject myGameObject;

}


