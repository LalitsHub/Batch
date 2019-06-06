using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.NWF
{
    class TC04_NWF_buidApplicationEditNewLoanActions
    {

        /// <summary>
        // Test Case : Buid Application - Edit New Loan Actions        
        // 1. Click on "Loan Actions" tab
        // 2. Select the Loan action and Click on "Edit New Loan Actions" icon to edit the loan action for which status is mentioned as "Edits Required"
        // 3. Select the value from the drop down for "CD Consumer Loan Type"
        // 4. Select "Estimated Closing Date" as after the "Application Date" to determine if a request is near or past due
        // 5. Navigate to "Fees" tab.Then click on "+" to add loan action fees
        // 6. Select "Fee Type" from the drop down
        // 7. Enter $ value for "Amount" [For Ex: $1500]
        //        Select "Payment Method" as Financed
        //        Select checkbox "Fee Exception"
        // 8. Navigate to "Coding" tab
        // 9. "Enter/Select the field values for below, [Red Vertical bars indicates mandatory fields]
        //      a) Subsidiary - Select ""ACA""
        //      b) Term Type - Select the value from the drop down
        //      c) Loan Type - Select the value from the drop down
        //      d) FCA Loan Type - Select the value from the drop down
        //      e) Primary SIC Code - Select the value from the drop down
        //      f) Primary SIC Dependency - Select ""H"" from options
        //      g) Secondary SIC Dependency - Select ""L"" from options
        //      h) Accounting System - Select ""COAL"" from options
        //      i) Secured Loan - Select ""Yes""
        // 10. Navigate to "Rate and Terms" tab.Then select the value(ARM-ARM Treasury) from drop down for "Rate Type" and also enter % value for "Estimated Stated Rate"
        // 11. Select checkbox "Rate Exception"
        // 12. Enter % value for "Policy Margin" and some text in "Rate Exception Comments"
        // 13. Click on "Save" button to save the loan action        
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC04NWF");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<NWF_TC_04>>", "<<Build Application - Edit New Loan Actions>>", "<<Build Application - Edit New Loan Actions>>", "PASS");                
                pages.NWFCreditRequestcs.EditLoanActionNWF(dtResult[0]["TestData1"].ToString(), dtResult[0]["TestData2"].ToString(), dtResult[0]["TestData3"].ToString(), dtResult[0]["TestData4"].ToString(), dtResult[0]["TestData5"].ToString(), dtResult[0]["TestData6"].ToString(), dtResult[0]["TestData7"].ToString(), dtResult[0]["TestData8"].ToString(), dtResult[0]["TestData9"].ToString(), dtResult[0]["TestData10"].ToString(), dtResult[0]["TestData11"].ToString(), dtResult[0]["TestData12"].ToString(), dtResult[0]["TestData13"].ToString(), dtResult[0]["TestData14"].ToString(), dtResult[0]["TestData15"].ToString(), dtResult[0]["TestData16"].ToString(), dtResult[0]["TestData17"].ToString(), dtResult[0]["TestData18"].ToString(), dtResult[0]["TestData19"].ToString(), dtResult[0]["TestData20"].ToString(), dtResult[0]["TestData21"].ToString(), dtResult[0]["TestData22"].ToString(), dtResult[0]["TestData23"].ToString(), dtResult[0]["TestData24"].ToString(), dtResult[0]["TestData25"].ToString(), dtResult[0]["TestData26"].ToString());
            }
        }
    }
}
