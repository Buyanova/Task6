using BackendApi.Contracts.User;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mapster;
using BackendApi.Contracts.Tovar;

namespace BackendApi.Controllers
{
    [Route(template: "api/[controller]")]
    [ApiController]
    public class TovarController : ControllerBase
    {
        private ITovarService _a;
        public TovarController(ITovarService d)
        {
            _a = d;
        }
        /// <summary>
        /// Получение списка всех товаров
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _a.GetAll());
        }

        /// <summary>
        /// Получение товаров по id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="id1"></param>
        /// <returns></returns>
        [HttpGet(template: "{id}")]
        public async Task<IActionResult> GetById(int id, int id1)
        {
            var result = await _a.GetById(id, id1);

            var response = result.Adapt<GetTovarResponse>(); // библиотека Mapster

            return Ok(response);
        }

        /// <summary>
        /// Создание нового товара
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add(CreateTovarRequest request)
        {
            var dto = request.Adapt<Tovar>(); // библиотека Mapster
            await _a.Create(dto);
            return Ok();
        }

        /// <summary>
        /// Изменение информации о товаре
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Update(CreateTovarRequest request)
        {
            var dto = request.Adapt<Tovar>(); // библиотека Mapster
            await _a.Update(dto);
            return Ok();
        }

        /// <summary>
        /// Удаление товара
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
