using UnityEngine;

public class Axe : MonoBehaviour
{
    public LayerMask EnemyLayer;
    public static bool Contains(LayerMask mask, int layer)
    {
        return mask == (mask | (1 << layer));
    }
    
    public void OnTriggerEnter(Collider other)
    {
        if (Contains(EnemyLayer, other.gameObject.layer))
        {
            if (other.GetComponent<Enemy>() != null)
                other.GetComponent<Enemy>().TakeDamage();
        }
    }
}
