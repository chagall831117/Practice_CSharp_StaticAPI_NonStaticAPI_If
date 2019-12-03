using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    [Header("血量")]
    public float Hp = 50;

    [Header("攻擊力")]
    public float Atk;

    [Header("玩家")]
    public GameObject player;

    [Header("音源")]
    public AudioSource aud;

    [Header("音效")]
    public AudioClip SoundAtk;

    /// <summary>
    /// 攻擊方法
    /// </summary>
    private void Attack()
    {
        if(Input.GetKeyDown("b"))
        {
            Atk = Random.Range(30f, 50f);
            player.SendMessage("Hurt", Atk);
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
        print("殭屍受到傷害:" + RivalAtk);
        print("殭屍剩餘血量:" + Hp);
    }
    /// <summary>
    /// 死亡方法
    /// </summary>
    private void Death()
    {
        if (Hp <= 0)
        {
            print("殭屍死亡");
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
