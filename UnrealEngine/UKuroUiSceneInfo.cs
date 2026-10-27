using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BD5 RID: 7125
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneInfo")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKuroUiSceneInfo : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B594 RID: 112020 RVA: 0x00284A6A File Offset: 0x00282C6A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroUiSceneInfo._ClassPtr;
		}

		// Token: 0x0601B595 RID: 112021 RVA: 0x00284A78 File Offset: 0x00282C78
		public UKuroUiSceneInfo() : this(BuiltinUtils.AllocNativeUObject(UKuroUiSceneInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B596 RID: 112022 RVA: 0x00284AA0 File Offset: 0x00282CA0
		public UKuroUiSceneInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroUiSceneInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006DE9 RID: 28137
		// (get) Token: 0x0601B597 RID: 112023 RVA: 0x00284AD3 File Offset: 0x00282CD3
		// (set) Token: 0x0601B598 RID: 112024 RVA: 0x00284AE7 File Offset: 0x00282CE7
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

		// Token: 0x17006DEA RID: 28138
		// (get) Token: 0x0601B599 RID: 112025 RVA: 0x00284AFC File Offset: 0x00282CFC
		// (set) Token: 0x0601B59A RID: 112026 RVA: 0x00284B10 File Offset: 0x00282D10
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

		// Token: 0x17006DEB RID: 28139
		// (get) Token: 0x0601B59B RID: 112027 RVA: 0x00284B25 File Offset: 0x00282D25
		// (set) Token: 0x0601B59C RID: 112028 RVA: 0x00284B39 File Offset: 0x00282D39
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

		// Token: 0x17006DEC RID: 28140
		// (get) Token: 0x0601B59D RID: 112029 RVA: 0x00284B4E File Offset: 0x00282D4E
		// (set) Token: 0x0601B59E RID: 112030 RVA: 0x00284B5E File Offset: 0x00282D5E
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

		// Token: 0x17006DED RID: 28141
		// (get) Token: 0x0601B59F RID: 112031 RVA: 0x00284B6F File Offset: 0x00282D6F
		// (set) Token: 0x0601B5A0 RID: 112032 RVA: 0x00284B7F File Offset: 0x00282D7F
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

		// Token: 0x17006DEE RID: 28142
		// (get) Token: 0x0601B5A1 RID: 112033 RVA: 0x00284B90 File Offset: 0x00282D90
		// (set) Token: 0x0601B5A2 RID: 112034 RVA: 0x00284BA0 File Offset: 0x00282DA0
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

		// Token: 0x17006DEF RID: 28143
		// (get) Token: 0x0601B5A3 RID: 112035 RVA: 0x00284BB1 File Offset: 0x00282DB1
		// (set) Token: 0x0601B5A4 RID: 112036 RVA: 0x00284BC5 File Offset: 0x00282DC5
		[Nullable(2)]
		public unsafe AKuroUiSceneRootActor RootActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKuroUiSceneRootActor>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroUiSceneInfo.__PropertyOffset_RootActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroUiSceneInfo.__PropertyOffset_RootActor, value);
			}
		}

		// Token: 0x17006DF0 RID: 28144
		// (get) Token: 0x0601B5A5 RID: 112037 RVA: 0x00284BDA File Offset: 0x00282DDA
		// (set) Token: 0x0601B5A6 RID: 112038 RVA: 0x00284BEE File Offset: 0x00282DEE
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

		// Token: 0x17006DF1 RID: 28145
		// (get) Token: 0x0601B5A7 RID: 112039 RVA: 0x00284C03 File Offset: 0x00282E03
		// (set) Token: 0x0601B5A8 RID: 112040 RVA: 0x00284C17 File Offset: 0x00282E17
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

		// Token: 0x0601B5A9 RID: 112041 RVA: 0x00284C2C File Offset: 0x00282E2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetLevelVisible(bool InIsVisible)
		{
			UKuroUiSceneInfo.__SetLevelVisible_FunctionParams* ptr = stackalloc UKuroUiSceneInfo.__SetLevelVisible_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroUiSceneInfo.__SetLevelVisible_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroUiSceneInfo.__SetLevelVisible_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InIsVisible = InIsVisible;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroUiSceneInfo.__SetLevelVisible_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601B5AA RID: 112042 RVA: 0x00284C73 File Offset: 0x00282E73
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void OnLevelVisible()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroUiSceneInfo.__OnLevelVisible_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601B5AB RID: 112043 RVA: 0x00284C88 File Offset: 0x00282E88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void OnLevelLoad()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroUiSceneInfo.__OnLevelLoad_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601B5AC RID: 112044 RVA: 0x00284C9D File Offset: 0x00282E9D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void OnLevelInVisible()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroUiSceneInfo.__OnLevelInVisible_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601B5AD RID: 112045 RVA: 0x00284CB4 File Offset: 0x00282EB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Init([Nullable(2)] ULevelStreamingDynamic InLevelStreaming, ref string InLevelName, ref string OptionalName, ref FVector InLocation, [Nullable(2)] UWorld InWorld)
		{
			UKuroUiSceneInfo.__Init_FunctionParams* ptr = stackalloc UKuroUiSceneInfo.__Init_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroUiSceneInfo.__Init_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroUiSceneInfo.__Init_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InLevelStreaming = ((InLevelStreaming != null) ? InLevelStreaming.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->InLevelName), InLevelName);
			FString.CopyFrom((void*)(&ptr->OptionalName), OptionalName);
			ptr->InLocation = InLocation;
			ptr->InWorld = ((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroUiSceneInfo.__Init_NativeFunctionPtr, (void*)ptr, 0);
			InLevelName = FString.ToString((void*)(&ptr->InLevelName));
			OptionalName = FString.ToString((void*)(&ptr->OptionalName));
			InLocation = ptr->InLocation;
			UnrealReflectionUtils.DestroyStruct(UKuroUiSceneInfo.__Init_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601B5AE RID: 112046 RVA: 0x00284D85 File Offset: 0x00282F85
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Destroy()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroUiSceneInfo.__Destroy_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601B5AF RID: 112047 RVA: 0x00284D9A File Offset: 0x00282F9A
		static UKuroUiSceneInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneInfo");
		}

		// Token: 0x0601B5B0 RID: 112048 RVA: 0x00284DA8 File Offset: 0x00282FA8
		protected UKuroUiSceneInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EB9B RID: 60315
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneInfo";

		// Token: 0x0400EB9C RID: 60316
		private static IntPtr _ClassPtr;

		// Token: 0x0400EB9D RID: 60317
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EB9E RID: 60318
		internal static int __PropertyOffset_Location;

		// Token: 0x0400EB9F RID: 60319
		internal static int __PropertyOffset_LevelName;

		// Token: 0x0400EBA0 RID: 60320
		internal static int __PropertyOffset_OptionalLevelName;

		// Token: 0x0400EBA1 RID: 60321
		internal static int __PropertyOffset_IsLoaded;

		// Token: 0x0400EBA2 RID: 60322
		internal static int __PropertyOffset_IsVisible;

		// Token: 0x0400EBA3 RID: 60323
		internal static int __PropertyOffset_CurrentState;

		// Token: 0x0400EBA4 RID: 60324
		internal static int __PropertyOffset_RootActor;

		// Token: 0x0400EBA5 RID: 60325
		internal static int __PropertyOffset_LevelStreaming;

		// Token: 0x0400EBA6 RID: 60326
		internal static int __PropertyOffset_World;

		// Token: 0x0400EBA7 RID: 60327
		private static IntPtr __SetLevelVisible_NativeFunctionPtr;

		// Token: 0x0400EBA8 RID: 60328
		private static IntPtr __OnLevelVisible_NativeFunctionPtr;

		// Token: 0x0400EBA9 RID: 60329
		private static IntPtr __OnLevelLoad_NativeFunctionPtr;

		// Token: 0x0400EBAA RID: 60330
		private static IntPtr __OnLevelInVisible_NativeFunctionPtr;

		// Token: 0x0400EBAB RID: 60331
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x0400EBAC RID: 60332
		private static IntPtr __Destroy_NativeFunctionPtr;

		// Token: 0x0200317E RID: 12670
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetLevelVisible_FunctionParams
		{
			// Token: 0x04016FB8 RID: 94136
			[FieldOffset(0)]
			public bool InIsVisible;
		}

		// Token: 0x0200317F RID: 12671
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __Init_FunctionParams
		{
			// Token: 0x04016FB9 RID: 94137
			[FieldOffset(0)]
			public IntPtr InLevelStreaming;

			// Token: 0x04016FBA RID: 94138
			[FieldOffset(8)]
			public FString InLevelName;

			// Token: 0x04016FBB RID: 94139
			[FieldOffset(24)]
			public FString OptionalName;

			// Token: 0x04016FBC RID: 94140
			[FieldOffset(40)]
			public FVector InLocation;

			// Token: 0x04016FBD RID: 94141
			[FieldOffset(56)]
			public IntPtr InWorld;
		}
	}
}
