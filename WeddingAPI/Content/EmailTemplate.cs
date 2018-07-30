﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeddingAPI.Content
{
    public static class EmailTemplate
    {
        public static string TemplateString
        {
            get
            {
                return
                    @"<!doctype html>
<html>
<head>
    <meta name=""viewport"" content=""width = device - width"">    
    </head>
    <body class="""" style=""background-color: #f6f6f6; font-family: sans-serif; -webkit-font-smoothing: antialiased; font-size: 14px; line-height: 1.4; margin: 0; padding: 0; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"">
    <table border = ""0"" cellpadding=""0"" cellspacing=""0"" class=""body"" style=""border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f6f6f6; width: 100%;"" width=""100%"" bgcolor=""#f6f6f6"">
        <tr>
            <td style = ""font-family: sans-serif; font-size: 14px; vertical-align: top;"" valign=""top"">&nbsp;</td>
            <td class=""container"" style=""font-family: sans-serif; font-size: 14px; vertical-align: top; display: block; max-width: 580px; padding: 10px; width: 580px; Margin: 0 auto;"" width=""580"" valign=""top"">
                <div class=""content"" style=""box-sizing: border-box; display: block; Margin: 0 auto; max-width: 580px; padding: 10px;"">

                    <!-- START CENTERED WHITE CONTAINER -->
                    <span class=""preheader"" style=""color: transparent; display: none; height: 0; max-height: 0; max-width: 0; opacity: 0; overflow: hidden; mso-hide: all; visibility: hidden; width: 0;"">We Invite You To Our Wedding! 诚挚邀请您参加我们的婚礼！</span>
                    <table class=""main align-center"" style=""border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; background: #ffffff; border-radius: 3px; width: 100%; text-align: center;"" width=""100%"" align=""center"">

                        <!-- START MAIN CONTENT AREA -->
                        <tr>
                            <td class=""wrapper"" style=""font-family: sans-serif; font-size: 14px; vertical-align: top; box-sizing: border-box; padding: 20px; background: linear-gradient(#ffffff, #f1f5f6);"" valign=""top"">
                                <table border = ""0"" cellpadding=""0"" cellspacing=""0"" style=""border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%;"" width=""100%"">
                                    <tr>
                                        <td style = ""font-family: sans-serif; font-size: 14px; vertical-align: top;"" valign=""top"">
                                            <h2 style = ""color: #dec7bf; font-family: sans-serif; font-weight: 400; line-height: 1.4; margin: 0; Margin-bottom: 30px;""> DEAR {DEAR_FRIEND}</h2>
                                            <p style = ""color: #b2b8b9; font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;""> You are cordially invited to celebrate the marriage of </p>
                                            <p style = ""color: #b2b8b9; font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;""><strong> Jingyi Guo & Xiao Yang</strong></p>
                                            <p style = ""color: #b2b8b9; font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;""> at Stone House, 50 Stirling Rd, Warren, NJ 07059</p>
                                            <p style = ""color: #b2b8b9; font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;""><strong> May 6th, 2018, Sunday, 11:30 a.m.</strong></p>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style = ""font-family: sans-serif; font-size: 14px; vertical-align: top;"" valign= ""top"">
                                            <p style = ""color: #b2b8b9; font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;""> Please visit our website below to respond by April 8th, with your email address and invitation code below!</p>
                                            <p style = ""color: #b2b8b9; font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;""> We look forward to your presence! </p>                                                        
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style = ""font-family: sans-serif; font-size: 14px; vertical-align: top;"" valign= ""top"">
    
                                                <strong style= ""border: 1px solid; border-color: #dec7bf; padding: 12px; font-size: 18px; color: #dec7bf; display: inline-block; margin: 8px 0 24px 0;"">{INV_CODE}</strong>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style = ""font-family: sans-serif; font-size: 14px; vertical-align: top;"" valign=""top"">                                                                                
                                            <p style= ""color: #b2b8b9; font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;""> 谨定于 <strong> 公历2018年05月06日 </strong></p>    
                                            <p style= ""color: #b2b8b9; font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;""> 为 <strong> 郭婧懿，杨潇</strong> 举行结婚典礼敬备喜宴</p>
                                            <p style = ""color: #b2b8b9; font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;""> 席设 Stone House, 50 Stirling Rd, Warren, NJ 07059</p>

                                        </td>
                                    </tr>
                                    <tr>
                                        <td style = ""font-family: sans-serif; font-size: 14px; vertical-align: top;"" valign=""top"">
                                            <p style = ""color: #b2b8b9; font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;""> 请点击以下链接，使用您的邮件地址及如上邀请码于4月8日之前回复!</p>
                                            <p style = ""color: #b2b8b9; font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;""> 我们衷心期待您的到来！</p>
                                            <br/>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style = ""font-family: sans-serif; font-size: 14px; vertical-align: top;"" valign=""top"">
                                            <table border = ""0"" cellpadding=""0"" cellspacing=""0"" class=""btn btn-primary"" style=""border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; box-sizing: border-box; width: 100%;"" width=""100%"">
                                                <tbody>
                                                    <tr>
                                                        <td align = ""center"" style=""font-family: sans-serif; font-size: 14px; vertical-align: top; padding-bottom: 15px;"" valign=""top"">
                                                            <table border = ""0"" cellpadding=""0"" cellspacing=""0"" style=""border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: auto;"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td style = ""font-family: sans-serif; font-size: 14px; vertical-align: top; border-radius: 5px; text-align: center; background-color: #598d8e;"" valign=""top"" align=""center"" bgcolor=""#598d8e""> <a href = ""http://www.jingyiguoandxiaoyang.com/en/index.html"" target=""_blank"" style=""border: solid 1px #3498db; border-radius: 5px; box-sizing: border-box; cursor: pointer; display: inline-block; font-size: 14px; font-weight: bold; margin: 0; padding: 12px 25px; text-decoration: none; text-transform: capitalize; background-color: #598d8e; border-color: #598d8e; color: #ffffff;"">RSVP(English)</a> </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                        <td align = ""center"" style=""font-family: sans-serif; font-size: 14px; vertical-align: top; padding-bottom: 15px;"" valign=""top"">
                                                            <table border = ""0"" cellpadding=""0"" cellspacing=""0"" style=""border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: auto;"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td style = ""font-family: sans-serif; font-size: 14px; vertical-align: top; border-radius: 5px; text-align: center; background-color: #598d8e;"" valign=""top"" align=""center"" bgcolor=""#598d8e""> <a href = ""http://www.jingyiguoandxiaoyang.com/cn/index.html"" target=""_blank"" style=""border: solid 1px #3498db; border-radius: 5px; box-sizing: border-box; cursor: pointer; display: inline-block; font-size: 14px; font-weight: bold; margin: 0; padding: 12px 25px; text-decoration: none; text-transform: capitalize; background-color: #598d8e; border-color: #598d8e; color: #ffffff;"">RSVP(简体中文)</a> </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>

                        <!-- END MAIN CONTENT AREA -->
                    </table>

                    <!-- START FOOTER -->
                    <div class=""footer"" style=""clear: both; Margin-top: 10px; text-align: center; width: 100%;"">
                        <table border = ""0"" cellpadding=""0"" cellspacing=""0"" style=""border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%;"" width=""100%"">
                            <tr>
                                <td class=""content-block"" style=""font-family: sans-serif; vertical-align: top; padding-bottom: 10px; padding-top: 10px; color: #999999; font-size: 12px; text-align: center;"" valign=""top"" align=""center"">
                                    <span class=""apple-link"" style=""color: #999999; font-size: 12px; text-align: center;""></span>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <!-- END FOOTER -->
                    <!-- END CENTERED WHITE CONTAINER -->
                </div>
            </td>
            <td style = ""font-family: sans-serif; font-size: 14px; vertical-align: top;"" valign=""top"">&nbsp;</td>
        </tr>
    </table>
</body>
</html>";
            }
        }

    }
}