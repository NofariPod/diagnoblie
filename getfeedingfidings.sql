create view viewFeedingFindingsTouching as(
SELECT  TreatmentNum,IdDiagnosis,IdOrgan,viewOrgan,side,RepetitiveResponse,available,LocationResponse,PowerResponse,manipulationResponse from  OrganFindings join FindingsTouching on OrganFindings.Id=FindingsTouching.NumResponse join DiagnosisOrgans on DiagnosisOrgans.numTest=OrganFindings.NumTest)
