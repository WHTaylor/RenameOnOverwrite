// Script called by SFTPGo as a pre-upload action
// Checks if the file that's being uploaded already exists, and renames it if so
// to avoid overwriting it.

var uploadPath = Environment.GetEnvironmentVariable("SFTPGO_ACTION_PATH");

// No need to rename if it doesn't exist
if (!File.Exists(uploadPath)) Environment.Exit(0);

var dir = Path.GetDirectoryName(uploadPath);
if (dir == null) Environment.Exit(1);

var fileName = Path.GetFileNameWithoutExtension(uploadPath);
var newFileName = fileName + "_" + DateTime.Now.ToFileTime() + Path.GetExtension(uploadPath);
File.Move(uploadPath, Path.Combine(dir, newFileName));
