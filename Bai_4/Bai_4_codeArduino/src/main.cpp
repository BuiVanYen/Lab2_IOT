#include <Arduino.h>

#define LED1_PIN 7
#define LED2_PIN 8

char prev = 0;  // lưu ký tự trước (B/T)

void setup() {
  pinMode(LED1_PIN, OUTPUT);
  pinMode(LED2_PIN, OUTPUT);
  digitalWrite(LED1_PIN, LOW);  
  digitalWrite(LED2_PIN, LOW);
  Serial.begin(9600);           
}


void handlePair(char a, char b) {
  if (a == 'B' && b == '1') { digitalWrite(LED1_PIN, HIGH); Serial.println("LED1 ON"); }
  else if (a == 'T' && b == '1') { digitalWrite(LED1_PIN, LOW);  Serial.println("LED1 OFF"); }
  else if (a == 'B' && b == '2') { digitalWrite(LED2_PIN, HIGH); Serial.println("LED2 ON"); }
  else if (a == 'T' && b == '2') { digitalWrite(LED2_PIN, LOW);  Serial.println("LED2 OFF"); }
}

void loop() {
  while (Serial.available()) {
    char c = Serial.read();

    // Nếu ký tự trước là B/T và ký tự hiện tại là 1/2 -> đủ cặp lệnh
    if ((prev == 'B' || prev == 'T') && (c == '1' || c == '2')) {
      handlePair(prev, c);
      prev = 0;                 // reset để chờ cặp mới
    } else {
      // Chỉ ghi nhớ khi là B hoặc T; ký tự rác khác thì bỏ
      prev = (c == 'B' || c == 'T') ? c : 0;
    }
  }
}
