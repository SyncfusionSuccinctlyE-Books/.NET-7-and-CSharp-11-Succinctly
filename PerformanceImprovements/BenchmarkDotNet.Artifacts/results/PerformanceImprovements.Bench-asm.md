## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; PerformanceImprovements.Bench.Min()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFCEAAA1300]; System.Linq.Enumerable.MinFloat[[System.Single, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Single>)
; Total bytes of code 10
```
```assembly
; System.Linq.Enumerable.MinFloat[[System.Single, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Single>)
       push      rbp
       push      rsi
       sub       rsp,68
       vzeroupper
       vmovaps   [rsp+50],xmm6
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       test      rcx,rcx
       je        near ptr M01_L16
       mov       rdx,[rcx]
       mov       rax,offset MT_System.Single[]
       cmp       rdx,rax
       jne       short M01_L00
       lea       rax,[rcx+10]
       mov       r8d,[rcx+8]
       jmp       short M01_L01
M01_L00:
       mov       rax,offset MT_System.Collections.Generic.List`1[[System.Single, System.Private.CoreLib]]
       cmp       rdx,rax
       jne       near ptr M01_L07
       mov       [rbp+10],rcx
       lea       rcx,[rbp-38]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFCEAAA3AE0]
       mov       rax,[rbp-38]
       mov       r8d,[rbp-30]
M01_L01:
       test      r8d,r8d
       je        near ptr M01_L17
       vmovss    xmm6,dword ptr [rax]
       mov       ecx,1
       cmp       r8d,1
       jbe       short M01_L05
M01_L02:
       cmp       ecx,r8d
       jae       near ptr M01_L18
       mov       r11d,ecx
       vmovss    xmm0,dword ptr [rax+r11*4]
       vucomiss  xmm6,xmm0
       jbe       short M01_L03
       vmovaps   xmm6,xmm0
       jmp       short M01_L04
M01_L03:
       vucomiss  xmm0,xmm0
       jp        short M01_L06
M01_L04:
       inc       ecx
       cmp       ecx,r8d
       jb        short M01_L02
M01_L05:
       vmovaps   xmm0,xmm6
       vmovaps   xmm6,[rsp+50]
       add       rsp,68
       pop       rsi
       pop       rbp
       ret
M01_L06:
       vmovaps   xmm6,[rsp+50]
       add       rsp,68
       pop       rsi
       pop       rbp
       ret
M01_L07:
       mov       r11,7FFCEA4C0498
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-40],rsi
       mov       rcx,rsi
       mov       r11,7FFCEA4C04A0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L12
       mov       rcx,rsi
       mov       r11,7FFCEA4C04A8
       call      qword ptr [r11]
       vmovaps   xmm6,xmm0
       vucomiss  xmm6,xmm6
       jp        short M01_L08
       je        short M01_L13
M01_L08:
       vmovss    dword ptr [rbp-24],xmm6
       jmp       short M01_L14
M01_L09:
       mov       rcx,rsi
       mov       r11,7FFCEA4C04B8
       call      qword ptr [r11]
       vucomiss  xmm6,xmm0
       jbe       short M01_L10
       vmovaps   xmm6,xmm0
       jmp       short M01_L13
M01_L10:
       vucomiss  xmm0,xmm0
       jp        short M01_L11
       je        short M01_L13
M01_L11:
       vmovss    dword ptr [rbp-24],xmm0
       jmp       short M01_L14
M01_L12:
       call      qword ptr [7FFCEA8CB7E0]
       int       3
M01_L13:
       mov       rcx,rsi
       mov       r11,7FFCEA4C04B0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,rsi
       mov       r11,7FFCEA4C04C0
       call      qword ptr [r11]
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsp
       call      M01_L19
       nop
       vmovss    xmm0,dword ptr [rbp-24]
       vmovaps   xmm6,[rsp+50]
       add       rsp,68
       pop       rsi
       pop       rbp
       ret
M01_L15:
       vmovaps   xmm0,xmm6
       vmovaps   xmm6,[rsp+50]
       add       rsp,68
       pop       rsi
       pop       rbp
       ret
M01_L16:
       mov       ecx,10
       call      qword ptr [7FFCEA8CB780]
       int       3
M01_L17:
       call      qword ptr [7FFCEA8CB7E0]
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L19:
       push      rbp
       push      rsi
       sub       rsp,48
       vzeroupper
       vmovaps   [rsp+30],xmm6
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rsi,[rbp-40]
       test      rsi,rsi
       je        short M01_L20
       mov       rcx,rsi
       mov       r11,7FFCEA4C04C0
       call      qword ptr [r11]
M01_L20:
       nop
       vmovaps   xmm6,[rsp+30]
       add       rsp,48
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 508
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; PerformanceImprovements.Bench.Max()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFCEAAE1600]; System.Linq.Enumerable.MaxFloat[[System.Single, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Single>)
; Total bytes of code 10
```
```assembly
; System.Linq.Enumerable.MaxFloat[[System.Single, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Single>)
       push      rbp
       push      rsi
       sub       rsp,68
       vzeroupper
       vmovaps   [rsp+50],xmm6
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       test      rcx,rcx
       je        near ptr M01_L19
       mov       rdx,[rcx]
       mov       rax,offset MT_System.Single[]
       cmp       rdx,rax
       jne       short M01_L00
       lea       rax,[rcx+10]
       mov       r8d,[rcx+8]
       jmp       short M01_L01
       xchg      ax,ax
M01_L00:
       mov       rax,offset MT_System.Collections.Generic.List`1[[System.Single, System.Private.CoreLib]]
       cmp       rdx,rax
       jne       near ptr M01_L09
       mov       [rbp+10],rcx
       lea       rcx,[rbp-38]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFCEAAE5708]
       mov       rax,[rbp-38]
       mov       r8d,[rbp-30]
