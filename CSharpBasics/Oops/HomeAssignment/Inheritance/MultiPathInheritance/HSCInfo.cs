namespace MultiPathInheritance
{
    public interface HSCInfo:PersonalInfo
    {
         long HSCMarkSheetNumber { get; set; }
         int PhysicsMark { get; set; }
         int ChemistryMark { get; set; }
         int MathsMark { get; set; }
         int TotalHSC { get; set; }
        double PercentageHSC { get; set; }

        void ShowHSCMarkSheet();
        void CalculateHSC();
    }
}