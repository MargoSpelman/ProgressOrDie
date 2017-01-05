/*
 * Authors: Isaiah Mann
 * Description: An interface to handle the audio module
 */

public interface IAudioModule {

	void Play(IAudioFile file);
	void Stop(IAudioFile file);

	bool TryLoadAudioClip(IAudioFile file);

	AudioFile ParseFile(string jsonText);

	IEvent ParseEvent(string jsonText);

}
