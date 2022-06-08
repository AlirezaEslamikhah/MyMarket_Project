namespace P9.Shared
{
    public class Clothe
    {
        public int Price {get; set;}
        public string Name{get; set;}
        public int Id {get; set;}
        public string Color {get; set;}
        public string picture{get;set;}
        public int count{get;set;}
        public int number;
        
        public override string ToString()
        {
            return $"{this.Name}, {this.Price}, {this.Id}, {this.Color}";
        }
        public override bool Equals(object obj)
        {
            var other = obj as Clothe;
            return (ReferenceEquals(other, null) ? false : other.Id == this.Id);
        }
        public override int GetHashCode()
        {
            return this.Id;
        }
    }
}