using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceAction
{
    internal class Message: IMessage,IPrintable
    {
        public string Text { get; set; }
        public Message(string text) => Text = text;
        public void Print() => Console.WriteLine(Text);
    }
}
