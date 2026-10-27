using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001891 RID: 6289
	[UnrealObjectPath("/Script/KuroGameplay.AutopilotRoute")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAutopilotRoute : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060172AA RID: 94890 RVA: 0x0021C5F9 File Offset: 0x0021A7F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAutopilotRoute._ClassPtr;
		}

		// Token: 0x060172AB RID: 94891 RVA: 0x0021C608 File Offset: 0x0021A808
		public UAutopilotRoute() : this(BuiltinUtils.AllocNativeUObject(UAutopilotRoute.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060172AC RID: 94892 RVA: 0x0021C630 File Offset: 0x0021A830
		[NullableContext(1)]
		public UAutopilotRoute(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAutopilotRoute.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D29 RID: 23849
		// (get) Token: 0x060172AD RID: 94893 RVA: 0x0021C663 File Offset: 0x0021A863
		// (set) Token: 0x060172AE RID: 94894 RVA: 0x0021C677 File Offset: 0x0021A877
		[Nullable(2)]
		public unsafe USplineComponent RoadSpline
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAutopilotRoute.__PropertyOffset_RoadSpline);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAutopilotRoute.__PropertyOffset_RoadSpline, value);
			}
		}

		// Token: 0x17005D2A RID: 23850
		// (get) Token: 0x060172AF RID: 94895 RVA: 0x0021C68C File Offset: 0x0021A88C
		// (set) Token: 0x060172B0 RID: 94896 RVA: 0x0021C6C5 File Offset: 0x0021A8C5
		[Nullable(1)]
		public TArray<FRoadSegmentInfo> RoadSegmentInfos
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FRoadSegmentInfo> result;
				if ((result = this._RoadSegmentInfos) == null)
				{
					result = (this._RoadSegmentInfos = new TArray<FRoadSegmentInfo>(base.NativePtr + (IntPtr)UAutopilotRoute.__PropertyOffset_RoadSegmentInfos, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.RoadSegmentInfos.CopyAssign(value);
			}
		}

		// Token: 0x060172B1 RID: 94897 RVA: 0x0021C6D4 File Offset: 0x0021A8D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UKuroRoadway GetRoadSegmentInfoByKey(float Key)
		{
			UAutopilotRoute.__GetRoadSegmentInfoByKey_FunctionParams* ptr = stackalloc UAutopilotRoute.__GetRoadSegmentInfoByKey_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAutopilotRoute.__GetRoadSegmentInfoByKey_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAutopilotRoute.__GetRoadSegmentInfoByKey_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Key = Key;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAutopilotRoute.__GetRoadSegmentInfoByKey_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroRoadway>(ptr->__Result);
		}

		// Token: 0x060172B2 RID: 94898 RVA: 0x0021C728 File Offset: 0x0021A928
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UKuroRoadway GetRoadSegmentInfoByAlongDistance(float Distance)
		{
			UAutopilotRoute.__GetRoadSegmentInfoByAlongDistance_FunctionParams* ptr = stackalloc UAutopilotRoute.__GetRoadSegmentInfoByAlongDistance_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAutopilotRoute.__GetRoadSegmentInfoByAlongDistance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAutopilotRoute.__GetRoadSegmentInfoByAlongDistance_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Distance = Distance;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAutopilotRoute.__GetRoadSegmentInfoByAlongDistance_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroRoadway>(ptr->__Result);
		}

		// Token: 0x060172B3 RID: 94899 RVA: 0x0021C77C File Offset: 0x0021A97C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UKuroRoadway D_GetRoadSegmentInfoByWorldPosition(FVectorDouble Position)
		{
			UAutopilotRoute.__D_GetRoadSegmentInfoByWorldPosition_FunctionParams* ptr = stackalloc UAutopilotRoute.__D_GetRoadSegmentInfoByWorldPosition_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UAutopilotRoute.__D_GetRoadSegmentInfoByWorldPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAutopilotRoute.__D_GetRoadSegmentInfoByWorldPosition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Position = Position;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAutopilotRoute.__D_GetRoadSegmentInfoByWorldPosition_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroRoadway>(ptr->__Result);
		}

		// Token: 0x060172B4 RID: 94900 RVA: 0x0021C7CE File Offset: 0x0021A9CE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Clear()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAutopilotRoute.__Clear_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060172B5 RID: 94901 RVA: 0x0021C7E3 File Offset: 0x0021A9E3
		static UAutopilotRoute()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.AutopilotRoute");
		}

		// Token: 0x060172B6 RID: 94902 RVA: 0x0021C7F1 File Offset: 0x0021A9F1
		protected UAutopilotRoute(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C8FB RID: 51451
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.AutopilotRoute";

		// Token: 0x0400C8FC RID: 51452
		private static IntPtr _ClassPtr;

		// Token: 0x0400C8FD RID: 51453
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C8FE RID: 51454
		internal static int __PropertyOffset_RoadSpline;

		// Token: 0x0400C8FF RID: 51455
		internal static int __PropertyOffset_RoadSegmentInfos;

		// Token: 0x0400C900 RID: 51456
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRoadSegmentInfo> _RoadSegmentInfos;

		// Token: 0x0400C901 RID: 51457
		private static IntPtr __GetRoadSegmentInfoByKey_NativeFunctionPtr;

		// Token: 0x0400C902 RID: 51458
		private static IntPtr __GetRoadSegmentInfoByAlongDistance_NativeFunctionPtr;

		// Token: 0x0400C903 RID: 51459
		private static IntPtr __D_GetRoadSegmentInfoByWorldPosition_NativeFunctionPtr;

		// Token: 0x0400C904 RID: 51460
		private static IntPtr __Clear_NativeFunctionPtr;

		// Token: 0x02002F92 RID: 12178
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetRoadSegmentInfoByKey_FunctionParams
		{
			// Token: 0x04016B5C RID: 93020
			[FieldOffset(0)]
			public float Key;

			// Token: 0x04016B5D RID: 93021
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02002F93 RID: 12179
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetRoadSegmentInfoByAlongDistance_FunctionParams
		{
			// Token: 0x04016B5E RID: 93022
			[FieldOffset(0)]
			public float Distance;

			// Token: 0x04016B5F RID: 93023
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02002F94 RID: 12180
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __D_GetRoadSegmentInfoByWorldPosition_FunctionParams
		{
			// Token: 0x04016B60 RID: 93024
			[FieldOffset(0)]
			public FVectorDouble Position;

			// Token: 0x04016B61 RID: 93025
			[FieldOffset(24)]
			public IntPtr __Result;
		}
	}
}
