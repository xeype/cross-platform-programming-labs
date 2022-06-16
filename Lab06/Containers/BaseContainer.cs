using System;
using Lab06.CustomExceptions;

namespace Lab06.Containers
{
    public class BaseContainer<T>
    {
        protected static int _objectNum;
        private static int _arraySize = 5;
        protected T?[] _objects = new T[_arraySize];

        public void ShowObjects()
        {
            for (var i = 0; i < _objectNum; i++)
            {
                Console.WriteLine(_objects[i]);
            }
        }

        public void AddObject(T obj)
        {
            if (CheckArrayAvailableSpace())
            {
                _objects[_objectNum] = obj;
                _objectNum++;
            }
            else
            {
                IncreaseArraySize();
                AddObject(obj);
            }
        }

        public void RemoveObjectByIndex(int index)
        {
            if (index >= _objectNum) throw new OutOfArrayException(index);

            for (var i = index; i < _objectNum - 1; i++)
            {
                _objects[i] = _objects[i + 1];
            }

            _objectNum--;
        }


        private bool CheckArrayAvailableSpace()
        {
            return _objects.Length > _objectNum;
        }

        private void IncreaseArraySize()
        {
            _arraySize += 5;
            T?[] temp = new T[_arraySize];

            for (var i = 0; i < _objects.Length; i++)
            {
                temp[i] = _objects[i];
            }

            _objects = new T[_arraySize];


            for (var i = 0; i < temp.Length; i++)
            {
                _objects[i] = temp[i];
            }
        }

        public T? this[int ordinalNum]
        {
            get
            {
                if (ordinalNum < _objectNum) return _objects[ordinalNum - 1];
                throw new ProductNotFoundException(ordinalNum);
            }
        }
    }
}