# UAC-Control
方便配置指定程序UAC策略

[![LICENSE](https://img.shields.io/github/license/mashape/apistatus.svg?style=flat-square&label=LICENSE)](https://github.com/maytom2016/UAC-Control/blob/master/LICENSE)
![GitHub Stars](https://img.shields.io/github/stars/maytom2016/UAC-Control.svg?style=flat-square&label=Stars&logo=github)
![GitHub Forks](https://img.shields.io/github/forks/maytom2016/UAC-Control.svg?style=flat-square&label=Forks&logo=github)

## 用途
特定程序运行时会请求UAC，可以在注册表HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers应用他们对应的策略。
本程序简化这个过程，直接在程序中修改相关策略，主要用途是让一些不应该请求管理员权限的应用别弹出请求窗口。

## 用法
有UI，可以直接看直接用，有疑问BUG可以提ISSUES，有空会看。
