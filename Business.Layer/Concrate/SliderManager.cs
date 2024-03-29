﻿namespace Business.Layer.Concrate;
public class SliderManager : ISliderService
{
    private readonly ISliderDal _sliderDal;
    public SliderManager(ISliderDal sliderDal)
    {
        _sliderDal = sliderDal;
    }
    public void TAdd(Slider entity)
    {
        _sliderDal.Add(entity);
    }
    public void TDelete(Slider entity)
    {
        _sliderDal.Delete(entity);
    }
    public List<Slider> TGetAllList()
    {
        return _sliderDal.GetAllList();
    }
    public Slider TGetById(int id)
    {
        return _sliderDal.GetById(id);
    }
    public void TUpdate(Slider entity)
    {
        _sliderDal.Update(entity);
    }
}