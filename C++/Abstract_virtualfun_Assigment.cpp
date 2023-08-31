#include<iostream>
using namespace std;

class MediaPlayer
{
	public:
	virtual void play()=0;
	virtual void pause()=0;
	virtual void stop()=0;
};
class AudioPlayer: public MediaPlayer
{
	
	public:
	void play()
	{
		cout<<"Audio is Playing: "<<endl;
	}
	void pause()
	{
		cout<<"Audio is paused: "<<endl;
	}
	void stop()
	{
		cout<<"Audio is stop: "<<endl;
	}
};
class VideoPlayer: public MediaPlayer
{
	public:
	void play()
	{
		cout<<"Video is Playing: "<<endl;
	}
	void pause()
	{
		cout<<"Video is paused: "<<endl;
	}
	void stop()
	{
		cout<<"Video is stop: "<<endl;
	}
};

int main()
{
	AudioPlayer AP;
	VideoPlayer VP;
	
	AP.play();
	AP.pause();
	AP.stop();
	VP.play();
	VP.pause();
	VP.stop();
	return 0;
}
