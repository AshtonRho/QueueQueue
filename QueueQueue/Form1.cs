using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace QueueQueue
{
    public partial class Form1 : Form
    {
        stackAsObjects stackA = new stackAsObjects();
        stackAsArray stackB = new stackAsArray();
        public Form1()
        {
            InitializeComponent();
        }

        //updates the stack to add the new item
        private void btn_push_Click(object sender, EventArgs e)
        {
            string data = rtb_input.Text;
            bool resultA = stackA.Push(data);
            bool resultB = stackB.Push(data);
            updateStackListsUI();
        }

        // updates the stack by removing the top item 
        private void btn_pop_Click(object sender, EventArgs e)
        {
            string resultA = stackA.Pop();
            string resultB = stackB.Pop();
            rtb_outputA.Text = resultA;
            rtb_outputB.Text = resultB;
            updateStackListsUI();
        }

        //has a look at what the item at the top of the stack is without removing it
        private void btn_peek_Click(object sender, EventArgs e)
        {
            string resultA = stackA.Peek();
            string resultB = stackB.Peek();
            rtb_outputA.Text = resultA;
            rtb_outputB.Text = resultB;
            updateStackListsUI();
        }

        //clears the stack so that theres no items left
        private void updateStackListsUI() {
            lbx_QA.Items.Clear();
            lbx_QB.Items.Clear();
            
            lbx_QA.Items.AddRange(stackA.ToArray());
            lbx_QB.Items.AddRange(stackB.ToArray());

        }

        //outputs a blank message
        private void btn_clearOutput_Click(object sender, EventArgs e)
        {
            rtb_outputA.Text = "";
            rtb_outputB.Text = "";
        }
    }

    //
    public class stackObject
    {
        public string data = "";
        public stackObject last = null;
        public stackObject() {}
        public stackObject(string pData) { data = pData; }
    }

    //sends a error message if the stack is empty
    public class stackAsObjects
    {
        private const string EMPTY_ERROR = "Error: Stack Empty";
        public stackObject top = null;

        //makes the bottom of the stack the top as it was first in so is forst out for a queue 
        public bool Push(string pData)
        {
            stackObject obj = new stackObject();
            obj.data = pData;
            obj.last = top;
            top = obj;
            return true;
        }

        //looks at top item, if it is empty return error message but if not show the item
        public string Peek() {
            if (top == null)
            {
                return EMPTY_ERROR;
            }
            else {
                return top.data;
            }
        }

        //looks at the top item and removes it if its not empty
        public string Pop()
        {
            string data = Peek();
            if (data != EMPTY_ERROR)
            {
                top = top.last;
            }
            return data;
        }

        //
        public string[] ToArray()
        {
            List<string> items = new List<string>();
            stackObject temp = top;
            while (temp != null)
            {
                items.Add(temp.data);
                temp = temp.last;
            }
            return items.ToArray();
        }
    }

    //creates the size limit of an item in the stack and generates what the error message will say
    public class stackAsArray
    {
        private const string EMPTY_ERROR = "Error: Stack Empty";
        private const int SIZE = 15;
        public string[] stack = new string[SIZE];
        public int next = 0;

        //checks the length of the item
        public bool Push(string pData)
        {
            if (next >= SIZE)
            {
                return false; // Full Error
            }
            else
            {
                stack[next] = pData;
                next++;
                return true;
            }
        }

        //looks at the top of the stack
        public string Peek() {
            if (next == 0)
            {
                return EMPTY_ERROR;
            }
            else {
                return stack[next - 1];
            }
        }

        //removes the top item if it is not empty
        public string Pop()
        {
            string data = Peek();
            if (data != EMPTY_ERROR)
            {
                next--;
            }
            return data;
        }
        public string[] ToArray()
        {
            var items = new ArraySegment<string>(stack, 0, next);
            return items.ToArray().Reverse().ToArray();
        }
    }
}
