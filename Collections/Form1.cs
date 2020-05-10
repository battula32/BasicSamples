using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Collections
{
    public partial class Form1 : Form
    {
        Hashtable hashTable = new Hashtable();
        IList<string> lst = new List<string>();
        IDictionary<Guid, string> dict = new Dictionary<Guid, string>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                this.hashTable.Add(Guid.NewGuid(), i.ToString());
                lst.Add(i.ToString());
                this.dict.Add(Guid.NewGuid(), i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //IDictionaryEnumerator id = this.hashTable.GetEnumerator();
            //int l = 0;
            //while (id.MoveNext())
            //{
            //    if (l == 5)
            //    {
                    
            //    }

            //    MessageBox.Show(id.Key.ToString(), id.Value.ToString());
            //    l++;
            //}
            int i;
            int l = 0;
            IEnumerator ie = lst.GetEnumerator();
            while (ie.MoveNext())
            {
                if (l == 5)
                {
                    lst.Insert(5, Guid.NewGuid().ToString());
                    ie = lst.GetEnumerator();
                    ie.Reset();
                }

                MessageBox.Show(lst[l], lst.IndexOf(lst[l]).ToString());
                if (l >= lst.Count - 1)
                {
                    l = 0;
                }

                l++;
            }
        }
    }
}
