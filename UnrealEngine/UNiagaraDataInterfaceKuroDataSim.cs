using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C0E RID: 7182
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.NiagaraDataInterfaceKuroDataSim")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UNiagaraDataInterfaceKuroDataSim : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601BB61 RID: 113505 RVA: 0x0028C8E5 File Offset: 0x0028AAE5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceKuroDataSim._ClassPtr;
		}

		// Token: 0x0601BB62 RID: 113506 RVA: 0x0028C8F4 File Offset: 0x0028AAF4
		public UNiagaraDataInterfaceKuroDataSim() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceKuroDataSim.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601BB63 RID: 113507 RVA: 0x0028C91C File Offset: 0x0028AB1C
		[NullableContext(1)]
		public UNiagaraDataInterfaceKuroDataSim(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceKuroDataSim.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601BB64 RID: 113508 RVA: 0x0028C94F File Offset: 0x0028AB4F
		static UNiagaraDataInterfaceKuroDataSim()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.NiagaraDataInterfaceKuroDataSim");
		}

		// Token: 0x0601BB65 RID: 113509 RVA: 0x0028C95D File Offset: 0x0028AB5D
		protected UNiagaraDataInterfaceKuroDataSim(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EE72 RID: 61042
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.NiagaraDataInterfaceKuroDataSim";

		// Token: 0x0400EE73 RID: 61043
		private static IntPtr _ClassPtr;

		// Token: 0x0400EE74 RID: 61044
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
