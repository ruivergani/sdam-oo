using System;

namespace StackExample
{
    public class Message
    {
        public string PersonName { get; }
        public string Text { get; }
        public DateTime Date { get; }

        public Message(string personName, string text, DateTime date)
        {
            PersonName = personName;
            Text = text;
            Date = date;
        }

        public override string ToString() // override the method which comes from System
        {
            return
                String.Format(
                    "{0}\nDear {1},\n{2}\n",
                    Date.ToString("dd/MM/yyyy"),
                    PersonName,
                    Text);
        }
    }
}
