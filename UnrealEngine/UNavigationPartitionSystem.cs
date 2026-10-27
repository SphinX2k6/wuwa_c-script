using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002634 RID: 9780
	[UnrealObjectPath("/Script/PathFindModule.NavigationPartitionSystem")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UNavigationPartitionSystem : UNavigationPartitionSystemBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060245DB RID: 148955 RVA: 0x0035D796 File Offset: 0x0035B996
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavigationPartitionSystem._ClassPtr;
		}

		// Token: 0x060245DC RID: 148956 RVA: 0x0035D7A4 File Offset: 0x0035B9A4
		public UNavigationPartitionSystem() : this(BuiltinUtils.AllocNativeUObject(UNavigationPartitionSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060245DD RID: 148957 RVA: 0x0035D7CC File Offset: 0x0035B9CC
		[NullableContext(1)]
		public UNavigationPartitionSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavigationPartitionSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008C1F RID: 35871
		// (get) Token: 0x060245DE RID: 148958 RVA: 0x0035D7FF File Offset: 0x0035B9FF
		// (set) Token: 0x060245DF RID: 148959 RVA: 0x0035D813 File Offset: 0x0035BA13
		[Nullable(2)]
		public unsafe UWorld OwnerWorld
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorld>(base.NativePtr / (IntPtr)sizeof(void*) + UNavigationPartitionSystem.__PropertyOffset_OwnerWorld);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNavigationPartitionSystem.__PropertyOffset_OwnerWorld, value);
			}
		}

		// Token: 0x060245E0 RID: 148960 RVA: 0x0035D828 File Offset: 0x0035BA28
		static UNavigationPartitionSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PathFindModule.NavigationPartitionSystem");
		}

		// Token: 0x060245E1 RID: 148961 RVA: 0x0035D836 File Offset: 0x0035BA36
		protected UNavigationPartitionSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013830 RID: 79920
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/PathFindModule.NavigationPartitionSystem";

		// Token: 0x04013831 RID: 79921
		private static IntPtr _ClassPtr;

		// Token: 0x04013832 RID: 79922
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013833 RID: 79923
		internal static int __PropertyOffset_OwnerWorld;
	}
}
