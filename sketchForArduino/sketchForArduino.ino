char* carNumbers[]={"У666МР111", "А064АА124", "С902СС156", "Т888ММ721", "Т888АМ341", "Т888РМ13", "Т888ЕЕ899"};

void setup() {
  Serial.begin(250000);
  pinMode(10, OUTPUT); 
  pinMode(9, OUTPUT);
  pinMode(8, OUTPUT);
}

void loop() {
  int index = random(7);
  Serial.println(carNumbers[index]);
  delay(1000);
  while (Serial.available())
  {
    char c = (char)Serial.read();
    Serial.flush();
    //Открытие () закрытие шлагбаума
    if (c == 'o')
      digitalWrite(10, HIGH);
    else if (c == 'c')
      digitalWrite(10, LOW);
    else if (c == 'g') {
      digitalWrite(9, HIGH);
      digitalWrite(8, LOW);
    }
    else if (c == 'r') {
      digitalWrite(9, LOW);
      digitalWrite(8, HIGH);
    }
  }
  delay(120000);
}
