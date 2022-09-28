
    class Functions : Word
    {
        public string Palidrome;
        public string input;
        public int length;
        public string Reverse;
        public string Palind(String item)
        {
            length = item.Length;
            for (int i = length - 1; i >= 0; i--)
            {
                Reverse += item[i].ToString();
            }
            if (Reverse == item)
            {
                Palidrome = "Is a Palindrome";
            }
            else
            {
                Palidrome = "Not a Palindrome";
            }
            return Palidrome;

        }

        public string oddOrEven(String str)
        {
            length = str.Length;
            if (length % 2 == 0)
            {
                str = "even";
            }
            else
            {
                str = "odd";
            }
            return str;
        }

        public string primeNum(int num)
        {
            int pr = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                pr++;
                }
            }
            if (pr == 2)
            {
                return "prime";
            }
            else
            {
                return "not prime";
            }
        }

    public string Palind()
    {
        throw new NotImplementedException();
    }

    public string oddOrEven()
    {
        throw new NotImplementedException();
    }

    public string primeNum()
    {
        throw new NotImplementedException();
    }
}

