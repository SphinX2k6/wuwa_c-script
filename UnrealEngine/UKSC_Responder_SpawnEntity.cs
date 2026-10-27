using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E25 RID: 7717
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Responder_SpawnEntity")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKSC_Responder_SpawnEntity : UKSC_EventResponder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D6B0 RID: 120496 RVA: 0x002B7431 File Offset: 0x002B5631
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Responder_SpawnEntity._ClassPtr;
		}

		// Token: 0x0601D6B1 RID: 120497 RVA: 0x002B7440 File Offset: 0x002B5640
		public UKSC_Responder_SpawnEntity() : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_SpawnEntity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D6B2 RID: 120498 RVA: 0x002B7468 File Offset: 0x002B5668
		public UKSC_Responder_SpawnEntity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_SpawnEntity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007698 RID: 30360
		// (get) Token: 0x0601D6B3 RID: 120499 RVA: 0x002B749C File Offset: 0x002B569C
		// (set) Token: 0x0601D6B4 RID: 120500 RVA: 0x002B74D5 File Offset: 0x002B56D5
		public TArray<FKSC_SpawnEntity> SpawnConfigs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKSC_SpawnEntity> result;
				if ((result = this._SpawnConfigs) == null)
				{
					result = (this._SpawnConfigs = new TArray<FKSC_SpawnEntity>(base.NativePtr + (IntPtr)UKSC_Responder_SpawnEntity.__PropertyOffset_SpawnConfigs, this));
				}
				return result;
			}
			set
			{
				this.SpawnConfigs.CopyAssign(value);
			}
		}

		// Token: 0x0601D6B5 RID: 120501 RVA: 0x002B74E3 File Offset: 0x002B56E3
		static UKSC_Responder_SpawnEntity()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Responder_SpawnEntity");
		}

		// Token: 0x0601D6B6 RID: 120502 RVA: 0x002B74F1 File Offset: 0x002B56F1
		protected UKSC_Responder_SpawnEntity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF3B RID: 65339
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Responder_SpawnEntity";

		// Token: 0x0400FF3C RID: 65340
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF3D RID: 65341
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF3E RID: 65342
		internal static int __PropertyOffset_SpawnConfigs;

		// Token: 0x0400FF3F RID: 65343
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSC_SpawnEntity> _SpawnConfigs;
	}
}
