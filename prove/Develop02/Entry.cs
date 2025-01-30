using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

public class Entry
{
    public string _entryResponce;
    public string _entryDate;
    public string _entryPrompt;
    public string _entryTitle; 


    public Entry(string date, string title, string prompt, string entry)
    {
        this._entryDate = date; 
        this._entryPrompt = prompt; 
        this._entryResponce = entry; 
        this._entryTitle = title; 
    }

 
   public string EntryDisplay()
   { 
        return $"Date:{_entryDate}Title: {_entryTitle}Prompt: {_entryPrompt}Entry: {_entryResponce}"; 
   } 

   public string SaveInfo()
   { 
        return $"{_entryDate}~{_entryTitle}~{_entryPrompt}~{_entryResponce}"; 
   } 



  
        
        
        

   


}