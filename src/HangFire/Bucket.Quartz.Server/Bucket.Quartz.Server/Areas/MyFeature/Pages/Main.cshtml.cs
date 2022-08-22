using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GZY.Quartz.MUI.Enum;
using GZY.Quartz.MUI.Model;
using GZY.Quartz.MUI.Service;
using GZY.Quartz.MUI.Tools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace GZY.Quartz.MUI.Areas.MyFeature.Pages
{
    public class MainModel : PageModel
    {
        private IQuartzHandle _quartzHandle;
        private IQuartzLogService _logService;
        public MainModel(IQuartzHandle quartzHandle, IQuartzLogService logService)
        {
            _quartzHandle = quartzHandle;
            _logService = logService;
        }
        [BindProperty]
        public tab_quarz_task Input { get; set; }
        /// <summary>
        /// ��ȡ�����б�
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnGetSelectJob()
        {
            var jobs = await _quartzHandle.GetJobs();

            return new JsonDataResult(jobs);
        }
        /// <summary>
        /// �½�����
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPostAddJob()
        {
           var date = await  _quartzHandle.AddJob(Input);
            Input.Status = Convert.ToInt32(JobState.��ͣ);
            return new JsonDataResult(date);
        }
        /// <summary>
        /// ��ͣ����
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPostPauseJob()
        {
            var date = await _quartzHandle.Pause(Input);

            return new JsonDataResult(date);
        }
        /// <summary>
        /// ��������
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPostStartJob()
        {
            var date = await _quartzHandle.Start(Input);

            return new JsonDataResult(date);
        }
        /// <summary>
        /// ����ִ������
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPostRunJob()
        {
            var date = await _quartzHandle.Run(Input);
            return new JsonDataResult(date);
        }
        /// <summary>
        /// �޸�����
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPostUpdateJob()
        {
            var date = await _quartzHandle.Update(Input);

            return new JsonDataResult(date);
        }
        /// <summary>
        /// ɾ������
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPostDeleteJob()
        {
            var date = await _quartzHandle.Remove(Input);

            return new JsonDataResult(date);
        }
        /// <summary>
        /// ��ȡ����ִ�м�¼
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPostJobRecord(string taskName, string groupName, int current, int size)
        {
            var date = await _logService.GetLogs(taskName,groupName, current, size);

            return new JsonDataResult(date);
        }
        public void OnGet()
        {
        }
    }
}
