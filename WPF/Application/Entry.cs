using System;
using System.Windows;
using System.Windows.Media;

namespace SJB.Sol.Application
  {
  static class ApplicationEntry
    {
    [STAThread]
    static void Main()
      {
      App app = new App();
      WindowMain winMain = new WindowMain();

      app.Run(winMain);
      }
    }
  }