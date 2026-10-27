using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010C0 RID: 4288
	[UnrealObjectPath("/Script/Engine.RuntimePartitionPolicyPassiveGrid")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class URuntimePartitionPolicyPassiveGrid : URuntimePartitionPolicy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F4B5 RID: 62645 RVA: 0x0016AD76 File Offset: 0x00168F76
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URuntimePartitionPolicyPassiveGrid._ClassPtr;
		}

		// Token: 0x0600F4B6 RID: 62646 RVA: 0x0016AD84 File Offset: 0x00168F84
		public URuntimePartitionPolicyPassiveGrid() : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionPolicyPassiveGrid.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F4B7 RID: 62647 RVA: 0x0016ADAC File Offset: 0x00168FAC
		[NullableContext(1)]
		public URuntimePartitionPolicyPassiveGrid(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionPolicyPassiveGrid.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F4B8 RID: 62648 RVA: 0x0016ADDF File Offset: 0x00168FDF
		static URuntimePartitionPolicyPassiveGrid()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimePartitionPolicyPassiveGrid");
		}

		// Token: 0x0600F4B9 RID: 62649 RVA: 0x0016ADED File Offset: 0x00168FED
		protected URuntimePartitionPolicyPassiveGrid(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400849D RID: 33949
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RuntimePartitionPolicyPassiveGrid";

		// Token: 0x0400849E RID: 33950
		private static IntPtr _ClassPtr;

		// Token: 0x0400849F RID: 33951
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
