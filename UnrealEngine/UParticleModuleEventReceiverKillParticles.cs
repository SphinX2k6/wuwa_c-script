using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F68 RID: 3944
	[UnrealObjectPath("/Script/Engine.ParticleModuleEventReceiverKillParticles")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UParticleModuleEventReceiverKillParticles : UParticleModuleEventReceiverBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D4DD RID: 54493 RVA: 0x00138DB1 File Offset: 0x00136FB1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleEventReceiverKillParticles._ClassPtr;
		}

		// Token: 0x0600D4DE RID: 54494 RVA: 0x00138DC0 File Offset: 0x00136FC0
		public UParticleModuleEventReceiverKillParticles() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleEventReceiverKillParticles.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D4DF RID: 54495 RVA: 0x00138DE8 File Offset: 0x00136FE8
		[NullableContext(1)]
		public UParticleModuleEventReceiverKillParticles(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleEventReceiverKillParticles.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031EC RID: 12780
		// (get) Token: 0x0600D4E0 RID: 54496 RVA: 0x00138E1B File Offset: 0x0013701B
		// (set) Token: 0x0600D4E1 RID: 54497 RVA: 0x00138E34 File Offset: 0x00137034
		public unsafe bool bStopSpawning
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleEventReceiverKillParticles.__PropertyOffset_bStopSpawning) & UParticleModuleEventReceiverKillParticles.__PropertyMask_bStopSpawning) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleEventReceiverKillParticles.__PropertyOffset_bStopSpawning) = ((*(base.NativePtr + (IntPtr)UParticleModuleEventReceiverKillParticles.__PropertyOffset_bStopSpawning) & ~UParticleModuleEventReceiverKillParticles.__PropertyMask_bStopSpawning) | (value ? UParticleModuleEventReceiverKillParticles.__PropertyMask_bStopSpawning : 0));
			}
		}

		// Token: 0x0600D4E2 RID: 54498 RVA: 0x00138E64 File Offset: 0x00137064
		static UParticleModuleEventReceiverKillParticles()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleEventReceiverKillParticles");
		}

		// Token: 0x0600D4E3 RID: 54499 RVA: 0x00138E72 File Offset: 0x00137072
		protected UParticleModuleEventReceiverKillParticles(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040072A4 RID: 29348
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleEventReceiverKillParticles";

		// Token: 0x040072A5 RID: 29349
		private static IntPtr _ClassPtr;

		// Token: 0x040072A6 RID: 29350
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040072A7 RID: 29351
		internal static int __PropertyOffset_bStopSpawning;

		// Token: 0x040072A8 RID: 29352
		internal static byte __PropertyMask_bStopSpawning;
	}
}
