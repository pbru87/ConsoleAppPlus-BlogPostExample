# ConsoleAppPlus

This project is used as the basis for a **Visual Studio** project template. To create the template, open the solution with Visual Studio (2022). Then click on the "***Project***" menu and choose "***Export Template...***"!

Possible **description**: "*Console App with additional functionality (Dependency Injection, appsettings.json).*"

After the export, you could manually insert the following **tags** into the file "***MyTemplate.vstemplate***".

```xml
<TemplateData>
    <LanguageTag>csharp</LanguageTag>
    <PlatformTag>windows</PlatformTag>
    <PlatformTag>linux</PlatformTag>
    <PlatformTag>macos</PlatformTag>
    <ProjectTypeTag>console</ProjectTypeTag>
</TemplateData>
```

For more information, please see [my related blog post](http://bit.ly/3WuFlUX)!

Additional resources:

- [How to: Create project templates](https://learn.microsoft.com/en-us/visualstudio/ide/how-to-create-project-templates)
- [Create custom project and item templates](https://learn.microsoft.com/en-us/visualstudio/extensibility/creating-custom-project-and-item-templates)
- [Add tags to project templates](https://learn.microsoft.com/en-us/visualstudio/ide/template-tags)
- [How to: Locate and organize project and item templates](https://learn.microsoft.com/en-us/visualstudio/ide/how-to-locate-and-organize-project-and-item-templates)