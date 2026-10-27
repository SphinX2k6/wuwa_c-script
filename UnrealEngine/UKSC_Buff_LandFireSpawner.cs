using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D1B RID: 7451
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_LandFireSpawner")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKSC_Buff_LandFireSpawner : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C9C8 RID: 117192 RVA: 0x002A4BCB File Offset: 0x002A2DCB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_LandFireSpawner._ClassPtr;
		}

		// Token: 0x0601C9C9 RID: 117193 RVA: 0x002A4BD8 File Offset: 0x002A2DD8
		public UKSC_Buff_LandFireSpawner() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_LandFireSpawner.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C9CA RID: 117194 RVA: 0x002A4C00 File Offset: 0x002A2E00
		[NullableContext(1)]
		public UKSC_Buff_LandFireSpawner(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_LandFireSpawner.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700732C RID: 29484
		// (get) Token: 0x0601C9CB RID: 117195 RVA: 0x002A4C33 File Offset: 0x002A2E33
		// (set) Token: 0x0601C9CC RID: 117196 RVA: 0x002A4C47 File Offset: 0x002A2E47
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_LandFireSpawner DaBuffLandFireSpawner_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_LandFireSpawner>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_LandFireSpawner.__PropertyOffset_DaBuffLandFireSpawner_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_LandFireSpawner.__PropertyOffset_DaBuffLandFireSpawner_, value);
			}
		}

		// Token: 0x0601C9CD RID: 117197 RVA: 0x002A4C5C File Offset: 0x002A2E5C
		static UKSC_Buff_LandFireSpawner()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_LandFireSpawner");
		}

		// Token: 0x0601C9CE RID: 117198 RVA: 0x002A4C6A File Offset: 0x002A2E6A
		protected UKSC_Buff_LandFireSpawner(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F828 RID: 63528
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_LandFireSpawner";

		// Token: 0x0400F829 RID: 63529
		private static IntPtr _ClassPtr;

		// Token: 0x0400F82A RID: 63530
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F82B RID: 63531
		internal static int __PropertyOffset_DaBuffLandFireSpawner_;
	}
}
