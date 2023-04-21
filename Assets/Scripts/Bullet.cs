using UnityEngine;

public class Bullet : MonoBehaviour
{
    public LayerMask EnemyLayer;
    public LayerMask WallLayer;
    
    public static bool Contains(LayerMask mask, int layer)
    {
        return mask == (mask | (1 << layer));
    }

    public void OnTriggerEnter(Collider other)
    {
        if (Contains(EnemyLayer, other.gameObject.layer))
        {
            other.GetComponent<Enemy>().Die();
        }
    }
}
