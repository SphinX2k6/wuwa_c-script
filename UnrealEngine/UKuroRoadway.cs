using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001904 RID: 6404
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroRoadway")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKuroRoadway : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017C4C RID: 97356 RVA: 0x0022D157 File Offset: 0x0022B357
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRoadway._ClassPtr;
		}

		// Token: 0x06017C4D RID: 97357 RVA: 0x0022D164 File Offset: 0x0022B364
		public UKuroRoadway() : this(BuiltinUtils.AllocNativeUObject(UKuroRoadway.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017C4E RID: 97358 RVA: 0x0022D18C File Offset: 0x0022B38C
		public UKuroRoadway(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRoadway.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005FA7 RID: 24487
		// (get) Token: 0x06017C4F RID: 97359 RVA: 0x0022D1BF File Offset: 0x0022B3BF
		// (set) Token: 0x06017C50 RID: 97360 RVA: 0x0022D1D3 File Offset: 0x0022B3D3
		[Nullable(2)]
		public unsafe USplineComponent RoadSpline
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRoadway.__PropertyOffset_RoadSpline);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRoadway.__PropertyOffset_RoadSpline, value);
			}
		}

		// Token: 0x17005FA8 RID: 24488
		// (get) Token: 0x06017C51 RID: 97361 RVA: 0x0022D1E8 File Offset: 0x0022B3E8
		// (set) Token: 0x06017C52 RID: 97362 RVA: 0x0022D1F8 File Offset: 0x0022B3F8
		public unsafe int Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRoadway.__PropertyOffset_Id);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRoadway.__PropertyOffset_Id) = value;
			}
		}

		// Token: 0x17005FA9 RID: 24489
		// (get) Token: 0x06017C53 RID: 97363 RVA: 0x0022D209 File Offset: 0x0022B409
		// (set) Token: 0x06017C54 RID: 97364 RVA: 0x0022D219 File Offset: 0x0022B419
		public unsafe int OpposingId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRoadway.__PropertyOffset_OpposingId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRoadway.__PropertyOffset_OpposingId) = value;
			}
		}

		// Token: 0x17005FAA RID: 24490
		// (get) Token: 0x06017C55 RID: 97365 RVA: 0x0022D22A File Offset: 0x0022B42A
		// (set) Token: 0x06017C56 RID: 97366 RVA: 0x0022D23A File Offset: 0x0022B43A
		public unsafe int Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRoadway.__PropertyOffset_Width);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRoadway.__PropertyOffset_Width) = value;
			}
		}

		// Token: 0x17005FAB RID: 24491
		// (get) Token: 0x06017C57 RID: 97367 RVA: 0x0022D24B File Offset: 0x0022B44B
		// (set) Token: 0x06017C58 RID: 97368 RVA: 0x0022D25B File Offset: 0x0022B45B
		public unsafe int Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRoadway.__PropertyOffset_Length);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRoadway.__PropertyOffset_Length) = value;
			}
		}

		// Token: 0x17005FAC RID: 24492
		// (get) Token: 0x06017C59 RID: 97369 RVA: 0x0022D26C File Offset: 0x0022B46C
		// (set) Token: 0x06017C5A RID: 97370 RVA: 0x0022D2A5 File Offset: 0x0022B4A5
		public TArray<int> Nexts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Nexts) == null)
				{
					result = (this._Nexts = new TArray<int>(base.NativePtr + (IntPtr)UKuroRoadway.__PropertyOffset_Nexts, this));
				}
				return result;
			}
			set
			{
				this.Nexts.CopyAssign(value);
			}
		}

		// Token: 0x17005FAD RID: 24493
		// (get) Token: 0x06017C5B RID: 97371 RVA: 0x0022D2B4 File Offset: 0x0022B4B4
		// (set) Token: 0x06017C5C RID: 97372 RVA: 0x0022D2ED File Offset: 0x0022B4ED
		public TArray<int> Lasts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Lasts) == null)
				{
					result = (this._Lasts = new TArray<int>(base.NativePtr + (IntPtr)UKuroRoadway.__PropertyOffset_Lasts, this));
				}
				return result;
			}
			set
			{
				this.Lasts.CopyAssign(value);
			}
		}

		// Token: 0x17005FAE RID: 24494
		// (get) Token: 0x06017C5D RID: 97373 RVA: 0x0022D2FB File Offset: 0x0022B4FB
		// (set) Token: 0x06017C5E RID: 97374 RVA: 0x0022D30B File Offset: 0x0022B50B
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRoadway.__PropertyOffset_bEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRoadway.__PropertyOffset_bEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005FAF RID: 24495
		// (get) Token: 0x06017C5F RID: 97375 RVA: 0x0022D31C File Offset: 0x0022B51C
		// (set) Token: 0x06017C60 RID: 97376 RVA: 0x0022D32C File Offset: 0x0022B52C
		public unsafe bool bAffectTerrain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRoadway.__PropertyOffset_bAffectTerrain) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRoadway.__PropertyOffset_bAffectTerrain) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005FB0 RID: 24496
		// (get) Token: 0x06017C61 RID: 97377 RVA: 0x0022D33D File Offset: 0x0022B53D
		// (set) Token: 0x06017C62 RID: 97378 RVA: 0x0022D34D File Offset: 0x0022B54D
		public unsafe int PavedRoadConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRoadway.__PropertyOffset_PavedRoadConfig);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRoadway.__PropertyOffset_PavedRoadConfig) = value;
			}
		}

		// Token: 0x06017C63 RID: 97379 RVA: 0x0022D360 File Offset: 0x0022B560
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void DebugDraw(FLinearColor Color, float LifeTime, int StartPointIndex, int EndPointIndex = -1)
		{
			UKuroRoadway.__DebugDraw_FunctionParams* ptr = stackalloc UKuroRoadway.__DebugDraw_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(UKuroRoadway.__DebugDraw_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRoadway.__DebugDraw_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Color = Color;
			ptr->LifeTime = LifeTime;
			ptr->StartPointIndex = StartPointIndex;
			ptr->EndPointIndex = EndPointIndex;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRoadway.__DebugDraw_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06017C64 RID: 97380 RVA: 0x0022D3C0 File Offset: 0x0022B5C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FVectorDouble D_GetStartPosition()
		{
			UKuroRoadway.__D_GetStartPosition_FunctionParams* ptr = stackalloc UKuroRoadway.__D_GetStartPosition_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroRoadway.__D_GetStartPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRoadway.__D_GetStartPosition_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRoadway.__D_GetStartPosition_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06017C65 RID: 97381 RVA: 0x0022D408 File Offset: 0x0022B608
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void D_GetNearestPointToPosition(FVectorDouble WorldPosition, ref FVectorDouble OutputNearestPoint, ref float OutputNearestPointKey, ref float OutputDistance)
		{
			UKuroRoadway.__D_GetNearestPointToPosition_FunctionParams* ptr = stackalloc UKuroRoadway.__D_GetNearestPointToPosition_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UKuroRoadway.__D_GetNearestPointToPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRoadway.__D_GetNearestPointToPosition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldPosition = WorldPosition;
			ptr->OutputNearestPoint = OutputNearestPoint;
			ptr->OutputNearestPointKey = OutputNearestPointKey;
			ptr->OutputDistance = OutputDistance;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRoadway.__D_GetNearestPointToPosition_NativeFunctionPtr, (void*)ptr, 0);
			OutputNearestPoint = ptr->OutputNearestPoint;
			OutputNearestPointKey = ptr->OutputNearestPointKey;
			OutputDistance = ptr->OutputDistance;
		}

		// Token: 0x06017C66 RID: 97382 RVA: 0x0022D48C File Offset: 0x0022B68C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FVectorDouble D_GetEndPosition()
		{
			UKuroRoadway.__D_GetEndPosition_FunctionParams* ptr = stackalloc UKuroRoadway.__D_GetEndPosition_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroRoadway.__D_GetEndPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRoadway.__D_GetEndPosition_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRoadway.__D_GetEndPosition_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06017C67 RID: 97383 RVA: 0x0022D4D2 File Offset: 0x0022B6D2
		static UKuroRoadway()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroRoadway");
		}

		// Token: 0x06017C68 RID: 97384 RVA: 0x0022D4E0 File Offset: 0x0022B6E0
		protected UKuroRoadway(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CE42 RID: 52802
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroRoadway";

		// Token: 0x0400CE43 RID: 52803
		private static IntPtr _ClassPtr;

		// Token: 0x0400CE44 RID: 52804
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CE45 RID: 52805
		internal static int __PropertyOffset_RoadSpline;

		// Token: 0x0400CE46 RID: 52806
		internal static int __PropertyOffset_Id;

		// Token: 0x0400CE47 RID: 52807
		internal static int __PropertyOffset_OpposingId;

		// Token: 0x0400CE48 RID: 52808
		internal static int __PropertyOffset_Width;

		// Token: 0x0400CE49 RID: 52809
		internal static int __PropertyOffset_Length;

		// Token: 0x0400CE4A RID: 52810
		internal static int __PropertyOffset_Nexts;

		// Token: 0x0400CE4B RID: 52811
		[Nullable(2)]
		private TArray<int> _Nexts;

		// Token: 0x0400CE4C RID: 52812
		internal static int __PropertyOffset_Lasts;

		// Token: 0x0400CE4D RID: 52813
		[Nullable(2)]
		private TArray<int> _Lasts;

		// Token: 0x0400CE4E RID: 52814
		internal static int __PropertyOffset_bEnable;

		// Token: 0x0400CE4F RID: 52815
		internal static int __PropertyOffset_bAffectTerrain;

		// Token: 0x0400CE50 RID: 52816
		internal static int __PropertyOffset_PavedRoadConfig;

		// Token: 0x0400CE51 RID: 52817
		private static IntPtr __DebugDraw_NativeFunctionPtr;

		// Token: 0x0400CE52 RID: 52818
		private static IntPtr __D_GetStartPosition_NativeFunctionPtr;

		// Token: 0x0400CE53 RID: 52819
		private static IntPtr __D_GetNearestPointToPosition_NativeFunctionPtr;

		// Token: 0x0400CE54 RID: 52820
		private static IntPtr __D_GetEndPosition_NativeFunctionPtr;

		// Token: 0x02002FDA RID: 12250
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __DebugDraw_FunctionParams
		{
			// Token: 0x04016BCB RID: 93131
			[FieldOffset(0)]
			public FLinearColor Color;

			// Token: 0x04016BCC RID: 93132
			[FieldOffset(16)]
			public float LifeTime;

			// Token: 0x04016BCD RID: 93133
			[FieldOffset(20)]
			public int StartPointIndex;

			// Token: 0x04016BCE RID: 93134
			[FieldOffset(24)]
			public int EndPointIndex;
		}

		// Token: 0x02002FDB RID: 12251
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __D_GetStartPosition_FunctionParams
		{
			// Token: 0x04016BCF RID: 93135
			[FieldOffset(0)]
			public FVectorDouble __Result;
		}

		// Token: 0x02002FDC RID: 12252
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __D_GetNearestPointToPosition_FunctionParams
		{
			// Token: 0x04016BD0 RID: 93136
			[FieldOffset(0)]
			public FVectorDouble WorldPosition;

			// Token: 0x04016BD1 RID: 93137
			[FieldOffset(24)]
			public FVectorDouble OutputNearestPoint;

			// Token: 0x04016BD2 RID: 93138
			[FieldOffset(48)]
			public float OutputNearestPointKey;

			// Token: 0x04016BD3 RID: 93139
			[FieldOffset(52)]
			public float OutputDistance;
		}

		// Token: 0x02002FDD RID: 12253
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __D_GetEndPosition_FunctionParams
		{
			// Token: 0x04016BD4 RID: 93140
			[FieldOffset(0)]
			public FVectorDouble __Result;
		}
	}
}
