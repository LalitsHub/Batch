using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.NWF
{
    class TC14_NWF_reviewDocuments
    {
        /// <summary>
        /// Approved radio button 
        //Click on "Submit" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC14NWF");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<NWF_TC_14>>", "<<Review Documents>>", "<<Review Documents>>", "PASS");
                pages.NWFCreditRequestcs.reviewDocuments();

            }
        }
    }
}
