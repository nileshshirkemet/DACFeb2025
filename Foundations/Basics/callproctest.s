	.include "console.i"

	.start	main

#compute procedure takes N as argument in rax
#and returns N*(N+1)/2 as result in rax
compute:
	mov	rcx, rax
	add	rcx, 1
	mul	rcx
	shr	rax, 1	#fast rax=rax/2
	ret

main:
	GetInt	askl
	mov	rdi, rax	#rdi=L
	GetInt	asku
	mov	rsi, rax	#rsi=U

	cmp	rdi, rsi
	jg	done		#jump to instruction labelled done if rdi > rsi

	sub	rdi, 1		#rdi=L-1
	mov	rax, rdi	#N=L-1
	call	compute
	mov	rbx, rax
	mov	rax, rsi	#N=U
	call	compute
	sub	rax, rbx

	PutInt	ans

done:	ret

askl:	.string	"Lower Limit: "
asku:	.string	"Upper Limit: "
ans:	.string	"Sum of Integers = "

	.end

