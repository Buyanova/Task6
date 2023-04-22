using BackendApi.Contracts.User;
using BackendApi.Contracts.Zakaz;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mapster;


namespace BackendApi.Controllers
{
    [Route(template: "api/[controller]")]
    [ApiController]
    public class ZakazController : ControllerBase
    {
        private IZakazService _a;
        public ZakazController(IZakazService d)
        {
            _a = d;
        }
        /// <summary>
        /// Получение списка всех заказов
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _a.GetAll());
        }

        /// <summary>
        /// Получение заказа по id заказа и покупателя
        /// </summary>
        /// <param name="id"></param>
        /// <param name="id1"></param>
        /// <returns></returns>
        [HttpGet(template: "{id}")]
        public async Task<IActionResult> GetById(int id, int id1)
        {
            var result = await _a.GetById(id, id1);

            var response = result.Adapt<GetZakazResponse>(); // библиотека Mapster

            return Ok(response);
        }

        /// <summary>
        /// Создание нового заказа
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add(CreateZakazRequest request)
        {
            var dto = request.Adapt<Zakaz>(); // библиотека Mapster
            await _a.Create(dto);
            return Ok();
        }

        /// <summary>
        /// Изменение информации о заказе
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Update(CreateZakazRequest request)
        {
            var dto = request.Adapt<Zakaz>(); // библиотека Mapster
            await _a.Update(dto);
            return Ok();
        }

        /// <summary>
        /// Удаление заказа
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _a.Delete(id);
            return Ok();
        }
    }
}
