//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JumpstartMenu.Adapters
{
    
    public class IConfigurationEntryAddInAdapter
    {
        internal static JumpstartMenu.Views.IConfigurationEntry ContractToViewAdapter(Start9.Api.Contracts.IConfigurationEntryContract contract)
        {
            if ((contract == null))
            {
                return null;
            }
            if (((System.Runtime.Remoting.RemotingServices.IsObjectOutOfAppDomain(contract) != true) 
                        && contract.GetType().Equals(typeof(IConfigurationEntryViewToContractAddInAdapter))))
            {
                return ((IConfigurationEntryViewToContractAddInAdapter)(contract)).GetSourceView();
            }
            else
            {
                return new IConfigurationEntryContractToViewAddInAdapter(contract);
            }
        }
        internal static Start9.Api.Contracts.IConfigurationEntryContract ViewToContractAdapter(JumpstartMenu.Views.IConfigurationEntry view)
        {
            if ((view == null))
            {
                return null;
            }
            if (view.GetType().Equals(typeof(IConfigurationEntryContractToViewAddInAdapter)))
            {
                return ((IConfigurationEntryContractToViewAddInAdapter)(view)).GetSourceContract();
            }
            else
            {
                return new IConfigurationEntryViewToContractAddInAdapter(view);
            }
        }
    }
}

