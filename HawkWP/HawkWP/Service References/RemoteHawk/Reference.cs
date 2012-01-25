﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace HawkWP.RemoteHawk {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RemoteHawk.IRemoteHawk")]
    public interface IRemoteHawk {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IRemoteHawk/GetCredentials", ReplyAction="http://tempuri.org/IRemoteHawk/GetCredentialsResponse")]
        System.IAsyncResult BeginGetCredentials(System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<System.Collections.ObjectModel.ObservableCollection<string>> EndGetCredentials(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IRemoteHawk/GetClients", ReplyAction="http://tempuri.org/IRemoteHawk/GetClientsResponse")]
        System.IAsyncResult BeginGetClients(System.AsyncCallback callback, object asyncState);
        
        int EndGetClients(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IRemoteHawk/GetNetwork", ReplyAction="http://tempuri.org/IRemoteHawk/GetNetworkResponse")]
        System.IAsyncResult BeginGetNetwork(System.AsyncCallback callback, object asyncState);
        
        string EndGetNetwork(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IRemoteHawk/GetIPv6Spoofing", ReplyAction="http://tempuri.org/IRemoteHawk/GetIPv6SpoofingResponse")]
        System.IAsyncResult BeginGetIPv6Spoofing(System.AsyncCallback callback, object asyncState);
        
        bool EndGetIPv6Spoofing(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRemoteHawkChannel : HawkWP.RemoteHawk.IRemoteHawk, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetCredentialsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetCredentialsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<System.Collections.ObjectModel.ObservableCollection<string>> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<System.Collections.ObjectModel.ObservableCollection<string>>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetClientsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetClientsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetNetworkCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetNetworkCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetIPv6SpoofingCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetIPv6SpoofingCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RemoteHawkClient : System.ServiceModel.ClientBase<HawkWP.RemoteHawk.IRemoteHawk>, HawkWP.RemoteHawk.IRemoteHawk {
        
        private BeginOperationDelegate onBeginGetCredentialsDelegate;
        
        private EndOperationDelegate onEndGetCredentialsDelegate;
        
        private System.Threading.SendOrPostCallback onGetCredentialsCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetClientsDelegate;
        
        private EndOperationDelegate onEndGetClientsDelegate;
        
        private System.Threading.SendOrPostCallback onGetClientsCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetNetworkDelegate;
        
        private EndOperationDelegate onEndGetNetworkDelegate;
        
        private System.Threading.SendOrPostCallback onGetNetworkCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetIPv6SpoofingDelegate;
        
        private EndOperationDelegate onEndGetIPv6SpoofingDelegate;
        
        private System.Threading.SendOrPostCallback onGetIPv6SpoofingCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public RemoteHawkClient() {
        }
        
        public RemoteHawkClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RemoteHawkClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RemoteHawkClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RemoteHawkClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetCredentialsCompletedEventArgs> GetCredentialsCompleted;
        
        public event System.EventHandler<GetClientsCompletedEventArgs> GetClientsCompleted;
        
        public event System.EventHandler<GetNetworkCompletedEventArgs> GetNetworkCompleted;
        
        public event System.EventHandler<GetIPv6SpoofingCompletedEventArgs> GetIPv6SpoofingCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult HawkWP.RemoteHawk.IRemoteHawk.BeginGetCredentials(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetCredentials(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.ObjectModel.ObservableCollection<System.Collections.ObjectModel.ObservableCollection<string>> HawkWP.RemoteHawk.IRemoteHawk.EndGetCredentials(System.IAsyncResult result) {
            try
            {
                return base.Channel.EndGetCredentials(result);
            }
            catch
            {
                return null;
            }
        }
        
        private System.IAsyncResult OnBeginGetCredentials(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((HawkWP.RemoteHawk.IRemoteHawk)(this)).BeginGetCredentials(callback, asyncState);
        }
        
        private object[] OnEndGetCredentials(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<System.Collections.ObjectModel.ObservableCollection<string>> retVal = ((HawkWP.RemoteHawk.IRemoteHawk)(this)).EndGetCredentials(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetCredentialsCompleted(object state) {
            if ((this.GetCredentialsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetCredentialsCompleted(this, new GetCredentialsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetCredentialsAsync() {
            this.GetCredentialsAsync(null);
        }
        
        public void GetCredentialsAsync(object userState) {
            if ((this.onBeginGetCredentialsDelegate == null)) {
                this.onBeginGetCredentialsDelegate = new BeginOperationDelegate(this.OnBeginGetCredentials);
            }
            if ((this.onEndGetCredentialsDelegate == null)) {
                this.onEndGetCredentialsDelegate = new EndOperationDelegate(this.OnEndGetCredentials);
            }
            if ((this.onGetCredentialsCompletedDelegate == null)) {
                this.onGetCredentialsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetCredentialsCompleted);
            }
            base.InvokeAsync(this.onBeginGetCredentialsDelegate, null, this.onEndGetCredentialsDelegate, this.onGetCredentialsCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult HawkWP.RemoteHawk.IRemoteHawk.BeginGetClients(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetClients(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        int HawkWP.RemoteHawk.IRemoteHawk.EndGetClients(System.IAsyncResult result) {
            return base.Channel.EndGetClients(result);
        }
        
        private System.IAsyncResult OnBeginGetClients(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((HawkWP.RemoteHawk.IRemoteHawk)(this)).BeginGetClients(callback, asyncState);
        }
        
        private object[] OnEndGetClients(System.IAsyncResult result) {
            int retVal = ((HawkWP.RemoteHawk.IRemoteHawk)(this)).EndGetClients(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetClientsCompleted(object state) {
            if ((this.GetClientsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetClientsCompleted(this, new GetClientsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetClientsAsync() {
            this.GetClientsAsync(null);
        }
        
        public void GetClientsAsync(object userState) {
            if ((this.onBeginGetClientsDelegate == null)) {
                this.onBeginGetClientsDelegate = new BeginOperationDelegate(this.OnBeginGetClients);
            }
            if ((this.onEndGetClientsDelegate == null)) {
                this.onEndGetClientsDelegate = new EndOperationDelegate(this.OnEndGetClients);
            }
            if ((this.onGetClientsCompletedDelegate == null)) {
                this.onGetClientsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetClientsCompleted);
            }
            base.InvokeAsync(this.onBeginGetClientsDelegate, null, this.onEndGetClientsDelegate, this.onGetClientsCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult HawkWP.RemoteHawk.IRemoteHawk.BeginGetNetwork(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetNetwork(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string HawkWP.RemoteHawk.IRemoteHawk.EndGetNetwork(System.IAsyncResult result) {
            return base.Channel.EndGetNetwork(result);
        }
        
        private System.IAsyncResult OnBeginGetNetwork(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((HawkWP.RemoteHawk.IRemoteHawk)(this)).BeginGetNetwork(callback, asyncState);
        }
        
        private object[] OnEndGetNetwork(System.IAsyncResult result) {
            string retVal = ((HawkWP.RemoteHawk.IRemoteHawk)(this)).EndGetNetwork(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetNetworkCompleted(object state) {
            if ((this.GetNetworkCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetNetworkCompleted(this, new GetNetworkCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetNetworkAsync() {
            this.GetNetworkAsync(null);
        }
        
        public void GetNetworkAsync(object userState) {
            if ((this.onBeginGetNetworkDelegate == null)) {
                this.onBeginGetNetworkDelegate = new BeginOperationDelegate(this.OnBeginGetNetwork);
            }
            if ((this.onEndGetNetworkDelegate == null)) {
                this.onEndGetNetworkDelegate = new EndOperationDelegate(this.OnEndGetNetwork);
            }
            if ((this.onGetNetworkCompletedDelegate == null)) {
                this.onGetNetworkCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetNetworkCompleted);
            }
            base.InvokeAsync(this.onBeginGetNetworkDelegate, null, this.onEndGetNetworkDelegate, this.onGetNetworkCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult HawkWP.RemoteHawk.IRemoteHawk.BeginGetIPv6Spoofing(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetIPv6Spoofing(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bool HawkWP.RemoteHawk.IRemoteHawk.EndGetIPv6Spoofing(System.IAsyncResult result) {
            return base.Channel.EndGetIPv6Spoofing(result);
        }
        
        private System.IAsyncResult OnBeginGetIPv6Spoofing(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((HawkWP.RemoteHawk.IRemoteHawk)(this)).BeginGetIPv6Spoofing(callback, asyncState);
        }
        
        private object[] OnEndGetIPv6Spoofing(System.IAsyncResult result) {
            bool retVal = ((HawkWP.RemoteHawk.IRemoteHawk)(this)).EndGetIPv6Spoofing(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetIPv6SpoofingCompleted(object state) {
            if ((this.GetIPv6SpoofingCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetIPv6SpoofingCompleted(this, new GetIPv6SpoofingCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetIPv6SpoofingAsync() {
            this.GetIPv6SpoofingAsync(null);
        }
        
        public void GetIPv6SpoofingAsync(object userState) {
            if ((this.onBeginGetIPv6SpoofingDelegate == null)) {
                this.onBeginGetIPv6SpoofingDelegate = new BeginOperationDelegate(this.OnBeginGetIPv6Spoofing);
            }
            if ((this.onEndGetIPv6SpoofingDelegate == null)) {
                this.onEndGetIPv6SpoofingDelegate = new EndOperationDelegate(this.OnEndGetIPv6Spoofing);
            }
            if ((this.onGetIPv6SpoofingCompletedDelegate == null)) {
                this.onGetIPv6SpoofingCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetIPv6SpoofingCompleted);
            }
            base.InvokeAsync(this.onBeginGetIPv6SpoofingDelegate, null, this.onEndGetIPv6SpoofingDelegate, this.onGetIPv6SpoofingCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override HawkWP.RemoteHawk.IRemoteHawk CreateChannel() {
            return new RemoteHawkClientChannel(this);
        }
        
        private class RemoteHawkClientChannel : ChannelBase<HawkWP.RemoteHawk.IRemoteHawk>, HawkWP.RemoteHawk.IRemoteHawk {
            
            public RemoteHawkClientChannel(System.ServiceModel.ClientBase<HawkWP.RemoteHawk.IRemoteHawk> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetCredentials(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetCredentials", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.ObjectModel.ObservableCollection<System.Collections.ObjectModel.ObservableCollection<string>> EndGetCredentials(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.ObjectModel.ObservableCollection<System.Collections.ObjectModel.ObservableCollection<string>> _result = ((System.Collections.ObjectModel.ObservableCollection<System.Collections.ObjectModel.ObservableCollection<string>>)(base.EndInvoke("GetCredentials", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetClients(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetClients", _args, callback, asyncState);
                return _result;
            }
            
            public int EndGetClients(System.IAsyncResult result) {
                object[] _args = new object[0];
                int _result = ((int)(base.EndInvoke("GetClients", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetNetwork(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetNetwork", _args, callback, asyncState);
                return _result;
            }
            
            public string EndGetNetwork(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("GetNetwork", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetIPv6Spoofing(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetIPv6Spoofing", _args, callback, asyncState);
                return _result;
            }
            
            public bool EndGetIPv6Spoofing(System.IAsyncResult result) {
                object[] _args = new object[0];
                bool _result = ((bool)(base.EndInvoke("GetIPv6Spoofing", _args, result)));
                return _result;
            }
        }
    }
}