	.include "console.i"

	.start main

main:
	PutMsg	greet
	ret

greet:	.string	"Hello World!\n"

	.end


