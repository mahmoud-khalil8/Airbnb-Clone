﻿public class HostVerificationOutputDTO
{
    public int Id { get; set; }
    public int HostId { get; set; }
    public string HostName { get; set; } = string.Empty;
    public string Status { get; set; } = "Pending";
    public string VerificationDocumentUrl1 { get; set; }
    public string VerificationDocumentUrl2 { get; set; }

    public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
}