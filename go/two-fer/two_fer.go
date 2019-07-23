package twofer

func ShareWith(name string) string {
	s := "One for "

	if name != "" {
		s += name
	} else {
		s += "you"
	}
	s += ", one for me."

	return s
}
