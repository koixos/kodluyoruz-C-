namespace ToDo
{
    using System;

    public class Card
    {
        public enum Sizes {XS=1, S, M, L, XL, Null=-1};
        private string? title;
        private string? content;
        private int id;
        private Sizes size;

        public Card(string title="null", string content="null", int id=-1, Sizes size=Sizes.Null)
        {
            this.title = title;
            this.content = content;
            this.id = id;
            this.size = size;
        }
        public Card() {}

        public string Title
        {
            get
            {
                if (this.title == null || this.title == "")
                    return "null";
                return title;
            }
            set { this.title = value; }
        }

        public string Content
        {
            get
            {
                if (this.content == null || this.content == "")
                    return "null";
                return content;
            }
            set { this.content = value; }
        }

        public int Id
        {
            get
            {
                if (this.id < 0)
                    return -1;
                return id;
            }
            set { this.id = value; }
        }

        public Sizes Size
        {
            get { return size; }
            set { this.size = value; }
        }
    }
}