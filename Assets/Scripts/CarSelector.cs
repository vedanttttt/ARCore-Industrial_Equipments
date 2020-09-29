using UnityEngine;
using System.Collections;

public class CarSelector : MonoBehaviour
{

    public GameObject Car1;
    public GameObject Car2;
    public GameObject Car3;
    public int BallSelected;

    // Use this for initialization
    void Start()
    {
        Car2.SetActive(false);
        Car3.SetActive(false);

    }

    public void LoadCar1()
    {
        Car1.SetActive(true);
        Car2.SetActive(false);
        Car3.SetActive(false);
    }

    public void LoadCar2()
    {
        Car1.SetActive(false);
        Car2.SetActive(true);
        Car3.SetActive(false);
    }

    public void LoadCar3()
    {
        Car1.SetActive(false);
        Car2.SetActive(false);
        Car3.SetActive(true);
    }

}
