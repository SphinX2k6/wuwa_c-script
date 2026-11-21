using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200036C RID: 876
	[UnrealObjectPath("/Script/KuroData.TraceBaseElement")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UTraceBaseElement : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005938 RID: 22840 RVA: 0x0007DE6D File Offset: 0x0007C06D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTraceBaseElement._ClassPtr;
		}

		// Token: 0x06005939 RID: 22841 RVA: 0x0007DE7C File Offset: 0x0007C07C
		public UTraceBaseElement() : this(BuiltinUtils.AllocNativeUObject(UTraceBaseElement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600593A RID: 22842 RVA: 0x0007DEA4 File Offset: 0x0007C0A4
		[NullableContext(1)]
		public UTraceBaseElement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTraceBaseElement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x0600593B RID: 22843 RVA: 0x0007DED7 File Offset: 0x0007C0D7
		// (set) Token: 0x0600593C RID: 22844 RVA: 0x0007DEEB File Offset: 0x0007C0EB
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

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x0600593D RID: 22845 RVA: 0x0007DF00 File Offset: 0x0007C100
		// (set) Token: 0x0600593E RID: 22846 RVA: 0x0007DF39 File Offset: 0x0007C139
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

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x0600593F RID: 22847 RVA: 0x0007DF47 File Offset: 0x0007C147
		// (set) Token: 0x06005940 RID: 22848 RVA: 0x0007DF5B File Offset: 0x0007C15B
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

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x06005941 RID: 22849 RVA: 0x0007DF70 File Offset: 0x0007C170
		// (set) Token: 0x06005942 RID: 22850 RVA: 0x0007DF80 File Offset: 0x0007C180
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

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x06005943 RID: 22851 RVA: 0x0007DF91 File Offset: 0x0007C191
		// (set) Token: 0x06005944 RID: 22852 RVA: 0x0007DFA1 File Offset: 0x0007C1A1
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

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x06005945 RID: 22853 RVA: 0x0007DFB2 File Offset: 0x0007C1B2
		// (set) Token: 0x06005946 RID: 22854 RVA: 0x0007DFC2 File Offset: 0x0007C1C2
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

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x06005947 RID: 22855 RVA: 0x0007DFD3 File Offset: 0x0007C1D3
		// (set) Token: 0x06005948 RID: 22856 RVA: 0x0007DFE3 File Offset: 0x0007C1E3
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

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x06005949 RID: 22857 RVA: 0x0007DFF4 File Offset: 0x0007C1F4
		// (set) Token: 0x0600594A RID: 22858 RVA: 0x0007E004 File Offset: 0x0007C204
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

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x0600594B RID: 22859 RVA: 0x0007E015 File Offset: 0x0007C215
		// (set) Token: 0x0600594C RID: 22860 RVA: 0x0007E025 File Offset: 0x0007C225
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

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x0600594D RID: 22861 RVA: 0x0007E036 File Offset: 0x0007C236
		// (set) Token: 0x0600594E RID: 22862 RVA: 0x0007E046 File Offset: 0x0007C246
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

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x0600594F RID: 22863 RVA: 0x0007E057 File Offset: 0x0007C257
		// (set) Token: 0x06005950 RID: 22864 RVA: 0x0007E067 File Offset: 0x0007C267
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

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x06005951 RID: 22865 RVA: 0x0007E078 File Offset: 0x0007C278
		// (set) Token: 0x06005952 RID: 22866 RVA: 0x0007E088 File Offset: 0x0007C288
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

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x06005953 RID: 22867 RVA: 0x0007E099 File Offset: 0x0007C299
		// (set) Token: 0x06005954 RID: 22868 RVA: 0x0007E0A9 File Offset: 0x0007C2A9
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

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x06005955 RID: 22869 RVA: 0x0007E0BA File Offset: 0x0007C2BA
		// (set) Token: 0x06005956 RID: 22870 RVA: 0x0007E0CA File Offset: 0x0007C2CA
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

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x06005957 RID: 22871 RVA: 0x0007E0DB File Offset: 0x0007C2DB
		// (set) Token: 0x06005958 RID: 22872 RVA: 0x0007E0EB File Offset: 0x0007C2EB
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

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x06005959 RID: 22873 RVA: 0x0007E0FC File Offset: 0x0007C2FC
		// (set) Token: 0x0600595A RID: 22874 RVA: 0x0007E10C File Offset: 0x0007C30C
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

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x0600595B RID: 22875 RVA: 0x0007E11D File Offset: 0x0007C31D
		// (set) Token: 0x0600595C RID: 22876 RVA: 0x0007E12D File Offset: 0x0007C32D
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

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x0600595D RID: 22877 RVA: 0x0007E13E File Offset: 0x0007C33E
		// (set) Token: 0x0600595E RID: 22878 RVA: 0x0007E14E File Offset: 0x0007C34E
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

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x0600595F RID: 22879 RVA: 0x0007E15F File Offset: 0x0007C35F
		// (set) Token: 0x06005960 RID: 22880 RVA: 0x0007E16F File Offset: 0x0007C36F
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

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x06005961 RID: 22881 RVA: 0x0007E180 File Offset: 0x0007C380
		// (set) Token: 0x06005962 RID: 22882 RVA: 0x0007E190 File Offset: 0x0007C390
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

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x06005963 RID: 22883 RVA: 0x0007E1A1 File Offset: 0x0007C3A1
		// (set) Token: 0x06005964 RID: 22884 RVA: 0x0007E1B1 File Offset: 0x0007C3B1
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

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x06005965 RID: 22885 RVA: 0x0007E1C2 File Offset: 0x0007C3C2
		// (set) Token: 0x06005966 RID: 22886 RVA: 0x0007E1D2 File Offset: 0x0007C3D2
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

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x06005967 RID: 22887 RVA: 0x0007E1E3 File Offset: 0x0007C3E3
		// (set) Token: 0x06005968 RID: 22888 RVA: 0x0007E1F3 File Offset: 0x0007C3F3
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

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x06005969 RID: 22889 RVA: 0x0007E204 File Offset: 0x0007C404
		// (set) Token: 0x0600596A RID: 22890 RVA: 0x0007E214 File Offset: 0x0007C414
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

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x0600596B RID: 22891 RVA: 0x0007E225 File Offset: 0x0007C425
		// (set) Token: 0x0600596C RID: 22892 RVA: 0x0007E239 File Offset: 0x0007C439
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

		// Token: 0x0600596D RID: 22893 RVA: 0x0007E24E File Offset: 0x0007C44E
		public void SetTraceTypeQuery(ETraceTypeQuery Type)
		{
			UTraceBaseElement.__SetTraceTypeQuery_Internal(base.NativePtr, Type);
		}

		// Token: 0x0600596E RID: 22894 RVA: 0x0007E261 File Offset: 0x0007C461
		public void SetTraceHitColor(float R, float G, float B, float A)
		{
			UTraceBaseElement.__SetTraceHitColor_Internal(base.NativePtr, R, G, B, A);
		}

		// Token: 0x0600596F RID: 22895 RVA: 0x0007E273 File Offset: 0x0007C473
		public void SetTraceColor(float R, float G, float B, float A)
		{
			UTraceBaseElement.__SetTraceColor_Internal(base.NativePtr, R, G, B, A);
		}

		// Token: 0x06005970 RID: 22896 RVA: 0x0007E285 File Offset: 0x0007C485
		public void SetStartLocation(double X, double Y, double Z)
		{
			UTraceBaseElement.__SetStartLocation_Internal(base.NativePtr, X, Y, Z);
		}

		// Token: 0x06005971 RID: 22897 RVA: 0x0007E295 File Offset: 0x0007C495
		public void SetObjectTypesQuery([Nullable(new byte[]
		{
			2,
			0
		})] ref TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes)
		{
			UTraceBaseElement.__SetObjectTypesQuery_Internal(base.NativePtr, (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr);
		}

		// Token: 0x06005972 RID: 22898 RVA: 0x0007E2B2 File Offset: 0x0007C4B2
		public void SetEndLocation(double X, double Y, double Z)
		{
			UTraceBaseElement.__SetEndLocation_Internal(base.NativePtr, X, Y, Z);
		}

		// Token: 0x06005973 RID: 22899 RVA: 0x0007E2C2 File Offset: 0x0007C4C2
		public void SetDrawDebugTrace(EDrawDebugTrace Type)
		{
			UTraceBaseElement.__SetDrawDebugTrace_Internal(base.NativePtr, Type);
		}

		// Token: 0x06005974 RID: 22900 RVA: 0x0007E2D5 File Offset: 0x0007C4D5
		public void Dispose()
		{
			UTraceBaseElement.__Dispose_Internal(base.NativePtr);
		}

		// Token: 0x06005975 RID: 22901 RVA: 0x0007E2E2 File Offset: 0x0007C4E2
		public void ClearCacheData(bool bClearWorld = false)
		{
			UTraceBaseElement.__ClearCacheData_Internal(base.NativePtr, bClearWorld);
		}

		// Token: 0x06005976 RID: 22902 RVA: 0x0007E2F0 File Offset: 0x0007C4F0
		public void AddObjectTypeQuery(EObjectTypeQuery ObjectType)
		{
			UTraceBaseElement.__AddObjectTypeQuery_Internal(base.NativePtr, ObjectType);
		}

		// Token: 0x06005977 RID: 22903
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTraceTypeQuery_Internal(IntPtr @this, TEnumAsByte<ETraceTypeQuery> Type);

		// Token: 0x06005978 RID: 22904
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTraceHitColor_Internal(IntPtr @this, float R, float G, float B, float A);

		// Token: 0x06005979 RID: 22905
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTraceColor_Internal(IntPtr @this, float R, float G, float B, float A);

		// Token: 0x0600597A RID: 22906
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartLocation_Internal(IntPtr @this, double X, double Y, double Z);

		// Token: 0x0600597B RID: 22907
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetObjectTypesQuery_Internal(IntPtr @this, IntPtr ObjectTypes);

		// Token: 0x0600597C RID: 22908
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndLocation_Internal(IntPtr @this, double X, double Y, double Z);

		// Token: 0x0600597D RID: 22909
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDrawDebugTrace_Internal(IntPtr @this, TEnumAsByte<EDrawDebugTrace> Type);

		// Token: 0x0600597E RID: 22910
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Dispose_Internal(IntPtr @this);

		// Token: 0x0600597F RID: 22911
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearCacheData_Internal(IntPtr @this, bool bClearWorld);

		// Token: 0x06005980 RID: 22912
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddObjectTypeQuery_Internal(IntPtr @this, TEnumAsByte<EObjectTypeQuery> ObjectType);

		// Token: 0x06005981 RID: 22913 RVA: 0x0007E303 File Offset: 0x0007C503
		static UTraceBaseElement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroData.TraceBaseElement");
		}

		// Token: 0x06005982 RID: 22914 RVA: 0x0007E311 File Offset: 0x0007C511
		protected UTraceBaseElement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040024E3 RID: 9443
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroData.TraceBaseElement";

		// Token: 0x040024E4 RID: 9444
		private static IntPtr _ClassPtr;

		// Token: 0x040024E5 RID: 9445
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040024E6 RID: 9446
		internal static int __PropertyOffset_WorldContextObject;

		// Token: 0x040024E7 RID: 9447
		internal static int __PropertyOffset_ActorsToIgnore;

		// Token: 0x040024E8 RID: 9448
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ActorsToIgnore;

		// Token: 0x040024E9 RID: 9449
		internal static int __PropertyOffset_HitResult;

		// Token: 0x040024EA RID: 9450
		internal static int __PropertyOffset_StartX;

		// Token: 0x040024EB RID: 9451
		internal static int __PropertyOffset_StartY;

		// Token: 0x040024EC RID: 9452
		internal static int __PropertyOffset_StartZ;

		// Token: 0x040024ED RID: 9453
		internal static int __PropertyOffset_EndX;

		// Token: 0x040024EE RID: 9454
		internal static int __PropertyOffset_EndY;

		// Token: 0x040024EF RID: 9455
		internal static int __PropertyOffset_EndZ;

		// Token: 0x040024F0 RID: 9456
		internal static int __PropertyOffset_TraceColor_R;

		// Token: 0x040024F1 RID: 9457
		internal static int __PropertyOffset_TraceColor_G;

		// Token: 0x040024F2 RID: 9458
		internal static int __PropertyOffset_TraceColor_B;

		// Token: 0x040024F3 RID: 9459
		internal static int __PropertyOffset_TraceColor_A;

		// Token: 0x040024F4 RID: 9460
		internal static int __PropertyOffset_TraceHitColor_R;

		// Token: 0x040024F5 RID: 9461
		internal static int __PropertyOffset_TraceHitColor_G;

		// Token: 0x040024F6 RID: 9462
		internal static int __PropertyOffset_TraceHitColor_B;

		// Token: 0x040024F7 RID: 9463
		internal static int __PropertyOffset_TraceHitColor_A;

		// Token: 0x040024F8 RID: 9464
		internal static int __PropertyOffset_DrawTime;

		// Token: 0x040024F9 RID: 9465
		internal static int __PropertyOffset_bTraceComplex;

		// Token: 0x040024FA RID: 9466
		internal static int __PropertyOffset_bIgnoreSelf;

		// Token: 0x040024FB RID: 9467
		internal static int __PropertyOffset_bIsSingle;

		// Token: 0x040024FC RID: 9468
		internal static int __PropertyOffset_bIsBoth;

		// Token: 0x040024FD RID: 9469
		internal static int __PropertyOffset_bIsTraceCapsuleAsSphere;

		// Token: 0x040024FE RID: 9470
		internal static int __PropertyOffset_bIsProfile;

		// Token: 0x040024FF RID: 9471
		internal static int __PropertyOffset_ProfileName;
	}
}
