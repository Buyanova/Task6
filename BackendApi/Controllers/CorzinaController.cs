using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using BackendApi.Contracts.Haracterystica;
using BackendApi.Contracts.Corzina;
using BackendApi.Contracts.Zakaz;

namespace BackendApi.Controllers
{
    [Route(template: "api/[controller]")]
    [ApiController]
    public class CorzinaController : ControllerBase
    {
        private ICorzinaService _a;
        public CorzinaController(ICorzinaService d)
        {
            _a = d;
        }
        /// <summary>
        /// Получение списка всей информации о товарах в заказе
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _a.GetAll());
        }

        /// <summary>
        /// Получение покинформации о товарах в заказеупателя по id заказа и id1 тоавра
        /// </summary>
        /// <param name="id"></param>
        /// <param name="id1"></param>
        /// <returns></returns>
        [HttpGet(template: "{id}")]
        public async Task<IActionResult> GetById(int id, int id1)
        {
            var result = await _a.GetById(id, id1);

            var response = result.Adapt<GetCorzinaResponse>(); // библиотека Mapster

            return Ok(response);
        }

        /// <summary>
        /// Создание новой корзины об информации о товарах в будущем заказе
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add(CreateCorzinaRequest request)
        {
            var dto = request.Adapt<Corzina>(); // библиотека Mapster
            await _a.Create(dto);
            return Ok();
        }

        /// <summary>
        /// Изменение товаров в корзине отложенных товаров
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Update(CreateCorzinaRequest request)
        {
            var dto = request.Adapt<Corzina>(); // библиотека Mapster
            await _a.Update(dto);
            return Ok();
        }

        /// <summary>
        /// Удаление корзины с товарами
        /// </summary>
        /// <param name="id"></param>
        /// <param name="id1"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(int id, int id1)
        {
            await _a.Delete(id, id1);
            return Ok();
        }
    }
}
