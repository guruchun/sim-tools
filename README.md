# sim-tools
## SimFCCM
연료전지 제어장치 시뮬레이터
- Modbus Server(TCP)
   * 관리콘솔이나 Calibration Tool 테스트용으로 제어장치의 역할을 수행한다.
   * 제어장치가 제공하는 Modbus Map의 정보를 조회/변경할 수 있다.
- Modbus Server(RTU)
   * HMI Panel 테스트용으로 제어장치의 역할을 수행한다.

## SimFCIF
연료전지 제어장치가 인터페이스하는 주변 장치 시뮬레이터
- 내부 장치
   * 지필로스 인버터 1K
   * 지필로스 인버터 10K
   * 지필로스 인버터 10K-Modbus/RTU
   * 온도모듈
   * 온도모듈-Modbus/RTU
- 외부 장치(시스템)
   * COGEN
   * Site Controller
   * Site Controller(PLC)-Modbus/RTU