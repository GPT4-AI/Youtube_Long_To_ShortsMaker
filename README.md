# Youtube Long To ShortsMaker
Youtube Long To Shorts Maker

![image](https://github.com/user-attachments/assets/3515da88-7866-4e6b-bff6-5ee863e31701)






Youtube Long To ShortsMake is a Windows application for generating short clips from a video file. It allows users to:
- Select a video file from their computer.
- Download a video from YouTube.
- Specify an outro video to append to each generated clip.
- Generate multiple short clips from the selected video at random intervals.

## Features
- **Video Selection:** Choose a video file from your computer.
- **YouTube Downloading:** Download a video from YouTube using `yt-dlp`.
- **Clip Generation:** Extract multiple clips from a video based on random time intervals.
- **Outro Merging:** Optionally append an outro video to each clip.
- **FFmpeg Integration:** Uses `ffmpeg` and `ffprobe` for video processing.

## Requirements
To run ShortsMaker, you need:
- Windows OS
- [yt-dlp](https://github.com/yt-dlp/yt-dlp) for downloading YouTube videos
- [FFmpeg](https://ffmpeg.org/) for video processing

Ensure both `yt-dlp` and `ffmpeg` are added to your system's PATH.

## Installation
1. Download and install [yt-dlp](https://github.com/yt-dlp/yt-dlp) and [FFmpeg](https://ffmpeg.org/).
2. Clone this repository or download the source code.
3. Open the project in Visual Studio.
4. Build and run the application.

## Usage
1. **Browse a Video:** Click "Browse" to select a video file.
2. **Download from YouTube:** Paste a YouTube URL and click "Download Video."
3. **Specify Outro (Optional):** Select an outro video to be appended to each clip.
4. **Set Number of Clips:** Enter the number of clips to generate.
5. **Generate Clips:** Click "Generate Clips" to create short videos.

## Technologies Used
- **C# (WinForms)**: User interface development
- **yt-dlp**: Downloading YouTube videos
- **FFmpeg**: Video processing and editing
- **FFprobe**: Retrieving video duration

## License
This project is licensed under the MIT License.

## Acknowledgments
- [yt-dlp](https://github.com/yt-dlp/yt-dlp)
- [FFmpeg](https://ffmpeg.org/)

