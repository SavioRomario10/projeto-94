using System.Diagnostics.Contracts;
using System.Text;

namespace Projeto.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(){}

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        public void AddComent(Comment comment)
        {
            Comments.Add(comment);
        }
        public void AddComent(Comment comment, Comment comment1)
        {
            Comments.Add(comment);
            Comments.Add(comment1);
        }
        public void RemoveComent(Comment comment)
        {
            Comments.Remove(comment);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Coments:");

            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }
    }
}