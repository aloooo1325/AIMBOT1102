# AIMBOT1102 - Entities Application

A C# Windows Forms application built with Visual Studio 2022 using the Guna UI2 framework.

## Quick Start - For Users

### Run the Application
Simply download **`Entities.exe`** and double-click it to run. No installation needed!

**System Requirements:**
- Windows 7, 10, or 11
- .NET Framework 4.7.2 or higher

---

## For Developers - Building from Source

### Prerequisites
- Visual Studio 2022 (Community, Professional, or Enterprise)
- .NET Framework 4.7.2 Developer Pack
- NuGet Package Manager (included with VS)

### Steps to Build

1. **Clone or Open the Project**
   ```bash
   git clone https://github.com/aloooo1325/AIMBOT1102.git
   cd AIMBOT1102
   ```

2. **Open in Visual Studio**
   - Open `Entities.sln` in Visual Studio 2022

3. **Restore NuGet Packages**
   - Visual Studio will automatically restore packages
   - Or right-click the project → "Restore NuGet Packages"

4. **Build the Project**
   - Press `Ctrl + Shift + B` or go to Build → Build Solution

5. **Run the Application**
   - Press `F5` or click the green "Start" button
   - Or navigate to `bin\Release\` and run `Entities.exe`

### Building a Standalone Single EXE

To create a single `.exe` file with all dependencies merged:

1. Ensure the project builds successfully first
2. Build the project in **Release** mode
3. The ILMerge process will automatically run after build
4. Find your merged executable at: `Entities\bin\Release\Entities.exe`

This merged `.exe` can be shared and run on any Windows machine without requiring the DLL file!

---

## Project Structure

```
AIMBOT1102/
├── Entities/                 # Main project folder
│   ├── Entities.csproj      # Project file
│   ├── Form1.cs             # Main form
│   ├── Form1.Designer.cs    # Form designer code
│   ├── Form1.resx           # Form resources
│   ├── CROXY.cs             # Additional logic
│   ├── Program.cs           # Entry point
│   ├── App.config           # Application config
│   ├── packages.config      # NuGet dependencies
│   ├── Properties/          # Assembly info & resources
│   ├── Resources/           # Application resources
│   └── bin/                 # Build output
├── Entities.sln             # Solution file
└── README.md                # This file
```

---

## Dependencies

- **Guna.UI2.WinForms** v2.0.4.8 - Modern UI components for Windows Forms
- **ILMerge** v3.0.41 - Merges assemblies into a single executable

---

## Troubleshooting

### "The project does not compile"
- Make sure you have .NET Framework 4.7.2 installed
- Clean and rebuild the solution: `Build → Clean Solution` → `Build → Build Solution`

### "ILMerge failed"
- Ensure the build completed successfully first
- The ILMerge tool should be installed via NuGet automatically

### "Guna.UI2.dll not found"
- Restore NuGet packages: Right-click project → "Restore NuGet Packages"
- Close and reopen Visual Studio

---

## Sharing Your App

### Option 1: Share the Single EXE (Recommended)
1. Build in Release mode
2. Share the merged `Entities.exe` file
3. User just needs to download and run it!

### Option 2: Share the Release Folder
1. Build in Release mode
2. Go to `Entities\bin\Release\`
3. Share the entire folder
4. User runs `Entities.exe`

### Option 3: Share as Portable Zip
1. Create a Release build
2. Zip the `bin\Release` folder
3. User extracts and runs `Entities.exe`

---

## License

This project is provided as-is for personal use.

---

## Support

For issues or questions, please check the GitHub repository issues page.
