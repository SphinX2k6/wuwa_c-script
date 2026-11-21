using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200079F RID: 1951
	[UnrealObjectPath("/Script/Niagara.NiagaraActor")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class ANiagaraActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A8FC RID: 43260 RVA: 0x000F9B6D File Offset: 0x000F7D6D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANiagaraActor._ClassPtr;
		}

		// Token: 0x0600A8FD RID: 43261 RVA: 0x000F9B7C File Offset: 0x000F7D7C
		public ANiagaraActor() : this(BuiltinUtils.AllocNativeUObject(ANiagaraActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A8FE RID: 43262 RVA: 0x000F9BA4 File Offset: 0x000F7DA4
		[NullableContext(1)]
		public ANiagaraActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANiagaraActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x0600A8FF RID: 43263 RVA: 0x000F9BD7 File Offset: 0x000F7DD7
		// (set) Token: 0x0600A900 RID: 43264 RVA: 0x000F9BEB File Offset: 0x000F7DEB
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

		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x0600A901 RID: 43265 RVA: 0x000F9C00 File Offset: 0x000F7E00
		// (set) Token: 0x0600A902 RID: 43266 RVA: 0x000F9C19 File Offset: 0x000F7E19
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

		// Token: 0x0600A903 RID: 43267 RVA: 0x000F9C49 File Offset: 0x000F7E49
		public void SetDestroyOnSystemFinish(bool bShouldDestroyOnSystemFinish)
		{
			ANiagaraActor.__SetDestroyOnSystemFinish_Internal(base.NativePtr, bShouldDestroyOnSystemFinish);
		}

		// Token: 0x0600A904 RID: 43268 RVA: 0x000F9C58 File Offset: 0x000F7E58
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OnNiagaraSystemFinished(UNiagaraComponent FinishedComponent)
		{
			ANiagaraActor.__OnNiagaraSystemFinished_FunctionParams* ptr = stackalloc ANiagaraActor.__OnNiagaraSystemFinished_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(ANiagaraActor.__OnNiagaraSystemFinished_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANiagaraActor.__OnNiagaraSystemFinished_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FinishedComponent = ((FinishedComponent != null) ? FinishedComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ANiagaraActor.__OnNiagaraSystemFinished_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600A905 RID: 43269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDestroyOnSystemFinish_Internal(IntPtr @this, bool bShouldDestroyOnSystemFinish);

		// Token: 0x0600A906 RID: 43270 RVA: 0x000F9CAD File Offset: 0x000F7EAD
		static ANiagaraActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraActor");
		}

		// Token: 0x0600A907 RID: 43271 RVA: 0x000F9CBB File Offset: 0x000F7EBB
		protected ANiagaraActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040048A6 RID: 18598
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraActor";

		// Token: 0x040048A7 RID: 18599
		private static IntPtr _ClassPtr;

		// Token: 0x040048A8 RID: 18600
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040048A9 RID: 18601
		internal static int __PropertyOffset_NiagaraComponent;

		// Token: 0x040048AA RID: 18602
		internal static int __PropertyOffset_bDestroyOnSystemFinish;

		// Token: 0x040048AB RID: 18603
		internal static byte __PropertyMask_bDestroyOnSystemFinish;

		// Token: 0x040048AC RID: 18604
		private static IntPtr __OnNiagaraSystemFinished_NativeFunctionPtr;

		// Token: 0x02000F5F RID: 3935
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnNiagaraSystemFinished_FunctionParams
		{
			// Token: 0x04006335 RID: 25397
			[FieldOffset(0)]
			public IntPtr FinishedComponent;
		}
	}
}
