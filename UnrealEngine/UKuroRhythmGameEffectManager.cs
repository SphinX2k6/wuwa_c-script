using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C4D RID: 7245
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGameEffectManager")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UKuroRhythmGameEffectManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C128 RID: 114984 RVA: 0x00294FE4 File Offset: 0x002931E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRhythmGameEffectManager._ClassPtr;
		}

		// Token: 0x0601C129 RID: 114985 RVA: 0x00294FF0 File Offset: 0x002931F0
		public UKuroRhythmGameEffectManager() : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmGameEffectManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C12A RID: 114986 RVA: 0x00295018 File Offset: 0x00293218
		[NullableContext(1)]
		public UKuroRhythmGameEffectManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmGameEffectManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007186 RID: 29062
		// (get) Token: 0x0601C12B RID: 114987 RVA: 0x0029504B File Offset: 0x0029324B
		// (set) Token: 0x0601C12C RID: 114988 RVA: 0x0029505F File Offset: 0x0029325F
		[Nullable(2)]
		public unsafe USplineComponent SplineComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameEffectManager.__PropertyOffset_SplineComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameEffectManager.__PropertyOffset_SplineComponent, value);
			}
		}

		// Token: 0x17007187 RID: 29063
		// (get) Token: 0x0601C12D RID: 114989 RVA: 0x00295074 File Offset: 0x00293274
		// (set) Token: 0x0601C12E RID: 114990 RVA: 0x00295088 File Offset: 0x00293288
		[Nullable(2)]
		public unsafe UNiagaraSystem EffectSystem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameEffectManager.__PropertyOffset_EffectSystem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameEffectManager.__PropertyOffset_EffectSystem, value);
			}
		}

		// Token: 0x17007188 RID: 29064
		// (get) Token: 0x0601C12F RID: 114991 RVA: 0x0029509D File Offset: 0x0029329D
		// (set) Token: 0x0601C130 RID: 114992 RVA: 0x002950B1 File Offset: 0x002932B1
		[Nullable(2)]
		public unsafe UNiagaraComponent NiagaraComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameEffectManager.__PropertyOffset_NiagaraComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameEffectManager.__PropertyOffset_NiagaraComponent, value);
			}
		}

		// Token: 0x0601C131 RID: 114993 RVA: 0x002950C8 File Offset: 0x002932C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Tick(float DeltaTime, float CurrentSplineLength, float CurrentAbsoluteTime, float CurrentTrackSpeed = 100f)
		{
			UKuroRhythmGameEffectManager.__Tick_FunctionParams* ptr = stackalloc UKuroRhythmGameEffectManager.__Tick_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroRhythmGameEffectManager.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameEffectManager.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			ptr->CurrentSplineLength = CurrentSplineLength;
			ptr->CurrentAbsoluteTime = CurrentAbsoluteTime;
			ptr->CurrentTrackSpeed = CurrentTrackSpeed;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameEffectManager.__Tick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C132 RID: 114994 RVA: 0x00295128 File Offset: 0x00293328
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetNiagaraCurrentTrackIndex(int CurrentTrackIndex)
		{
			UKuroRhythmGameEffectManager.__SetNiagaraCurrentTrackIndex_FunctionParams* ptr = stackalloc UKuroRhythmGameEffectManager.__SetNiagaraCurrentTrackIndex_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameEffectManager.__SetNiagaraCurrentTrackIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameEffectManager.__SetNiagaraCurrentTrackIndex_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurrentTrackIndex = CurrentTrackIndex;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameEffectManager.__SetNiagaraCurrentTrackIndex_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C133 RID: 114995 RVA: 0x00295170 File Offset: 0x00293370
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetNiagaraBPM(float BPM)
		{
			UKuroRhythmGameEffectManager.__SetNiagaraBPM_FunctionParams* ptr = stackalloc UKuroRhythmGameEffectManager.__SetNiagaraBPM_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameEffectManager.__SetNiagaraBPM_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameEffectManager.__SetNiagaraBPM_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BPM = BPM;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameEffectManager.__SetNiagaraBPM_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C134 RID: 114996 RVA: 0x002951B8 File Offset: 0x002933B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnNoteMiss(int NoteIndex)
		{
			UKuroRhythmGameEffectManager.__OnNoteMiss_FunctionParams* ptr = stackalloc UKuroRhythmGameEffectManager.__OnNoteMiss_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameEffectManager.__OnNoteMiss_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameEffectManager.__OnNoteMiss_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NoteIndex = NoteIndex;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameEffectManager.__OnNoteMiss_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C135 RID: 114997 RVA: 0x00295200 File Offset: 0x00293400
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnNoteHit(int NoteIndex, EKuroRhythmGameNoteType NoteType)
		{
			UKuroRhythmGameEffectManager.__OnNoteHit_FunctionParams* ptr = stackalloc UKuroRhythmGameEffectManager.__OnNoteHit_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroRhythmGameEffectManager.__OnNoteHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameEffectManager.__OnNoteHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NoteIndex = NoteIndex;
			ptr->NoteType = NoteType;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameEffectManager.__OnNoteHit_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C136 RID: 114998 RVA: 0x00295250 File Offset: 0x00293450
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnHoldNoteInterrupted(int NoteIndex)
		{
			UKuroRhythmGameEffectManager.__OnHoldNoteInterrupted_FunctionParams* ptr = stackalloc UKuroRhythmGameEffectManager.__OnHoldNoteInterrupted_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameEffectManager.__OnHoldNoteInterrupted_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameEffectManager.__OnHoldNoteInterrupted_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NoteIndex = NoteIndex;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameEffectManager.__OnHoldNoteInterrupted_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C137 RID: 114999 RVA: 0x00295298 File Offset: 0x00293498
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnHoldNoteCompleted(int NoteIndex)
		{
			UKuroRhythmGameEffectManager.__OnHoldNoteCompleted_FunctionParams* ptr = stackalloc UKuroRhythmGameEffectManager.__OnHoldNoteCompleted_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameEffectManager.__OnHoldNoteCompleted_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameEffectManager.__OnHoldNoteCompleted_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NoteIndex = NoteIndex;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameEffectManager.__OnHoldNoteCompleted_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C138 RID: 115000 RVA: 0x002952E0 File Offset: 0x002934E0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Initialize(USplineComponent InSplineComponent, UNiagaraSystem InEffectSystem = null)
		{
			UKuroRhythmGameEffectManager.__Initialize_FunctionParams* ptr = stackalloc UKuroRhythmGameEffectManager.__Initialize_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroRhythmGameEffectManager.__Initialize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameEffectManager.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSplineComponent = ((InSplineComponent != null) ? InSplineComponent.NativePtr : IntPtr.Zero);
			ptr->InEffectSystem = ((InEffectSystem != null) ? InEffectSystem.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameEffectManager.__Initialize_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C139 RID: 115001 RVA: 0x0029534C File Offset: 0x0029354C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USplineComponent GetSplineComponent()
		{
			UKuroRhythmGameEffectManager.__GetSplineComponent_FunctionParams* ptr = stackalloc UKuroRhythmGameEffectManager.__GetSplineComponent_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroRhythmGameEffectManager.__GetSplineComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameEffectManager.__GetSplineComponent_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameEffectManager.__GetSplineComponent_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USplineComponent>(ptr->__Result);
		}

		// Token: 0x0601C13A RID: 115002 RVA: 0x00295398 File Offset: 0x00293598
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UNiagaraComponent GetNiagaraComponent()
		{
			UKuroRhythmGameEffectManager.__GetNiagaraComponent_FunctionParams* ptr = stackalloc UKuroRhythmGameEffectManager.__GetNiagaraComponent_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroRhythmGameEffectManager.__GetNiagaraComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameEffectManager.__GetNiagaraComponent_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameEffectManager.__GetNiagaraComponent_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraComponent>(ptr->__Result);
		}

		// Token: 0x0601C13B RID: 115003 RVA: 0x002953E4 File Offset: 0x002935E4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UNiagaraSystem GetEffectSystem()
		{
			UKuroRhythmGameEffectManager.__GetEffectSystem_FunctionParams* ptr = stackalloc UKuroRhythmGameEffectManager.__GetEffectSystem_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroRhythmGameEffectManager.__GetEffectSystem_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameEffectManager.__GetEffectSystem_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameEffectManager.__GetEffectSystem_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraSystem>(ptr->__Result);
		}

		// Token: 0x0601C13C RID: 115004 RVA: 0x0029542F File Offset: 0x0029362F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Cleanup()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameEffectManager.__Cleanup_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C13D RID: 115005 RVA: 0x00295444 File Offset: 0x00293644
		static UKuroRhythmGameEffectManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRhythmGame.KuroRhythmGameEffectManager");
		}

		// Token: 0x0601C13E RID: 115006 RVA: 0x00295452 File Offset: 0x00293652
		protected UKuroRhythmGameEffectManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F184 RID: 61828
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGameEffectManager";

		// Token: 0x0400F185 RID: 61829
		private static IntPtr _ClassPtr;

		// Token: 0x0400F186 RID: 61830
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F187 RID: 61831
		internal static int __PropertyOffset_SplineComponent;

		// Token: 0x0400F188 RID: 61832
		internal static int __PropertyOffset_EffectSystem;

		// Token: 0x0400F189 RID: 61833
		internal static int __PropertyOffset_NiagaraComponent;

		// Token: 0x0400F18A RID: 61834
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x0400F18B RID: 61835
		private static IntPtr __SetNiagaraCurrentTrackIndex_NativeFunctionPtr;

		// Token: 0x0400F18C RID: 61836
		private static IntPtr __SetNiagaraBPM_NativeFunctionPtr;

		// Token: 0x0400F18D RID: 61837
		private static IntPtr __OnNoteMiss_NativeFunctionPtr;

		// Token: 0x0400F18E RID: 61838
		private static IntPtr __OnNoteHit_NativeFunctionPtr;

		// Token: 0x0400F18F RID: 61839
		private static IntPtr __OnHoldNoteInterrupted_NativeFunctionPtr;

		// Token: 0x0400F190 RID: 61840
		private static IntPtr __OnHoldNoteCompleted_NativeFunctionPtr;

		// Token: 0x0400F191 RID: 61841
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x0400F192 RID: 61842
		private static IntPtr __GetSplineComponent_NativeFunctionPtr;

		// Token: 0x0400F193 RID: 61843
		private static IntPtr __GetNiagaraComponent_NativeFunctionPtr;

		// Token: 0x0400F194 RID: 61844
		private static IntPtr __GetEffectSystem_NativeFunctionPtr;

		// Token: 0x0400F195 RID: 61845
		private static IntPtr __Cleanup_NativeFunctionPtr;

		// Token: 0x020031AE RID: 12718
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __Tick_FunctionParams
		{
			// Token: 0x04016FF2 RID: 94194
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x04016FF3 RID: 94195
			[FieldOffset(4)]
			public float CurrentSplineLength;

			// Token: 0x04016FF4 RID: 94196
			[FieldOffset(8)]
			public float CurrentAbsoluteTime;

			// Token: 0x04016FF5 RID: 94197
			[FieldOffset(12)]
			public float CurrentTrackSpeed;
		}

		// Token: 0x020031AF RID: 12719
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetNiagaraCurrentTrackIndex_FunctionParams
		{
			// Token: 0x04016FF6 RID: 94198
			[FieldOffset(0)]
			public int CurrentTrackIndex;
		}

		// Token: 0x020031B0 RID: 12720
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetNiagaraBPM_FunctionParams
		{
			// Token: 0x04016FF7 RID: 94199
			[FieldOffset(0)]
			public float BPM;
		}

		// Token: 0x020031B1 RID: 12721
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnNoteMiss_FunctionParams
		{
			// Token: 0x04016FF8 RID: 94200
			[FieldOffset(0)]
			public int NoteIndex;
		}

		// Token: 0x020031B2 RID: 12722
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnNoteHit_FunctionParams
		{
			// Token: 0x04016FF9 RID: 94201
			[FieldOffset(0)]
			public int NoteIndex;

			// Token: 0x04016FFA RID: 94202
			[FieldOffset(4)]
			public EKuroRhythmGameNoteType NoteType;
		}

		// Token: 0x020031B3 RID: 12723
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnHoldNoteInterrupted_FunctionParams
		{
			// Token: 0x04016FFB RID: 94203
			[FieldOffset(0)]
			public int NoteIndex;
		}

		// Token: 0x020031B4 RID: 12724
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnHoldNoteCompleted_FunctionParams
		{
			// Token: 0x04016FFC RID: 94204
			[FieldOffset(0)]
			public int NoteIndex;
		}

		// Token: 0x020031B5 RID: 12725
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __Initialize_FunctionParams
		{
			// Token: 0x04016FFD RID: 94205
			[FieldOffset(0)]
			public IntPtr InSplineComponent;

			// Token: 0x04016FFE RID: 94206
			[FieldOffset(8)]
			public IntPtr InEffectSystem;
		}

		// Token: 0x020031B6 RID: 12726
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSplineComponent_FunctionParams
		{
			// Token: 0x04016FFF RID: 94207
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x020031B7 RID: 12727
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetNiagaraComponent_FunctionParams
		{
			// Token: 0x04017000 RID: 94208
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x020031B8 RID: 12728
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetEffectSystem_FunctionParams
		{
			// Token: 0x04017001 RID: 94209
			[FieldOffset(0)]
			public IntPtr __Result;
		}
	}
}
