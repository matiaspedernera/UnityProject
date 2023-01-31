using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditorInternal.VersionControl.ListControl;

public class VersatilEnemy : MonoBehaviour
{
    public enum EnemyTypes
    {
        Looker,
        Chaser
    }
    [SerializeField] private EnemyTypes EnemyType;
    [SerializeField] private Transform characterTransform;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetBehaviour();
    }

    public void SetBehaviour()
    {
        switch(EnemyType)
        {
            case EnemyTypes.Looker:
            transform.LookAt(characterTransform);
            break;
            case EnemyTypes.Chaser:
            transform.LookAt(characterTransform);
            var characterVector = characterTransform.position - transform.position;
            if (characterVector.magnitude > 2)
              {
                transform.position = Vector3.MoveTowards(transform.position, characterTransform.position, Time.deltaTime * speed);
              }
            break;
        }
    }
}
