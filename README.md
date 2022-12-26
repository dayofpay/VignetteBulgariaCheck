## VignetteCheckBG

Цел на проекта: 

- VignetteCheckBG е създаден с цел да ви даде пълна информация относно винетката на МПС, да проверява за наличие на глоби от КАТ и да прави периодични проверки за изтичаща винетката




 ### Tech Stack

* Bunifu UI

* C#

* JSON ( За parse-ване на данните от API-то на КАТ и БГТОЛ)

 ### API

* МВР БГ

* АПИ - Агенция "Пътна инфраструктура"


## Снимка на проекта ( Потребителско меню )
![Меню](https://cdn.discordapp.com/attachments/798641136716611614/1032304357137461349/smartmockups_l9fr244s.jpg)

# V-DEVS API

* Вземи общ брой проверени винетки
```http
https://v-devs.online/api.php?getTotalVignetteChecks
```
* Взима последната версия на софтуера
```http
https://v-devs.online/api.php?getLatestVersion&source=vignette
```
* Взима link за сваляне на последната версия към софтуера
```http
https://v-devs.online/api.php?getLatestVersion&source=vignette&getDownloadURL
```
* Взима данни за всяка версия на софтуера
```http
https://v-devs.online/api.php?getVersions&software=vignettecheckbg&datatype=allData
```
* Взима всички налични ПУБЛИЧНИ версии за софтуера
```http
https://v-devs.online/api.php?getVersions&software=vignettecheckbg&datatype=versionsOnly
```
* Взима всички налични линкове за сваляне на софтуера
```http
https://v-devs.online/api.php?getVersions&software=vignettecheckbg&datatype=downloadURL_all
```
