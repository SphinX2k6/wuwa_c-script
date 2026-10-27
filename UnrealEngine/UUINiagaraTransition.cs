using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002192 RID: 8594
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UINiagaraTransition")]
	[UnrealStructLayout(912, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 912)]
	public class UUINiagaraTransition : UUITransitionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602096A RID: 133482 RVA: 0x00303F48 File Offset: 0x00302148
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUINiagaraTransition._ClassPtr;
		}

		// Token: 0x0602096B RID: 133483 RVA: 0x00303F54 File Offset: 0x00302154
		public UUINiagaraTransition() : this(BuiltinUtils.AllocNativeUObject(UUINiagaraTransition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602096C RID: 133484 RVA: 0x00303F7C File Offset: 0x0030217C
		[NullableContext(1)]
		public UUINiagaraTransition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUINiagaraTransition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F6E RID: 32622
		// (get) Token: 0x0602096D RID: 133485 RVA: 0x00303FB0 File Offset: 0x003021B0
		// (set) Token: 0x0602096E RID: 133486 RVA: 0x00303FE9 File Offset: 0x003021E9
		[Nullable(1)]
		public FNiagaraTransitionInfo TransitionInfo
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FNiagaraTransitionInfo result;
				if ((result = this._TransitionInfo) == null)
				{
					result = (this._TransitionInfo = new FNiagaraTransitionInfo(base.NativePtr + (IntPtr)UUINiagaraTransition.__PropertyOffset_TransitionInfo, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraTransitionInfo.StaticStruct(), base.NativePtr + (IntPtr)UUINiagaraTransition.__PropertyOffset_TransitionInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007F6F RID: 32623
		// (get) Token: 0x0602096F RID: 133487 RVA: 0x0030400A File Offset: 0x0030220A
		// (set) Token: 0x06020970 RID: 133488 RVA: 0x0030401E File Offset: 0x0030221E
		public unsafe ULTweener ColorTweener
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULTweener>(base.NativePtr / (IntPtr)sizeof(void*) + UUINiagaraTransition.__PropertyOffset_ColorTweener);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUINiagaraTransition.__PropertyOffset_ColorTweener, value);
			}
		}

		// Token: 0x06020971 RID: 133489 RVA: 0x00304033 File Offset: 0x00302233
		public void SetStateNiagaraSystem(EUISelectableSelectionState State, UNiagaraSystem NewSystem)
		{
			UUINiagaraTransition.__SetStateNiagaraSystem_Internal(base.NativePtr, State, (NewSystem != null) ? NewSystem.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020972 RID: 133490 RVA: 0x00304051 File Offset: 0x00302251
		public void SetAllTransitionNiagaraSystem(UNiagaraSystem NewSystem)
		{
			UUINiagaraTransition.__SetAllTransitionNiagaraSystem_Internal(base.NativePtr, (NewSystem != null) ? NewSystem.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020973 RID: 133491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStateNiagaraSystem_Internal(IntPtr @this, EUISelectableSelectionState State, IntPtr NewSystem);

		// Token: 0x06020974 RID: 133492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllTransitionNiagaraSystem_Internal(IntPtr @this, IntPtr NewSystem);

		// Token: 0x06020975 RID: 133493 RVA: 0x0030406E File Offset: 0x0030226E
		static UUINiagaraTransition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UINiagaraTransition");
		}

		// Token: 0x06020976 RID: 133494 RVA: 0x0030407C File Offset: 0x0030227C
		protected UUINiagaraTransition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011720 RID: 71456
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UINiagaraTransition";

		// Token: 0x04011721 RID: 71457
		private static IntPtr _ClassPtr;

		// Token: 0x04011722 RID: 71458
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011723 RID: 71459
		internal static int __PropertyOffset_TransitionInfo;

		// Token: 0x04011724 RID: 71460
		private FNiagaraTransitionInfo _TransitionInfo;

		// Token: 0x04011725 RID: 71461
		internal static int __PropertyOffset_ColorTweener;
	}
}
