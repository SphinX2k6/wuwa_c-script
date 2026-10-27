using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002633 RID: 9779
	[UnrealObjectPath("/Script/PathFindModule.NavigationPartitionPath")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UNavigationPartitionPath : UNavigationPartitionPathBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060245D6 RID: 148950 RVA: 0x0035D716 File Offset: 0x0035B916
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavigationPartitionPath._ClassPtr;
		}

		// Token: 0x060245D7 RID: 148951 RVA: 0x0035D724 File Offset: 0x0035B924
		public UNavigationPartitionPath() : this(BuiltinUtils.AllocNativeUObject(UNavigationPartitionPath.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060245D8 RID: 148952 RVA: 0x0035D74C File Offset: 0x0035B94C
		[NullableContext(1)]
		public UNavigationPartitionPath(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavigationPartitionPath.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060245D9 RID: 148953 RVA: 0x0035D77F File Offset: 0x0035B97F
		static UNavigationPartitionPath()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PathFindModule.NavigationPartitionPath");
		}

		// Token: 0x060245DA RID: 148954 RVA: 0x0035D78D File Offset: 0x0035B98D
		protected UNavigationPartitionPath(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401382D RID: 79917
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/PathFindModule.NavigationPartitionPath";

		// Token: 0x0401382E RID: 79918
		private static IntPtr _ClassPtr;

		// Token: 0x0401382F RID: 79919
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
