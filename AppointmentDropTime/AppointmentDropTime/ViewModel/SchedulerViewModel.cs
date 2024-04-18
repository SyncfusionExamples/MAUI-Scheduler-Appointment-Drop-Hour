using Syncfusion.Maui.Scheduler;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentDropTime
{
    public class SchedulerViewModel
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerViewModel" /> class.
        /// </summary>
        public SchedulerViewModel()
        {
            this.GenerateAppointments();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the appointments.
        /// </summary>
        public ObservableCollection<SchedulerAppointment> Events { get; set; }

        #endregion

        #region Method

        /// <summary>
        /// Method to generate the appointments.
        /// </summary>
        private void GenerateAppointments()
        {
            this.Events = new ObservableCollection<SchedulerAppointment>();

            //Adding the schedule appointments in the schedule appointment collection.
            this.Events.Add(new SchedulerAppointment
            {
                StartTime = DateTime.Now.Date.AddHours(10),
                EndTime = DateTime.Now.Date.AddHours(11),
                Subject = "Client Meeting",
                Background = new SolidColorBrush(Color.FromArgb("#FF9C27B0")),
            });


            this.Events.Add(new SchedulerAppointment
            {
                StartTime = DateTime.Now.Date.AddDays(0).AddHours(17),
                EndTime = DateTime.Now.Date.AddDays(0).AddHours(18),
                Subject = "Consulting",
                Background = new SolidColorBrush(Color.FromArgb("#FF8BC34A")),
            });
        }

        #endregion
    }
}
