using Microsoft.AspNetCore.Mvc;
using Domain.Interfaces;
using Domain.Models;
using BackendApi.Contracts.User;
using Mapster;

namespace BackendApi.Controllers
{
    [Route(template: "api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _pokupatelService;
        public UserController(IUserService userService)
        {
            _pokupatelService = userService;
        }

        /// <summary>
        /// Получение списка всех покупатлей БД 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _pokupatelService.GetAll());
        }

        /// <summary>
        /// Получение покупателя по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet(template: "{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _pokupatelService.GetById(id);

            var response = result.Adapt<GetUserResponse>(); // библиотека Mapster

            return Ok(response);
        }

        /// <summary>
        /// Создание нового пользователя
        /// </summary>
        /// <remarks>
        /// Пример запроса:
        ///
        /// POST /Todo
        /// {
        /// "fio": "Иванов Иван Иванович",
        /// "phone": "+79064493491",
        /// "email": "renkoм@ivangmail.com",
        /// "password": "!Pa$$word123@",
        /// "adres": "г. Москва Ул. Генерала Белова, дом 6"
        /// }
        ///
        /// </remarks>
        /// <param name="request"></param>
        /// <returns></returns>
        // POST api/<UsersController>
        [HttpPost]
        public async Task<IActionResult> Add(CreateUserRequest request)
        {
            var dto = request.Adapt<Pokupatel>(); // библиотека Mapster
            await _pokupatelService.Create(dto);
            return Ok();
        }
        /// <summary>
        /// Изменение информации о покупателе
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Update(CreateUserRequest request)
        {
            var dto = request.Adapt<Pokupatel>(); // библиотека Mapster
            await _pokupatelService.Update(dto);
            return Ok();
        }
        /// <summary>
        /// Удаление покупателя из БД
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _pokupatelService.Delete(id);
            return Ok();
        }

    }
}
