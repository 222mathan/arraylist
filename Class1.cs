using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class ArrayList
    {
        int[] _array;
        int _current = 0;
        int _capacity;

        //constructor
        public ArrayList(int size = 2)
        {
            _array = new int[size];
        }

        public int Current
        {
            get
            {
                return _current;
            }

        }
        public int Capacity
        {
            get
            {
                return _array.Length; ;
            }

        }
        bool _isempty = true;
        public bool Isempty
        {
            get
            {
                if (_current > 0)
                {
                    _isempty = false;
                }
                return _isempty;
            }
        }
        //get()
        public int get(int index)
        {
            return _array[index];
        }
        //set()
        public void set(int index, int value)
        {
            _array[index] = value;
        }

        //resize()
        private void resize()
        {
            int[] newarray = new int[_array.Length * 2];
            for (int i = 0; i < _array.Length; i++)
            {
                newarray[i] = _array[i];
            }
            _array = newarray;
        }
        //add()
        private void add(int value)
        {
            if (_capacity == _current + 1)
            {
                resize();
            }
            _array[_current] = value;
            _current++;
        }
        //contains()
        private bool contain(int value)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == value)
                {
                    return true;
                }
                
            }
            return false;
        }
        //remove()
        public void remove()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = _array[i + 1];
            }
            _current--;
        }
      
        //insert
        public void insert(int index, int value)
        {
            if (_capacity == _current + 1)
            {
                resize();
            }
            int temp1 = 0;
            int temp2 = 0;
            for (int i = index; i < _array.Length; i++)
            {
                if (i == index)
                {
                    temp1 = _array[i];
                    _array[i] = temp1;
                }
                if (i > index)
                {
                    temp1 = _array[i];
                    _array[i] = temp2;
                    temp2 = temp1;
                }
            }
            _current++;
        }

        //print()
        public void print(int[] array)
        {
            for(int i=0;i<_array.Length;i++)
            {
                Console.WriteLine(_array[i]+"\t");
            }
            Console.WriteLine();
        }
    }
}
