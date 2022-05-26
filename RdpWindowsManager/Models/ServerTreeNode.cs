using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace RdpWindowsManager.Models
{
   [Serializable]
   public class ServerTreeNode : TreeNode
   {
      public string Host { get; set; }
      public int Port { get; set; }
      public string Username { get; set; }
      public string Password { get; set; }

      public ServerTreeNode()
      { }

      public ServerTreeNode(string text)
      {
         Text = text;
      }

      protected ServerTreeNode(SerializationInfo si, StreamingContext context) : base(si, context)
      {
         Host = si.GetString("Host");
         Username = si.GetString("Username");
         Password = si.GetString("Password");
         Port = si.GetInt32("Port");
      }

      protected override void Serialize(SerializationInfo si, StreamingContext context)
      {
         base.Serialize(si, context);
         si.AddValue("Host", Host);
         si.AddValue("Username", Username);
         si.AddValue("Password", Password);
         si.AddValue("Port", Port);
      }
   }
}