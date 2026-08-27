using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private MeshRenderer rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        rb.material.color = Color.red;

        Player player = collision.gameObject.GetComponent<Player>();
        if (player != null)
            return;
        
            player.Hp -= 15; 
        UIManager.Instance.ShowNotiText($"Hurt-15\nHP: {player.Hp}");

        if (player.Hp <= 0)
        {
            player.Hp = 0;
            UIManager.Instance.ShowNotiText($"You are dead!!!!\nPoints: {player.Point}");
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        rb.material.color = new Color32(160, 82, 45, 255); 
    }
}
