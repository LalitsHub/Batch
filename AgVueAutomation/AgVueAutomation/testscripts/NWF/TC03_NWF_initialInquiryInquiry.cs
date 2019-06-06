using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.NWF
{
    class TC03_NWF_initialInquiryInquiry
    {
        /// <summary>
        /// Test Case :Initial Inquiry - Inquiry
        /// Test Steps :
        /// 1. Click on "Inquiry" tab  
        /// 2.Enter Values in the below fields for consumer loan:
        ///         -Inquiry Decision: Select "Proceed with Application"
        ///         -Application Date: M/d/yyyy
        ///         -Inquiry Comments: 
        /// 3. Click on "Save" button 
        /// 4. Click on "Submit" button 
        /// 
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC03NWF");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<NWF_TC_03>>", "<<Initial Inquiry - Inquiry>>", "<<Initial Inquiry - Inquiry>>", "PASS");                
                pages.NWFCreditRequestcs.addinquiryDecisionNWF(dtResult[0]["TestData1"].ToString(), dtResult[0]["TestData2"].ToString(), dtResult[0]["TestData3"].ToString());
            }
        }
    }
}
