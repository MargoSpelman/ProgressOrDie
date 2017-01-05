/*
 * Author: Isaiah Mann
 * Desc: Handles controller all the modules
 */

using UnityEngine;

public class ModuleController : SingletonController<ModuleController> {
	[SerializeField]
	Module[] modules;
}
