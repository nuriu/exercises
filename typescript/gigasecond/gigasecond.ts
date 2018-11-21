export default class Gigasecond {
  private d: Date

  constructor(d: Date) {
    this.d = d
    this.d.setSeconds(d.getSeconds() + 1000000000)
  }

  date(): Date {
    return this.d
  }
}
