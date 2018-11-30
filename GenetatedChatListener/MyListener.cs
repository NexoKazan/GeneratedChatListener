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
            line += "EnterChat: " + context.GetText() + "\r\n";
        }
        public override void ExitChat([NotNull] SpeakParser.ChatContext context) {
            line += "ExitChat: " + context.GetText() + "\r\n";
        }
        public override void EnterLine([NotNull] SpeakParser.LineContext context) {
            line += "EnterLine: " + context.GetText() + "\r\n";
        }
        public override void ExitLine([NotNull] SpeakParser.LineContext context) {
            line += "ExitLine: " + context.GetText() + "\r\n";
        }
        public override void EnterName([NotNull] SpeakParser.NameContext context) {
            line += "EnterName: " + context.WORD().GetText() + "\r\n";
        }
        public override void ExitName([NotNull] SpeakParser.NameContext context)
        {
            line += "ExitName: " + context.GetText() + "\r\n";
        }
    }
}
