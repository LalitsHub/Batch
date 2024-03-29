﻿using System.Data;

namespace AgVueAutomation.testscripts.NWF
{
    class TC01_NWF_initialInquiryApplicant
    {
        /// <summary>
        /// Test case : North West Florida - Initial Inquiry - Applicant
        /// Test Steps :
        /// Navigate to AgVue application URL in new browser
        /// Login to the application with the valid user name and password[Loan Officer]
        /// Click on "New Case" button.Then select "NWF Credit Request"
        /// Verify the breadcrumbs displayed at the top of the page
        /// "Verify the below tabs displayed on the page accordingly, [Red Vertical bars indicates mandatory fields]
        ///     - Applicants
        ///     - Loan Actions
        ///     - Calculators
        ///     - Inquiry
        ///     - Documents"
        /// Select "New" for RP Type(Responsible Party) Type
        /// Click "+" to add applicants
        /// "Enter/Select the field values for ""Add Applicants"" [Red Vertical bars indicates mandatory fields]
        ///     a) Customer Type - Person
        ///     b) Applicant Role - Primary
        ///     c) Applicant Type - Individual
        ///     d) First Name - Enter applicant's first name
        ///     e) Middle Name - Enter applicant's middle name (Optional)
        ///     f) Last Name - Enter applicant's last name
        ///     g) Suffix - Select from the drown down value
        ///     h) Date of Birth - Enter applicant's date of birth [M/d/yyyy]
        ///     i) Marital Status - Select ""Married"" from the drop down value
        ///     j) Tax ID Number - Enter nine digit number
        ///     k) Conflict of Interest - Select the value from the drop down
        ///     l) Address 1 - Enter applicant's address line 1
        ///     m) Address 2 - Enter applicant's address line 2 (Optional)
        ///     n) City - Enter applicant's city (For Ex: Columbia)
        ///     o) State - Select applicant's state from the drop down (For Ex: SC)
        ///     p) Zip Code - Enter zip code(For Ex: 29201)
        /// Once the zip code is entered -> Count Name and County Code gets automatically updated
        ///     q) Email Address - Enter applicant's email address (Optional)
        ///     r) Phone - Enter applicant's phone number (Optional)
        /// Then click on ""Save"" button
        /// "Enter/Select the field values for below, [Red Vertical bars indicates mandatory fields]
        ///     a) RP Name - Enter responsible party name
        ///     b) Involvement in Farming - Select ""Full-time Farmer"" from the drop down
        ///     c) Official Loan - Select No
        ///     d) Minority Farmer - Select No       
        ///     e) Are all spouses of signers and guarantors obligated on this loan? - Select Yes
        ///     f) Out of Trade Area - Select No
        ///     
        /// 
        /// </summary>

        public static void testscript()
        {
            lib.generalLib objgeneralLib = new lib.generalLib();
            //System.Threading.Thread.Sleep(5000);
            
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC01NWF");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<NWF_TC_01>>", "<<Initial Inquiry - Applicant>>", "<<Initial Inquiry - Applicant>>", "PASS");

                pages.mainMenu.selectMenuNWF("NEW CASE", "NWF CREDIT REQUEST", "");
                lib.resultUtil.AddResult("Select NWF Credit Request", "Select New Case -> NWF Credit Request option", "Should be able to select New Case -> NWF Credit Request option", "PASS");
                System.Threading.Thread.Sleep(3000);
                if (pages.NWFCreditRequestcs.selectTab("Applicants"))
                {
                    lib.resultUtil.AddResult("Verify Applicants Tab", "Applicants Tab should exist and able to select", "Applicants Tab exist and able to select", "PASS");
                }
                else
                {
                    lib.resultUtil.AddResult("Verify Applicants Tab", "Applicants Tab should exist and able to select", "Applicants Tab not exist or not able to select", "FAIL");
                }
                if (pages.NWFCreditRequestcs.selectTab("Loan Actions"))
                {
                    lib.resultUtil.AddResult("Verify Loan Actions Tab", "Loan Actions Tab should exist and able to select", "Loan Actions Tab exist and able to select", "PASS");
                }
                else
                {
                    lib.resultUtil.AddResult("Verify Loan Actions Tab", "Loan Actions Tab should exist and able to select", "Loan Actions Tab not exist or not able to select", "FAIL");
                }
                if (pages.NWFCreditRequestcs.selectTab("Calculators"))
                {
                    lib.resultUtil.AddResult("Verify Calculators Tab", "Calculators Tab should exist and able to select", "Calculators Tab exist and able to select", "PASS");
                }
                else
                {
                    lib.resultUtil.AddResult("Verify Calculators Tab", "Calculators Tab should exist and able to select", "Calculators Tab not exist or not able to select", "FAIL");
                }
                if (pages.NWFCreditRequestcs.selectTab("Inquiry"))
                {
                    lib.resultUtil.AddResult("Verify Inquiry Tab", "Inquiry Tab should exist and able to select", "Inquriy Tab exist and able to select", "PASS");
                }
                else
                {
                    lib.resultUtil.AddResult("Verify Inquiry Tab", "Inquiry Tab should exist and able to select", "Inquiry Tab not exist or not able to select", "FAIL");
                }
                if (pages.NWFCreditRequestcs.selectTab("Documents"))
                {
                    lib.resultUtil.AddResult("Verify Documents Tab", "Documents Tab should exist and able to select", "Documents Tab exist and able to select", "PASS");
                }
                else
                {
                    lib.resultUtil.AddResult("Verify Documents Tab", "Documents Tab should exist and able to select", "Documents Tab not exist or not able to select", "FAIL");
                }
                //System.Threading.Thread.Sleep(4000);
                pages.NWFCreditRequestcs.addApplicantNWF(dtResult[0]["TestData1"].ToString(), dtResult[0]["TestData2"].ToString(), dtResult[0]["TestData3"].ToString(), dtResult[0]["TestData4"].ToString(), dtResult[0]["TestData5"].ToString(), dtResult[0]["TestData6"].ToString(), dtResult[0]["TestData7"].ToString(), dtResult[0]["TestData8"].ToString(), dtResult[0]["TestData9"].ToString(), dtResult[0]["TestData10"].ToString(), dtResult[0]["TestData11"].ToString(), dtResult[0]["TestData12"].ToString(), dtResult[0]["TestData13"].ToString(), dtResult[0]["TestData14"].ToString(), dtResult[0]["TestData15"].ToString(), dtResult[0]["TestData16"].ToString(), dtResult[0]["TestData17"].ToString(), dtResult[0]["TestData18"].ToString(), dtResult[0]["TestData19"].ToString(), dtResult[0]["TestData20"].ToString(), dtResult[0]["TestData21"].ToString(), dtResult[0]["TestData22"].ToString(), dtResult[0]["TestData23"].ToString(), dtResult[0]["TestData24"].ToString(), dtResult[0]["TestData25"].ToString(), dtResult[0]["TestData26"].ToString(), dtResult[0]["TestData27"].ToString(), dtResult[0]["TestData28"].ToString(), dtResult[0]["TestData29"].ToString(), dtResult[0]["TestData30"].ToString(), dtResult[0]["TestData31"].ToString());
                pages.NWFCreditRequestcs.addResponsiblePartyNWF(dtResult[0]["TestData32"].ToString(), dtResult[0]["TestData33"].ToString());

            }
        }
    }
}
