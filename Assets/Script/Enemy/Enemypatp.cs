using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform pointA;    
    public Transform pointB;    
    public float speed = 2f;

    private Transform target;
     private float fixedY;

    void Start()
    {
        if (pointA == null || pointB == null)
        {
            Debug.LogError("PointA または PointB が設定されていません！");
            enabled = false;
            return;
        }
        transform.position = pointA.position;
        target = pointB;
        SetFacingDirection();
        fixedY = transform.position.y;       
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (transform.position == target.position)
        {
            target = (target == pointA) ? pointB : pointA;
            SetFacingDirection();
        }
    }

    void SetFacingDirection()
    {
        Vector3 s = transform.localScale;
        s.x = Mathf.Abs(s.x) * (target.position.x > transform.position.x ? -1 : 1);
        transform.localScale = s;
    }
}
