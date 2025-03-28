	.include "console.i"

	.extern gcd
	.start	main

main:
	GetInt	ask

	mov	rdi, rax
	GetInt	ask
	mov	rsi, rax
	call	gcd

	PutInt	ans

	ret


ask:	.string	"Positive Integer: "
ans:	.string	"G.C.D = "

	.end
