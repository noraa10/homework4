using System;

// Node class for Singly Linked List
public class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

public class SinglyLinkedList
{
    private Node head;

    // 1. Write a C# program to create and display a Singly Linked List.
    public void CreateAndDisplayList()
    {
        head = new Node(1);
        Node second = new Node(2);
        Node third = new Node(3);

        head.Next = second;
        second.Next = third;

        Console.WriteLine("Singly Linked List:");
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }

    // 2. Write a C# program to create a singly linked list of n nodes and display it in reverse order.
    public void CreateAndDisplayListInReverseOrder(int n)
    {
        head = null;
        for (int i = n; i > 0; i--)
        {
            Node newNode = new Node(i);
            newNode.Next = head;
            head = newNode;
        }

        Console.WriteLine("Singly Linked List in Reverse Order:");
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }

    // 3. Write a C# program to create a singly linked list of n nodes and count the number of nodes.
    public int CreateAndCountNodes(int n)
    {
        head = null;
        for (int i = 1; i <= n; i++)
        {
            Node newNode = new Node(i);
            newNode.Next = head;
            head = newNode;
        }

        int count = 0;
        Node current = head;
        while (current != null)
        {
            count++;
            current = current.Next;
        }

        return count;
    }

    // 4. Write a C# program to insert a node at any position in a Singly Linked List.
    public void InsertNodeAtPosition(int data, int position)
    {
        Node newNode = new Node(data);
        if (position == 1)
        {
            newNode.Next = head;
            head = newNode;
            return;
        }

        Node current = head;
        for (int i = 1; i < position - 1 && current != null; i++)
        {
            current = current.Next;
        }

        if (current == null)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        newNode.Next = current.Next;
        current.Next = newNode;
    }

    // 5. Write a C# program to insert a node at the beginning of a Singly Linked List.
    public void InsertNodeAtBeginning(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;
    }

    // 6. Write a C# program to insert a node at the end of a Singly Linked List.
    public void InsertNodeAtEnd(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }

        Node current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode;
    }

    // 7. Write a C# program to get a node in an existing singly linked list.
    public Node GetNode(int index)
    {
        Node current = head;
        int currentIndex = 0;
        while (current != null)
        {
            if (currentIndex == index)
            {
                return current;
            }
            current = current.Next;
            currentIndex++;
        }
        return null;
    }

    // 8. Write a C# program to find the first index that matches a given element. Return -1 for no matching.
    public int FindFirstIndex(int element)
    {
        Node current = head;
        int index = 0;
        while (current != null)
        {
            if (current.Data == element)
            {
                return index;
            }
            current = current.Next;
            index++;
        }
        return -1;
    }

    // 9. Write a C# program to check whether a single linked list is empty or not. Return true otherwise false.
    public bool IsListEmpty()
    {
        return head == null;
    }

    // 10. Write a C# program to empty a singly linked list by pointing the head towards null.
    public void EmptyList()
    {
        head = null;
    }
    // 11. Remove node at specified index
    public void RemoveNodeAtIndex(int index)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        if (index == 0)
        {
            head = head.Next;
            return;
        }

        Node current = head;
        for (int i = 0; i < index - 1 && current.Next != null; i++)
        {
            current = current.Next;
        }

        if (current.Next == null)
        {
            Console.WriteLine("Invalid index.");
            return;
        }

        Node nodeToRemove = current.Next;
        current.Next = current.Next.Next;
        nodeToRemove = null;
    }



    // 12. Calculate the size of a Singly Linked list
    public int CalculateListSize()
    {
        int size = 0;
        Node current = head;

        while (current != null)
        {
            size++;
            current = current.Next;
        }

        return size;
    }


    // 13. Remove the first element from a Singly Linked list
    public void RemoveFirstElement()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        Node nodeToRemove = head;
        head = head.Next;
        nodeToRemove = null;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        SinglyLinkedList list = new SinglyLinkedList();

        // 1. Create and display a Singly Linked List
        list.CreateAndDisplayList();

        // 2. Create a singly linked list of n nodes and display it in reverse order
        list.CreateAndDisplayListInReverseOrder(5);

        // 3. Create a singly linked list of n nodes and count the number of nodes
        int nodeCount = list.CreateAndCountNodes(7);
        Console.WriteLine($"Number of nodes: {nodeCount}");

        // 4. Insert a node at any position in a Singly Linked List
        list.InsertNodeAtPosition(100, 3);
        list.CreateAndDisplayList();

        // 5. Insert a node at the beginning of a Singly Linked List
        list.InsertNodeAtBeginning(0);
        list.CreateAndDisplayList();

        // 6. Insert a node at the end of a Singly Linked List
        list.InsertNodeAtEnd(200);
        list.CreateAndDisplayList();

        // 7. Get a node in an existing singly linked list
        Node node = list.GetNode(3);
        Console.WriteLine($"Node at index 3: {node?.Data}");

        // 8. Find the first index that matches a given element
        int index = list.FindFirstIndex(100);
        Console.WriteLine($"First index of 100: {index}");

        // 9. Check if the list is empty
        bool isEmpty = list.IsListEmpty();
        Console.WriteLine($"Is the list empty? {isEmpty}");

        // 10. Empty the singly linked list
        list.EmptyList();
        isEmpty = list.IsListEmpty();
        Console.WriteLine($"Is the list empty? {isEmpty}");


        // Remove node at index 2
        list.RemoveNodeAtIndex(2);
        list.CreateAndDisplayList();

        // Calculate the size of the list
        int listSize = list.CalculateListSize();
        Console.WriteLine($"List size: {listSize}");

        // Remove the first element
        list.RemoveFirstElement();
        list.CreateAndDisplayList();


    }
}