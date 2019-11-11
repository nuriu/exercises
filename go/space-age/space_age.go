package space

// Planet basic string type to represent planet names
type Planet string

var secondsPerEarthYear = 31557600.0

var orbitalPeriods = map[Planet]float64{
	"Earth":   secondsPerEarthYear * 1.0,
	"Mercury": secondsPerEarthYear * 0.2408467,
	"Venus":   secondsPerEarthYear * 0.61519726,
	"Mars":    secondsPerEarthYear * 1.8808158,
	"Jupiter": secondsPerEarthYear * 11.862615,
	"Saturn":  secondsPerEarthYear * 29.447498,
	"Uranus":  secondsPerEarthYear * 84.016846,
	"Neptune": secondsPerEarthYear * 164.79132,
}

// Age calculates age
func Age(seconds float64, planet Planet) float64 {
	return seconds / orbitalPeriods[planet]
}
