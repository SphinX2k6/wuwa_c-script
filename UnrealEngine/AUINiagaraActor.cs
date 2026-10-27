using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002190 RID: 8592
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UINiagaraActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUINiagaraActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020951 RID: 133457 RVA: 0x00303D63 File Offset: 0x00301F63
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUINiagaraActor._ClassPtr;
		}

		// Token: 0x06020952 RID: 133458 RVA: 0x00303D70 File Offset: 0x00301F70
		public AUINiagaraActor() : this(BuiltinUtils.AllocNativeUObject(AUINiagaraActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020953 RID: 133459 RVA: 0x00303D98 File Offset: 0x00301F98
		[NullableContext(1)]
		public AUINiagaraActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUINiagaraActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F6C RID: 32620
		// (get) Token: 0x06020954 RID: 133460 RVA: 0x00303DCB File Offset: 0x00301FCB
		// (set) Token: 0x06020955 RID: 133461 RVA: 0x00303DDF File Offset: 0x00301FDF
		public unsafe UUINiagara UINiagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUINiagara>(base.NativePtr / (IntPtr)sizeof(void*) + AUINiagaraActor.__PropertyOffset_UINiagara);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AUINiagaraActor.__PropertyOffset_UINiagara, value);
			}
		}

		// Token: 0x06020956 RID: 133462 RVA: 0x00303DF4 File Offset: 0x00301FF4
		public void SwitchToStop()
		{
			AUINiagaraActor.__SwitchToStop_Internal(base.NativePtr);
		}

		// Token: 0x06020957 RID: 133463 RVA: 0x00303E01 File Offset: 0x00302001
		public UUINiagara GetUINiagara()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUINiagara>(AUINiagaraActor.__GetUINiagara_Internal(base.NativePtr));
		}

		// Token: 0x06020958 RID: 133464 RVA: 0x00303E13 File Offset: 0x00302013
		public void DeactivateSystem()
		{
			AUINiagaraActor.__DeactivateSystem_Internal(base.NativePtr);
		}

		// Token: 0x06020959 RID: 133465 RVA: 0x00303E20 File Offset: 0x00302020
		public void ActivateSystem()
		{
			AUINiagaraActor.__ActivateSystem_Internal(base.NativePtr);
		}

		// Token: 0x0602095A RID: 133466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SwitchToStop_Internal(IntPtr @this);

		// Token: 0x0602095B RID: 133467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetUINiagara_Internal(IntPtr @this);

		// Token: 0x0602095C RID: 133468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeactivateSystem_Internal(IntPtr @this);

		// Token: 0x0602095D RID: 133469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActivateSystem_Internal(IntPtr @this);

		// Token: 0x0602095E RID: 133470 RVA: 0x00303E2D File Offset: 0x0030202D
		static AUINiagaraActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UINiagaraActor");
		}

		// Token: 0x0602095F RID: 133471 RVA: 0x00303E3B File Offset: 0x0030203B
		protected AUINiagaraActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011718 RID: 71448
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UINiagaraActor";

		// Token: 0x04011719 RID: 71449
		private static IntPtr _ClassPtr;

		// Token: 0x0401171A RID: 71450
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401171B RID: 71451
		internal static int __PropertyOffset_UINiagara;
	}
}
