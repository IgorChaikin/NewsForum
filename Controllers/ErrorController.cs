using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsForum.Models.ViewModels;

namespace NewsForum.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index(int? statusCode = null)
        {
            HttpErrorViewModel context = new HttpErrorViewModel();
            if (statusCode != null)
            {
                context.Code = (int)statusCode;
                if((int)statusCode>=400 && (int)statusCode < 500)
                {
                    context.Description = "Ошибка клиента.";
                    switch ((int)statusCode)
                    {
                        case 400: context.Description += " Неверный запрос."; break;
                        case 401: context.Description += " Не авторизован."; break;
                        case 403: context.Description += " Доступ запрещён."; break;
                        case 404: context.Description += " Запрашиваемый ресурс не найден."; break;
                        case 405: context.Description += " Неизвестный метод запроса."; break;
                        case 409: context.Description += " Конфликт запроса с текущим состоянием сервера."; break;
                        default: break;
                    }
                }
            }
            return View(context);
        }
    }
}
