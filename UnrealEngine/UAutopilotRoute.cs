using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003B5 RID: 949
	[UnrealObjectPath("/Script/KuroGameplay.AutopilotRoute")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAutopilotRoute : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005D55 RID: 23893 RVA: 0x00083A99 File Offset: 0x00081C99
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAutopilotRoute._ClassPtr;
		}

		// Token: 0x06005D56 RID: 23894 RVA: 0x00083AA8 File Offset: 0x00081CA8
		public UAutopilotRoute() : this(BuiltinUtils.AllocNativeUObject(UAutopilotRoute.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005D57 RID: 23895 RVA: 0x00083AD0 File Offset: 0x00081CD0
		[NullableContext(1)]
		public UAutopilotRoute(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAutopilotRoute.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x06005D58 RID: 23896 RVA: 0x00083B03 File Offset: 0x00081D03
		// (set) Token: 0x06005D59 RID: 23897 RVA: 0x00083B17 File Offset: 0x00081D17
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

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x06005D5A RID: 23898 RVA: 0x00083B2C File Offset: 0x00081D2C
		// (set) Token: 0x06005D5B RID: 23899 RVA: 0x00083B65 File Offset: 0x00081D65
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

		// Token: 0x06005D5C RID: 23900 RVA: 0x00083B74 File Offset: 0x00081D74
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe UKuroRoadway GetRoadSegmentInfoByKey(float Key)
		{
			UAutopilotRoute.__GetRoadSegmentInfoByKey_FunctionParams* ptr = stackalloc UAutopilotRoute.__GetRoadSegmentInfoByKey_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAutopilotRoute.__GetRoadSegmentInfoByKey_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAutopilotRoute.__GetRoadSegmentInfoByKey_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Key = Key;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAutopilotRoute.__GetRoadSegmentInfoByKey_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroRoadway>(ptr->__Result);
		}

		// Token: 0x06005D5D RID: 23901 RVA: 0x00083BC8 File Offset: 0x00081DC8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe UKuroRoadway GetRoadSegmentInfoByAlongDistance(float Distance)
		{
			UAutopilotRoute.__GetRoadSegmentInfoByAlongDistance_FunctionParams* ptr = stackalloc UAutopilotRoute.__GetRoadSegmentInfoByAlongDistance_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAutopilotRoute.__GetRoadSegmentInfoByAlongDistance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAutopilotRoute.__GetRoadSegmentInfoByAlongDistance_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Distance = Distance;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAutopilotRoute.__GetRoadSegmentInfoByAlongDistance_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroRoadway>(ptr->__Result);
		}

		// Token: 0x06005D5E RID: 23902 RVA: 0x00083C1C File Offset: 0x00081E1C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe UKuroRoadway D_GetRoadSegmentInfoByWorldPosition(FVectorDouble Position)
		{
			UAutopilotRoute.__D_GetRoadSegmentInfoByWorldPosition_FunctionParams* ptr = stackalloc UAutopilotRoute.__D_GetRoadSegmentInfoByWorldPosition_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UAutopilotRoute.__D_GetRoadSegmentInfoByWorldPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAutopilotRoute.__D_GetRoadSegmentInfoByWorldPosition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Position = Position;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAutopilotRoute.__D_GetRoadSegmentInfoByWorldPosition_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroRoadway>(ptr->__Result);
		}

		// Token: 0x06005D5F RID: 23903 RVA: 0x00083C6D File Offset: 0x00081E6D
		[SkipLocalsInit]
		public void Clear()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAutopilotRoute.__Clear_NativeFunctionPtr, null);
		}

		// Token: 0x06005D60 RID: 23904 RVA: 0x00083C81 File Offset: 0x00081E81
		static UAutopilotRoute()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.AutopilotRoute");
		}

		// Token: 0x06005D61 RID: 23905 RVA: 0x00083C8F File Offset: 0x00081E8F
		protected UAutopilotRoute(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040026E4 RID: 9956
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.AutopilotRoute";

		// Token: 0x040026E5 RID: 9957
		private static IntPtr _ClassPtr;

		// Token: 0x040026E6 RID: 9958
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040026E7 RID: 9959
		internal static int __PropertyOffset_RoadSpline;

		// Token: 0x040026E8 RID: 9960
		internal static int __PropertyOffset_RoadSegmentInfos;

		// Token: 0x040026E9 RID: 9961
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRoadSegmentInfo> _RoadSegmentInfos;

		// Token: 0x040026EA RID: 9962
		private static IntPtr __GetRoadSegmentInfoByKey_NativeFunctionPtr;

		// Token: 0x040026EB RID: 9963
		private static IntPtr __GetRoadSegmentInfoByAlongDistance_NativeFunctionPtr;

		// Token: 0x040026EC RID: 9964
		private static IntPtr __D_GetRoadSegmentInfoByWorldPosition_NativeFunctionPtr;

		// Token: 0x040026ED RID: 9965
		private static IntPtr __Clear_NativeFunctionPtr;

		// Token: 0x02000AB5 RID: 2741
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetRoadSegmentInfoByKey_FunctionParams
		{
			// Token: 0x04005B19 RID: 23321
			[FieldOffset(0)]
			public float Key;

			// Token: 0x04005B1A RID: 23322
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02000AB6 RID: 2742
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetRoadSegmentInfoByAlongDistance_FunctionParams
		{
			// Token: 0x04005B1B RID: 23323
			[FieldOffset(0)]
			public float Distance;

			// Token: 0x04005B1C RID: 23324
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02000AB7 RID: 2743
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __D_GetRoadSegmentInfoByWorldPosition_FunctionParams
		{
			// Token: 0x04005B1D RID: 23325
			[FieldOffset(0)]
			public FVectorDouble Position;

			// Token: 0x04005B1E RID: 23326
			[FieldOffset(24)]
			public IntPtr __Result;
		}
	}
}
