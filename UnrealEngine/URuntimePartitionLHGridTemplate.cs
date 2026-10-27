using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010B7 RID: 4279
	[UnrealObjectPath("/Script/Engine.RuntimePartitionLHGridTemplate")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public class URuntimePartitionLHGridTemplate : URuntimePartitionTemplate, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F46F RID: 62575 RVA: 0x0016A786 File Offset: 0x00168986
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URuntimePartitionLHGridTemplate._ClassPtr;
		}

		// Token: 0x0600F470 RID: 62576 RVA: 0x0016A794 File Offset: 0x00168994
		public URuntimePartitionLHGridTemplate() : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionLHGridTemplate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F471 RID: 62577 RVA: 0x0016A7BC File Offset: 0x001689BC
		[NullableContext(1)]
		public URuntimePartitionLHGridTemplate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionLHGridTemplate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F472 RID: 62578 RVA: 0x0016A7EF File Offset: 0x001689EF
		static URuntimePartitionLHGridTemplate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimePartitionLHGridTemplate");
		}

		// Token: 0x0600F473 RID: 62579 RVA: 0x0016A7FD File Offset: 0x001689FD
		protected URuntimePartitionLHGridTemplate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400847A RID: 33914
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RuntimePartitionLHGridTemplate";

		// Token: 0x0400847B RID: 33915
		private static IntPtr _ClassPtr;

		// Token: 0x0400847C RID: 33916
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
