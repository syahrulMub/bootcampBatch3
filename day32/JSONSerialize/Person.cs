namespace JSONSerialize;
using System.Text.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.DataContracts;

[DataContract]
public class Person
{
    [DataMember]
    private string _name;
    [DataMember]
    private int _age;
    [DataMember]
    private  Gender _gender;
    [DataMember]
    private Job _job;
    public Person(string name, int age, Gender gender, Job job = Job.nganggur)
    {
        _name = name;
        _age = age;
        _gender = gender;
        _job = job;

    }
    public string name
    {
        get { return _name; }
        set { _name = value; }
    }
    public int age
    {
        get { return _age; }
        set { _age = value; }
    }
    public Gender gender
    {
        get { return _gender; }
        set { _gender = value; }
    }
    public Job job
    {
        get { return _job; }
        set { _job = value; }
    }
}
public enum Gender
{
    male,
    female
}
public enum Job
{
    driver,
    tailor,
    chef,
    nganggur
    
}
