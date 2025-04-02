	.include "console.i"

	.start	main

main:
	GetInt	askl
	mov	rdi, rax	#rdi=L
	GetInt	asku
	mov	rsi, rax	#rsi=U

	cmp	rdi, rsi
	jg	done		#jump to instruction labelled done if rdi > rsi

	sub	rdi, 1		#rdi=L-1
	mov	rax, rdi	#N=L-1
	mov	rcx, rax
	add	rcx, 1
	mul	rcx
	mov	rcx, 2
	div	rcx
	mov	rbx, rax
	mov	rax, rsi	#N=U
	mov	rcx, rax
	add	rcx, 1
	mul	rcx
	mov	rcx, 2
	div	rcx
	sub	rax, rbx

	PutInt	ans

done:	ret

askl:	.string	"Lower Limit: "
asku:	.string	"Upper Limit: "
ans:	.string	"Sum of Integers = "

	.end

