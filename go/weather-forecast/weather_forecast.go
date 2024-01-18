// Package weather constructs weather forecast sentence
// for given city with given condition.
package weather

// CurrentCondition represents weather condition.
var CurrentCondition string

// CurrentLocation represents current city.
var CurrentLocation string

// Forecast returns forecast for given city with given condition.
func Forecast(city, condition string) string {
	CurrentLocation, CurrentCondition = city, condition
	return CurrentLocation + " - current weather condition: " + CurrentCondition
}
