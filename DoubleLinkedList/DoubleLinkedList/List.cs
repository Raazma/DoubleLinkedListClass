using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class List
    {
        Node First_ = null;
        Node Last_ = null;
   
/// <summary>
/// ///////GEGI GEGI the list///////////////////////////////////////////////////////
/// </summary>
        public List()
        { 
        
        }
        public void AddNew(String name,String description,long id)
        {
            if (First_ == null)
            {
                First_ = new Node(name, description, id);
                Last_ = First_;         
            }
            else
            {
                Node New = new Node(name, description, id , Last_);              
                Last_ = New;              
            }
        }
        public void RemoveFirst()
        {
            if (First_ == Last_)           
                  First_ = null;                       
            else
            {
                First_.GetNext().SetPrevious(null);
                First_ = First_.GetNext();
            }
        }
        public object[] Get(int index)
        {
            Node info = First_;

            for (int i = 1; i < index; i++)           
                 if ((info = info.GetNext()) != null) { }
                              
            return new object[] { info.GetName(), info.GetDescript(), info.GetID() };
        }
        public void RemoveAt(int index)
        {
            Node delete = First_;

            for (int i = 1; i < index; i++)            
                 if ((delete = delete.GetNext()) != null) { }


            if (delete == Last_)
            {
                delete.GetPrevious().SetNext(null);
                Last_ = delete.GetPrevious();
                delete = null;
            }
            else if (delete == First_)
            { 
                delete.GetNext().SetPrevious(null);
                First_ = delete.GetNext();
                delete = null;
            }
            else if (delete == Last_ && delete == First_)
            {
                First_ = null;
                Last_ = null;
                delete = null;
            }
            else
            {
                delete.GetNext().GetPrevious().SetPrevious(delete.GetPrevious());
                delete.GetPrevious().SetNext(delete.GetNext());
                delete = null;
            }                       
        }
    }
    /// <summary>
    /// ///////////////////Much Fun Node/////////////////////////////////////////
    /// </summary>
    class Node
    {
        private String Name_;
        private String Descrip_;
        private long ID_;

        private Node Next_ = null;
        private  Node Previous_ = null;
        public Node(String name, String descrip ,long id)
        {
            Name_ = name;
            Descrip_ = descrip;
            ID_ = id;
        }
        public Node(String name, String descrip, long id , Node previous)
        {
            Name_ = name;
            Descrip_ = descrip;
            ID_ = id;
            this.SetPrevious(previous);
            previous.SetNext(this);
        }
        public void  SetNext(Node next)
        {
            Next_ = next;
        }
        public Node GetNext()
        {
            return Next_;
        }
        public void SetPrevious(Node previous)
        {
            Previous_ = previous;
        }
        public Node GetPrevious()
        {
            return Previous_;
        }
        public String GetName()
        {
            return Name_;
        }
        public void SetName(String name)
        {
            Name_ = name;
        }
        public String GetDescript()
        {        
         return Descrip_;
        }
        public void SetDecript(String descrip)
        {
            Descrip_ = descrip;
        }
        public long GetID()
        {
            return ID_;
        }
        public void SetId(long id)
        {
            ID_ = id;
        }
    }
}
