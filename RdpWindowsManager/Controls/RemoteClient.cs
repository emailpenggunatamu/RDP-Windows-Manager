using AxMSTSCLib;
using MSTSCLib;
using Rynte.UI2;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RdpWindowsManager.Controls
{
   public class RemoteClient
   {
      private readonly Size _size;
      private readonly TabPage _tabPage;
      private AxMsRdpClient6NotSafeForScripting _client;

      public RemoteClient(Size size, TabPage tabPage)
      {
         _size = size;
         _tabPage = tabPage;
      }

      public event Action<string> ClientDisconnected;

      public void Initialize()
      {
         _client = new AxMsRdpClient6NotSafeForScripting();
         ((System.ComponentModel.ISupportInitialize)_client).BeginInit();

         _client.Enabled = true;
         _client.Dock = DockStyle.Fill;
         _client.Size = _size;
         _client.MinimumSize = _size;

         _tabPage.Controls.Add(_client);

         ((System.ComponentModel.ISupportInitialize)_client).EndInit();
         _client.CreateControl();

         IMsRdpClientNonScriptable4 ocx = (IMsRdpClientNonScriptable4)_client.GetOcx();

         ocx.EnableCredSspSupport = true;
         ocx.AllowCredentialSaving = false;
         ocx.PromptForCredentials = false;
         ocx.PromptForCredsOnClient = false;

         _client.AdvancedSettings7.ConnectionBarShowRestoreButton = false;
         _client.OnDisconnected += OnDisconnected;
      }

      private void OnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
      {
         ClientDisconnected?.Invoke(_client.GetErrorDescription((uint)e.discReason, (uint)_client.ExtendedDisconnectReason));

         if (_client.Connected == 1)
         {
            _client.Disconnect();
         }

         _client?.Dispose();

         ((RynteTabControl)_tabPage.Parent).SelectedTab = _tabPage;
         _tabPage.Dispose();
      }

      public void Conntect(string host, string username, string password, int port = 0)
      {
         _client.Server = host;
         _client.UserName = username;

         if (port > 0)
         {
            _client.AdvancedSettings7.RDPPort = port;
         }

         _client.AdvancedSettings7.ClearTextPassword = password;
         _client?.Connect();
      }
   }
}