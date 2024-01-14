﻿namespace Dtos.Layer.MessageDto;
public class CreateMessageDto
{
	public string NameSurmane { get; set; }
	public string Mail { get; set; }
	public string PhoneNumber { get; set; }
	public string Subject { get; set; }
	public string MessageContent { get; set; }
	public DateTime MessageSendDate { get; set; }
	public bool Status { get; set; }
}