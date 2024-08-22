//ÇAĞRI BEKLETME VE GERİ DÖNÜŞ 

[HttpPost("HoldCall")]
public async Task<IActıonResult> HoldCallAsy([FromBody] CallRequest request);


[HttpPost("HoldCall")]
public async Task<IActionResult> HoldCallAsync([FromBody] CallRequest request)
{
    //çağrıyı belli bir süre bekletme

    var result = await HoldCallImplementationAsync(request);

    if (result)
    {
        return Ok("Çağrı bekletildi");
    }
    else
    {
        return StatusCode(500, "Çağrı bekletme hatası");
    }
}

[HttpPost("ReturnCall")]
public async Task<IActionResult> ReturnCallAsync([FromBody] CallRequest request)
{
    //Bekletilen çağrıyı geri döndürme

    var result = await ReturnCallImplementationAsync(request);

    if (result)
    {
        return Ok("Çağrı geri döndürüldü");
    }
    else
    {
        return StatusCode(500, "Çağrıyı geri döndürme hatası");
    }
}

private async Task<bool> HoldCallImplementationAsync(CallRequest request)
{
  //çağrı veritabanına bekletme eklenebilir.
    await Task.Delay(500); // Simülasyon için bekleme
    return true;
}

private async Task<bool> ReturnCallImplementationAsync(CallRequest request)
{
   //veritabanına geri dönüş eklenebilir
    await Task.Delay(500); // Simülasyon için bekleme
    return true;
}


return Ok(santral);

