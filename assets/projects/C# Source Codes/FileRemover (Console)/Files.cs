namespace FileRemover
{
    class Files
    {
        //File's info
        private string LastUseDate;
        private int Count;
        private static int Quantity;

        // Encapsulation
        public string GetLastUseDate
        {
            set
            {
                if (value == "15")
                {
                    Count++;
                    this.LastUseDate = value;
                }
            }
            get
            {
                return this.LastUseDate;
            }
        }
        public int GetCount
        {
            set
            {
                this.Count = value;
            }
            get
            {
                return this.Count;
            }
        }
        public static int GetQuantity()
        {
            return Quantity;
        }
        public void AddQuantity()
        {
            Quantity++;
        }
    }
}
