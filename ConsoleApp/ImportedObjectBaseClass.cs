namespace ConsoleApp
{
    internal class ImportedObjectBaseClass
    {
        private string _type;
        private string _parentType;
        public string Name { get; set; }
        public string Type
        {
            get => _type.ToUpper();
            set => _type = value;
        }

        public string ParentType
        {
            get => _parentType.ToUpper();
            set => _parentType = value;
        }
    }
}