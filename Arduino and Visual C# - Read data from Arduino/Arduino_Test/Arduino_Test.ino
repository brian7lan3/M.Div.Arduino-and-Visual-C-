int Loop = 1;

void setup() {
  Serial.begin(9600);
}

void loop() {
  Serial.println(" Data Loop = " + String(Loop));
  Loop++;
  delay(500);
}
