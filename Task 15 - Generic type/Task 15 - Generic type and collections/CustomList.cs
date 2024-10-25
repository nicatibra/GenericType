namespace Task_15___Generic_type_and_collections
{
    class CustomList<T>
    {
        private T[] _arr;
        private int _count;
        public int _capacity;
        private int Length { get { return _arr.Length; } }

        public T this[int index]
        {
            get
            {
                if (index >= _count || index < 0)
                {
                    Console.WriteLine("Index out of range.");
                }
                return _arr[index];
            }
            set
            {
                if (index < _count && index >= 0)
                {
                    _arr[index] = value;
                }
                else
                {
                    Console.WriteLine("Index out of range.");
                }
            }
        }

        public CustomList(int capacity = 4)
        {
            _arr = new T[capacity];
            _count = 0;
            _capacity = capacity;
        }

        public CustomList(params T[] values)
        {
            _capacity = values.Length;
            _capacity = values.Length > 4 ? values.Length : 4;
            _arr = new T[_capacity];
            Array.Copy(values, _arr, _count);
        }


        private void Capacity(int minCapacity = 0)
        {
            if (minCapacity == 0)
            {
                minCapacity = _count + 1;
            }

            if (minCapacity > _capacity)
            {
                int newCapacity = _capacity * 2;

                if (newCapacity < minCapacity)
                {
                    newCapacity = minCapacity;
                }

                Array.Resize(ref _arr, newCapacity);
                _capacity = newCapacity;
            }
        }

        public void Add(T value)
        {
            Capacity();
            _arr[_count++] = value;
        }

        public void AddRange(params T[] values)
        {
            foreach (T value in values)
            {
                _arr[_count++] = value;
            }

        }

        public void Remove(T value)
        {
            int findIndex = Array.IndexOf(_arr, value, 0, _count);

            if (findIndex != -1)
            {
                Console.WriteLine($"{value} removed from the list.");

                for (int i = findIndex; i < _count - 1; i++)
                {
                    _arr[i] = _arr[i + 1];
                }
                _count--;
                Array.Resize(ref _arr, _count);
            }
            else
            {
                Console.WriteLine($"Cant remove {value} because it is not found in the list.");
            }
        }
        public void RemoveRange(params T[] values)
        {
            foreach (var value in values)
            {
                Remove(value);
            }
        }

        public bool Contains(T value)
        {
            return _arr.Contains(value);
        }

        public T Sum()
        {
            if (typeof(T) == typeof(int))
            {
                int sum = 0;
                for (int i = 0; i < _arr.Length; i++)
                {
                    sum += Convert.ToInt32(_arr[i]);
                }
                return (T)(object)sum;
            }
            else if (typeof(T) == typeof(float))
            {
                float sum = 0;
                for (int i = 0; i < _arr.Length; i++)
                {
                    sum += Convert.ToSingle(_arr[i]);
                }
                return (T)(object)sum;
            }
            else if (typeof(T) == typeof(double))
            {
                double sum = 0;
                for (int i = 0; i < _arr.Length; i++)
                {
                    sum += Convert.ToDouble(_arr[i]);
                }
                return (T)(object)sum;
            }
            else if (typeof(T) == typeof(decimal))
            {
                decimal sum = 0;
                for (int i = 0; i < _arr.Length; i++)
                {
                    sum += Convert.ToDecimal(_arr[i]);
                }
                return (T)(object)sum;
            }
            else
            {
                throw new InvalidOperationException("Sum can not be calculated.");
            }
        }

        public override string ToString()
        {
            string result = string.Join(" ", _arr.Take(_count));
            return result;
        }
    }
}


