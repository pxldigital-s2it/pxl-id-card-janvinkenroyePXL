using DigitalStudentCard.Core.Enums;
using DigitalStudentCard.Core.Models;
using System;

namespace DigitalStudentCard.Core.ViewModels.StudentMoment
{
    public class StudentMomentItemViewModel : BaseViewModel
  {
    private int _id;
    private string _name;
    private MomentType _momentType;
    private DateTime _date;
    private string _location;

    public StudentMomentItemViewModel(Moment model)
    {
        _id = model.Id;
        _name = model.Name;
        _momentType = model.MomentType;
        _date = model.Date;
        _location = model.Location;
    }

    public int Id => _id;

    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value);
    }

    public MomentType MomentType
    {
        get => _momentType;
        set => SetProperty(ref _momentType, value);
    }

    public DateTime Date
    {
        get => _date;
        set => SetProperty(ref _date, value);
    }

    public string Location
    {
        get => _location;
        set => SetProperty(ref _location, value);
    }
    }
}
