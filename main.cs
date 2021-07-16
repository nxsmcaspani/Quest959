using System;

class SetRange {
  private int minValue;
  private int maxValue;
  
  public int GetMinValue(){
    return this.minValue;
  }
  public int GetMaxValue(){
    return this.maxValue;
  }

  public void SetMinValue(int value){
    this.minValue = value;
  }
  public void SetMaxValue(int value){
    this.maxValue = value;
  }

  public int CheckValueInRange(int val){
    if(val < this.GetMinValue()){
      Console.WriteLine ("You have entered "+val+" which is lower than "+this.GetMinValue()+" which is the minimum");
      return this.GetMinValue();
    } 
    if(val > this.GetMaxValue()){
      Console.WriteLine ("You have entered "+val+" which is greater than "+this.GetMaxValue()+" which is the maximum");
      return this.GetMaxValue();
    }
    return val;
  }

  public static void Main (string[] args) {
    SetRange range = new SetRange();
    Console.WriteLine("Please provide a first limit :");
    int firstLimit = Convert.ToInt32(Console.ReadLine());
    range.SetMinValue(firstLimit);
    Console.WriteLine("Please provide a second limit :");
    int secondLimit = Convert.ToInt32(Console.ReadLine());
    if(secondLimit < range.GetMinValue()){
      range.SetMaxValue(range.GetMinValue());
      range.SetMinValue(secondLimit);
    } else range.SetMaxValue(secondLimit);
    Console.WriteLine("Limit1: "+ firstLimit);
    Console.WriteLine("Limit2: "+ secondLimit);
    Console.WriteLine("Integer to limit :");
    int integerToLimit = Convert.ToInt32(Console.ReadLine());
    integerToLimit = range.CheckValueInRange(integerToLimit);
    Console.WriteLine("Resulting integer: "+ integerToLimit);
  }
}