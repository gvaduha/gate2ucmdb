﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ucmdb.UcmdbServiceFacade {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/UcmdbServiceFacade")]
    [System.SerializableAttribute()]
    public partial struct Employee : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DateOfHireField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameEnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsDirectorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsPartyMemberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsOutstaffField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JobDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JobStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MiddleNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ModifiedTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneDirectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneInternalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneMobileField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DateOfHire {
            get {
                return this.DateOfHireField;
            }
            set {
                if ((object.ReferenceEquals(this.DateOfHireField, value) != true)) {
                    this.DateOfHireField = value;
                    this.RaisePropertyChanged("DateOfHire");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmployeeId {
            get {
                return this.EmployeeIdField;
            }
            set {
                if ((this.EmployeeIdField.Equals(value) != true)) {
                    this.EmployeeIdField = value;
                    this.RaisePropertyChanged("EmployeeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstNameEn {
            get {
                return this.FirstNameEnField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameEnField, value) != true)) {
                    this.FirstNameEnField = value;
                    this.RaisePropertyChanged("FirstNameEn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsDirector {
            get {
                return this.IsDirectorField;
            }
            set {
                if ((this.IsDirectorField.Equals(value) != true)) {
                    this.IsDirectorField = value;
                    this.RaisePropertyChanged("IsDirector");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsPartyMember {
            get {
                return this.IsPartyMemberField;
            }
            set {
                if ((this.IsPartyMemberField.Equals(value) != true)) {
                    this.IsPartyMemberField = value;
                    this.RaisePropertyChanged("IsPartyMember");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsOutstaff {
            get {
                return this.IsOutstaffField;
            }
            set {
                if ((this.IsOutstaffField.Equals(value) != true)) {
                    this.IsOutstaffField = value;
                    this.RaisePropertyChanged("IsOutstaff");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string JobDescription {
            get {
                return this.JobDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.JobDescriptionField, value) != true)) {
                    this.JobDescriptionField = value;
                    this.RaisePropertyChanged("JobDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string JobStatus {
            get {
                return this.JobStatusField;
            }
            set {
                if ((object.ReferenceEquals(this.JobStatusField, value) != true)) {
                    this.JobStatusField = value;
                    this.RaisePropertyChanged("JobStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location {
            get {
                return this.LocationField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationField, value) != true)) {
                    this.LocationField = value;
                    this.RaisePropertyChanged("Location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LoginName {
            get {
                return this.LoginNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginNameField, value) != true)) {
                    this.LoginNameField = value;
                    this.RaisePropertyChanged("LoginName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MiddleName {
            get {
                return this.MiddleNameField;
            }
            set {
                if ((object.ReferenceEquals(this.MiddleNameField, value) != true)) {
                    this.MiddleNameField = value;
                    this.RaisePropertyChanged("MiddleName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ModifiedTime {
            get {
                return this.ModifiedTimeField;
            }
            set {
                if ((this.ModifiedTimeField.Equals(value) != true)) {
                    this.ModifiedTimeField = value;
                    this.RaisePropertyChanged("ModifiedTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneDirect {
            get {
                return this.PhoneDirectField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneDirectField, value) != true)) {
                    this.PhoneDirectField = value;
                    this.RaisePropertyChanged("PhoneDirect");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneInternal {
            get {
                return this.PhoneInternalField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneInternalField, value) != true)) {
                    this.PhoneInternalField = value;
                    this.RaisePropertyChanged("PhoneInternal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneMobile {
            get {
                return this.PhoneMobileField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneMobileField, value) != true)) {
                    this.PhoneMobileField = value;
                    this.RaisePropertyChanged("PhoneMobile");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost", ConfigurationName="UcmdbServiceFacade.IEmployeeService", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IEmployeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/IEmployeeService/ConnectToUcmdbServer", ReplyAction="http://localhost/IEmployeeService/ConnectToUcmdbServerResponse")]
        void ConnectToUcmdbServer(System.Uri ucmdbUri, System.Net.NetworkCredential credentials, string appContextName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/IEmployeeService/FindUpdatedSince", ReplyAction="http://localhost/IEmployeeService/FindUpdatedSinceResponse")]
        void FindUpdatedSince(System.DateTime date, bool nonBlockedOnly);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/IEmployeeService/SetChunkSize", ReplyAction="http://localhost/IEmployeeService/SetChunkSizeResponse")]
        void SetChunkSize(int size);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/IEmployeeService/GetNextChunk", ReplyAction="http://localhost/IEmployeeService/GetNextChunkResponse")]
        ucmdb.UcmdbServiceFacade.Employee[] GetNextChunk();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeServiceChannel : ucmdb.UcmdbServiceFacade.IEmployeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<ucmdb.UcmdbServiceFacade.IEmployeeService>, ucmdb.UcmdbServiceFacade.IEmployeeService {
        
        public EmployeeServiceClient() {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void ConnectToUcmdbServer(System.Uri ucmdbUri, System.Net.NetworkCredential credentials, string appContextName) {
            base.Channel.ConnectToUcmdbServer(ucmdbUri, credentials, appContextName);
        }
        
        public void FindUpdatedSince(System.DateTime date, bool nonBlockedOnly) {
            base.Channel.FindUpdatedSince(date, nonBlockedOnly);
        }
        
        public void SetChunkSize(int size) {
            base.Channel.SetChunkSize(size);
        }
        
        public ucmdb.UcmdbServiceFacade.Employee[] GetNextChunk() {
            return base.Channel.GetNextChunk();
        }
    }
}
