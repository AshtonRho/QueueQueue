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

        private void btn_push_Click(object sender, EventArgs e)
        {
            string data = rtb_input.Text;
            bool resultA = stackA.Push(data);
            bool resultB = stackB.Push(data);
            updateStackListsUI();
        }

        private void btn_pop_Click(object sender, EventArgs e)
        {
            string resultA = stackA.Pop();
            string resultB = stackB.Pop();
            rtb_outputA.Text = resultA;
            rtb_outputB.Text = resultB;
            updateStackListsUI();
        }

        private void btn_peek_Click(object sender, EventArgs e)
        {
            string resultA = stackA.Peek();
            string resultB = stackB.Peek();
            rtb_outputA.Text = resultA;
            rtb_outputB.Text = resultB;
            updateStackListsUI();
        }

        private void updateStackListsUI() {
            lbx_QA.Items.Clear();
            lbx_QB.Items.Clear();
            
            lbx_QA.Items.AddRange(stackA.ToArray());
            lbx_QB.Items.AddRange(stackB.ToArray());

        }

        private void btn_clearOutput_Click(object sender, EventArgs e)
        {
            rtb_outputA.Text = "";
            rtb_outputB.Text = "";
        }
    }
    public class stackObject
    {
        public string data = "";
        public stackObject last = null;
        public stackObject() {}
        public stackObject(string pData) { data = pData; }
    }
    public class stackAsObjects
    {
        private const string EMPTY_ERROR = "Error: Stack Empty";
        public stackObject top = null;
        public bool Push(string pData)
        {
            stackObject obj = new stackObject();
            obj.data = pData;
            obj.last = top;
            top = obj;
            return true;
        }
        public string Peek() {
            if (top == null)
            {
                return EMPTY_ERROR;
            }
            else {
                return top.data;
            }
        }
        public string Pop()
        {
            string data = Peek();
            if (data != EMPTY_ERROR)
            {
                top = top.last;
            }
            return data;
        }
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
    public class stackAsArray
    {
        private const string EMPTY_ERROR = "Error: Stack Empty";
        private const int SIZE = 15;
        public string[] stack = new string[SIZE];
        public int next = 0;
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
        public string Peek() {
            if (next == 0)
            {
                return EMPTY_ERROR;
            }
            else {
                return stack[next - 1];
            }
        }
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
