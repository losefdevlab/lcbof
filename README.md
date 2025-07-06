# LCBOF | Losefchat官方出品的客户端机器人框架

<!-- ALL-CONTRIBUTORS-BADGE:START - Do not remove or modify this section -->

[![All Contributors](https://img.shields.io/badge/all_contributors-2-orange.svg?style=flat-square)](#contributors-)

<!-- ALL-CONTRIBUTORS-BADGE:END -->

主要开发：阿龙<br>
Copyright (C) 2025 **LosefDevLab**<br>
Copyright (C) 2018-Now **XYLCS/XIT**<br>
Copyright (C) 2019-2025 **kakako Chat Community Studio(KCCS)**<br>
Copyright (C) 2024-2025 **PPPO Technological Team(PTT)**<br>

以上合并称为 LosefChat开发团队<br>

Lcbof (2025) by LosefChat开发团队 2025-Now freedom-create in XFCSTD2.<br>

XFCSTD PATH:/XFCSTD2.md

> **注意**：本项目需要自行编译，请参考文末的编译指南。<br>

## 1 主要内容

- 可由多人控制
- 方便快捷的使其他客户端用户使用这个机器人进行任何事情
- 自动任务，方便快捷的管理服务器
- 可自由开发

## 3 模组支持

Lcbof提供了模组支持功能：

1. 拉取 Lcbof 的代码。
2. 将模组代码按模组作者要求复制到模组开发区域。(如果模组作者有自动安装程序，则使用)
3. 在模组运行区域添加安装代码。
4. 重新编译 Lcbof，即可使用第三方功能。

---

## 如何编译？

请确保已安装 `dotnet` （版本 >= 8.0）、`openssl`（版本 >= 3.0）和 `git`，然后按照以下步骤操作：

```bash
git clone https://github.com/LosefDevLab/lcbof.git
cd lcbof
dotnet build
cd bin
cd Debug
cd net8.0
# 以下内容，仅需要安全通信服务端需要操作
openssl genpkey -algorithm RSA -out sfc.key -aes256
# ^^^生成密钥
openssl req -new -key sfc.key -out sfc.csr
# ^^^生成签名
# 此处仅为演示, 实际建议使用可靠的签名, 否则早晚被破解
# 微软40块钱一份的签名它不香吗？
openssl x509 -req -days 365 -in sfc.csr -signkey sfc.key -out sfc.crt
# ^^^签名认证
openssl pkcs12 -export -out sfc.pfx -inkey sfc.key -in sfc.crt
# ^^^导出
# 以上内容仅服务端需要操作, 客户端连接到这种开启安全通讯的服务器需要在程序同目录下提供服务器开放的安全通讯证书


# 运行
./lcbof
```


## 贡献&Git规范标准

CMTMSG规范

- 需要先创建当前要做的内容的计划issues, 这个issues可以是需要修复的、更新计划、功能添加(类似于JIRA工单)
- 当做完这些内容/做了新内容的其中一部分/修改新内容的部分/修复一些bug/合并, 按情况分别提交cmtmsg:
  - Add for #x : xxxxxxx
  - Add part for #x : xxxxxxx
  - Update for #x : xxxxxxx
  - Fix in #x : xxxxxxx
  - Merge branch xx(branchname) to xx(branch) in #x : xxxxxx

Release & tag信息规范

- 请使用WVPB版本号规则
- tag无需标注
- Release标题为版本号
- Release描述需用MD格式
- Release描述需按照以下格式进行编写:

  ```
  本次更新:
  -----
  - (本次阶段的所有CMTMSG)
  -----
  - (更新简述)
  ```

## License

LCBOF使用 MIT License

## Contributors ✨

Thanks goes to these wonderful people ([emoji key](https://allcontributors.org/docs/en/emoji-key)):

<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->

<!-- prettier-ignore-start -->

<!-- markdownlint-disable -->

<table>
  <tbody>
    <tr>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/Alonglosef"><img src="https://avatars.githubusercontent.com/u/200359803?v=4?s=100" width="100px;" alt="阿龙"/><br /><sub><b>阿龙</b></sub></a><br /><a href="https://github.com/losefdevlab/losefchat/commits?author=Alonglosef" title="Code">💻</a> <a href="#security-Alonglosef" title="Security">🛡️</a> <a href="https://github.com/losefdevlab/losefchat/commits?author=Alonglosef" title="Tests">⚠️</a> <a href="#design-Alonglosef" title="Design">🎨</a></td>
      <td align="center" valign="top" width="14.28%"><a href="http://www.xylcsstudio.com"><img src="https://avatars.githubusercontent.com/u/158823035?v=4?s=100" width="100px;" alt="XYLCS-Studio"/><br /><sub><b>XYLCS-Studio</b></sub></a><br /><a href="https://github.com/losefdevlab/losefchat/commits?author=XYLCS-Studio" title="Code">💻</a> <a href="https://github.com/losefdevlab/losefchat/issues?q=author%3AXYLCS-Studio" title="Bug reports">🐛</a> <a href="#design-XYLCS-Studio" title="Design">🎨</a></td>
    </tr>
  </tbody>
</table>

<!-- markdownlint-restore -->

<!-- prettier-ignore-end -->

<!-- ALL-CONTRIBUTORS-LIST:END -->

This project follows the [all-contributors](https://github.com/all-contributors/all-contributors) specification. Contributions of any kind welcome!
