package hamming

import "errors"

func Distance(a, b string) (int, error) {
	ar, br := []rune(a), []rune(b)

	if len(ar) != len(br) {
		return 0, errors.New("lengths of a and b must be equal")
	}

	dist := 0
	for i := 0; i < len(ar); i++ {
		if ar[i] != br[i] {
			dist++
		}
	}

	return dist, nil
}
