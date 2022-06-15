using System;

namespace Lab02
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
            if (index >= _objectNum) Console.WriteLine("Element not found");
            else
            {
                for (var i = index; i < _objectNum - 1; i++)
                {
                    _objects[i] = _objects[i + 1];
                }

                _objectNum--;
            }
        }

        public void SortObjectsByPrice()
        {
            Product? temp;
            for (var i = 0; i < _objectNum - 1; i++)
            {
                for (int j = i + 1; j < _objectNum; j++)
                {
                    if (_objects[i]?.price > _objects[j]?.price)
                    {
                        temp = _objects[i];
                        _objects[i] = _objects[j];
                        _objects[j] = temp;
                    }
                }
            }
        }

        private bool CheckArrayAvailableSpace()
        {
            if (_objects.Length <= _objectNum) return false;
            return true;
        }

        private void IncreaseArraySize()
        {
            _arraySize += 5;
            Product[] temp = new Product[_arraySize];

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
    }
}