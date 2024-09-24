# RenameOnOverwrite

A script that can be run as a hook by [SFTPGo](https://sftpgo.com/) to rotate files with the same filename, rather than overwriting them.

Deployed to FaseExCashless.isis.cclrc.ac.uk to enable multiple files to be uploaded for a single pass in a day.

## Usage

 - Build the (win-x64) application with `dotnet publish`
 - Deploy the application to the host that's running SFTPGo
 - Set environment variables for SFTP configuration (by default, in a file in `env.d` of the SFTPGo installation directory):

```
SFTPGO_COMMON__ACTIONS__EXECUTE_ON=pre-upload
SFTPGO_COMMON__ACTIONS__HOOK="<path to executable>"
```
