﻿namespace Business.Layer.Concrate;
public class MessageManager : IMessageService
{
	private readonly IMessageDal _messageDal;
	public MessageManager(IMessageDal messageDal)
	{
		_messageDal = messageDal;
	}
	public void TAdd(Message entity)
	{
		_messageDal.Add(entity);
	}
	public void TDelete(Message entity)
	{
		_messageDal.Delete(entity);
	}
	public List<Message> TGetAllList()
	{
		return _messageDal.GetAllList();
	}
	public Message TGetById(int id)
	{
		return _messageDal.GetById(id);
	}
	public void TUpdate(Message entity)
	{
		_messageDal.Update(entity);
	}
}