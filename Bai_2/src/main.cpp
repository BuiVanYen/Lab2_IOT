#include <Arduino.h>
#define LED_PIN    13
#define BUZZER_PIN 9

void setup() {
  pinMode(LED_PIN, OUTPUT);
  pinMode(BUZZER_PIN, OUTPUT);
  Serial.begin(9600);
  Serial.println("Nhap: led on/off, buzzer on/off");
}

void loop() {
  if (Serial.available()) {
    String cmd = Serial.readStringUntil('\n');
    cmd.trim();

    if (cmd == "led on") {
      digitalWrite(LED_PIN, HIGH);
      Serial.println("LED ON");
    }
    else if (cmd == "led off") {
      digitalWrite(LED_PIN, LOW);
      Serial.println("LED OFF");
    }
    else if (cmd == "buzzer on") {
      tone(BUZZER_PIN, 2000);
      Serial.println("BUZZER ON");
    }
    else if (cmd == "buzzer off") {
      noTone(BUZZER_PIN);
      Serial.println("BUZZER OFF");
    }
    else {
      Serial.println("Invalid command");
    }
  }
}
