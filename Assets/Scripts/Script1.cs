using UnityEngine;

public class Script1 : MonoBehaviour
{
    [SerializeField] private string characterName;
    public int speed;
    private double life;
    public Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        life = 100.0;
        DamageCharacter(50.0);
        HealCharacter(20.5);
        Debug.Log("La vida de tu personaje es de: " + life);
    }

    // Update is called once per frame
    void Update()
    {
        MoveAtCertainSpeed(speed);
    }

    public void MoveAtCertainSpeed(int speed)
    {
        transform.position = transform.position + movement * speed;
    }

    public void HealCharacter(double lifeHealed)
    {
        life += lifeHealed;
    }

    public void DamageCharacter(double damageDone)
    {
        life -= damageDone;
    }
}
