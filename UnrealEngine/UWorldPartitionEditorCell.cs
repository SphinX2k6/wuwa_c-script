using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001256 RID: 4694
	[UnrealObjectPath("/Script/Engine.WorldPartitionEditorCell")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UWorldPartitionEditorCell : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011419 RID: 70681 RVA: 0x0019553A File Offset: 0x0019373A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionEditorCell._ClassPtr;
		}

		// Token: 0x0601141A RID: 70682 RVA: 0x00195548 File Offset: 0x00193748
		public UWorldPartitionEditorCell() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionEditorCell.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601141B RID: 70683 RVA: 0x00195570 File Offset: 0x00193770
		[NullableContext(1)]
		public UWorldPartitionEditorCell(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionEditorCell.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601141C RID: 70684 RVA: 0x001955A3 File Offset: 0x001937A3
		static UWorldPartitionEditorCell()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionEditorCell");
		}

		// Token: 0x0601141D RID: 70685 RVA: 0x001955B1 File Offset: 0x001937B1
		protected UWorldPartitionEditorCell(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040093B6 RID: 37814
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionEditorCell";

		// Token: 0x040093B7 RID: 37815
		private static IntPtr _ClassPtr;

		// Token: 0x040093B8 RID: 37816
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
