// Jimmy Vegas Unity Tutorial
// This Script will rotate your stars and planet



var Speed : int;

function Update () {
	Speed = 2;
	transform.Rotate(0, Speed, 0, Space.World);
}