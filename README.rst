极验验证
========
极验行为验证是一款可以帮助你的网站与 APP 应用识别与拦截机器程序批量自动化操作的SaaS应用。它是由极验开发的
新一代人机验证产品，它不基于传统“问题-答案”的检测模式，而是通过利用深度学习对验证过程中产生的行为数据进行
高维分析，发现人机行为模式与行为特征的差异，更加精准地区分人机行为。


集成流程
--------
行为验证的整个集成流程是顺序进行的，业务层主要涉及到客户端和服务端的部署，在下一个步骤开始前请确保上一个
步骤的检查点都已经正确完成；请开发者严格按照步骤进行。

步骤   注册极验账户(1) - 登录极验后台(2) - 注册验证ID和Key (3) - 配置ID属性(4) - 集成服务端代码(5) - 
	   集成客户端代码(6) - 服务上线(7) - 数据上线(8) - 登录后台查看数据(9)


新手指南
--------
0. 产品概述 - https://docs.geetest.com/install/overview/prodes/
1. 入门指引 - https://docs.geetest.com/install/overview/beginner/


文档导航
--------
* 部署指引 - https://docs.geetest.com/install/overview/guide
* 数据通讯流程 - https://docs.geetest.com/install/overview/flowchart
* 服务的部署 - https://docs.geetest.com/install/deploy/server/csharp
* 客户端部署 - https://docs.geetest.com/install/deploy/client/web
* 名词解释 - https://docs.geetest.com/install/help/glossary
* 常见问题 - https://docs.geetest.com/install/help/faq


联系我们
--------
* 官网： www.geetest.com
* 技术支持邮箱：service@geetest.com
* 技术支持电话：400-8521-816
* 联系商务邮箱：cooperation@geetest.com
* 联系商务电话：13720157161


Gt C# SDK
=========

极验验证　C#　SDK,支持.Net Framework3.5及以上版本．本项目提供的Demo的前端实现方法均是面向PC端的。 本项目是面向服务器端的，具体使用可以参考我们的 `文档 <http://www.geetest.com/install/sections/idx-server-sdk.html>`_ ,客户端相关开发请参考我们的 `前端文档 <http://www.geetest.com/install/>`_.

**注意事项：部署在生产环境中时，需要将gt.js文件存放到项目中并在页面中引用该文件。该js的作用是充分利用多CDN，使静态文件尽可能加载成功。**

开发环境
________

    - Visual Studio（推荐VS2012以上版本）
    - .NET Framework 4.5

快速开始
________

1. 从 `Github <https://github.com/GeeTeam/gt-csharp-sdk/>`_ 上Clone代码:

.. code-block:: bash

    $ git clone https://github.com/GeeTeam/gt-csharp-sdk.git

2. 根据你的.Net Framework版本编译代码(或者用VS打开项目直接运行DEMO)．
3. 将编译完成的DLL引入你的项目.
4. 编写你的代码，代码示例:

.. code-block:: csharp

	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using System.Web.UI;
	using System.Web.UI.WebControls;
	using GeetestSDK;

	namespace demo
	{
	    public partial class GetCaptcha : System.Web.UI.Page
	    {
	        protected void Page_Load(object sender, EventArgs e)
	        {
	            Response.ContentType = "application/json";
	            Response.Write(getCaptcha());
	            Response.End();
	        }
	        private String getCaptcha()
	        {
	            GeetestLib geetest = new GeetestLib(GeetestConfig.publicKey, GeetestConfig.privateKey);
	            Byte gtServerStatus = geetest.preProcess();
	            Session[GeetestLib.gtServerStatusSessionKey] = gtServerStatus;
	            return geetest.getResponseStr();
	        }
	    }
	}


发布日志
-----------------
+ 3.1.1

 - 统一接口

+ 3.1.0

 - 添加challenge加密特性，使验证更安全， 老版本更新请先联系管理员

+ 2.0.2
    - 修复Failback Bug

+ 2.0.1 
    - 完善注释
    - 添加API文档
    - 修改Demo
+ 2.0.0
    - 去除旧的接口
    - 添加注释
