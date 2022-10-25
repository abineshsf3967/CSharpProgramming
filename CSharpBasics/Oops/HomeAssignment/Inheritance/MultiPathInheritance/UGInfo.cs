namespace MultiPathInheritance
{
    public interface UGInfo
    {
         long UGMarkSheetNumber { get; set; }
         int SEM1 { get; set; }
         int SEM2 { get; set; }
         int SEM3 { get; set; }
         int SEM4 { get; set; }
         int TotalUG { get; set; }
         double PercentageUG { get; set; }


         void ShowUGMarkSheet();
         void CalculateUG();
    }
}