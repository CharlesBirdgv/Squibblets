using UnityEngine;
using UnityEngine.UI;
public class NPCController : MonoBehaviour {
    public GameObject player; public string instructionText;
    private int interactionDistance = 2;
    void Start() {
        player = GameObject.FindWithTag("Player");
        }
    void Update() {
    float distance = Vector2.Distance(transform.position, player.transform.position);
        if (distance <= interactionDistance) {
        // Display text instructions on screen
        // You can use the UI system in Unity to create a Canvas, Text object, etc.
        // and set its text property to instructionText.
        // Stop player movement
        Rigidbody2D playerRb = player.GetComponent<Rigidbody2D>();
        playerRb.velocity = Vector2.zero;
        playerRb.angularVelocity = Vector2.zero;
        }
    }
}
