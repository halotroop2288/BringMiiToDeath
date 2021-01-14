using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using SFB;

public static class SaveLoad {

	private static bool HasExtension(string path, ExtensionFilter filter) {
		foreach (string ext in filter.Extensions) {
			if (path.EndsWith('.' + ext))
				return true;
		}
		return false;
	}
}
