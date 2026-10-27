using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001257 RID: 4695
	[UnrealObjectPath("/Script/Engine.WorldPartitionEditorHash")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UWorldPartitionEditorHash : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601141E RID: 70686 RVA: 0x001955BA File Offset: 0x001937BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionEditorHash._ClassPtr;
		}

		// Token: 0x0601141F RID: 70687 RVA: 0x001955C6 File Offset: 0x001937C6
		static UWorldPartitionEditorHash()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionEditorHash");
		}

		// Token: 0x06011420 RID: 70688 RVA: 0x001955D4 File Offset: 0x001937D4
		protected UWorldPartitionEditorHash() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionEditorHash.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011421 RID: 70689 RVA: 0x001955FC File Offset: 0x001937FC
		protected UWorldPartitionEditorHash(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040093B9 RID: 37817
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionEditorHash";

		// Token: 0x040093BA RID: 37818
		private static IntPtr _ClassPtr;

		// Token: 0x040093BB RID: 37819
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
