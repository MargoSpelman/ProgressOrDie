/*
 * Author: Isaiah Mann
 * Description: Interface to define the User Interface module
 */

public interface IUIModule {

	UIElement Get(string id);

	void Show(UIElement element);
	void Hide(UIElement element);

	void AddListener(UIElement element, UIEventListener listener);
	void AddHandler(UIElement element, UIEventHandler handler);

}
