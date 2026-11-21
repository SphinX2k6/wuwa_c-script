using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003FE RID: 1022
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroRoadway")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKuroRoadway : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006441 RID: 25665 RVA: 0x0008F28B File Offset: 0x0008D48B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRoadway._ClassPtr;
		}

		// Token: 0x06006442 RID: 25666 RVA: 0x0008F298 File Offset: 0x0008D498
		public UKuroRoadway() : this(BuiltinUtils.AllocNativeUObject(UKuroRoadway.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006443 RID: 25667 RVA: 0x0008F2C0 File Offset: 0x0008D4C0
		public UKuroRoadway(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRoadway.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x06006444 RID: 25668 RVA: 0x0008F2F3 File Offset: 0x0008D4F3
		// (set) Token: 0x06006445 RID: 25669 RVA: 0x0008F307 File Offset: 0x0008D507
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

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x06006446 RID: 25670 RVA: 0x0008F31C File Offset: 0x0008D51C
		// (set) Token: 0x06006447 RID: 25671 RVA: 0x0008F32C File Offset: 0x0008D52C
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

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x06006448 RID: 25672 RVA: 0x0008F33D File Offset: 0x0008D53D
		// (set) Token: 0x06006449 RID: 25673 RVA: 0x0008F34D File Offset: 0x0008D54D
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

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x0600644A RID: 25674 RVA: 0x0008F35E File Offset: 0x0008D55E
		// (set) Token: 0x0600644B RID: 25675 RVA: 0x0008F36E File Offset: 0x0008D56E
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

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x0600644C RID: 25676 RVA: 0x0008F37F File Offset: 0x0008D57F
		// (set) Token: 0x0600644D RID: 25677 RVA: 0x0008F38F File Offset: 0x0008D58F
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

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x0600644E RID: 25678 RVA: 0x0008F3A0 File Offset: 0x0008D5A0
		// (set) Token: 0x0600644F RID: 25679 RVA: 0x0008F3D9 File Offset: 0x0008D5D9
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

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x06006450 RID: 25680 RVA: 0x0008F3E8 File Offset: 0x0008D5E8
		// (set) Token: 0x06006451 RID: 25681 RVA: 0x0008F421 File Offset: 0x0008D621
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

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x06006452 RID: 25682 RVA: 0x0008F42F File Offset: 0x0008D62F
		// (set) Token: 0x06006453 RID: 25683 RVA: 0x0008F43F File Offset: 0x0008D63F
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

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x06006454 RID: 25684 RVA: 0x0008F450 File Offset: 0x0008D650
		// (set) Token: 0x06006455 RID: 25685 RVA: 0x0008F460 File Offset: 0x0008D660
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

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x06006456 RID: 25686 RVA: 0x0008F471 File Offset: 0x0008D671
		// (set) Token: 0x06006457 RID: 25687 RVA: 0x0008F481 File Offset: 0x0008D681
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

		// Token: 0x06006458 RID: 25688 RVA: 0x0008F494 File Offset: 0x0008D694
		[SkipLocalsInit]
		public unsafe void DebugDraw(FLinearColor Color, float LifeTime, int StartPointIndex, int EndPointIndex = -1)
		{
			UKuroRoadway.__DebugDraw_FunctionParams* ptr = stackalloc UKuroRoadway.__DebugDraw_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(UKuroRoadway.__DebugDraw_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRoadway.__DebugDraw_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Color = Color;
			ptr->LifeTime = LifeTime;
			ptr->StartPointIndex = StartPointIndex;
			ptr->EndPointIndex = EndPointIndex;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRoadway.__DebugDraw_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06006459 RID: 25689 RVA: 0x0008F4F0 File Offset: 0x0008D6F0
		[SkipLocalsInit]
		public unsafe FVectorDouble D_GetStartPosition()
		{
			UKuroRoadway.__D_GetStartPosition_FunctionParams* ptr = stackalloc UKuroRoadway.__D_GetStartPosition_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroRoadway.__D_GetStartPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRoadway.__D_GetStartPosition_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRoadway.__D_GetStartPosition_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600645A RID: 25690 RVA: 0x0008F538 File Offset: 0x0008D738
		[SkipLocalsInit]
		public unsafe void D_GetNearestPointToPosition(FVectorDouble WorldPosition, ref FVectorDouble OutputNearestPoint, ref float OutputNearestPointKey, ref float OutputDistance)
		{
			UKuroRoadway.__D_GetNearestPointToPosition_FunctionParams* ptr = stackalloc UKuroRoadway.__D_GetNearestPointToPosition_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UKuroRoadway.__D_GetNearestPointToPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRoadway.__D_GetNearestPointToPosition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldPosition = WorldPosition;
			ptr->OutputNearestPoint = OutputNearestPoint;
			ptr->OutputNearestPointKey = OutputNearestPointKey;
			ptr->OutputDistance = OutputDistance;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRoadway.__D_GetNearestPointToPosition_NativeFunctionPtr, (void*)ptr);
			OutputNearestPoint = ptr->OutputNearestPoint;
			OutputNearestPointKey = ptr->OutputNearestPointKey;
			OutputDistance = ptr->OutputDistance;
		}

		// Token: 0x0600645B RID: 25691 RVA: 0x0008F5B8 File Offset: 0x0008D7B8
		[SkipLocalsInit]
		public unsafe FVectorDouble D_GetEndPosition()
		{
			UKuroRoadway.__D_GetEndPosition_FunctionParams* ptr = stackalloc UKuroRoadway.__D_GetEndPosition_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroRoadway.__D_GetEndPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRoadway.__D_GetEndPosition_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRoadway.__D_GetEndPosition_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600645C RID: 25692 RVA: 0x0008F5FD File Offset: 0x0008D7FD
		static UKuroRoadway()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroRoadway");
		}

		// Token: 0x0600645D RID: 25693 RVA: 0x0008F60B File Offset: 0x0008D80B
		protected UKuroRoadway(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002A48 RID: 10824
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroRoadway";

		// Token: 0x04002A49 RID: 10825
		private static IntPtr _ClassPtr;

		// Token: 0x04002A4A RID: 10826
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002A4B RID: 10827
		internal static int __PropertyOffset_RoadSpline;

		// Token: 0x04002A4C RID: 10828
		internal static int __PropertyOffset_Id;

		// Token: 0x04002A4D RID: 10829
		internal static int __PropertyOffset_OpposingId;

		// Token: 0x04002A4E RID: 10830
		internal static int __PropertyOffset_Width;

		// Token: 0x04002A4F RID: 10831
		internal static int __PropertyOffset_Length;

		// Token: 0x04002A50 RID: 10832
		internal static int __PropertyOffset_Nexts;

		// Token: 0x04002A51 RID: 10833
		[Nullable(2)]
		private TArray<int> _Nexts;

		// Token: 0x04002A52 RID: 10834
		internal static int __PropertyOffset_Lasts;

		// Token: 0x04002A53 RID: 10835
		[Nullable(2)]
		private TArray<int> _Lasts;

		// Token: 0x04002A54 RID: 10836
		internal static int __PropertyOffset_bEnable;

		// Token: 0x04002A55 RID: 10837
		internal static int __PropertyOffset_bAffectTerrain;

		// Token: 0x04002A56 RID: 10838
		internal static int __PropertyOffset_PavedRoadConfig;

		// Token: 0x04002A57 RID: 10839
		private static IntPtr __DebugDraw_NativeFunctionPtr;

		// Token: 0x04002A58 RID: 10840
		private static IntPtr __D_GetStartPosition_NativeFunctionPtr;

		// Token: 0x04002A59 RID: 10841
		private static IntPtr __D_GetNearestPointToPosition_NativeFunctionPtr;

		// Token: 0x04002A5A RID: 10842
		private static IntPtr __D_GetEndPosition_NativeFunctionPtr;

		// Token: 0x02000AEE RID: 2798
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __DebugDraw_FunctionParams
		{
			// Token: 0x04005B74 RID: 23412
			[FieldOffset(0)]
			public FLinearColor Color;

			// Token: 0x04005B75 RID: 23413
			[FieldOffset(16)]
			public float LifeTime;

			// Token: 0x04005B76 RID: 23414
			[FieldOffset(20)]
			public int StartPointIndex;

			// Token: 0x04005B77 RID: 23415
			[FieldOffset(24)]
			public int EndPointIndex;
		}

		// Token: 0x02000AEF RID: 2799
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __D_GetStartPosition_FunctionParams
		{
			// Token: 0x04005B78 RID: 23416
			[FieldOffset(0)]
			public FVectorDouble __Result;
		}

		// Token: 0x02000AF0 RID: 2800
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __D_GetNearestPointToPosition_FunctionParams
		{
			// Token: 0x04005B79 RID: 23417
			[FieldOffset(0)]
			public FVectorDouble WorldPosition;

			// Token: 0x04005B7A RID: 23418
			[FieldOffset(24)]
			public FVectorDouble OutputNearestPoint;

			// Token: 0x04005B7B RID: 23419
			[FieldOffset(48)]
			public float OutputNearestPointKey;

			// Token: 0x04005B7C RID: 23420
			[FieldOffset(52)]
			public float OutputDistance;
		}

		// Token: 0x02000AF1 RID: 2801
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __D_GetEndPosition_FunctionParams
		{
			// Token: 0x04005B7D RID: 23421
			[FieldOffset(0)]
			public FVectorDouble __Result;
		}
	}
}
