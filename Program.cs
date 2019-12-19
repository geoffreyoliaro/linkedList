using System;

namespace TechnoBrainInterview
{
    using System; 
      
public class LinkedList 
{ 
    Node head; // head of list 
  
    /* Linked list Node*/
    class Node 
    { 
        public string data; 
        public Node next; 
        public Node(string d)  
        { 
            data = d; next = null; 
        } 
    } 
  
    void removeDuplicates() 
    { 
        /*Another reference to head*/
        Node current = head; 
  
        /* Pointer to store the next  
        pointer of a node to be deleted*/
        Node next_next; 
  
        /* do nothing if the list is empty */
        if (head == null)  
            return; 
  
        /* Traverse list till the last node */
        while (current.next != null)  
        { 
  
            /*Compare current node with the next node */
            if (current.data == current.next.data)  
            { 
                next_next = current.next.next; 
                current.next = null; 
                current.next = next_next; 
            } 
            else // advance if no deletion 
                current = current.next; 
        } 
    } 
                      
    /* Utility functions */
  
    /* Inserts a new Node at front of the list. */
    public void push(string new_data) 
    { 
        /* 1 & 2: Allocate the Node & 
                Put in the data*/
        Node new_node = new Node(new_data); 
  
        /* 3. Make next of new Node as head */
        new_node.next = head; 
  
        /* 4. Move the head to point to new Node */
        head = new_node; 
    } 
  
    /* Function to print linked list */
    void printList() 
    { 
        Node temp = head; 
        while (temp != null) 
        { 
            Console.Write(temp.data+" "); 
            temp = temp.next; 
        }  
        Console.WriteLine(); 
    } 
   
    class Program
    {


        static void Main(string[] args)
        {
             LinkedList llist = new LinkedList(); 
        llist.push("A");
        llist.push("B");
        llist.push("B"); 
        llist.push("C"); 
        llist.push("C"); 
        llist.push("D"); 

        // llist.push(13); 
        // llist.push(13); 
        // llist.push(11); 
        // llist.push(11); 
        // llist.push(11);
        // llist.push(15);
        // llist.push(17); 
          
        Console.WriteLine("List before removal of duplicates"); 
        llist.printList(); 
          
        llist.removeDuplicates(); 
          
        Console.WriteLine("List after removal of elements"); 
        llist.printList();
            

    }
}
}
}