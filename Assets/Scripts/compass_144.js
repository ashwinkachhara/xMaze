var camAngle: float;

private var texWidth: float;
private var texHeight: float;
private var compTex: Texture2D;
private var imageTextAsset: TextAsset;

function Start() {
	imageTextAsset = Resources.Load("Compass", typeof(TextAsset)) as TextAsset;
	compTex = new Texture2D(512,64);
	compTex.LoadImage(imageTextAsset.bytes);
	texWidth = 360 / gameObject.main.fieldOfView * gameObject.main.aspect * Screen.width;
	texHeight = compTex.height * texWidth / compTex.width;
}


function OnGUI() {
	camAngle = gameObject.main.transform.eulerAngles.y;
	
	if (camAngle > 180) {
		camAngle -= 360;
	}
	
	var compX = Screen.width / 2 - camAngle / 360 * texWidth;
	GUI.DrawTexture(new Rect(compX - texWidth, 0, texWidth, texHeight), compTex);
	GUI.DrawTexture(new Rect(compX, 0, texWidth, texHeight), compTex);
}