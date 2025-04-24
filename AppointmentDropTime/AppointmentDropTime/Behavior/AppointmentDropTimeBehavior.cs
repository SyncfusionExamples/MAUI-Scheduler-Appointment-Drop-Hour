using Syncfusion.Maui.Scheduler;

namespace AppointmentDropTime;

internal class AppointmentDropTimeBehavior : Behavior<ContentPage>
{
    /// <summary>
    /// schedule initialize
    /// </summary>
    private SfScheduler? scheduler;

    protected override void OnAttachedTo(ContentPage bindable)
    {
        base.OnAttachedTo(bindable);
        this.scheduler = bindable.FindByName<SfScheduler>("Scheduler");
        if (this.scheduler != null)
        {
            this.scheduler.AppointmentDrop += OnSchedulerAppointmentDrop;
        }
    }

    private void OnSchedulerAppointmentDrop(object? sender, AppointmentDropEventArgs e)
    {
        var dropTime = e.DropTime;
        e.DropTime = new DateTime(dropTime.Year, dropTime.Month, dropTime.Day, dropTime.Hour, 0, 0);
    }

    protected override void OnDetachingFrom(ContentPage bindable)
    {
        base.OnDetachingFrom(bindable);

        if (this.scheduler != null)
        {
            this.scheduler.AppointmentDrop -= OnSchedulerAppointmentDrop;
            this.scheduler = null;
        }
    }
}