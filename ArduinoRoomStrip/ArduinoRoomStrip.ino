#include <Adafruit_NeoPixel.h>

const int LEDStrip = 6;
const int NeopixelLEDStrip = 7;
const int numPixels = 150;

int selectedColor[3] = {255, 255, 255};
int brightness = 255;

int value1 = 0;
int value2 = 0;
int colorSelection = 0;

Adafruit_NeoPixel strip = Adafruit_NeoPixel(numPixels, NeopixelLEDStrip, NEO_GRB + NEO_KHZ800);

void setup() {
  pinMode(LEDStrip, OUTPUT);
  updateStrip(255);
  updateNeopixelStrip(255, false);
  strip.setBrightness(brightness);
  strip.begin();
  strip.clear();
  strip.show();
  Serial.begin(9600);
  Serial.setTimeout(50);
}

void loop() {
  while (!Serial.available()) {}
  String userInput = Serial.readString();

  // Data interpretation
  if (userInput.substring(0, 5) == "Color") {
    colorSelection = userInput.substring(5, 6).toInt();

    // Color selection
    if (colorSelection == 0) {
      selectedColor[0] = userInput.substring(6, 9).toInt();
      selectedColor[1] = userInput.substring(10, 13).toInt();
      selectedColor[2] = userInput.substring(14, 17).toInt();
      // If white
      if (selectedColor[0] + selectedColor[1] + selectedColor[2] == 0) {
        brightness = 128;
      }
      else {
        brightness = 255;
      }
    }

    updateNeopixelStrip(value2, true);
  }
  // Only update neopixel strip
  else if (userInput.substring(0, 3) == "   ") {
    value2 = userInput.substring(3, 6).toInt();
    updateNeopixelStrip(value2, false);
  }
  // Only update strip
  else if (userInput.substring(3, 6) == "   ") {
    value1 = userInput.substring(0, 3).toInt();
    updateStrip(value1);
  }
  // Update both
  else {
    value1 = userInput.substring(0, 3).toInt();
    value2 = userInput.substring(3, 6).toInt();

    updateStrip(value1);
    updateNeopixelStrip(value2, false);
  }

  Serial.println(value1);
  Serial.println(value2);
}

void updateStrip(int n) {
  analogWrite(LEDStrip, n);
}

void updateNeopixelStrip(int n, bool instant) {
  strip.clear();
  strip.setBrightness(brightness);
  if (colorSelection == 0) {
    if (instant) {
      for (int i = 0; i < n; i++) {
        strip.setPixelColor(i, strip.Color(selectedColor[0], selectedColor[1], selectedColor[2]));
      }
    }
    else {
      for (int i = 0; i < n; i++) {
        strip.setPixelColor(i, strip.Color(selectedColor[0], selectedColor[1], selectedColor[2]));
        strip.show();
      }
    }
  }
  else if (colorSelection == 1) {
    if (instant) {
      for (int i = 0; i < n; i++) {
        // Red
        if (i % 3 == 0) {
          strip.setPixelColor(i, strip.Color(255, 0, 0));
        }
        // Green
        else if (i % 3 == 1) {
          strip.setPixelColor(i, strip.Color(0, 255, 0));
        }
        // Blue
        else {
          strip.setPixelColor(i, strip.Color(0, 250, 255));
        }
      }
    }
    else {
      for (int i = 0; i < n; i++) {
        // Red
        if (i % 3 == 0) {
          strip.setPixelColor(i, strip.Color(255, 0, 0));
        }
        // Green
        else if (i % 3 == 1) {
          strip.setPixelColor(i, strip.Color(0, 255, 0));
        }
        // Blue
        else {
          strip.setPixelColor(i, strip.Color(0, 250, 255));
        }
        strip.show();
      }
    }
  }
  strip.show();
}