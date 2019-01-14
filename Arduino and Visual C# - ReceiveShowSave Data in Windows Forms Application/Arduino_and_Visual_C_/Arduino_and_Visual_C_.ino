int analogpin = 0;

void setup() {
  Serial.begin(9600);
}

void loop() {
  int value = analogRead(analogpin);
  Serial.println(value);
  delay(1000);
}
