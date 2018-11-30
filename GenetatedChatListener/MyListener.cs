using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetatedChatListener
{
    class MyListener : SpeakBaseListener
    {
        public string line;
        public override void EnterChat([NotNull] SpeakParser.ChatContext context) {
            line += "EnterChat: " + context.line().ToString() + "\r\n";
        }
        public override void ExitChat([NotNull] SpeakParser.ChatContext context) {
            line += "ExitChat: " + context.line().ToString() + "\r\n";
        }
        //public virtual void EnterLine([NotNull] SpeakParser.LineContext context) { }
        //public virtual void ExitLine([NotNull] SpeakParser.LineContext context) { }
        public override void EnterName([NotNull] SpeakParser.NameContext context) {
           // line += "EnterName: " + context.WORD().GetText() + "\r\n";
        }
    }
}
