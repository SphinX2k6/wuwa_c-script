using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025A6 RID: 9638
	[UnrealObjectPath("/Script/Niagara.NiagaraEventReceiverEmitterAction_SpawnParticles")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UNiagaraEventReceiverEmitterAction_SpawnParticles : UNiagaraEventReceiverEmitterAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023CBB RID: 146619 RVA: 0x0034EFED File Offset: 0x0034D1ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraEventReceiverEmitterAction_SpawnParticles._ClassPtr;
		}

		// Token: 0x06023CBC RID: 146620 RVA: 0x0034EFFC File Offset: 0x0034D1FC
		public UNiagaraEventReceiverEmitterAction_SpawnParticles() : this(BuiltinUtils.AllocNativeUObject(UNiagaraEventReceiverEmitterAction_SpawnParticles.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023CBD RID: 146621 RVA: 0x0034F024 File Offset: 0x0034D224
		[NullableContext(1)]
		public UNiagaraEventReceiverEmitterAction_SpawnParticles(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraEventReceiverEmitterAction_SpawnParticles.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008994 RID: 35220
		// (get) Token: 0x06023CBE RID: 146622 RVA: 0x0034F057 File Offset: 0x0034D257
		// (set) Token: 0x06023CBF RID: 146623 RVA: 0x0034F067 File Offset: 0x0034D267
		public unsafe uint NumParticles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraEventReceiverEmitterAction_SpawnParticles.__PropertyOffset_NumParticles);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraEventReceiverEmitterAction_SpawnParticles.__PropertyOffset_NumParticles) = (int)value;
			}
		}

		// Token: 0x06023CC0 RID: 146624 RVA: 0x0034F078 File Offset: 0x0034D278
		static UNiagaraEventReceiverEmitterAction_SpawnParticles()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraEventReceiverEmitterAction_SpawnParticles");
		}

		// Token: 0x06023CC1 RID: 146625 RVA: 0x0034F086 File Offset: 0x0034D286
		protected UNiagaraEventReceiverEmitterAction_SpawnParticles(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401332E RID: 78638
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraEventReceiverEmitterAction_SpawnParticles";

		// Token: 0x0401332F RID: 78639
		private static IntPtr _ClassPtr;

		// Token: 0x04013330 RID: 78640
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013331 RID: 78641
		internal static int __PropertyOffset_NumParticles;
	}
}
