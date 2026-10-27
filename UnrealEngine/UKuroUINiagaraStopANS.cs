using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BD4 RID: 7124
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroUINiagaraStopANS")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UKuroUINiagaraStopANS : UKuroAnimNotifyState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B58F RID: 112015 RVA: 0x002849EC File Offset: 0x00282BEC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroUINiagaraStopANS._ClassPtr;
		}

		// Token: 0x0601B590 RID: 112016 RVA: 0x002849F8 File Offset: 0x00282BF8
		public UKuroUINiagaraStopANS() : this(BuiltinUtils.AllocNativeUObject(UKuroUINiagaraStopANS.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B591 RID: 112017 RVA: 0x00284A20 File Offset: 0x00282C20
		[NullableContext(1)]
		public UKuroUINiagaraStopANS(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroUINiagaraStopANS.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601B592 RID: 112018 RVA: 0x00284A53 File Offset: 0x00282C53
		static UKuroUINiagaraStopANS()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroUINiagaraStopANS");
		}

		// Token: 0x0601B593 RID: 112019 RVA: 0x00284A61 File Offset: 0x00282C61
		protected UKuroUINiagaraStopANS(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EB98 RID: 60312
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroUINiagaraStopANS";

		// Token: 0x0400EB99 RID: 60313
		private static IntPtr _ClassPtr;

		// Token: 0x0400EB9A RID: 60314
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
