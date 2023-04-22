using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using BackendApi.Contracts.Tovar;
using BackendApi.Contracts.Haracterystica;
using BackendApi.Contracts.Zakaz;

namespace BackendApi.Controllers
{
    [Route(template: "api/[controller]")]
    [ApiController]
    public class HaracterysticaController : ControllerBase
    {
        private IHaracterysticaService _a;
        public HaracterysticaController(IHaracterysticaService d)
        {
            _a = d;
        }
        /// <summary>
        /// Получение списка всех характеристик товаров
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _a.GetAll());
        }

        /// <summary>
        /// Получение характеристик товаров по id категории
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet(template: "{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _a.GetById(id);

            var response = result.Adapt<GetHaracterysticaResponse>(); // библиотека Mapster

            return Ok(response);
        }

        /// <summary>
        /// Создание новых характеристик, категорий для товаров
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add(CreateHaracterysticaRequest request)
        {
            var dto = request.Adapt<HaracterysticaTovarov>(); // библиотека Mapster
            await _a.Create(dto);
            return Ok();
        }

        /// <summary>
        /// Изменение информации характеристик товара
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Update(CreateHaracterysticaRequest request)
        {
            var dto = request.Adapt<HaracterysticaTovarov>(); // библиотека Mapster
            await _a.Update(dto);
            return Ok();
        }

        /// <summary>
        /// Удаление зарактеристик товара
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
