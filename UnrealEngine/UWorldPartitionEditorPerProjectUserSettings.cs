using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001258 RID: 4696
	[UnrealObjectPath("/Script/Engine.WorldPartitionEditorPerProjectUserSettings")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UWorldPartitionEditorPerProjectUserSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011422 RID: 70690 RVA: 0x00195605 File Offset: 0x00193805
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionEditorPerProjectUserSettings._ClassPtr;
		}

		// Token: 0x06011423 RID: 70691 RVA: 0x00195614 File Offset: 0x00193814
		public UWorldPartitionEditorPerProjectUserSettings() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionEditorPerProjectUserSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011424 RID: 70692 RVA: 0x0019563C File Offset: 0x0019383C
		[NullableContext(1)]
		public UWorldPartitionEditorPerProjectUserSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionEditorPerProjectUserSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011425 RID: 70693 RVA: 0x0019566F File Offset: 0x0019386F
		static UWorldPartitionEditorPerProjectUserSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionEditorPerProjectUserSettings");
		}

		// Token: 0x06011426 RID: 70694 RVA: 0x0019567D File Offset: 0x0019387D
		protected UWorldPartitionEditorPerProjectUserSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040093BC RID: 37820
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionEditorPerProjectUserSettings";

		// Token: 0x040093BD RID: 37821
		private static IntPtr _ClassPtr;

		// Token: 0x040093BE RID: 37822
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
