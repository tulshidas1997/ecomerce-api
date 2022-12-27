using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Core.Interfaces.Services;
using CleanArchitecture.Services;
using Core.Dtos;
using Core.Models;
using Moq;

namespace CleanArchitecture.Test;

[TestFixture]
public class CowServiceTest:BaseTest<Cow,CowDto,ICowRepository>
{
    private ICowService _cowService;

    public CowServiceTest() : base(new Cow() { Color = "Red" }, new CowDto() { Color = "Red" }, new Mock<ICowRepository>(MockBehavior.Strict))
    {
    }

    [SetUp]
    public void Setup()
    {
        _cowService = new CowService(_repository.Object, _mapper);
    }

    [Test]
    public async Task TestCreate()
    {
        var result = await _cowService.Create(_demoDto);
        Assert.AreEqual(_demoDto.Color,result.Color);
    }

    [Test]
    public async Task TestGetAll()
    {
        var result = await _cowService.GetAll();
        Assert.AreEqual(1,result.Count);
    }



}