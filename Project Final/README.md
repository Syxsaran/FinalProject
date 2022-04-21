# ReportSalesCoffee

**ความเป็นมาของโปรแกรม**
```
เนื่องจากในตอนเด็กผมอยากกิจการร้านกาแฟเล็กๆเป็นของตัวเอง ผมจึงสร้างโปรแกรมนี้ขึ้นมา
```
**วัตถุประสงค์ของโปรแกรม**
```
โปรแกรมนี้สร้างขึ้นเพื่อที่จะบันทึกว่าในเเต่ละวันมีการขายกาแฟและของหวานอาหารไปเท่าไหร่
```
**Class diagram**
```mermaid
classDiagram
  direction LR
  class form1{
  login()
  logout()
  }
  class logout{
  close()
  }
  class form2{
  -coffee
  -sweet
  -food
  logincoffee()
  logindessert()
  loginfood()
  }
  class classcoffee{
  -number
  -name
  -amount
  -date
  add()
  }
  class classsweet{
  -number
  -name
  -amount
  -date
  add()
  }
  class classfood{
  -number
  -name
  -amount
  -date
  add()
  }
  class Filecoffee{
  -
  open()
  save()
  }
  class Filesweet{
  -
  open()
  save()
  }
  class Filefood{
  -
  open()
  save()
  }
  class opensweet{
  -location file
  open file()
  }
  class savesweet{
  -location file
  save file()
  }
  class opencoffee{
  -location file
  open file()
  }
  class savecoffee{
  -location file
  save file()
  }
  class openfood{
  -location file
  open file()
  }
  class savefood{
  -location file
  save file()
  }
  
  savefood --|> Filefood
  openfood --|> Filefood
  
  savecoffee --|> Filecoffee
  opencoffee --|> Filecoffee
  
  savesweet --|> Filesweet
  opensweet --|> Filesweet
  
  Filesweet --|> classsweet
  Filecoffee --|> classcoffee
  Filefood --|> classfood
  
  classcoffee --|> form2
  classsweet --|> form2
  classfood --|> form2

  
  form2 --|> form1
  logout --|> form1
  ```
**เจ้าของโปรแกรม**
```นาย ศรันย์ ซุ่นเส้ง 643450086-6```
