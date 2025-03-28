	.include "common.i"

	.global	gcd #publish gcd label so that it is visible in other modules

gcd:
1:	cmp	rdi, rsi
	je	3f
	ja	2f
	sub	rsi, rdi
	jmp	1b
2:	sub	rdi, rsi
	jmp	1b
3:	mov	rax, rdi
	ret

	.end


