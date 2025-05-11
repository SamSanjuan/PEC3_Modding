using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit3D {
    public class ActiveDialogueTrigger : MonoBehaviour
    {
        public DialogueCanvasController dcc;
        public Transform targetPos;
        public float distance;

        private void Update()
        {
            Vector3 actualPos = transform.position;

            // Calcula la distancia entre tu posici�n y la posici�n objetivo
            float currentDistance = Vector3.Distance(actualPos, targetPos.position);

            // Si est�s dentro del rango, activa el di�logo
            if (currentDistance < distance)
            {
                Debug.Log("deber�a salir texto");
                dcc.animator.SetBool("Active", true);
            }
            // Si est�s fuera del rango, desactiva el di�logo
            else
            {
                dcc.animator.SetBool("Active", false);
            }

        }
    }

}