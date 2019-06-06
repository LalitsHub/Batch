
namespace AgVueAutomation.testscripts
{
    class NWF_Happy_Path_Test
    {
        public static void testscript()
        {
            lib.resultUtil.CreateTestReport(lib.initializeTest.currentTestCase, "North West Florida (NWF) - Happy Path Test");
            string url = lib.generalLib.readjson("UatURL");
            lib.generalLib.initializeDriver();
            lib.initializeTest.driver.Navigate().GoToUrl(url + "NWF");

            //pages.NWFCreditRequestcs.seacrWithCaseId("ACR-127");
            System.Threading.Thread.Sleep(3000);

            NWF.TC01_NWF_initialInquiryApplicant.testscript();
            NWF.TC02_NWF_initialInquiryLoanAction.testscript();
            NWF.TC03_NWF_initialInquiryInquiry.testscript();
            NWF.TC04_NWF_buidApplicationEditNewLoanActions.testscript();
            NWF.TC05_NWF_buildApplicationApplications.testscript();
            NWF.TC06_NWF_buildLoanPackageLoanActions.testscript();
            NWF.TC07_NWF_analyzeCreditRequestAssignCreditAnalyst.testscript();
            NWF.TC08_NWF_analyzeCreditRequestCreditAnalysis.testscript();
            NWF.TC09_NWF_preDecisionReview.testscript();
            NWF.TC10_NWF_decisionPrep.testscript();
            NWF.TC11_NWF_decisionLoanActionApprove.testscript();
            NWF.TC12_NWF_clearFileForClosing.testscript();
            NWF.TC13_NWF_prepareDocuments.testscript();
            NWF.TC14_NWF_reviewDocuments.testscript();
            NWF.TC15_NWF_creditRequestClosingPrintAndSendDocs.testscript();
            NWF.TC16_NWF_recieveDocuments.testscript();
            NWF.TC17_NWF_recievedBooking.testscript();
            NWF.TC18_NWF_reviewAndBookLoan.testscript();
            NWF.TC19_NWF_createFundingRequest.testscript();
            NWF.TC20_NWF_reviewAndFundingLoant.testscript();
            NWF.TC21_NWF_nextDayVerification.testscript();
            NWF.TC22_NWF_receiveAndScanDocuments.testscript();
            NWF.TC23_NWF_postAuditClose.testscript();
            NWF.TC24_NWF_finalCreditRequestActions.testscript();
            lib.generalLib.quitDriver();
            lib.resultUtil.GenerateTestReport();
        }
    }
}
