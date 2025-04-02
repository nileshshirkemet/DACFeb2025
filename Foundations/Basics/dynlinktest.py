import ctypes

dij = ctypes.CDLL('./dijkstra.so')
m = abs(int(input('First Integer : ')))
n = abs(int(input('Second Integer: ')))
g = dij.gcd(m, n)
print('G.C.D =', g)


