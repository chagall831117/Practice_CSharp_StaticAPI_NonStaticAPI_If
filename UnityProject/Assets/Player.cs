using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("血量")]
    public float Hp = 100;

    [Header("攻擊力")]
    public float Atk;

    [Header("殭屍")]
    public GameObject Zb;

    [Header("音源")]
    public AudioSource aud;

    [Header("音效")]
    public AudioClip SoundAtk;

    /// <summary>
    /// 攻擊方法
    /// </summary>
    private void Attack()
    {
        if (Input.GetKeyDown("a"))
        {
            Atk = Random.Range(10f, 30f);
            Zb.SendMessage("Hurt", Atk);
            aud.clip = SoundAtk;
            aud.Play();
        }
    }
    /// <summary>
    /// 受傷方法
    /// </summary>
    private void Hurt(float RivalAtk)
    {
        Hp = Hp - RivalAtk;
        print("玩家受到傷害:" + RivalAtk);
        print("玩家剩餘血量:" + Hp);
    }
    /// <summary>
    /// 死亡方法
    /// </summary>
    private void Death()
    {
        if (Hp <= 0)
        {
            print("玩家死亡");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        Death();
    }
}