M01_L01:
       test      r8d,r8d
       je        near ptr M01_L20
       xor       ecx,ecx
       jmp       short M01_L03
M01_L02:
       inc       ecx
M01_L03:
       cmp       ecx,r8d
       jge       short M01_L04
       mov       r11d,ecx
       vmovss    xmm0,dword ptr [rax+r11*4]
       vucomiss  xmm0,xmm0
       jp        short M01_L02
M01_L04:
       cmp       ecx,r8d
       jne       short M01_L05
       lea       ecx,[r8-1]
       cmp       ecx,r8d
       jae       near ptr M01_L21
       mov       r8d,ecx
       vmovss    xmm0,dword ptr [rax+r8*4]
       vmovaps   xmm6,[rsp+50]
       add       rsp,68
       pop       rsi
       pop       rbp
       ret
M01_L05:
       cmp       ecx,r8d
       jae       near ptr M01_L21
       mov       r11d,ecx
       vmovss    xmm6,dword ptr [rax+r11*4]
       cmp       ecx,r8d
       jae       short M01_L08
M01_L06:
       cmp       ecx,r8d
       jae       near ptr M01_L21
       mov       r11d,ecx
       vmovss    xmm0,dword ptr [rax+r11*4]
       vucomiss  xmm0,xmm6
       jbe       short M01_L07
       vmovaps   xmm6,xmm0
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jb        short M01_L06
M01_L08:
       vmovaps   xmm0,xmm6
       vmovaps   xmm6,[rsp+50]
       add       rsp,68
       pop       rsi
       pop       rbp
       ret
M01_L09:
       mov       r11,7FFCEA5004A8
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-40],rsi
       mov       rcx,rsi
       mov       r11,7FFCEA5004B0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L15
       mov       rcx,rsi
       mov       r11,7FFCEA5004B8
       call      qword ptr [r11]
       vmovaps   xmm6,xmm0
       vucomiss  xmm6,xmm6
       jp        short M01_L10
       je        short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       r11,7FFCEA5004C0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L14
       mov       rcx,rsi
       mov       r11,7FFCEA5004C8
       call      qword ptr [r11]
       vmovaps   xmm6,xmm0
       vucomiss  xmm6,xmm6
       jp        short M01_L10
M01_L11:
       mov       rcx,rsi
       mov       r11,7FFCEA5004D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L16
M01_L12:
       mov       rcx,rsi
       mov       r11,7FFCEA5004D8
       call      qword ptr [r11]
       vucomiss  xmm0,xmm6
       jbe       short M01_L13
       vmovaps   xmm6,xmm0
M01_L13:
       mov       rcx,rsi
       mov       r11,7FFCEA5004D0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L12
       jmp       short M01_L16
M01_L14:
       vmovss    dword ptr [rbp-24],xmm6
       jmp       short M01_L17
M01_L15:
       call      qword ptr [7FFCEA90B7E0]
       int       3
M01_L16:
       mov       rcx,rsi
       mov       r11,7FFCEA5004E0
       call      qword ptr [r11]
       jmp       short M01_L18
M01_L17:
       mov       rcx,rsp
       call      M01_L22
       nop
       vmovss    xmm0,dword ptr [rbp-24]
       vmovaps   xmm6,[rsp+50]
       add       rsp,68
       pop       rsi
       pop       rbp
       ret
M01_L18:
       vmovaps   xmm0,xmm6
       vmovaps   xmm6,[rsp+50]
       add       rsp,68
       pop       rsi
       pop       rbp
       ret
M01_L19:
       mov       ecx,10
       call      qword ptr [7FFCEA90B780]
       int       3
