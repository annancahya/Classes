using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowtoProgram7 : MonoBehaviour
{
    Player warrior;
    Player archer;

    void Start()
    {
        warrior = new Player(1, 2, "Annan");
        archer = new Player(1, 2, "Manca");
    }

  
}
