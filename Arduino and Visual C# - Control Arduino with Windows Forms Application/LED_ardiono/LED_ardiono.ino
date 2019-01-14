int LED = 3;

void setup() {
  Serial.begin(9600);
  pinMode(LED, OUTPUT);
}

void loop() {
  char data = Serial.read();

  switch (data) {
    case '1':
      digitalWrite(LED, HIGH);
      break;
    case '0':
      digitalWrite(LED, LOW);
      break;
  }
}
