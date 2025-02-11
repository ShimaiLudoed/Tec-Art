using UnityEngine;
using UnityEngine.Animations.Rigging;

public class IKInteraction : MonoBehaviour
{
    [SerializeField] private float interactionRange = 3f; // Радиус для активации взаимодействия
    [SerializeField] private RigBuilder rigBuilder; // Компонент RigBuilder
    [SerializeField] private Transform interactiveObject; // Ссылка на интерактивный объект

    private bool isInRange = false;

    void Update()
    {
        // Проверяем, находится ли персонаж в радиусе интерактивного объекта
        float distance = Vector3.Distance(transform.position, interactiveObject.position);

        if (distance <= interactionRange && !isInRange)
        {
            // Включаем RigBuilder, если персонаж в пределах радиуса
            rigBuilder.enabled = true;
            isInRange = true;
        }
        else if (distance > interactionRange && isInRange)
        {
            // Выключаем RigBuilder, если персонаж удалился от объекта
            rigBuilder.enabled = false;
            isInRange = false;
        }

        // Логика для анимации тянущейся руки
        if (isInRange)
        {
            // Ваш код для анимации или IK взаимодействия с объектом
        }
    }
}