package hamming

import "errors"

// Distance calculates distance between two dna strands
func Distance(a, b string) (int, error) {
	ar, br := []rune(a), []rune(b)

	if len(ar) != len(br) {
		return 0, errors.New("lengths of a and b must be equal")
	}

	dist := 0
	for i := range ar {
		if ar[i] != br[i] {
			dist++
		}
	}

	return dist, nil
}
