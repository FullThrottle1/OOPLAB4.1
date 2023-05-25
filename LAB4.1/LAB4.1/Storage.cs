
namespace LAB4._1
{
    class Storage
    {
        private CCircle[] arr;
        private int size;

        public Storage(int size)
        {

            arr = new CCircle[size];
            this.size = size;
        }
        ~Storage()
        {

        }
        public int getCount()
        {
            return size;
        }
        public void setObject(int index, CCircle o)
        {
            if (index < size && index >= 0 && arr[index] == null)
                arr[index] = o;
            else if (index >= 0)
            {

                CCircle[] temp = new CCircle[size + 1];
                for (int i = 0; i < size; i++)
                {
                    temp[i] = arr[i];

                }
                temp[size] = o;
                size++;
                arr = temp;

            }
        }
        public void setObject(CCircle o)
        {
            bool found = false;
            for (int i = 0; i < getCount(); i++)
            {
                if (arr[i] == null)
                {
                    arr[i] = o;
                    found = true;
                    break;


                }
            }
            if (found == false)
            {
                CCircle[] temp = new CCircle[size + 1];
                for (int i = 0; i < size; i++)
                {
                    temp[i] = arr[i];

                }
                temp[size] = o;
                size++;
                arr = temp;
            }
        }
        public CCircle getObject(int index)
        {
            return arr[index];
        }

        public void deleteObject(int index)
        {
            if (index < size)
            {
                CCircle[] temp = new CCircle[size - 1];
                for (int i = 0; i < index; i++)
                {
                    temp[i] = arr[i];
                }
                size--;
                for (int i = index; i < size; i++)
                {
                    temp[i] = arr[i + 1];
                }

                arr = temp;
            }
        }
        public int countRealObjects()
        {
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] != null)
                    count++;
            }
            return count;
        }
        public CCircle takeOutObject(int index)
        {

            if (index < size)
            {
                CCircle o = arr[index];
                CCircle[] temp = new CCircle[size - 1];
                for (int i = 0; i < index; i++)
                {
                    temp[i] = arr[i];
                }
                size--;
                for (int i = index; i < size; i++)
                {
                    temp[i] = arr[i + 1];
                }

                arr = temp;
                return o;
            }
            else return null;

        }
    }
}
