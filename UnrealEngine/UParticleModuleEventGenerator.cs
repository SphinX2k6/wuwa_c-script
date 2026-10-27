using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F66 RID: 3942
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleEventGenerator")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UParticleModuleEventGenerator : UParticleModuleEventBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D4CE RID: 54478 RVA: 0x00138C49 File Offset: 0x00136E49
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleEventGenerator._ClassPtr;
		}

		// Token: 0x0600D4CF RID: 54479 RVA: 0x00138C58 File Offset: 0x00136E58
		public UParticleModuleEventGenerator() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleEventGenerator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D4D0 RID: 54480 RVA: 0x00138C80 File Offset: 0x00136E80
		public UParticleModuleEventGenerator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleEventGenerator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031E9 RID: 12777
		// (get) Token: 0x0600D4D1 RID: 54481 RVA: 0x00138CB4 File Offset: 0x00136EB4
		// (set) Token: 0x0600D4D2 RID: 54482 RVA: 0x00138CED File Offset: 0x00136EED
		public TArray<FParticleEvent_GenerateInfo> Events
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FParticleEvent_GenerateInfo> result;
				if ((result = this._Events) == null)
				{
					result = (this._Events = new TArray<FParticleEvent_GenerateInfo>(base.NativePtr + (IntPtr)UParticleModuleEventGenerator.__PropertyOffset_Events, this));
				}
				return result;
			}
			set
			{
				this.Events.CopyAssign(value);
			}
		}

		// Token: 0x0600D4D3 RID: 54483 RVA: 0x00138CFB File Offset: 0x00136EFB
		static UParticleModuleEventGenerator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleEventGenerator");
		}

		// Token: 0x0600D4D4 RID: 54484 RVA: 0x00138D09 File Offset: 0x00136F09
		protected UParticleModuleEventGenerator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400729A RID: 29338
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleEventGenerator";

		// Token: 0x0400729B RID: 29339
		private static IntPtr _ClassPtr;

		// Token: 0x0400729C RID: 29340
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400729D RID: 29341
		internal static int __PropertyOffset_Events;

		// Token: 0x0400729E RID: 29342
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FParticleEvent_GenerateInfo> _Events;
	}
}