M01_L20:
       call      qword ptr [7FFCEA90B7E0]
       int       3
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L22:
       push      rbp
       push      rsi
       sub       rsp,48
       vzeroupper
       vmovaps   [rsp+30],xmm6
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rsi,[rbp-40]
       test      rsi,rsi
       je        short M01_L23
       mov       rcx,rsi
       mov       r11,7FFCEA5004E0
       call      qword ptr [r11]
M01_L23:
       nop
       vmovaps   xmm6,[rsp+30]
       add       rsp,48
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 619
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; PerformanceImprovements.Bench.Average()
       sub       rsp,28
       vzeroupper
       mov       rcx,[rcx+8]
       call      qword ptr [7FFCEAAD1300]; System.Linq.Enumerable.Average[[System.Single, System.Private.CoreLib],[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Single>)
       vcvtsd2ss xmm0,xmm0,xmm0
       add       rsp,28
       ret
; Total bytes of code 26
```
```assembly
; System.Linq.Enumerable.Average[[System.Single, System.Private.CoreLib],[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Single>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,90
       vzeroupper
       vmovaps   [rsp+80],xmm6
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-80],rsp
       test      rcx,rcx
       je        near ptr M01_L11
       mov       rdx,[rcx]
       mov       rax,offset MT_System.Single[]
       cmp       rdx,rax
       jne       short M01_L00
       lea       rax,[rcx+10]
       mov       esi,[rcx+8]
       jmp       short M01_L01
M01_L00:
       mov       rax,offset MT_System.Collections.Generic.List`1[[System.Single, System.Private.CoreLib]]
       cmp       rdx,rax
       jne       short M01_L02
       mov       [rbp+10],rcx
       lea       rcx,[rbp-40]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFCEAAD5708]
       mov       rax,[rbp-40]
       mov       esi,[rbp-38]
M01_L01:
       test      esi,esi
       je        near ptr M01_L12
       mov       [rbp-70],rax
       mov       [rbp-68],esi
       lea       rcx,[rbp-70]
       call      qword ptr [7FFCEAAD3BA0]; System.Linq.Enumerable.Sum[[System.Single, System.Private.CoreLib],[System.Double, System.Private.CoreLib]](System.ReadOnlySpan`1<Single>)
       vmovsd    qword ptr [rbp-30],xmm0
       lea       rdx,[rbp-48]
       mov       ecx,esi
       call      qword ptr [7FFCEAAF5078]; System.Double.TryConvertFrom[[System.Int32, System.Private.CoreLib]](Int32, Double ByRef)
       test      eax,eax
       je        near ptr M01_L13
       vmovsd    xmm0,qword ptr [rbp-48]
       vmovsd    xmm1,qword ptr [rbp-30]
       vdivsd    xmm0,xmm1,xmm0
       vmovaps   xmm6,[rsp+80]
       add       rsp,90
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L02:
       mov       r11,7FFCEA4F0498
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-78],rsi
       mov       rcx,rsi
       mov       r11,7FFCEA4F04A0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L07
       mov       rcx,rsi
       mov       r11,7FFCEA4F04A8
       call      qword ptr [r11]
       lea       rdx,[rbp-50]
       call      qword ptr [7FFCEAAD5C78]; System.Double.TryConvertFrom[[System.Single, System.Private.CoreLib]](Single, Double ByRef)
       test      eax,eax
       je        near ptr M01_L06
       vmovsd    xmm6,qword ptr [rbp-50]
       mov       edi,1
       mov       rcx,rsi
       mov       r11,7FFCEA4F04B0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       r11,7FFCEA4F04B8
       call      qword ptr [r11]
       lea       rdx,[rbp-58]
       call      qword ptr [7FFCEAAD5C78]; System.Double.TryConvertFrom[[System.Single, System.Private.CoreLib]](Single, Double ByRef)
       test      eax,eax
       je        short M01_L08
       vmovsd    xmm0,qword ptr [rbp-58]
       vaddsd    xmm6,xmm6,xmm0
       inc       rdi
       mov       rcx,rsi
       mov       r11,7FFCEA4F04B0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L03
M01_L04:
       lea       rdx,[rbp-60]
       mov       rcx,rdi
       call      qword ptr [7FFCEAAF97B0]; System.Double.TryConvertFrom[[System.Int64, System.Private.CoreLib]](Int64, Double ByRef)
       test      eax,eax
       je        short M01_L05
       vmovsd    xmm0,qword ptr [rbp-60]
       vdivsd    xmm0,xmm6,xmm0
       vmovsd    qword ptr [rbp-28],xmm0
       jmp       short M01_L10
M01_L05:
       xor       eax,eax
       mov       [rbp-60],rax
       jmp       short M01_L09
M01_L06:
       xor       eax,eax
       mov       [rbp-50],rax
       jmp       short M01_L09
