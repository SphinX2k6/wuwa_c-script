using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C55 RID: 7253
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGamePlayer")]
	[UnrealStructLayout(1320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1320)]
	public class AKuroRhythmGamePlayer : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C235 RID: 115253 RVA: 0x00297500 File Offset: 0x00295700
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroRhythmGamePlayer._ClassPtr;
		}

		// Token: 0x0601C236 RID: 115254 RVA: 0x0029750C File Offset: 0x0029570C
		public AKuroRhythmGamePlayer() : this(BuiltinUtils.AllocNativeUObject(AKuroRhythmGamePlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C237 RID: 115255 RVA: 0x00297534 File Offset: 0x00295734
		[NullableContext(1)]
		public AKuroRhythmGamePlayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroRhythmGamePlayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170071D6 RID: 29142
		// (get) Token: 0x0601C238 RID: 115256 RVA: 0x00297568 File Offset: 0x00295768
		// (set) Token: 0x0601C239 RID: 115257 RVA: 0x002975A1 File Offset: 0x002957A1
		[Nullable(1)]
		public FKuroRhythmGameConfig GameConfig
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroRhythmGameConfig result;
				if ((result = this._GameConfig) == null)
				{
					result = (this._GameConfig = new FKuroRhythmGameConfig(base.NativePtr + (IntPtr)AKuroRhythmGamePlayer.__PropertyOffset_GameConfig, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmGameConfig.StaticStruct(), base.NativePtr + (IntPtr)AKuroRhythmGamePlayer.__PropertyOffset_GameConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170071D7 RID: 29143
		// (get) Token: 0x0601C23A RID: 115258 RVA: 0x002975C2 File Offset: 0x002957C2
		// (set) Token: 0x0601C23B RID: 115259 RVA: 0x002975D2 File Offset: 0x002957D2
		public unsafe bool bIsPlaying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroRhythmGamePlayer.__PropertyOffset_bIsPlaying) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroRhythmGamePlayer.__PropertyOffset_bIsPlaying) = (value ? 1 : 0);
			}
		}

		// Token: 0x170071D8 RID: 29144
		// (get) Token: 0x0601C23C RID: 115260 RVA: 0x002975E3 File Offset: 0x002957E3
		// (set) Token: 0x0601C23D RID: 115261 RVA: 0x002975F3 File Offset: 0x002957F3
		public unsafe float CurrentPlayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroRhythmGamePlayer.__PropertyOffset_CurrentPlayTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroRhythmGamePlayer.__PropertyOffset_CurrentPlayTime) = value;
			}
		}

		// Token: 0x0601C23E RID: 115262 RVA: 0x00297604 File Offset: 0x00295804
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Stop()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroRhythmGamePlayer.__Stop_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C23F RID: 115263 RVA: 0x00297619 File Offset: 0x00295819
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Resume()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroRhythmGamePlayer.__Resume_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C240 RID: 115264 RVA: 0x0029762E File Offset: 0x0029582E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Play()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroRhythmGamePlayer.__Play_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C241 RID: 115265 RVA: 0x00297643 File Offset: 0x00295843
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Pause()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroRhythmGamePlayer.__Pause_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C242 RID: 115266 RVA: 0x00297658 File Offset: 0x00295858
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsPlaying()
		{
			AKuroRhythmGamePlayer.__IsPlaying_FunctionParams* ptr = stackalloc AKuroRhythmGamePlayer.__IsPlaying_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(AKuroRhythmGamePlayer.__IsPlaying_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AKuroRhythmGamePlayer.__IsPlaying_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroRhythmGamePlayer.__IsPlaying_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C243 RID: 115267 RVA: 0x002976A0 File Offset: 0x002958A0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Initialize(in FKuroRhythmGameConfig InConfig)
		{
			AKuroRhythmGamePlayer.__Initialize_FunctionParams* ptr = stackalloc AKuroRhythmGamePlayer.__Initialize_FunctionParams[(UIntPtr)287] + 15L / (long)sizeof(AKuroRhythmGamePlayer.__Initialize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AKuroRhythmGamePlayer.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
			if (InConfig != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmGameConfig.StaticStruct(), &ptr->InConfig, InConfig.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroRhythmGamePlayer.__Initialize_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C244 RID: 115268 RVA: 0x00297708 File Offset: 0x00295908
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetTotalDuration()
		{
			AKuroRhythmGamePlayer.__GetTotalDuration_FunctionParams* ptr = stackalloc AKuroRhythmGamePlayer.__GetTotalDuration_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(AKuroRhythmGamePlayer.__GetTotalDuration_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AKuroRhythmGamePlayer.__GetTotalDuration_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroRhythmGamePlayer.__GetTotalDuration_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C245 RID: 115269 RVA: 0x00297750 File Offset: 0x00295950
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetCurrentPlayTime()
		{
			AKuroRhythmGamePlayer.__GetCurrentPlayTime_FunctionParams* ptr = stackalloc AKuroRhythmGamePlayer.__GetCurrentPlayTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(AKuroRhythmGamePlayer.__GetCurrentPlayTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AKuroRhythmGamePlayer.__GetCurrentPlayTime_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroRhythmGamePlayer.__GetCurrentPlayTime_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C246 RID: 115270 RVA: 0x00297796 File Offset: 0x00295996
		static AKuroRhythmGamePlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRhythmGame.KuroRhythmGamePlayer");
		}

		// Token: 0x0601C247 RID: 115271 RVA: 0x002977A4 File Offset: 0x002959A4
		protected AKuroRhythmGamePlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F23B RID: 62011
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGamePlayer";

		// Token: 0x0400F23C RID: 62012
		private static IntPtr _ClassPtr;

		// Token: 0x0400F23D RID: 62013
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F23E RID: 62014
		internal static int __PropertyOffset_GameConfig;

		// Token: 0x0400F23F RID: 62015
		[Nullable(2)]
		private FKuroRhythmGameConfig _GameConfig;

		// Token: 0x0400F240 RID: 62016
		internal static int __PropertyOffset_bIsPlaying;

		// Token: 0x0400F241 RID: 62017
		internal static int __PropertyOffset_CurrentPlayTime;

		// Token: 0x0400F242 RID: 62018
		private static IntPtr __Stop_NativeFunctionPtr;

		// Token: 0x0400F243 RID: 62019
		private static IntPtr __Resume_NativeFunctionPtr;

		// Token: 0x0400F244 RID: 62020
		private static IntPtr __Play_NativeFunctionPtr;

		// Token: 0x0400F245 RID: 62021
		private static IntPtr __Pause_NativeFunctionPtr;

		// Token: 0x0400F246 RID: 62022
		private static IntPtr __IsPlaying_NativeFunctionPtr;

		// Token: 0x0400F247 RID: 62023
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x0400F248 RID: 62024
		private static IntPtr __GetTotalDuration_NativeFunctionPtr;

		// Token: 0x0400F249 RID: 62025
		private static IntPtr __GetCurrentPlayTime_NativeFunctionPtr;

		// Token: 0x020031DD RID: 12765
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsPlaying_FunctionParams
		{
			// Token: 0x04017030 RID: 94256
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020031DE RID: 12766
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 272)]
		protected ref struct __Initialize_FunctionParams
		{
			// Token: 0x04017031 RID: 94257
			[FieldOffset(0)]
			public byte InConfig;
		}

		// Token: 0x020031DF RID: 12767
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetTotalDuration_FunctionParams
		{
			// Token: 0x04017032 RID: 94258
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x020031E0 RID: 12768
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetCurrentPlayTime_FunctionParams
		{
			// Token: 0x04017033 RID: 94259
			[FieldOffset(0)]
			public float __Result;
		}
	}
}
