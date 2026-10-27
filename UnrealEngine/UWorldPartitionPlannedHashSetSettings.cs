using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200126A RID: 4714
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionPlannedHashSetSettings")]
	[UnrealStructLayout(432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UWorldPartitionPlannedHashSetSettings : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060114B1 RID: 70833 RVA: 0x001963C0 File Offset: 0x001945C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionPlannedHashSetSettings._ClassPtr;
		}

		// Token: 0x060114B2 RID: 70834 RVA: 0x001963CC File Offset: 0x001945CC
		public UWorldPartitionPlannedHashSetSettings() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionPlannedHashSetSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060114B3 RID: 70835 RVA: 0x001963F4 File Offset: 0x001945F4
		public UWorldPartitionPlannedHashSetSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionPlannedHashSetSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700436C RID: 17260
		// (get) Token: 0x060114B4 RID: 70836 RVA: 0x00196428 File Offset: 0x00194628
		// (set) Token: 0x060114B5 RID: 70837 RVA: 0x00196461 File Offset: 0x00194661
		public TMap<FName, FPlannedRuntimePartitionModifier> Modifiers
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FPlannedRuntimePartitionModifier> result;
				if ((result = this._Modifiers) == null)
				{
					result = (this._Modifiers = new TMap<FName, FPlannedRuntimePartitionModifier>(base.NativePtr + (IntPtr)UWorldPartitionPlannedHashSetSettings.__PropertyOffset_Modifiers, this));
				}
				return result;
			}
			set
			{
				this.Modifiers.CopyAssign(value);
			}
		}

		// Token: 0x060114B6 RID: 70838 RVA: 0x0019646F File Offset: 0x0019466F
		static UWorldPartitionPlannedHashSetSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionPlannedHashSetSettings");
		}

		// Token: 0x060114B7 RID: 70839 RVA: 0x0019647D File Offset: 0x0019467D
		protected UWorldPartitionPlannedHashSetSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009415 RID: 37909
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionPlannedHashSetSettings";

		// Token: 0x04009416 RID: 37910
		private static IntPtr _ClassPtr;

		// Token: 0x04009417 RID: 37911
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009418 RID: 37912
		internal static int __PropertyOffset_Modifiers;

		// Token: 0x04009419 RID: 37913
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FPlannedRuntimePartitionModifier> _Modifiers;
	}
}
