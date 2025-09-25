#include <Arduino.h>
// còi bị động 

#define BUZZER_PIN 9

void setup() {
  pinMode(BUZZER_PIN, OUTPUT);
}

void loop() {
  analogWrite(BUZZER_PIN, 250); 
  delay(2000);
  analogWrite(BUZZER_PIN, 0);   
  delay(2000);
}

//còi chủ động
/*
#define BUZZER_PIN 7  

void setup() {
  pinMode(BUZZER_PIN, OUTPUT);
  digitalWrite(BUZZER_PIN, LOW);  
}

void loop() {
  digitalWrite(BUZZER_PIN, HIGH); 
  delay(2000);                    
  digitalWrite(BUZZER_PIN, LOW);  
  delay(2000);                   
}
*/