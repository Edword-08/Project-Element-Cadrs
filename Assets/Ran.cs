using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        // «десь реализуем логику перемещени€ карты в €чейку
        GameManager.instance.MoveCardToCell(this.gameObject);
    }
}

public class Cell : MonoBehaviour
{
    public bool isOccupied = false;
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public List<GameObject> cards;
    public List<Cell> cells;

    private void Awake()
    {
        instance = this;
    }

    public void MoveCardToCell(GameObject card)
    {
        // Ќаходим ближайшую свободную €чейку
        Cell closestCell = FindClosestFreeCell(card.transform.position);
        if (closestCell != null)
        {
            card.transform.position = closestCell.transform.position;
            closestCell.isOccupied = true;
        }
    }

    private Cell FindClosestFreeCell(Vector3 cardPosition)
    {
        // –еализаци€ поиска ближайшей свободной €чейки
        // Ќапример, можно использовать алгоритм A* или просто перебирать все €чейки
        // и выбирать ближайшую свободную
    }
}