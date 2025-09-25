#include <Arduino.h>

#define BUZZER_PIN 9
// tần số mỗi note 
const uint16_t melody[] = {
  262,262,294,262,349,330,
  262,262,294,262,392,349,
  262,262,523,440,349,330,294,
  466,466,440,349,392,349
};
// thời gian mỗi note
const uint16_t durMs[] = {
  250,250,500,500,500,1000,
  250,250,500,500,500,1000,
  250,250,500,500,500,500,1000,
  250,250,500,500,500,1000
};
const size_t N = sizeof(melody)/sizeof(melody[0]);// đếm số phần tử aray melody

bool playing = false,//đang phát ko? 
inGap = false;// khoảng nghỉ
size_t idx = 0;// index: đang note thứ mấy
unsigned long tNext = 0;// mốc time chuyển tt
const uint8_t GAP_DIV = 3;// độ dài nghỉ = dur/3

char buf[12]; uint8_t blen = 0;

void startSong(){ playing=true; idx=0; inGap=false; tNext=0;  }
void stopSong(){  playing=false; noTone(BUZZER_PIN);  }
// hàm xử lí cmd, viết thường hay viết hoa đều được
void handleCmd(const char* s){
  String S = String(s); S.trim(); S.toUpperCase();
  if (S=="ON")  { startSong(); Serial.println("PLAY"); }
  else if (S=="OFF"){ stopSong(); Serial.println("STOP"); }
  else if (S.length()) Serial.println("Invalid (ON/OFF)");
}

void setup() {
  pinMode(BUZZER_PIN, OUTPUT);
  Serial.begin(9600);
  Serial.println("Type ON / OFF");
}

void loop() {
  // xử lí chuỗi
  while (Serial.available()) {
    char c = Serial.read();
    if (c=='\r' || c=='\n') {
      if (blen) { buf[blen]='\0'; handleCmd(buf); blen=0; }
      // nuốt ký tự đôi CR+LF nếu có
    } else if (blen < sizeof(buf)-1) {
      buf[blen++] = c;
    }
  }

  // Phát nhạc
  if (!playing) return;// return ngay khi nhận lệnh off
  unsigned long now = millis();// đồng hồ hiện tại 

  if (tNext==0) {                   // bắt đầu nốt
    tone(BUZZER_PIN, melody[idx]);// phát nốt ở mảng thứ i
    tNext = now + durMs[idx];// hẹn giờ kết thúc nôte
    inGap = false;
  } else if (now >= tNext) {
    if (!inGap) {                   // chuyển sang nghỉ
      noTone(BUZZER_PIN);
      unsigned long gap = durMs[idx]/GAP_DIV; if (gap<10) gap=10;
      tNext = now + gap; inGap = true;
    } else {                        // sang nốt kế
      idx++;
      if (idx>=N) { stopSong(); return; }
      tone(BUZZER_PIN, melody[idx]);
      tNext = now + durMs[idx]; inGap = false;
    }
  }
}
