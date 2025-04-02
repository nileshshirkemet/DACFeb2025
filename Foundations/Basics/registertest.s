	.include "console.i"

	.start main

main:
	GetInt	asku		#rax=N
	
	mov	rcx, rax	#rcx=N
	add	rcx, 1		#rcx=N+1
	mul	rcx		#rax=N*(N+1)
	mov	rcx, 2		#rdx=2
	div	rcx		#rax=N*(N+1)/2	

	PutInt	ans

	ret

asku:	.string	"Upper Limit: "
ans:	.string	"Sum of Integers = "

	.end


