using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTextBox : MonoBehaviour
{
    [SerializeField]
    Text dialog;
    [SerializeField]
    string message;

    IEnumerator animateText;
    [SerializeField, Range(0.01f, 4f)]
    float animationSpeed = 1;

    public string Message { get => message; set => message = value; }

    public void ShowDialog()
    {
        animateText = Animate(animationSpeed);
        StartCoroutine(animateText);
    }

    public void ClearText()
    {
        dialog.text = "";
    }

    IEnumerator Animate(float time)
    {
        for(int i=0; i < message.Length; i++) {
            dialog.text += message[i];
            yield return new WaitForSeconds(time);
        }
    }
}
