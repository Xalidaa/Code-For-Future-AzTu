namespace StaticClassExample
{
    class Group
    {
        public Student[] _students;
        public string Name { get; set; }

        public Student this[int index]
        {
            get { return _students[index]; }
        }

        // indexi sadece int kimi yox string kimi de gondermek olur(her hansi bir soz meselen fin)
        public Student this[string fin]
        {
            get 
            { 
                for (int i =0;i < _students.Length;i++)
                {
                    if (_students[i].Fin == fin)
                    {
                        return _students[i];
                    }
                }
                return null;
            }
        }
    }
}
