﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebConvertWS.ConvertWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ConvertWS.ConvertWSSoap")]
    public interface ConvertWSSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EUR2VND", ReplyAction="*")]
        double EUR2VND(double eur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EUR2VND", ReplyAction="*")]
        System.Threading.Tasks.Task<double> EUR2VNDAsync(double eur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/USD2VND", ReplyAction="*")]
        double USD2VND(double usd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/USD2VND", ReplyAction="*")]
        System.Threading.Tasks.Task<double> USD2VNDAsync(double usd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VND2EUR", ReplyAction="*")]
        double VND2EUR(double vnd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VND2EUR", ReplyAction="*")]
        System.Threading.Tasks.Task<double> VND2EURAsync(double vnd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VND2USD", ReplyAction="*")]
        double VND2USD(double vnd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VND2USD", ReplyAction="*")]
        System.Threading.Tasks.Task<double> VND2USDAsync(double vnd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ConvertWSSoapChannel : WebConvertWS.ConvertWS.ConvertWSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConvertWSSoapClient : System.ServiceModel.ClientBase<WebConvertWS.ConvertWS.ConvertWSSoap>, WebConvertWS.ConvertWS.ConvertWSSoap {
        
        public ConvertWSSoapClient() {
        }
        
        public ConvertWSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ConvertWSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConvertWSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConvertWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double EUR2VND(double eur) {
            return base.Channel.EUR2VND(eur);
        }
        
        public System.Threading.Tasks.Task<double> EUR2VNDAsync(double eur) {
            return base.Channel.EUR2VNDAsync(eur);
        }
        
        public double USD2VND(double usd) {
            return base.Channel.USD2VND(usd);
        }
        
        public System.Threading.Tasks.Task<double> USD2VNDAsync(double usd) {
            return base.Channel.USD2VNDAsync(usd);
        }
        
        public double VND2EUR(double vnd) {
            return base.Channel.VND2EUR(vnd);
        }
        
        public System.Threading.Tasks.Task<double> VND2EURAsync(double vnd) {
            return base.Channel.VND2EURAsync(vnd);
        }
        
        public double VND2USD(double vnd) {
            return base.Channel.VND2USD(vnd);
        }
        
        public System.Threading.Tasks.Task<double> VND2USDAsync(double vnd) {
            return base.Channel.VND2USDAsync(vnd);
        }
    }
}
