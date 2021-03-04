# Image Resizer

## A C# Exercise

Build a simple command line application in .NET Core that resizes an image.

The application should accept two command line arguments:

* Image path - the location of the image file on the computer
* Width - the desired width of the new image

```sh
dotnet run myimage.jpg 32
```

When executed the application should create a new image in the same directory as the source image.

The new file should contain an image with the desired width and a new height that is proportional to the original height.
For example if the source image has a width of `100` and a height of `50` and you resize the image to a width of `50`,
the height should be `25`.

The new filename should be based on the source image filename and should also include the new dimensions.
For example a soure file named: `myimage.jpg` with dimensions `100x50` when resized to a width of `50`
should produce a file called `myimage_50x25.jpg`.

You should use this nuget package: https://www.nuget.org/packages/SixLabors.ImageSharp/

> **NOTE:** Make sure to build this application _incrementally_.
> It's recommended that you write out the steps you plan to take as a list of tasks that you can check off as you go.  
> For example:  
> 1. Read and print command line arguments
> 1. Copy image file without resizing it and save it with the new name
> 1.  ...