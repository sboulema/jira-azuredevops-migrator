using System;
using System.Collections.Generic;

namespace JiraExport
{
    public interface IJiraRevision
    {
        List<RevisionAction<JiraAttachment>> AttachmentActions { get; set; }
        string Author { get; set; }
        Dictionary<string, string> Fields { get; set; }
        int Index { get; }
        List<RevisionAction<JiraLink>> LinkActions { get; set; }
        string OriginId { get; }
        JiraItem ParentItem { get; }
        DateTime Time { get; set; }
        string Type { get; }

        int CompareTo(JiraRevision other);
        string GetFieldValue(string fieldName);
    }
}