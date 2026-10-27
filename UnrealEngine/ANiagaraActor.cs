using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200253E RID: 9534
	[UnrealObjectPath("/Script/Niagara.NiagaraActor")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class ANiagaraActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023630 RID: 144944 RVA: 0x00345498 File Offset: 0x00343698
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANiagaraActor._ClassPtr;
		}

		// Token: 0x06023631 RID: 144945 RVA: 0x003454A4 File Offset: 0x003436A4
		public ANiagaraActor() : this(BuiltinUtils.AllocNativeUObject(ANiagaraActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023632 RID: 144946 RVA: 0x003454CC File Offset: 0x003436CC
		[NullableContext(1)]
		public ANiagaraActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANiagaraActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008802 RID: 34818
		// (get) Token: 0x06023633 RID: 144947 RVA: 0x003454FF File Offset: 0x003436FF
		// (set) Token: 0x06023634 RID: 144948 RVA: 0x00345513 File Offset: 0x00343713
		[Nullable(2)]
		public unsafe UNiagaraComponent NiagaraComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ANiagaraActor.__PropertyOffset_NiagaraComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANiagaraActor.__PropertyOffset_NiagaraComponent, value);
			}
		}

		// Token: 0x17008803 RID: 34819
		// (get) Token: 0x06023635 RID: 144949 RVA: 0x00345528 File Offset: 0x00343728
		// (set) Token: 0x06023636 RID: 144950 RVA: 0x00345541 File Offset: 0x00343741
		public unsafe bool bDestroyOnSystemFinish
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANiagaraActor.__PropertyOffset_bDestroyOnSystemFinish) & ANiagaraActor.__PropertyMask_bDestroyOnSystemFinish) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANiagaraActor.__PropertyOffset_bDestroyOnSystemFinish) = ((*(base.NativePtr + (IntPtr)ANiagaraActor.__PropertyOffset_bDestroyOnSystemFinish) & ~ANiagaraActor.__PropertyMask_bDestroyOnSystemFinish) | (value ? ANiagaraActor.__PropertyMask_bDestroyOnSystemFinish : 0));
			}
		}

		// Token: 0x06023637 RID: 144951 RVA: 0x00345571 File Offset: 0x00343771
		public void SetDestroyOnSystemFinish(bool bShouldDestroyOnSystemFinish)
		{
			ANiagaraActor.__SetDestroyOnSystemFinish_Internal(base.NativePtr, bShouldDestroyOnSystemFinish);
		}

		// Token: 0x06023638 RID: 144952 RVA: 0x00345580 File Offset: 0x00343780
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnNiagaraSystemFinished(UNiagaraComponent FinishedComponent)
		{
			ANiagaraActor.__OnNiagaraSystemFinished_FunctionParams* ptr = stackalloc ANiagaraActor.__OnNiagaraSystemFinished_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(ANiagaraActor.__OnNiagaraSystemFinished_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANiagaraActor.__OnNiagaraSystemFinished_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FinishedComponent = ((FinishedComponent != null) ? FinishedComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ANiagaraActor.__OnNiagaraSystemFinished_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023639 RID: 144953
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDestroyOnSystemFinish_Internal(IntPtr @this, bool bShouldDestroyOnSystemFinish);

		// Token: 0x0602363A RID: 144954 RVA: 0x003455D6 File Offset: 0x003437D6
		static ANiagaraActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraActor");
		}

		// Token: 0x0602363B RID: 144955 RVA: 0x003455E4 File Offset: 0x003437E4
		protected ANiagaraActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012FE0 RID: 77792
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraActor";

		// Token: 0x04012FE1 RID: 77793
		private static IntPtr _ClassPtr;

		// Token: 0x04012FE2 RID: 77794
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012FE3 RID: 77795
		internal static int __PropertyOffset_NiagaraComponent;

		// Token: 0x04012FE4 RID: 77796
		internal static int __PropertyOffset_bDestroyOnSystemFinish;

		// Token: 0x04012FE5 RID: 77797
		internal static byte __PropertyMask_bDestroyOnSystemFinish;

		// Token: 0x04012FE6 RID: 77798
		private static IntPtr __OnNiagaraSystemFinished_NativeFunctionPtr;

		// Token: 0x0200366C RID: 13932
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnNiagaraSystemFinished_FunctionParams
		{
			// Token: 0x0401773E RID: 96062
			[FieldOffset(0)]
			public IntPtr FinishedComponent;
		}
	}
}
