using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200126D RID: 4717
	[UnrealObjectPath("/Script/Engine.WorldPartitionRuntimeAutoDivide")]
	[UnrealStructLayout(792, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 792)]
	public class UWorldPartitionRuntimeAutoDivide : UWorldPartitionRuntimeHashSet, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060114C8 RID: 70856 RVA: 0x00196611 File Offset: 0x00194811
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionRuntimeAutoDivide._ClassPtr;
		}

		// Token: 0x060114C9 RID: 70857 RVA: 0x00196620 File Offset: 0x00194820
		public UWorldPartitionRuntimeAutoDivide() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionRuntimeAutoDivide.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060114CA RID: 70858 RVA: 0x00196648 File Offset: 0x00194848
		[NullableContext(1)]
		public UWorldPartitionRuntimeAutoDivide(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionRuntimeAutoDivide.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060114CB RID: 70859 RVA: 0x0019667B File Offset: 0x0019487B
		static UWorldPartitionRuntimeAutoDivide()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionRuntimeAutoDivide");
		}

		// Token: 0x060114CC RID: 70860 RVA: 0x00196689 File Offset: 0x00194889
		protected UWorldPartitionRuntimeAutoDivide(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009423 RID: 37923
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionRuntimeAutoDivide";

		// Token: 0x04009424 RID: 37924
		private static IntPtr _ClassPtr;

		// Token: 0x04009425 RID: 37925
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
