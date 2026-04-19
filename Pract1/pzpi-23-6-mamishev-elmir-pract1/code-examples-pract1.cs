// Класи підсистеми
class VideoFile { public VideoFile(string name) { } }
class OggCompressionCodec : ISourceCodec { }
class MPEG4CompressionCodec : ISourceCodec { }
class CodecFactory
{
    public ISourceCodec Extract(VideoFile f)
    {
        return null;
    }
}
class BitrateReader
{
    public static VideoFile Read(string f,
    ISourceCodec c)
    {
        return null; 
    }
    public static VideoFile Convert(VideoFile b, ISourceCodec c)
    {
        return null;
    }
}
class AudioMixer
{
    public File Fix(VideoFile v)
    {
        return null;
    }
}
	// Клас Фасад
	class VideoConversionFacade
{
public File ConvertVideo(string fileName, string format)
   {
      VideoFile file = new VideoFile(fileName);
      ISourceCodec sourceCodec = new 
      CodecFactory().Extract(file);
      ISourceCodec destinationCodec = (format == "mp4")
         ? new MPEG4CompressionCodec()
         : new OggCompressionCodec();
      VideoFile buffer = BitrateReader.Read(fileName, 
      sourceCodec);
      VideoFile intermediateResult = 
      BitrateReader.Convert(buffer, 
      destinationCodec);
      File result = new AudioMixer().Fix(intermediateResult);
      return result;
   }
}
class Program {
   static void Main() {
      VideoConversionFacade converter = new 
      VideoConversionFacade();
      File mp4 = converter.ConvertVideo("video.ogg", "mp4");
   }
}
