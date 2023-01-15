using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class move : MonoBehaviour
{
    public float MoveSpeed;
    //public TextMeshPro ScoreText;
    public AudioSource tickSource;
    private int score = 0;
    //private TextMeshPro score1 ;
    public Animator boyAnimator;
    // Start is called before the first frame update
    void Start()
    {
        tickSource = GetComponent<AudioSource>();
        //score1 = GameObject.Find("Score").GetComponent<TextMeshPro>();
    }
    private void OnTriggerEnter(Collider other)
    {
        //score++;
        Debug.Log(other.gameObject);
        //if (score == 4)
        if (other.gameObject.tag == "pass")
        {
            tickSource.Play();
            SceneManager.LoadScene("s2");
        }
        if (other.gameObject.tag == "pass2")
        {
            tickSource.Play();
            SceneManager.LoadScene("s3");
        }
        if (other.gameObject.tag == "pass3")
        {
            boyAnimator.SetBool("show", true);
            StartCoroutine(DestoryMyself());
            
        }
        if (other.gameObject.tag == "fruit")
        {
            Destroy(other.gameObject);
            tickSource.Play();
            GameScore.Instance.AddScore(score);
            //score++;
            //ScoreText.text = score.ToString();
            
            //score1.text = score.ToString();
        }
    }

    IEnumerator DestoryMyself()
    {
        
        yield return new WaitForSeconds(5);
        //Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(0, 0, MoveSpeed);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(0, 0, -MoveSpeed);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(-MoveSpeed, 0, 0);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(MoveSpeed, 0, 0);

    }
}
