using System.Runtime.InteropServices.Marshalling;

namespace LangGraphCompanionAPI.Models;

public readonly struct PresentationInfo
{
    public string Message { get; }
    public string Description { get; }
    public  string Author { get; }
    public  double Version { get; }
    public  Dictionary<string, string> Endpoints { get; }
    public  Dictionary<string, string> Metadata { get; }
    
    public PresentationInfo(
     string message,
     string description,
     string author,
     double version,
     Dictionary<string, string> endpoints,
     Dictionary<string, string> metadata)
        {
        Message = message;
        Description = description;
        Author = author;
        Version = version;
        Endpoints = endpoints;
        Metadata = metadata;
        }
}