﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SBIReportUtility.BusinessLayer.HRMSQuality {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="urn:java/lang", ItemName="String")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:ValidatencuserwebserviceWsd/ValidatencuserwebserviceVi", ConfigurationName="HRMSQuality.ValidatencuserwebserviceVi")]
    public interface ValidatencuserwebserviceVi {
        
        // CODEGEN: Generating message contract since the wrapper namespace (urn:ValidatencuserwebserviceVi) of message ValidateuserRequest does not match the default value (urn:ValidatencuserwebserviceWsd/ValidatencuserwebserviceVi)
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        SBIReportUtility.BusinessLayer.HRMSQuality.ValidateuserResponse Validateuser(SBIReportUtility.BusinessLayer.HRMSQuality.ValidateuserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<SBIReportUtility.BusinessLayer.HRMSQuality.ValidateuserResponse> ValidateuserAsync(SBIReportUtility.BusinessLayer.HRMSQuality.ValidateuserRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (urn:ValidatencuserwebserviceVi) of message getUserDetailsRequest does not match the default value (urn:ValidatencuserwebserviceWsd/ValidatencuserwebserviceVi)
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        SBIReportUtility.BusinessLayer.HRMSQuality.getUserDetailsResponse getUserDetails(SBIReportUtility.BusinessLayer.HRMSQuality.getUserDetailsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<SBIReportUtility.BusinessLayer.HRMSQuality.getUserDetailsResponse> getUserDetailsAsync(SBIReportUtility.BusinessLayer.HRMSQuality.getUserDetailsRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (urn:ValidatencuserwebserviceVi) of message getAuthenticationRequest does not match the default value (urn:ValidatencuserwebserviceWsd/ValidatencuserwebserviceVi)
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        SBIReportUtility.BusinessLayer.HRMSQuality.getAuthenticationResponse getAuthentication(SBIReportUtility.BusinessLayer.HRMSQuality.getAuthenticationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<SBIReportUtility.BusinessLayer.HRMSQuality.getAuthenticationResponse> getAuthenticationAsync(SBIReportUtility.BusinessLayer.HRMSQuality.getAuthenticationRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Validateuser", WrapperNamespace="urn:ValidatencuserwebserviceVi", IsWrapped=true)]
    public partial class ValidateuserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:ValidatencuserwebserviceVi", Order=0)]
        public string Uname;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:ValidatencuserwebserviceVi", Order=1)]
        public string Password;
        
        public ValidateuserRequest() {
        }
        
        public ValidateuserRequest(string Uname, string Password) {
            this.Uname = Uname;
            this.Password = Password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ValidateuserResponse", WrapperNamespace="urn:ValidatencuserwebserviceVi", IsWrapped=true)]
    public partial class ValidateuserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:ValidatencuserwebserviceVi", Order=0)]
        public string Response;
        
        public ValidateuserResponse() {
        }
        
        public ValidateuserResponse(string Response) {
            this.Response = Response;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getUserDetails", WrapperNamespace="urn:ValidatencuserwebserviceVi", IsWrapped=true)]
    public partial class getUserDetailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:ValidatencuserwebserviceVi", Order=0)]
        public string UserId;
        
        public getUserDetailsRequest() {
        }
        
        public getUserDetailsRequest(string UserId) {
            this.UserId = UserId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getUserDetailsResponse", WrapperNamespace="urn:ValidatencuserwebserviceVi", IsWrapped=true)]
    public partial class getUserDetailsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:ValidatencuserwebserviceVi", Order=0)]
        public SBIReportUtility.BusinessLayer.HRMSQuality.ArrayOfString Response;
        
        public getUserDetailsResponse() {
        }
        
        public getUserDetailsResponse(SBIReportUtility.BusinessLayer.HRMSQuality.ArrayOfString Response) {
            this.Response = Response;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getAuthentication", WrapperNamespace="urn:ValidatencuserwebserviceVi", IsWrapped=true)]
    public partial class getAuthenticationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:ValidatencuserwebserviceVi", Order=0)]
        public string UserId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:ValidatencuserwebserviceVi", Order=1)]
        public string Password;
        
        public getAuthenticationRequest() {
        }
        
        public getAuthenticationRequest(string UserId, string Password) {
            this.UserId = UserId;
            this.Password = Password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getAuthenticationResponse", WrapperNamespace="urn:ValidatencuserwebserviceVi", IsWrapped=true)]
    public partial class getAuthenticationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:ValidatencuserwebserviceVi", Order=0)]
        public SBIReportUtility.BusinessLayer.HRMSQuality.ArrayOfString Response;
        
        public getAuthenticationResponse() {
        }
        
        public getAuthenticationResponse(SBIReportUtility.BusinessLayer.HRMSQuality.ArrayOfString Response) {
            this.Response = Response;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ValidatencuserwebserviceViChannel : SBIReportUtility.BusinessLayer.HRMSQuality.ValidatencuserwebserviceVi, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ValidatencuserwebserviceViClient : System.ServiceModel.ClientBase<SBIReportUtility.BusinessLayer.HRMSQuality.ValidatencuserwebserviceVi>, SBIReportUtility.BusinessLayer.HRMSQuality.ValidatencuserwebserviceVi {
        
        public ValidatencuserwebserviceViClient() {
        }
        
        public ValidatencuserwebserviceViClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ValidatencuserwebserviceViClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ValidatencuserwebserviceViClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ValidatencuserwebserviceViClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SBIReportUtility.BusinessLayer.HRMSQuality.ValidateuserResponse SBIReportUtility.BusinessLayer.HRMSQuality.ValidatencuserwebserviceVi.Validateuser(SBIReportUtility.BusinessLayer.HRMSQuality.ValidateuserRequest request) {
            return base.Channel.Validateuser(request);
        }
        
        public string Validateuser(string Uname, string Password) {
            SBIReportUtility.BusinessLayer.HRMSQuality.ValidateuserRequest inValue = new SBIReportUtility.BusinessLayer.HRMSQuality.ValidateuserRequest();
            inValue.Uname = Uname;
            inValue.Password = Password;
            SBIReportUtility.BusinessLayer.HRMSQuality.ValidateuserResponse retVal = ((SBIReportUtility.BusinessLayer.HRMSQuality.ValidatencuserwebserviceVi)(this)).Validateuser(inValue);
            return retVal.Response;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SBIReportUtility.BusinessLayer.HRMSQuality.ValidateuserResponse> SBIReportUtility.BusinessLayer.HRMSQuality.ValidatencuserwebserviceVi.ValidateuserAsync(SBIReportUtility.BusinessLayer.HRMSQuality.ValidateuserRequest request) {
            return base.Channel.ValidateuserAsync(request);
        }
        
        public System.Threading.Tasks.Task<SBIReportUtility.BusinessLayer.HRMSQuality.ValidateuserResponse> ValidateuserAsync(string Uname, string Password) {
            SBIReportUtility.BusinessLayer.HRMSQuality.ValidateuserRequest inValue = new SBIReportUtility.BusinessLayer.HRMSQuality.ValidateuserRequest();
            inValue.Uname = Uname;
            inValue.Password = Password;
            return ((SBIReportUtility.BusinessLayer.HRMSQuality.ValidatencuserwebserviceVi)(this)).ValidateuserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SBIReportUtility.BusinessLayer.HRMSQuality.getUserDetailsResponse SBIReportUtility.BusinessLayer.HRMSQuality.ValidatencuserwebserviceVi.getUserDetails(SBIReportUtility.BusinessLayer.HRMSQuality.getUserDetailsRequest request) {
            return base.Channel.getUserDetails(request);
        }
        
        public SBIReportUtility.BusinessLayer.HRMSQuality.ArrayOfString getUserDetails(string UserId) {
            SBIReportUtility.BusinessLayer.HRMSQuality.getUserDetailsRequest inValue = new SBIReportUtility.BusinessLayer.HRMSQuality.getUserDetailsRequest();
            inValue.UserId = UserId;
            SBIReportUtility.BusinessLayer.HRMSQuality.getUserDetailsResponse retVal = ((SBIReportUtility.BusinessLayer.HRMSQuality.ValidatencuserwebserviceVi)(this)).getUserDetails(inValue);
            return retVal.Response;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SBIReportUtility.BusinessLayer.HRMSQuality.getUserDetailsResponse> SBIReportUtility.BusinessLayer.HRMSQuality.ValidatencuserwebserviceVi.getUserDetailsAsync(SBIReportUtility.BusinessLayer.HRMSQuality.getUserDetailsRequest request) {
            return base.Channel.getUserDetailsAsync(request);
        }
        
        public System.Threading.Tasks.Task<SBIReportUtility.BusinessLayer.HRMSQuality.getUserDetailsResponse> getUserDetailsAsync(string UserId) {
            SBIReportUtility.BusinessLayer.HRMSQuality.getUserDetailsRequest inValue = new SBIReportUtility.BusinessLayer.HRMSQuality.getUserDetailsRequest();
            inValue.UserId = UserId;
            return ((SBIReportUtility.BusinessLayer.HRMSQuality.ValidatencuserwebserviceVi)(this)).getUserDetailsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SBIReportUtility.BusinessLayer.HRMSQuality.getAuthenticationResponse SBIReportUtility.BusinessLayer.HRMSQuality.ValidatencuserwebserviceVi.getAuthentication(SBIReportUtility.BusinessLayer.HRMSQuality.getAuthenticationRequest request) {
            return base.Channel.getAuthentication(request);
        }
        
        public SBIReportUtility.BusinessLayer.HRMSQuality.ArrayOfString getAuthentication(string UserId, string Password) {
            SBIReportUtility.BusinessLayer.HRMSQuality.getAuthenticationRequest inValue = new SBIReportUtility.BusinessLayer.HRMSQuality.getAuthenticationRequest();
            inValue.UserId = UserId;
            inValue.Password = Password;
            SBIReportUtility.BusinessLayer.HRMSQuality.getAuthenticationResponse retVal = ((SBIReportUtility.BusinessLayer.HRMSQuality.ValidatencuserwebserviceVi)(this)).getAuthentication(inValue);
            return retVal.Response;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SBIReportUtility.BusinessLayer.HRMSQuality.getAuthenticationResponse> SBIReportUtility.BusinessLayer.HRMSQuality.ValidatencuserwebserviceVi.getAuthenticationAsync(SBIReportUtility.BusinessLayer.HRMSQuality.getAuthenticationRequest request) {
            return base.Channel.getAuthenticationAsync(request);
        }
        
        public System.Threading.Tasks.Task<SBIReportUtility.BusinessLayer.HRMSQuality.getAuthenticationResponse> getAuthenticationAsync(string UserId, string Password) {
            SBIReportUtility.BusinessLayer.HRMSQuality.getAuthenticationRequest inValue = new SBIReportUtility.BusinessLayer.HRMSQuality.getAuthenticationRequest();
            inValue.UserId = UserId;
            inValue.Password = Password;
            return ((SBIReportUtility.BusinessLayer.HRMSQuality.ValidatencuserwebserviceVi)(this)).getAuthenticationAsync(inValue);
        }
    }
}