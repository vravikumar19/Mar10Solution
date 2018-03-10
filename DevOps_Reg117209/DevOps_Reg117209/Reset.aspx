<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reset.aspx.cs" Inherits="DevOps_Reg117209.Reset" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reset Password</title>
</head>
<body>
    <form id="frmReset1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Enter Old Password</td>
                    <td><input type="text" runat="server" id="txtOldPassword" /></td>
                </tr>
                 <tr>
                    <td>Enter New Password</td>
                    <td><input type="text" runat="server" id="txtNewPasswpord" /></td>
                </tr>
                <tr>
                    <td>Confirm New Password</td>
                    <td><input type="text" runat="server" id="txtConfirmNewPwd" /></td>
                </tr>
                <tr>
                   
                    <td><input type="button" runat="server" id="cmdSubmit" value="Submit"/></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
