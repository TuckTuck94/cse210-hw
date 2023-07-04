public class Comment
    {
        public string Name { get; set; }
        public string Text { get; set; }

        public Comment(string name, string text)
        {
            this.Name = name;
            this.Text = text;
        }
    }