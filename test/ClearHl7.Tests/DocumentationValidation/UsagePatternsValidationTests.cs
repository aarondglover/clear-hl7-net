using System;
using Xunit;
using ClearHl7;
using ClearHl7.Helpers;
using ClearHl7.Codes.V282;
using ClearHl7.Codes.V282.Helpers;

namespace ClearHl7.Tests.DocumentationValidation
{
    /// <summary>
    /// Tests to validate that the documentation examples actually work as described.
    /// </summary>
    public class UsagePatternsValidationTests
    {
        [Fact]
        public void StaticMethods_Work_AsDocumented()
        {
            // Test static EnumHelper usage as shown in README
            var staticCode = EnumHelper.EnumToCode(CodeMaritalStatus.Married);
            Assert.Equal("M", staticCode);
            
            // Test static MessageHelper usage as shown in README
            var staticMessage = MessageHelper.NewInstance(Hl7Version.V282);
            Assert.NotNull(staticMessage);
            Assert.Equal("ClearHl7.V282.Message", staticMessage.GetType().FullName);
        }
        
        [Fact]
        public void InstanceMethods_Work_AsDocumented()
        {
            // Test instance EnumHelper usage as shown in README
            // Note: Instance methods are available through IEnumHelper interface
            IEnumHelper helper = new EnumHelper();
            var instanceCode = helper.EnumToCode(CodeMaritalStatus.Married);
            Assert.Equal("M", instanceCode);
        }
        
        [Fact]
        public void InterfaceBased_Usage_Works_AsDocumented()
        {
            // Test interface-based usage as shown in README
            IEnumHelper interfaceHelper = new EnumHelper();
            var interfaceCode = interfaceHelper.EnumToCode(CodeYesNoIndicator.Yes);
            Assert.Equal("Y", interfaceCode);
        }
        
        [Fact]
        public void StaticAndInstance_ProduceSameResults()
        {
            // Verify both approaches produce identical results as claimed in README
            var staticCode = EnumHelper.EnumToCode(CodeMaritalStatus.Single);
            
            IEnumHelper helper = new EnumHelper();
            var instanceCode = helper.EnumToCode(CodeMaritalStatus.Single);
            
            Assert.Equal(staticCode, instanceCode);
        }
        
        [Fact]
        public void DependencyInjection_Pattern_Works()
        {
            // Simulate the dependency injection pattern shown in README
            IEnumHelper enumHelper = new EnumHelper();
            
            // This pattern supports the service class example in README
            var service = new TestService(enumHelper);
            var result = service.ProcessCodeExample();
            
            Assert.NotNull(result);
            Assert.Equal("S", result); // CodeMaritalStatus.Single = "S"
        }
    }
    
    /// <summary>
    /// Example service class demonstrating the dependency injection pattern from README.
    /// </summary>
    public class TestService
    {
        private readonly IEnumHelper _enumHelper;
        
        public TestService(IEnumHelper enumHelper)
        {
            _enumHelper = enumHelper;
        }
        
        public string ProcessCodeExample()
        {
            return _enumHelper.EnumToCode(CodeMaritalStatus.Single);
        }
    }
}