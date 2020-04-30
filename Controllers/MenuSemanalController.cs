using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MenuSemanal.Models;
using MenuSemanal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MenuSemanal.Controllers
{
    public class MenuSemanalController : Controller
    {
        private readonly ILogger<MenuSemanalController> _logger;
        private readonly IMenuSemanalServices<Week>  _menuSemanal;

        public MenuSemanalController(ILogger<MenuSemanalController> logger, IMenuSemanalServices<Week> menuSemanal)
        {
            this._logger = logger;
            this._menuSemanal = menuSemanal;
        }
        public async Task<IActionResult> Index()
        {
            return View(await LoadWeeks());
        }

        public async Task<IActionResult> GetItemDetail(string id)
        {
            var week = await LoadWeekDetail(id);
            return View("Semana", week);
        }

        private async Task<Week> LoadWeekDetail(string id)
        {
            //IsBusy = true;

            try
            {
                //Items.Clear();
                var week = await this._menuSemanal.GetItemAsync(id);
                return week;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return default(Week);
            }
            finally
            {
                //IsBusy = false;
            }
        }

        private async Task<IEnumerable<Week>> LoadWeeks()
        {
            var listWeeks = new List<Week>();
            //IsBusy = true;

            try
            {
                //Items.Clear();
                var weeks = await this._menuSemanal.GetItemsAsync(true);
                foreach (var week in weeks)
                {
                    listWeeks.Add(week);
                }
                return listWeeks;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return default(List<Week>);
            }
            finally
            {
                //IsBusy = false;
            }
        }
    }
}