M01_L07:
       call      qword ptr [7FFCEA8FB7E0]
       int       3
M01_L08:
       xor       eax,eax
       mov       [rbp-58],rax
M01_L09:
       call      qword ptr [7FFCEA8F79C0]
       int       3
M01_L10:
       mov       rcx,rsi
       mov       r11,7FFCEA4F04C0
       call      qword ptr [r11]
       vmovsd    xmm0,qword ptr [rbp-28]
       vmovaps   xmm6,[rsp+80]
       add       rsp,90
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L11:
       mov       ecx,10
       call      qword ptr [7FFCEA8FB780]
       int       3
M01_L12:
       call      qword ptr [7FFCEA8FB7E0]
       int       3
M01_L13:
       xor       eax,eax
       mov       [rbp-48],rax
       call      qword ptr [7FFCEA8F79C0]
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       vzeroupper
       vmovaps   [rsp+30],xmm6
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0A0]
       cmp       qword ptr [rbp-78],0
       je        short M01_L14
       mov       rcx,[rbp-78]
       mov       r11,7FFCEA4F04C0
       call      qword ptr [r11]
M01_L14:
       nop
       vmovaps   xmm6,[rsp+30]
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 601
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; PerformanceImprovements.Bench.Sum()
       sub       rsp,28
       vzeroupper
       mov       rcx,[rcx+8]
       call      qword ptr [7FFCEAAB1300]; System.Linq.Enumerable.Sum[[System.Single, System.Private.CoreLib],[System.Double, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Single>)
       vcvtsd2ss xmm0,xmm0,xmm0
       add       rsp,28
       ret
; Total bytes of code 26
```
```assembly
; System.Linq.Enumerable.Sum[[System.Single, System.Private.CoreLib],[System.Double, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Single>)
       push      rbp
       push      rsi
       sub       rsp,78
       vzeroupper
       vmovaps   [rsp+60],xmm6
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-60],rsp
       test      rcx,rcx
       je        near ptr M01_L06
       mov       rdx,[rcx]
       mov       rax,offset MT_System.Single[]
       cmp       rdx,rax
       jne       short M01_L00
       lea       rax,[rcx+10]
       mov       r8d,[rcx+8]
       jmp       near ptr M01_L04
M01_L00:
       mov       rax,offset MT_System.Collections.Generic.List`1[[System.Single, System.Private.CoreLib]]
       cmp       rdx,rax
       jne       short M01_L01
       mov       [rbp+10],rcx
       lea       rcx,[rbp-30]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFCEAAB5708]
       mov       rax,[rbp-30]
       mov       r8d,[rbp-28]
       jmp       short M01_L04
M01_L01:
       vxorps    xmm6,xmm6,xmm6
       mov       r11,7FFCEA4D0488
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-50],rsi
       mov       rcx,rsi
       mov       r11,7FFCEA4D0490
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L05
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFCEA4D0498
       call      qword ptr [r11]
       lea       rdx,[rbp-38]
       call      qword ptr [7FFCEAAB5C78]; System.Double.TryConvertFrom[[System.Single, System.Private.CoreLib]](Single, Double ByRef)
       test      eax,eax
       je        short M01_L03
       vmovsd    xmm0,qword ptr [rbp-38]
       vaddsd    xmm6,xmm6,xmm0
       mov       rcx,rsi
       mov       r11,7FFCEA4D0490
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L05
M01_L03:
       xor       eax,eax
       mov       [rbp-38],rax
       call      qword ptr [7FFCEA8D79C0]
       int       3
M01_L04:
       mov       [rbp-48],rax
       mov       [rbp-40],r8d
       lea       rcx,[rbp-48]
       call      qword ptr [7FFCEAAB3BA0]; System.Linq.Enumerable.Sum[[System.Single, System.Private.CoreLib],[System.Double, System.Private.CoreLib]](System.ReadOnlySpan`1<Single>)
       nop
       vmovaps   xmm6,[rsp+60]
       add       rsp,78
       pop       rsi
       pop       rbp
       ret
M01_L05:
       mov       rcx,rsi
       mov       r11,7FFCEA4D04A0
       call      qword ptr [r11]
       vmovaps   xmm0,xmm6
       vmovaps   xmm6,[rsp+60]
       add       rsp,78
       pop       rsi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFCEA8DB780]
       int       3
       push      rbp
       push      rsi
       sub       rsp,48
       vzeroupper
       vmovaps   [rsp+30],xmm6
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-50],0
       je        short M01_L07
       mov       rcx,[rbp-50]
       mov       r11,7FFCEA4D04A0
       call      qword ptr [r11]
M01_L07:
       nop
       vmovaps   xmm6,[rsp+30]
       add       rsp,48
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 394
```

