	.include "console.i"

	.start	main

main:
	GetInt	askp
	mov	rbx, rax
	GetInt	askm
	mov	rcx, rax

	shl	rbx, 5			#rbx=32*rbx
	add	rbx, basic		#direct memory addressing
	mov	rdi, offset year
	mov	rax, [rdi+8*rcx]	#indirect memory addressing (indirection)
	mul	rbx

	PutInt	ans

	ret

askp:	.string	"Pay Grade: "
askm:	.string	"Month[1-12]: "
ans:	.string	"Salary = "
basic:	.quad	368
year:	.quad	0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31

	.end



