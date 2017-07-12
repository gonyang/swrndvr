var uvAnimationTileX = 24; //Here you can place the number of columns of your sheet. 
                           //The above sheet has 24
 
var uvAnimationTileY = 1; //Here you can place the number of rows of your sheet. 
                          //The above sheet has 1
var framesPerSecond = 10.0;
private var rNum = 1.0;
private	var currentTime = 0;

private var temp : int;
// DanceFloorAnimSpeed.animSpeed = 2;

framesPerSecond = DanceFloor_ChangeSpeed.animSpeed;

function Start() 
{


// print(framesPerSecond);

}


function Update () {
 	framesPerSecond = DanceFloor_ChangeSpeed.animSpeed;
	// Calculate index
	var index : int = Time.time * framesPerSecond;


	// rNum = ((1 / uvAnimationTileX) *  Random.Range(1, uvAnimationTileX));
    
	// uvAnimationTileX = uvAnimationTileX + 1;

	// repeat when exhausting all frames
	index = index % (uvAnimationTileX * uvAnimationTileY);


	if (index > currentTime) 
	{
	currentTime = index;
	rNum = ((1.0 / uvAnimationTileX) * Random.Range(1, uvAnimationTileX));;

	}
	 
 
	// Size of every tile
	var size = Vector2 (1.0 / uvAnimationTileX, 1.0 / uvAnimationTileY);
 
	// split into horizontal and vertical index
	var uIndex = index % uvAnimationTileX;
	var vIndex = index / uvAnimationTileX;


 
	// build offset
	// v coordinate is the bottom of the image in opengl so we need to invert.
	var offset = Vector2 (rNum, 1.0 - size.y - vIndex * size.y);

	// var offset = Vector2 (uIndex * size.x, 1.0 - size.y - vIndex * size.y);
 
	// GetComponent.<Renderer>().material.SetTextureOffset ("_DetailAlbedoMap", offset);
	// GetComponent.<Renderer>().material.SetTextureScale ("_DetailAlbedoMap", size);
	// GetComponent.<Renderer>().material.SetTextureOffset ("_DetailMask", offset);
	// GetComponent.<Renderer>().material.SetTextureScale ("_DetailMask", size);

	GetComponent.<Renderer>().material.SetTextureOffset ("_MainTex", offset);
	GetComponent.<Renderer>().material.SetTextureScale ("_MainTex", size);

}