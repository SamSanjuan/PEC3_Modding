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

            // Calcula la distancia entre tu posición y la posición objetivo
            float currentDistance = Vector3.Distance(actualPos, targetPos.position);

            // Si estás dentro del rango, activa el diálogo
            if (currentDistance < distance)
            {
                Debug.Log("debería salir texto");
                dcc.animator.SetBool("Active", true);
            }
            // Si estás fuera del rango, desactiva el diálogo
            else
            {
                dcc.animator.SetBool("Active", false);
            }

        }
    }

}