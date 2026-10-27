using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017FA RID: 6138
	[UnrealObjectPath("/Script/KuroData.TraceBaseElement")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UTraceBaseElement : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016B62 RID: 93026 RVA: 0x0021274D File Offset: 0x0021094D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTraceBaseElement._ClassPtr;
		}

		// Token: 0x06016B63 RID: 93027 RVA: 0x0021275C File Offset: 0x0021095C
		public UTraceBaseElement() : this(BuiltinUtils.AllocNativeUObject(UTraceBaseElement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016B64 RID: 93028 RVA: 0x00212784 File Offset: 0x00210984
		[NullableContext(1)]
		public UTraceBaseElement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTraceBaseElement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005BCD RID: 23501
		// (get) Token: 0x06016B65 RID: 93029 RVA: 0x002127B7 File Offset: 0x002109B7
		// (set) Token: 0x06016B66 RID: 93030 RVA: 0x002127CB File Offset: 0x002109CB
		[Nullable(2)]
		public unsafe UObject WorldContextObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + UTraceBaseElement.__PropertyOffset_WorldContextObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTraceBaseElement.__PropertyOffset_WorldContextObject, value);
			}
		}

		// Token: 0x17005BCE RID: 23502
		// (get) Token: 0x06016B67 RID: 93031 RVA: 0x002127E0 File Offset: 0x002109E0
		// (set) Token: 0x06016B68 RID: 93032 RVA: 0x00212819 File Offset: 0x00210A19
		[Nullable(1)]
		public TArray<AActor> ActorsToIgnore
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._ActorsToIgnore) == null)
				{
					result = (this._ActorsToIgnore = new TArray<AActor>(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_ActorsToIgnore, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ActorsToIgnore.CopyAssign(value);
			}
		}

		// Token: 0x17005BCF RID: 23503
		// (get) Token: 0x06016B69 RID: 93033 RVA: 0x00212827 File Offset: 0x00210A27
		// (set) Token: 0x06016B6A RID: 93034 RVA: 0x0021283B File Offset: 0x00210A3B
		[Nullable(2)]
		public unsafe UKuroHitResult HitResult
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroHitResult>(base.NativePtr / (IntPtr)sizeof(void*) + UTraceBaseElement.__PropertyOffset_HitResult);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTraceBaseElement.__PropertyOffset_HitResult, value);
			}
		}

		// Token: 0x17005BD0 RID: 23504
		// (get) Token: 0x06016B6B RID: 93035 RVA: 0x00212850 File Offset: 0x00210A50
		// (set) Token: 0x06016B6C RID: 93036 RVA: 0x00212860 File Offset: 0x00210A60
		public unsafe double StartX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_StartX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_StartX) = value;
			}
		}

		// Token: 0x17005BD1 RID: 23505
		// (get) Token: 0x06016B6D RID: 93037 RVA: 0x00212871 File Offset: 0x00210A71
		// (set) Token: 0x06016B6E RID: 93038 RVA: 0x00212881 File Offset: 0x00210A81
		public unsafe double StartY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_StartY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_StartY) = value;
			}
		}

		// Token: 0x17005BD2 RID: 23506
		// (get) Token: 0x06016B6F RID: 93039 RVA: 0x00212892 File Offset: 0x00210A92
		// (set) Token: 0x06016B70 RID: 93040 RVA: 0x002128A2 File Offset: 0x00210AA2
		public unsafe double StartZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_StartZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_StartZ) = value;
			}
		}

		// Token: 0x17005BD3 RID: 23507
		// (get) Token: 0x06016B71 RID: 93041 RVA: 0x002128B3 File Offset: 0x00210AB3
		// (set) Token: 0x06016B72 RID: 93042 RVA: 0x002128C3 File Offset: 0x00210AC3
		public unsafe double EndX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_EndX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_EndX) = value;
			}
		}

		// Token: 0x17005BD4 RID: 23508
		// (get) Token: 0x06016B73 RID: 93043 RVA: 0x002128D4 File Offset: 0x00210AD4
		// (set) Token: 0x06016B74 RID: 93044 RVA: 0x002128E4 File Offset: 0x00210AE4
		public unsafe double EndY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_EndY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_EndY) = value;
			}
		}

		// Token: 0x17005BD5 RID: 23509
		// (get) Token: 0x06016B75 RID: 93045 RVA: 0x002128F5 File Offset: 0x00210AF5
		// (set) Token: 0x06016B76 RID: 93046 RVA: 0x00212905 File Offset: 0x00210B05
		public unsafe double EndZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_EndZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_EndZ) = value;
			}
		}

		// Token: 0x17005BD6 RID: 23510
		// (get) Token: 0x06016B77 RID: 93047 RVA: 0x00212916 File Offset: 0x00210B16
		// (set) Token: 0x06016B78 RID: 93048 RVA: 0x00212926 File Offset: 0x00210B26
		public unsafe float TraceColor_R
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_TraceColor_R);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_TraceColor_R) = value;
			}
		}

		// Token: 0x17005BD7 RID: 23511
		// (get) Token: 0x06016B79 RID: 93049 RVA: 0x00212937 File Offset: 0x00210B37
		// (set) Token: 0x06016B7A RID: 93050 RVA: 0x00212947 File Offset: 0x00210B47
		public unsafe float TraceColor_G
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_TraceColor_G);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_TraceColor_G) = value;
			}
		}

		// Token: 0x17005BD8 RID: 23512
		// (get) Token: 0x06016B7B RID: 93051 RVA: 0x00212958 File Offset: 0x00210B58
		// (set) Token: 0x06016B7C RID: 93052 RVA: 0x00212968 File Offset: 0x00210B68
		public unsafe float TraceColor_B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_TraceColor_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_TraceColor_B) = value;
			}
		}

		// Token: 0x17005BD9 RID: 23513
		// (get) Token: 0x06016B7D RID: 93053 RVA: 0x00212979 File Offset: 0x00210B79
		// (set) Token: 0x06016B7E RID: 93054 RVA: 0x00212989 File Offset: 0x00210B89
		public unsafe float TraceColor_A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_TraceColor_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_TraceColor_A) = value;
			}
		}

		// Token: 0x17005BDA RID: 23514
		// (get) Token: 0x06016B7F RID: 93055 RVA: 0x0021299A File Offset: 0x00210B9A
		// (set) Token: 0x06016B80 RID: 93056 RVA: 0x002129AA File Offset: 0x00210BAA
		public unsafe float TraceHitColor_R
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_TraceHitColor_R);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_TraceHitColor_R) = value;
			}
		}

		// Token: 0x17005BDB RID: 23515
		// (get) Token: 0x06016B81 RID: 93057 RVA: 0x002129BB File Offset: 0x00210BBB
		// (set) Token: 0x06016B82 RID: 93058 RVA: 0x002129CB File Offset: 0x00210BCB
		public unsafe float TraceHitColor_G
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_TraceHitColor_G);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_TraceHitColor_G) = value;
			}
		}

		// Token: 0x17005BDC RID: 23516
		// (get) Token: 0x06016B83 RID: 93059 RVA: 0x002129DC File Offset: 0x00210BDC
		// (set) Token: 0x06016B84 RID: 93060 RVA: 0x002129EC File Offset: 0x00210BEC
		public unsafe float TraceHitColor_B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_TraceHitColor_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_TraceHitColor_B) = value;
			}
		}

		// Token: 0x17005BDD RID: 23517
		// (get) Token: 0x06016B85 RID: 93061 RVA: 0x002129FD File Offset: 0x00210BFD
		// (set) Token: 0x06016B86 RID: 93062 RVA: 0x00212A0D File Offset: 0x00210C0D
		public unsafe float TraceHitColor_A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_TraceHitColor_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_TraceHitColor_A) = value;
			}
		}

		// Token: 0x17005BDE RID: 23518
		// (get) Token: 0x06016B87 RID: 93063 RVA: 0x00212A1E File Offset: 0x00210C1E
		// (set) Token: 0x06016B88 RID: 93064 RVA: 0x00212A2E File Offset: 0x00210C2E
		public unsafe float DrawTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_DrawTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_DrawTime) = value;
			}
		}

		// Token: 0x17005BDF RID: 23519
		// (get) Token: 0x06016B89 RID: 93065 RVA: 0x00212A3F File Offset: 0x00210C3F
		// (set) Token: 0x06016B8A RID: 93066 RVA: 0x00212A4F File Offset: 0x00210C4F
		public unsafe bool bTraceComplex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_bTraceComplex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_bTraceComplex) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005BE0 RID: 23520
		// (get) Token: 0x06016B8B RID: 93067 RVA: 0x00212A60 File Offset: 0x00210C60
		// (set) Token: 0x06016B8C RID: 93068 RVA: 0x00212A70 File Offset: 0x00210C70
		public unsafe bool bIgnoreSelf
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_bIgnoreSelf) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_bIgnoreSelf) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005BE1 RID: 23521
		// (get) Token: 0x06016B8D RID: 93069 RVA: 0x00212A81 File Offset: 0x00210C81
		// (set) Token: 0x06016B8E RID: 93070 RVA: 0x00212A91 File Offset: 0x00210C91
		public unsafe bool bIsSingle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_bIsSingle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_bIsSingle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005BE2 RID: 23522
		// (get) Token: 0x06016B8F RID: 93071 RVA: 0x00212AA2 File Offset: 0x00210CA2
		// (set) Token: 0x06016B90 RID: 93072 RVA: 0x00212AB2 File Offset: 0x00210CB2
		public unsafe bool bIsBoth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_bIsBoth) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_bIsBoth) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005BE3 RID: 23523
		// (get) Token: 0x06016B91 RID: 93073 RVA: 0x00212AC3 File Offset: 0x00210CC3
		// (set) Token: 0x06016B92 RID: 93074 RVA: 0x00212AD3 File Offset: 0x00210CD3
		public unsafe bool bIsTraceCapsuleAsSphere
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_bIsTraceCapsuleAsSphere) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_bIsTraceCapsuleAsSphere) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005BE4 RID: 23524
		// (get) Token: 0x06016B93 RID: 93075 RVA: 0x00212AE4 File Offset: 0x00210CE4
		// (set) Token: 0x06016B94 RID: 93076 RVA: 0x00212AF4 File Offset: 0x00210CF4
		public unsafe bool bIsProfile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_bIsProfile) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_bIsProfile) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005BE5 RID: 23525
		// (get) Token: 0x06016B95 RID: 93077 RVA: 0x00212B05 File Offset: 0x00210D05
		// (set) Token: 0x06016B96 RID: 93078 RVA: 0x00212B19 File Offset: 0x00210D19
		public unsafe FName ProfileName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_ProfileName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBaseElement.__PropertyOffset_ProfileName) = value;
			}
		}

		// Token: 0x06016B97 RID: 93079 RVA: 0x00212B2E File Offset: 0x00210D2E
		public void SetTraceTypeQuery(ETraceTypeQuery Type)
		{
			UTraceBaseElement.__SetTraceTypeQuery_Internal(base.NativePtr, Type);
		}

		// Token: 0x06016B98 RID: 93080 RVA: 0x00212B41 File Offset: 0x00210D41
		public void SetTraceHitColor(float R, float G, float B, float A)
		{
			UTraceBaseElement.__SetTraceHitColor_Internal(base.NativePtr, R, G, B, A);
		}

		// Token: 0x06016B99 RID: 93081 RVA: 0x00212B53 File Offset: 0x00210D53
		public void SetTraceColor(float R, float G, float B, float A)
		{
			UTraceBaseElement.__SetTraceColor_Internal(base.NativePtr, R, G, B, A);
		}

		// Token: 0x06016B9A RID: 93082 RVA: 0x00212B65 File Offset: 0x00210D65
		public void SetStartLocation(double X, double Y, double Z)
		{
			UTraceBaseElement.__SetStartLocation_Internal(base.NativePtr, X, Y, Z);
		}

		// Token: 0x06016B9B RID: 93083 RVA: 0x00212B75 File Offset: 0x00210D75
		public void SetObjectTypesQuery([Nullable(new byte[]
		{
			2,
			0
		})] ref TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes)
		{
			UTraceBaseElement.__SetObjectTypesQuery_Internal(base.NativePtr, (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr);
		}

		// Token: 0x06016B9C RID: 93084 RVA: 0x00212B92 File Offset: 0x00210D92
		public void SetEndLocation(double X, double Y, double Z)
		{
			UTraceBaseElement.__SetEndLocation_Internal(base.NativePtr, X, Y, Z);
		}

		// Token: 0x06016B9D RID: 93085 RVA: 0x00212BA2 File Offset: 0x00210DA2
		public void SetDrawDebugTrace(EDrawDebugTrace Type)
		{
			UTraceBaseElement.__SetDrawDebugTrace_Internal(base.NativePtr, Type);
		}

		// Token: 0x06016B9E RID: 93086 RVA: 0x00212BB5 File Offset: 0x00210DB5
		public void Dispose()
		{
			UTraceBaseElement.__Dispose_Internal(base.NativePtr);
		}

		// Token: 0x06016B9F RID: 93087 RVA: 0x00212BC2 File Offset: 0x00210DC2
		public void ClearCacheData(bool bClearWorld = false)
		{
			UTraceBaseElement.__ClearCacheData_Internal(base.NativePtr, bClearWorld);
		}

		// Token: 0x06016BA0 RID: 93088 RVA: 0x00212BD0 File Offset: 0x00210DD0
		public void AddObjectTypeQuery(EObjectTypeQuery ObjectType)
		{
			UTraceBaseElement.__AddObjectTypeQuery_Internal(base.NativePtr, ObjectType);
		}

		// Token: 0x06016BA1 RID: 93089
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTraceTypeQuery_Internal(IntPtr @this, TEnumAsByte<ETraceTypeQuery> Type);

		// Token: 0x06016BA2 RID: 93090
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTraceHitColor_Internal(IntPtr @this, float R, float G, float B, float A);

		// Token: 0x06016BA3 RID: 93091
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTraceColor_Internal(IntPtr @this, float R, float G, float B, float A);

		// Token: 0x06016BA4 RID: 93092
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartLocation_Internal(IntPtr @this, double X, double Y, double Z);

		// Token: 0x06016BA5 RID: 93093
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetObjectTypesQuery_Internal(IntPtr @this, IntPtr ObjectTypes);

		// Token: 0x06016BA6 RID: 93094
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndLocation_Internal(IntPtr @this, double X, double Y, double Z);

		// Token: 0x06016BA7 RID: 93095
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDrawDebugTrace_Internal(IntPtr @this, TEnumAsByte<EDrawDebugTrace> Type);

		// Token: 0x06016BA8 RID: 93096
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Dispose_Internal(IntPtr @this);

		// Token: 0x06016BA9 RID: 93097
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearCacheData_Internal(IntPtr @this, bool bClearWorld);

		// Token: 0x06016BAA RID: 93098
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddObjectTypeQuery_Internal(IntPtr @this, TEnumAsByte<EObjectTypeQuery> ObjectType);

		// Token: 0x06016BAB RID: 93099 RVA: 0x00212BE3 File Offset: 0x00210DE3
		static UTraceBaseElement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroData.TraceBaseElement");
		}

		// Token: 0x06016BAC RID: 93100 RVA: 0x00212BF1 File Offset: 0x00210DF1
		protected UTraceBaseElement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C54B RID: 50507
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroData.TraceBaseElement";

		// Token: 0x0400C54C RID: 50508
		private static IntPtr _ClassPtr;

		// Token: 0x0400C54D RID: 50509
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C54E RID: 50510
		internal static int __PropertyOffset_WorldContextObject;

		// Token: 0x0400C54F RID: 50511
		internal static int __PropertyOffset_ActorsToIgnore;

		// Token: 0x0400C550 RID: 50512
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ActorsToIgnore;

		// Token: 0x0400C551 RID: 50513
		internal static int __PropertyOffset_HitResult;

		// Token: 0x0400C552 RID: 50514
		internal static int __PropertyOffset_StartX;

		// Token: 0x0400C553 RID: 50515
		internal static int __PropertyOffset_StartY;

		// Token: 0x0400C554 RID: 50516
		internal static int __PropertyOffset_StartZ;

		// Token: 0x0400C555 RID: 50517
		internal static int __PropertyOffset_EndX;

		// Token: 0x0400C556 RID: 50518
		internal static int __PropertyOffset_EndY;

		// Token: 0x0400C557 RID: 50519
		internal static int __PropertyOffset_EndZ;

		// Token: 0x0400C558 RID: 50520
		internal static int __PropertyOffset_TraceColor_R;

		// Token: 0x0400C559 RID: 50521
		internal static int __PropertyOffset_TraceColor_G;

		// Token: 0x0400C55A RID: 50522
		internal static int __PropertyOffset_TraceColor_B;

		// Token: 0x0400C55B RID: 50523
		internal static int __PropertyOffset_TraceColor_A;

		// Token: 0x0400C55C RID: 50524
		internal static int __PropertyOffset_TraceHitColor_R;

		// Token: 0x0400C55D RID: 50525
		internal static int __PropertyOffset_TraceHitColor_G;

		// Token: 0x0400C55E RID: 50526
		internal static int __PropertyOffset_TraceHitColor_B;

		// Token: 0x0400C55F RID: 50527
		internal static int __PropertyOffset_TraceHitColor_A;

		// Token: 0x0400C560 RID: 50528
		internal static int __PropertyOffset_DrawTime;

		// Token: 0x0400C561 RID: 50529
		internal static int __PropertyOffset_bTraceComplex;

		// Token: 0x0400C562 RID: 50530
		internal static int __PropertyOffset_bIgnoreSelf;

		// Token: 0x0400C563 RID: 50531
		internal static int __PropertyOffset_bIsSingle;

		// Token: 0x0400C564 RID: 50532
		internal static int __PropertyOffset_bIsBoth;

		// Token: 0x0400C565 RID: 50533
		internal static int __PropertyOffset_bIsTraceCapsuleAsSphere;

		// Token: 0x0400C566 RID: 50534
		internal static int __PropertyOffset_bIsProfile;

		// Token: 0x0400C567 RID: 50535
		internal static int __PropertyOffset_ProfileName;
	}
}
