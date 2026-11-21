using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004E7 RID: 1255
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneInfo")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKuroUiSceneInfo : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600767A RID: 30330 RVA: 0x000ACF3B File Offset: 0x000AB13B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroUiSceneInfo._ClassPtr;
		}

		// Token: 0x0600767B RID: 30331 RVA: 0x000ACF48 File Offset: 0x000AB148
		public UKuroUiSceneInfo() : this(BuiltinUtils.AllocNativeUObject(UKuroUiSceneInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600767C RID: 30332 RVA: 0x000ACF70 File Offset: 0x000AB170
		public UKuroUiSceneInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroUiSceneInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x0600767D RID: 30333 RVA: 0x000ACFA3 File Offset: 0x000AB1A3
		// (set) Token: 0x0600767E RID: 30334 RVA: 0x000ACFB7 File Offset: 0x000AB1B7
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroUiSceneInfo.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroUiSceneInfo.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x0600767F RID: 30335 RVA: 0x000ACFCC File Offset: 0x000AB1CC
		// (set) Token: 0x06007680 RID: 30336 RVA: 0x000ACFE0 File Offset: 0x000AB1E0
		public unsafe string LevelName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroUiSceneInfo.__PropertyOffset_LevelName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroUiSceneInfo.__PropertyOffset_LevelName)), value);
			}
		}

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x06007681 RID: 30337 RVA: 0x000ACFF5 File Offset: 0x000AB1F5
		// (set) Token: 0x06007682 RID: 30338 RVA: 0x000AD009 File Offset: 0x000AB209
		public unsafe string OptionalLevelName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroUiSceneInfo.__PropertyOffset_OptionalLevelName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroUiSceneInfo.__PropertyOffset_OptionalLevelName)), value);
			}
		}

		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x06007683 RID: 30339 RVA: 0x000AD01E File Offset: 0x000AB21E
		// (set) Token: 0x06007684 RID: 30340 RVA: 0x000AD02E File Offset: 0x000AB22E
		public unsafe bool IsLoaded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroUiSceneInfo.__PropertyOffset_IsLoaded) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroUiSceneInfo.__PropertyOffset_IsLoaded) = (value ? 1 : 0);
			}
		}

		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x06007685 RID: 30341 RVA: 0x000AD03F File Offset: 0x000AB23F
		// (set) Token: 0x06007686 RID: 30342 RVA: 0x000AD04F File Offset: 0x000AB24F
		public unsafe bool IsVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroUiSceneInfo.__PropertyOffset_IsVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroUiSceneInfo.__PropertyOffset_IsVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x06007687 RID: 30343 RVA: 0x000AD060 File Offset: 0x000AB260
		// (set) Token: 0x06007688 RID: 30344 RVA: 0x000AD070 File Offset: 0x000AB270
		public unsafe EKuroUiSceneLoadingState CurrentState
		{
			get
			{
				return (EKuroUiSceneLoadingState)(*(base.NativePtr + (IntPtr)UKuroUiSceneInfo.__PropertyOffset_CurrentState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroUiSceneInfo.__PropertyOffset_CurrentState) = (byte)value;
			}
		}

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x06007689 RID: 30345 RVA: 0x000AD081 File Offset: 0x000AB281
		// (set) Token: 0x0600768A RID: 30346 RVA: 0x000AD095 File Offset: 0x000AB295
		[Nullable(2)]
		public unsafe ULevelStreamingDynamic LevelStreaming
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelStreamingDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroUiSceneInfo.__PropertyOffset_LevelStreaming);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroUiSceneInfo.__PropertyOffset_LevelStreaming, value);
			}
		}

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x0600768B RID: 30347 RVA: 0x000AD0AA File Offset: 0x000AB2AA
		// (set) Token: 0x0600768C RID: 30348 RVA: 0x000AD0BE File Offset: 0x000AB2BE
		[Nullable(2)]
		public unsafe UWorld World
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorld>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroUiSceneInfo.__PropertyOffset_World);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroUiSceneInfo.__PropertyOffset_World, value);
			}
		}

		// Token: 0x0600768D RID: 30349 RVA: 0x000AD0D4 File Offset: 0x000AB2D4
		[SkipLocalsInit]
		public unsafe void SetLevelVisible(bool InIsVisible)
		{
			UKuroUiSceneInfo.__SetLevelVisible_FunctionParams* ptr = stackalloc UKuroUiSceneInfo.__SetLevelVisible_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroUiSceneInfo.__SetLevelVisible_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroUiSceneInfo.__SetLevelVisible_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InIsVisible = InIsVisible;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroUiSceneInfo.__SetLevelVisible_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600768E RID: 30350 RVA: 0x000AD11A File Offset: 0x000AB31A
		[SkipLocalsInit]
		public void OnLevelVisible()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroUiSceneInfo.__OnLevelVisible_NativeFunctionPtr, null);
		}

		// Token: 0x0600768F RID: 30351 RVA: 0x000AD12E File Offset: 0x000AB32E
		[SkipLocalsInit]
		public void OnLevelLoad()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroUiSceneInfo.__OnLevelLoad_NativeFunctionPtr, null);
		}

		// Token: 0x06007690 RID: 30352 RVA: 0x000AD142 File Offset: 0x000AB342
		[SkipLocalsInit]
		public void OnLevelInVisible()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroUiSceneInfo.__OnLevelInVisible_NativeFunctionPtr, null);
		}

		// Token: 0x06007691 RID: 30353 RVA: 0x000AD158 File Offset: 0x000AB358
		[SkipLocalsInit]
		public unsafe void Init([Nullable(2)] ULevelStreamingDynamic InLevelStreaming, ref string InLevelName, ref string OptionalName, ref FVector InLocation, [Nullable(2)] UWorld InWorld)
		{
			UKuroUiSceneInfo.__Init_FunctionParams* ptr = stackalloc UKuroUiSceneInfo.__Init_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroUiSceneInfo.__Init_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroUiSceneInfo.__Init_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InLevelStreaming = ((InLevelStreaming != null) ? InLevelStreaming.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->InLevelName), InLevelName);
			FString.CopyFrom((void*)(&ptr->OptionalName), OptionalName);
			ptr->InLocation = InLocation;
			ptr->InWorld = ((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroUiSceneInfo.__Init_NativeFunctionPtr, (void*)ptr);
			InLevelName = FString.ToString((void*)(&ptr->InLevelName));
			OptionalName = FString.ToString((void*)(&ptr->OptionalName));
			InLocation = ptr->InLocation;
			UnrealReflectionUtils.DestroyStruct(UKuroUiSceneInfo.__Init_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007692 RID: 30354 RVA: 0x000AD228 File Offset: 0x000AB428
		[SkipLocalsInit]
		public void Destroy()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroUiSceneInfo.__Destroy_NativeFunctionPtr, null);
		}

		// Token: 0x06007693 RID: 30355 RVA: 0x000AD23C File Offset: 0x000AB43C
		static UKuroUiSceneInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneInfo");
		}

		// Token: 0x06007694 RID: 30356 RVA: 0x000AD24A File Offset: 0x000AB44A
		protected UKuroUiSceneInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040031F1 RID: 12785
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneInfo";

		// Token: 0x040031F2 RID: 12786
		private static IntPtr _ClassPtr;

		// Token: 0x040031F3 RID: 12787
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040031F4 RID: 12788
		internal static int __PropertyOffset_Location;

		// Token: 0x040031F5 RID: 12789
		internal static int __PropertyOffset_LevelName;

		// Token: 0x040031F6 RID: 12790
		internal static int __PropertyOffset_OptionalLevelName;

		// Token: 0x040031F7 RID: 12791
		internal static int __PropertyOffset_IsLoaded;

		// Token: 0x040031F8 RID: 12792
		internal static int __PropertyOffset_IsVisible;

		// Token: 0x040031F9 RID: 12793
		internal static int __PropertyOffset_CurrentState;

		// Token: 0x040031FA RID: 12794
		internal static int __PropertyOffset_LevelStreaming;

		// Token: 0x040031FB RID: 12795
		internal static int __PropertyOffset_World;

		// Token: 0x040031FC RID: 12796
		private static IntPtr __SetLevelVisible_NativeFunctionPtr;

		// Token: 0x040031FD RID: 12797
		private static IntPtr __OnLevelVisible_NativeFunctionPtr;

		// Token: 0x040031FE RID: 12798
		private static IntPtr __OnLevelLoad_NativeFunctionPtr;

		// Token: 0x040031FF RID: 12799
		private static IntPtr __OnLevelInVisible_NativeFunctionPtr;

		// Token: 0x04003200 RID: 12800
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x04003201 RID: 12801
		private static IntPtr __Destroy_NativeFunctionPtr;

		// Token: 0x02000C23 RID: 3107
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetLevelVisible_FunctionParams
		{
			// Token: 0x04005E6C RID: 24172
			[FieldOffset(0)]
			public bool InIsVisible;
		}

		// Token: 0x02000C24 RID: 3108
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __Init_FunctionParams
		{
			// Token: 0x04005E6D RID: 24173
			[FieldOffset(0)]
			public IntPtr InLevelStreaming;

			// Token: 0x04005E6E RID: 24174
			[FieldOffset(8)]
			public FString InLevelName;

			// Token: 0x04005E6F RID: 24175
			[FieldOffset(24)]
			public FString OptionalName;

			// Token: 0x04005E70 RID: 24176
			[FieldOffset(40)]
			public FVector InLocation;

			// Token: 0x04005E71 RID: 24177
			[FieldOffset(56)]
			public IntPtr InWorld;
		}
	}
}
