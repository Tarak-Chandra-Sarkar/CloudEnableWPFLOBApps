﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Expenses.WPF.ExpensesService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/Expenses.Data.CommunicationModels")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AliasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ManagerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Alias {
            get {
                return this.AliasField;
            }
            set {
                if ((object.ReferenceEquals(this.AliasField, value) != true)) {
                    this.AliasField = value;
                    this.RaisePropertyChanged("Alias");
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
        public string Manager {
            get {
                return this.ManagerField;
            }
            set {
                if ((object.ReferenceEquals(this.ManagerField, value) != true)) {
                    this.ManagerField = value;
                    this.RaisePropertyChanged("Manager");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Charge", Namespace="http://schemas.datacontract.org/2004/07/Expenses.Data.CommunicationModels")]
    [System.SerializableAttribute()]
    public partial class Charge : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal BilledAmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ChargeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ExpenseDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ExpenseReportIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MerchantField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NotesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal TransactionAmountField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal BilledAmount {
            get {
                return this.BilledAmountField;
            }
            set {
                if ((this.BilledAmountField.Equals(value) != true)) {
                    this.BilledAmountField = value;
                    this.RaisePropertyChanged("BilledAmount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ChargeId {
            get {
                return this.ChargeIdField;
            }
            set {
                if ((this.ChargeIdField.Equals(value) != true)) {
                    this.ChargeIdField = value;
                    this.RaisePropertyChanged("ChargeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
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
        public System.DateTime ExpenseDate {
            get {
                return this.ExpenseDateField;
            }
            set {
                if ((this.ExpenseDateField.Equals(value) != true)) {
                    this.ExpenseDateField = value;
                    this.RaisePropertyChanged("ExpenseDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ExpenseReportId {
            get {
                return this.ExpenseReportIdField;
            }
            set {
                if ((this.ExpenseReportIdField.Equals(value) != true)) {
                    this.ExpenseReportIdField = value;
                    this.RaisePropertyChanged("ExpenseReportId");
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
        public string Merchant {
            get {
                return this.MerchantField;
            }
            set {
                if ((object.ReferenceEquals(this.MerchantField, value) != true)) {
                    this.MerchantField = value;
                    this.RaisePropertyChanged("Merchant");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Notes {
            get {
                return this.NotesField;
            }
            set {
                if ((object.ReferenceEquals(this.NotesField, value) != true)) {
                    this.NotesField = value;
                    this.RaisePropertyChanged("Notes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TransactionAmount {
            get {
                return this.TransactionAmountField;
            }
            set {
                if ((this.TransactionAmountField.Equals(value) != true)) {
                    this.TransactionAmountField = value;
                    this.RaisePropertyChanged("TransactionAmount");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExpenseReport", Namespace="http://schemas.datacontract.org/2004/07/Expenses.Data.CommunicationModels")]
    [System.SerializableAttribute()]
    public partial class ExpenseReport : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApproverField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CostCenterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateResolvedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateSubmittedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ExpenseReportIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NotesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Expenses.WPF.ExpensesService.ExpenseReportStatus StatusField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Approver {
            get {
                return this.ApproverField;
            }
            set {
                if ((object.ReferenceEquals(this.ApproverField, value) != true)) {
                    this.ApproverField = value;
                    this.RaisePropertyChanged("Approver");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CostCenter {
            get {
                return this.CostCenterField;
            }
            set {
                if ((this.CostCenterField.Equals(value) != true)) {
                    this.CostCenterField = value;
                    this.RaisePropertyChanged("CostCenter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateResolved {
            get {
                return this.DateResolvedField;
            }
            set {
                if ((this.DateResolvedField.Equals(value) != true)) {
                    this.DateResolvedField = value;
                    this.RaisePropertyChanged("DateResolved");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateSubmitted {
            get {
                return this.DateSubmittedField;
            }
            set {
                if ((this.DateSubmittedField.Equals(value) != true)) {
                    this.DateSubmittedField = value;
                    this.RaisePropertyChanged("DateSubmitted");
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
        public int ExpenseReportId {
            get {
                return this.ExpenseReportIdField;
            }
            set {
                if ((this.ExpenseReportIdField.Equals(value) != true)) {
                    this.ExpenseReportIdField = value;
                    this.RaisePropertyChanged("ExpenseReportId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Notes {
            get {
                return this.NotesField;
            }
            set {
                if ((object.ReferenceEquals(this.NotesField, value) != true)) {
                    this.NotesField = value;
                    this.RaisePropertyChanged("Notes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Expenses.WPF.ExpensesService.ExpenseReportStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExpenseReportStatus", Namespace="http://schemas.datacontract.org/2004/07/Expenses.Data.CommunicationModels")]
    public enum ExpenseReportStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Submitted = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Saved = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Approved = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ExpensesService.IExpenseService")]
    public interface IExpenseService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/GetEmployee", ReplyAction="http://tempuri.org/IExpenseService/GetEmployeeResponse")]
        Expenses.WPF.ExpensesService.Employee GetEmployee(string employeeAlias);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/GetEmployee", ReplyAction="http://tempuri.org/IExpenseService/GetEmployeeResponse")]
        System.Threading.Tasks.Task<Expenses.WPF.ExpensesService.Employee> GetEmployeeAsync(string employeeAlias);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/GetCharge", ReplyAction="http://tempuri.org/IExpenseService/GetChargeResponse")]
        Expenses.WPF.ExpensesService.Charge GetCharge(int chargeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/GetCharge", ReplyAction="http://tempuri.org/IExpenseService/GetChargeResponse")]
        System.Threading.Tasks.Task<Expenses.WPF.ExpensesService.Charge> GetChargeAsync(int chargeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/GetExpenseReport", ReplyAction="http://tempuri.org/IExpenseService/GetExpenseReportResponse")]
        Expenses.WPF.ExpensesService.ExpenseReport GetExpenseReport(int expenseReportId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/GetExpenseReport", ReplyAction="http://tempuri.org/IExpenseService/GetExpenseReportResponse")]
        System.Threading.Tasks.Task<Expenses.WPF.ExpensesService.ExpenseReport> GetExpenseReportAsync(int expenseReportId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/GetOutstandingChargesForEmployee", ReplyAction="http://tempuri.org/IExpenseService/GetOutstandingChargesForEmployeeResponse")]
        Expenses.WPF.ExpensesService.Charge[] GetOutstandingChargesForEmployee(int employeeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/GetOutstandingChargesForEmployee", ReplyAction="http://tempuri.org/IExpenseService/GetOutstandingChargesForEmployeeResponse")]
        System.Threading.Tasks.Task<Expenses.WPF.ExpensesService.Charge[]> GetOutstandingChargesForEmployeeAsync(int employeeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/GetChargesForExpenseReport", ReplyAction="http://tempuri.org/IExpenseService/GetChargesForExpenseReportResponse")]
        Expenses.WPF.ExpensesService.Charge[] GetChargesForExpenseReport(int expenseReportId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/GetChargesForExpenseReport", ReplyAction="http://tempuri.org/IExpenseService/GetChargesForExpenseReportResponse")]
        System.Threading.Tasks.Task<Expenses.WPF.ExpensesService.Charge[]> GetChargesForExpenseReportAsync(int expenseReportId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/GetExpenseReportsForEmployee", ReplyAction="http://tempuri.org/IExpenseService/GetExpenseReportsForEmployeeResponse")]
        Expenses.WPF.ExpensesService.ExpenseReport[] GetExpenseReportsForEmployee(int employeeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/GetExpenseReportsForEmployee", ReplyAction="http://tempuri.org/IExpenseService/GetExpenseReportsForEmployeeResponse")]
        System.Threading.Tasks.Task<Expenses.WPF.ExpensesService.ExpenseReport[]> GetExpenseReportsForEmployeeAsync(int employeeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/GetExpenseReportsForEmployeeByStatus", ReplyAction="http://tempuri.org/IExpenseService/GetExpenseReportsForEmployeeByStatusResponse")]
        Expenses.WPF.ExpensesService.ExpenseReport[] GetExpenseReportsForEmployeeByStatus(int employeeId, Expenses.WPF.ExpensesService.ExpenseReportStatus status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/GetExpenseReportsForEmployeeByStatus", ReplyAction="http://tempuri.org/IExpenseService/GetExpenseReportsForEmployeeByStatusResponse")]
        System.Threading.Tasks.Task<Expenses.WPF.ExpensesService.ExpenseReport[]> GetExpenseReportsForEmployeeByStatusAsync(int employeeId, Expenses.WPF.ExpensesService.ExpenseReportStatus status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/CreateNewCharge", ReplyAction="http://tempuri.org/IExpenseService/CreateNewChargeResponse")]
        int CreateNewCharge(Expenses.WPF.ExpensesService.Charge charge);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/CreateNewCharge", ReplyAction="http://tempuri.org/IExpenseService/CreateNewChargeResponse")]
        System.Threading.Tasks.Task<int> CreateNewChargeAsync(Expenses.WPF.ExpensesService.Charge charge);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/CreateNewExpenseReport", ReplyAction="http://tempuri.org/IExpenseService/CreateNewExpenseReportResponse")]
        int CreateNewExpenseReport(Expenses.WPF.ExpensesService.ExpenseReport expenseReport);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/CreateNewExpenseReport", ReplyAction="http://tempuri.org/IExpenseService/CreateNewExpenseReportResponse")]
        System.Threading.Tasks.Task<int> CreateNewExpenseReportAsync(Expenses.WPF.ExpensesService.ExpenseReport expenseReport);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/UpdateCharge", ReplyAction="http://tempuri.org/IExpenseService/UpdateChargeResponse")]
        int UpdateCharge(Expenses.WPF.ExpensesService.Charge charge);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/UpdateCharge", ReplyAction="http://tempuri.org/IExpenseService/UpdateChargeResponse")]
        System.Threading.Tasks.Task<int> UpdateChargeAsync(Expenses.WPF.ExpensesService.Charge charge);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/UpdateExpenseReport", ReplyAction="http://tempuri.org/IExpenseService/UpdateExpenseReportResponse")]
        int UpdateExpenseReport(Expenses.WPF.ExpensesService.ExpenseReport expenseReport);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/UpdateExpenseReport", ReplyAction="http://tempuri.org/IExpenseService/UpdateExpenseReportResponse")]
        System.Threading.Tasks.Task<int> UpdateExpenseReportAsync(Expenses.WPF.ExpensesService.ExpenseReport expenseReport);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/DeleteExpenseReport", ReplyAction="http://tempuri.org/IExpenseService/DeleteExpenseReportResponse")]
        void DeleteExpenseReport(int expenseReportId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/DeleteExpenseReport", ReplyAction="http://tempuri.org/IExpenseService/DeleteExpenseReportResponse")]
        System.Threading.Tasks.Task DeleteExpenseReportAsync(int expenseReportId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/ResetData", ReplyAction="http://tempuri.org/IExpenseService/ResetDataResponse")]
        void ResetData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseService/ResetData", ReplyAction="http://tempuri.org/IExpenseService/ResetDataResponse")]
        System.Threading.Tasks.Task ResetDataAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IExpenseServiceChannel : Expenses.WPF.ExpensesService.IExpenseService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExpenseServiceClient : System.ServiceModel.ClientBase<Expenses.WPF.ExpensesService.IExpenseService>, Expenses.WPF.ExpensesService.IExpenseService {
        
        public ExpenseServiceClient() {
        }
        
        public ExpenseServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ExpenseServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExpenseServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExpenseServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Expenses.WPF.ExpensesService.Employee GetEmployee(string employeeAlias) {
            return base.Channel.GetEmployee(employeeAlias);
        }
        
        public System.Threading.Tasks.Task<Expenses.WPF.ExpensesService.Employee> GetEmployeeAsync(string employeeAlias) {
            return base.Channel.GetEmployeeAsync(employeeAlias);
        }
        
        public Expenses.WPF.ExpensesService.Charge GetCharge(int chargeId) {
            return base.Channel.GetCharge(chargeId);
        }
        
        public System.Threading.Tasks.Task<Expenses.WPF.ExpensesService.Charge> GetChargeAsync(int chargeId) {
            return base.Channel.GetChargeAsync(chargeId);
        }
        
        public Expenses.WPF.ExpensesService.ExpenseReport GetExpenseReport(int expenseReportId) {
            return base.Channel.GetExpenseReport(expenseReportId);
        }
        
        public System.Threading.Tasks.Task<Expenses.WPF.ExpensesService.ExpenseReport> GetExpenseReportAsync(int expenseReportId) {
            return base.Channel.GetExpenseReportAsync(expenseReportId);
        }
        
        public Expenses.WPF.ExpensesService.Charge[] GetOutstandingChargesForEmployee(int employeeId) {
            return base.Channel.GetOutstandingChargesForEmployee(employeeId);
        }
        
        public System.Threading.Tasks.Task<Expenses.WPF.ExpensesService.Charge[]> GetOutstandingChargesForEmployeeAsync(int employeeId) {
            return base.Channel.GetOutstandingChargesForEmployeeAsync(employeeId);
        }
        
        public Expenses.WPF.ExpensesService.Charge[] GetChargesForExpenseReport(int expenseReportId) {
            return base.Channel.GetChargesForExpenseReport(expenseReportId);
        }
        
        public System.Threading.Tasks.Task<Expenses.WPF.ExpensesService.Charge[]> GetChargesForExpenseReportAsync(int expenseReportId) {
            return base.Channel.GetChargesForExpenseReportAsync(expenseReportId);
        }
        
        public Expenses.WPF.ExpensesService.ExpenseReport[] GetExpenseReportsForEmployee(int employeeId) {
            return base.Channel.GetExpenseReportsForEmployee(employeeId);
        }
        
        public System.Threading.Tasks.Task<Expenses.WPF.ExpensesService.ExpenseReport[]> GetExpenseReportsForEmployeeAsync(int employeeId) {
            return base.Channel.GetExpenseReportsForEmployeeAsync(employeeId);
        }
        
        public Expenses.WPF.ExpensesService.ExpenseReport[] GetExpenseReportsForEmployeeByStatus(int employeeId, Expenses.WPF.ExpensesService.ExpenseReportStatus status) {
            return base.Channel.GetExpenseReportsForEmployeeByStatus(employeeId, status);
        }
        
        public System.Threading.Tasks.Task<Expenses.WPF.ExpensesService.ExpenseReport[]> GetExpenseReportsForEmployeeByStatusAsync(int employeeId, Expenses.WPF.ExpensesService.ExpenseReportStatus status) {
            return base.Channel.GetExpenseReportsForEmployeeByStatusAsync(employeeId, status);
        }
        
        public int CreateNewCharge(Expenses.WPF.ExpensesService.Charge charge) {
            return base.Channel.CreateNewCharge(charge);
        }
        
        public System.Threading.Tasks.Task<int> CreateNewChargeAsync(Expenses.WPF.ExpensesService.Charge charge) {
            return base.Channel.CreateNewChargeAsync(charge);
        }
        
        public int CreateNewExpenseReport(Expenses.WPF.ExpensesService.ExpenseReport expenseReport) {
            return base.Channel.CreateNewExpenseReport(expenseReport);
        }
        
        public System.Threading.Tasks.Task<int> CreateNewExpenseReportAsync(Expenses.WPF.ExpensesService.ExpenseReport expenseReport) {
            return base.Channel.CreateNewExpenseReportAsync(expenseReport);
        }
        
        public int UpdateCharge(Expenses.WPF.ExpensesService.Charge charge) {
            return base.Channel.UpdateCharge(charge);
        }
        
        public System.Threading.Tasks.Task<int> UpdateChargeAsync(Expenses.WPF.ExpensesService.Charge charge) {
            return base.Channel.UpdateChargeAsync(charge);
        }
        
        public int UpdateExpenseReport(Expenses.WPF.ExpensesService.ExpenseReport expenseReport) {
            return base.Channel.UpdateExpenseReport(expenseReport);
        }
        
        public System.Threading.Tasks.Task<int> UpdateExpenseReportAsync(Expenses.WPF.ExpensesService.ExpenseReport expenseReport) {
            return base.Channel.UpdateExpenseReportAsync(expenseReport);
        }
        
        public void DeleteExpenseReport(int expenseReportId) {
            base.Channel.DeleteExpenseReport(expenseReportId);
        }
        
        public System.Threading.Tasks.Task DeleteExpenseReportAsync(int expenseReportId) {
            return base.Channel.DeleteExpenseReportAsync(expenseReportId);
        }
        
        public void ResetData() {
            base.Channel.ResetData();
        }
        
        public System.Threading.Tasks.Task ResetDataAsync() {
            return base.Channel.ResetDataAsync();
        }
    }
}
