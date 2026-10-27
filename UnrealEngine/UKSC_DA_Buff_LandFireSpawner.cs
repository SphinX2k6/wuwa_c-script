using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D65 RID: 7525
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_LandFireSpawner")]
	[UnrealStructLayout(512, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 512)]
	public class UKSC_DA_Buff_LandFireSpawner : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CD16 RID: 118038 RVA: 0x002A98CC File Offset: 0x002A7ACC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_LandFireSpawner._ClassPtr;
		}

		// Token: 0x0601CD17 RID: 118039 RVA: 0x002A98D8 File Offset: 0x002A7AD8
		public UKSC_DA_Buff_LandFireSpawner() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_LandFireSpawner.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CD18 RID: 118040 RVA: 0x002A9900 File Offset: 0x002A7B00
		public UKSC_DA_Buff_LandFireSpawner(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_LandFireSpawner.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007412 RID: 29714
		// (get) Token: 0x0601CD19 RID: 118041 RVA: 0x002A9934 File Offset: 0x002A7B34
		// (set) Token: 0x0601CD1A RID: 118042 RVA: 0x002A996D File Offset: 0x002A7B6D
		public TMap<EKSC_AttrType, int> ModifyMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, int> result;
				if ((result = this._ModifyMap) == null)
				{
					result = (this._ModifyMap = new TMap<EKSC_AttrType, int>(base.NativePtr + (IntPtr)UKSC_DA_Buff_LandFireSpawner.__PropertyOffset_ModifyMap, this));
				}
				return result;
			}
			set
			{
				this.ModifyMap.CopyAssign(value);
			}
		}

		// Token: 0x17007413 RID: 29715
		// (get) Token: 0x0601CD1B RID: 118043 RVA: 0x002A997B File Offset: 0x002A7B7B
		// (set) Token: 0x0601CD1C RID: 118044 RVA: 0x002A998F File Offset: 0x002A7B8F
		[Nullable(2)]
		public unsafe UKSC_DA_AdditionalAttack AdditionalAttack
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_AdditionalAttack>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_LandFireSpawner.__PropertyOffset_AdditionalAttack);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_LandFireSpawner.__PropertyOffset_AdditionalAttack, value);
			}
		}

		// Token: 0x0601CD1D RID: 118045 RVA: 0x002A99A4 File Offset: 0x002A7BA4
		static UKSC_DA_Buff_LandFireSpawner()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_LandFireSpawner");
		}

		// Token: 0x0601CD1E RID: 118046 RVA: 0x002A99B2 File Offset: 0x002A7BB2
		protected UKSC_DA_Buff_LandFireSpawner(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA16 RID: 64022
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_LandFireSpawner";

		// Token: 0x0400FA17 RID: 64023
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA18 RID: 64024
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA19 RID: 64025
		internal static int __PropertyOffset_ModifyMap;

		// Token: 0x0400FA1A RID: 64026
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _ModifyMap;

		// Token: 0x0400FA1B RID: 64027
		internal static int __PropertyOffset_AdditionalAttack;
	}
}
