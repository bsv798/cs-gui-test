using System;
using Gtk;
using OpenTK;
using OpenTK.Graphics.OpenGL4;

public partial class MainWindow : Gtk.Window
{
    const string VertexShaderSource = @"
            #version 330
            layout(location = 0) in vec4 position;
            void main(void)
            {
                gl_Position = position;
            }
        ";

    // A simple fragment shader. Just a constant red color.
    const string FragmentShaderSource = @"
            #version 330
            out vec4 outputColor;
            void main(void)
            {
                outputColor = vec4(1.0, 0.0, 0.0, 1.0);
            }
        ";

    // Points of a triangle in normalized device coordinates.
    readonly float[] Points = new float[] {
            // X, Y, Z, W
            -0.5f, 0.0f, 0.0f, 1.0f,
            0.5f, 0.0f, 0.0f, 1.0f,
            0.0f, 0.5f, 0.0f, 1.0f };

    int VertexShader;
    int FragmentShader;
    int ShaderProgram;
    int VertexBufferObject;
    int VertexArrayObject;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButton2Clicked(object sender, EventArgs e)
    {

    }
}
