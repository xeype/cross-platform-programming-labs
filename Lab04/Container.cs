using System;
using Lab04.CustomExceptions;

namespace Lab04
{
    public class Container
    {
        private static int _objectNum;
        private static int _arraySize = 5;
        private Product?[] _objects = new Product?[_arraySize];


        public void ShowObjects()
        {
            for (var i = 0; i < _objectNum; i++)
            {
                Console.WriteLine(_objects[i]);
            }
        }

        public void AddObject(Product obj)
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

        public void SortObjectsByPrice()
        {
            for (var i = 0; i < _objectNum - 1; i++)
            {
                for (var j = i + 1; j < _objectNum; j++)
                {
                    if (!(_objects[i]?.price > _objects[j]?.price)) continue;
                    (_objects[i], _objects[j]) = (_objects[j], _objects[i]);
                }
            }
        }

        private bool CheckArrayAvailableSpace()
        {
            return _objects.Length > _objectNum;
        }

        private void IncreaseArraySize()
        {
            _arraySize += 5;
            Product?[] temp = new Product[_arraySize];

            for (var i = 0; i < _objects.Length; i++)
            {
                temp[i] = _objects[i];
            }

            _objects = new Product[_arraySize];


            for (var i = 0; i < temp.Length; i++)
            {
                _objects[i] = temp[i];
            }
        }

        public Product? this[int ordinalNum]
        {
            get
            {
                if (ordinalNum < _objectNum) return _objects[ordinalNum - 1];
                throw new ProductNotFoundException(ordinalNum);
            }
        }

        public Product? this[string name]
        {
            get
            {
                for (var i = 0; i < _objectNum; i++)
                {
                    if (_objects[i]?.name == name) return _objects[i];
                }

                throw new ProductNotFoundException(name);
            }
        }

        public Product? this[decimal price]
        {
            get
            {
                for (var i = 0; i < _objectNum; i++)
                {
                    if (_objects[i]?.price == price) return _objects[i];
                }

                throw new ProductNotFoundException(price);
            }
        }
    }
}