using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024A1 RID: 9377
	[UnrealObjectPath("/Script/NavigationSystem.NavMeshRenderingComponent")]
	[UnrealStructLayout(1744, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1744)]
	public class UNavMeshRenderingComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023194 RID: 143764 RVA: 0x0033E7F6 File Offset: 0x0033C9F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavMeshRenderingComponent._ClassPtr;
		}

		// Token: 0x06023195 RID: 143765 RVA: 0x0033E804 File Offset: 0x0033CA04
		public UNavMeshRenderingComponent() : this(BuiltinUtils.AllocNativeUObject(UNavMeshRenderingComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023196 RID: 143766 RVA: 0x0033E82C File Offset: 0x0033CA2C
		[NullableContext(1)]
		public UNavMeshRenderingComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavMeshRenderingComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06023197 RID: 143767 RVA: 0x0033E85F File Offset: 0x0033CA5F
		static UNavMeshRenderingComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavMeshRenderingComponent");
		}

		// Token: 0x06023198 RID: 143768 RVA: 0x0033E86D File Offset: 0x0033CA6D
		protected UNavMeshRenderingComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012BCD RID: 76749
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavMeshRenderingComponent";

		// Token: 0x04012BCE RID: 76750
		private static IntPtr _ClassPtr;

		// Token: 0x04012BCF RID: 76751
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
