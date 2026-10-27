using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024C4 RID: 9412
	[UnrealObjectPath("/Script/NiagaraAnimNotifies.AnimNotifyState_TimedNiagaraEffect")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UAnimNotifyState_TimedNiagaraEffect : UAnimNotifyState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602337F RID: 144255 RVA: 0x00341846 File Offset: 0x0033FA46
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimNotifyState_TimedNiagaraEffect._ClassPtr;
		}

		// Token: 0x06023380 RID: 144256 RVA: 0x00341854 File Offset: 0x0033FA54
		public UAnimNotifyState_TimedNiagaraEffect() : this(BuiltinUtils.AllocNativeUObject(UAnimNotifyState_TimedNiagaraEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023381 RID: 144257 RVA: 0x0034187C File Offset: 0x0033FA7C
		[NullableContext(1)]
		public UAnimNotifyState_TimedNiagaraEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimNotifyState_TimedNiagaraEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008767 RID: 34663
		// (get) Token: 0x06023382 RID: 144258 RVA: 0x003418AF File Offset: 0x0033FAAF
		// (set) Token: 0x06023383 RID: 144259 RVA: 0x003418C3 File Offset: 0x0033FAC3
		[Nullable(2)]
		public unsafe UNiagaraSystem Template
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimNotifyState_TimedNiagaraEffect.__PropertyOffset_Template);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimNotifyState_TimedNiagaraEffect.__PropertyOffset_Template, value);
			}
		}

		// Token: 0x17008768 RID: 34664
		// (get) Token: 0x06023384 RID: 144260 RVA: 0x003418D8 File Offset: 0x0033FAD8
		// (set) Token: 0x06023385 RID: 144261 RVA: 0x003418EC File Offset: 0x0033FAEC
		public unsafe FName SocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState_TimedNiagaraEffect.__PropertyOffset_SocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState_TimedNiagaraEffect.__PropertyOffset_SocketName) = value;
			}
		}

		// Token: 0x17008769 RID: 34665
		// (get) Token: 0x06023386 RID: 144262 RVA: 0x00341901 File Offset: 0x0033FB01
		// (set) Token: 0x06023387 RID: 144263 RVA: 0x00341915 File Offset: 0x0033FB15
		public unsafe FVector LocationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState_TimedNiagaraEffect.__PropertyOffset_LocationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState_TimedNiagaraEffect.__PropertyOffset_LocationOffset) = value;
			}
		}

		// Token: 0x1700876A RID: 34666
		// (get) Token: 0x06023388 RID: 144264 RVA: 0x0034192A File Offset: 0x0033FB2A
		// (set) Token: 0x06023389 RID: 144265 RVA: 0x0034193E File Offset: 0x0033FB3E
		public unsafe FRotator RotationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState_TimedNiagaraEffect.__PropertyOffset_RotationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState_TimedNiagaraEffect.__PropertyOffset_RotationOffset) = value;
			}
		}

		// Token: 0x1700876B RID: 34667
		// (get) Token: 0x0602338A RID: 144266 RVA: 0x00341953 File Offset: 0x0033FB53
		// (set) Token: 0x0602338B RID: 144267 RVA: 0x00341963 File Offset: 0x0033FB63
		public unsafe bool bDestroyAtEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState_TimedNiagaraEffect.__PropertyOffset_bDestroyAtEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState_TimedNiagaraEffect.__PropertyOffset_bDestroyAtEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602338C RID: 144268 RVA: 0x00341974 File Offset: 0x0033FB74
		static UAnimNotifyState_TimedNiagaraEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NiagaraAnimNotifies.AnimNotifyState_TimedNiagaraEffect");
		}

		// Token: 0x0602338D RID: 144269 RVA: 0x00341982 File Offset: 0x0033FB82
		protected UAnimNotifyState_TimedNiagaraEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012CF8 RID: 77048
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NiagaraAnimNotifies.AnimNotifyState_TimedNiagaraEffect";

		// Token: 0x04012CF9 RID: 77049
		private static IntPtr _ClassPtr;

		// Token: 0x04012CFA RID: 77050
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012CFB RID: 77051
		internal static int __PropertyOffset_Template;

		// Token: 0x04012CFC RID: 77052
		internal static int __PropertyOffset_SocketName;

		// Token: 0x04012CFD RID: 77053
		internal static int __PropertyOffset_LocationOffset;

		// Token: 0x04012CFE RID: 77054
		internal static int __PropertyOffset_RotationOffset;

		// Token: 0x04012CFF RID: 77055
		internal static int __PropertyOffset_bDestroyAtEnd;
	}
}
