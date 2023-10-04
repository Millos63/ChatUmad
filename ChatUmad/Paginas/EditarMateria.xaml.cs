namespace ChatUmad.Paginas;

public partial class EditarMateria : ContentPage
{
    private Subject subject;

    public EditarMateria(Subject subject)
    {
        InitializeComponent();

        // Almacenar el usuario pasado como parámetro
        this.subject = subject;

        // Poblar los campos de edición con los datos actuales del usuario
        NameEntry.Text = subject.Name;
        CodeEntry.Text = subject.Code;
        SectionEntry.Text = subject.Section;
        GroupEntry.Text = subject.Group;
        TeacherEntry.Text = subject.Teacher;
        CreditsEntry.Text = subject.Credits;
    }


    private void OnClickSave(object sender, EventArgs e)
    {
        subject.Name = NameEntry.Text;
        subject.Code = CodeEntry.Text;
        subject.Section = SectionEntry.Text;
        subject.Group = GroupEntry.Text;
        subject.Teacher = TeacherEntry.Text;
        subject.Credits = CreditsEntry.Text;

        Navigation.PopAsync();
    }
}