using Lab06.CustomExceptions;

namespace Lab06.Containers
{
    public class EntitiesContainer : BaseContainer<Product>
    {
        public void SortObjectsByPrice()
        {
            for (var i = 0; i < _objectNum - 1; i++)
            {
                for (int j = i + 1; j < _objectNum; j++)
                {
                    if (_objects[i]?.price > _objects[j]?.price)
                    {
                        (_objects[i], _objects[j]) = (_objects[j], _objects[i]);
                    }
                }
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