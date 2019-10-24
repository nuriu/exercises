package hamming

import "github.com/pkg/errors"

func Distance(a, b string) (int, error) {
	if len(a) != len(b) {
		return -1, errors.New("lengths of a and b must be equal")
	}

	dist := 0
	for i := 0; i < len(a); i++ {
		if a[i] != b[i] {
			dist++
		}
	}

	return dist, nil
}
