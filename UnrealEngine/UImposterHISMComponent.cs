using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200151F RID: 5407
	[UnrealObjectPath("/Script/ImposterManager.ImposterHISMComponent")]
	[UnrealStructLayout(3232, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3232)]
	public class UImposterHISMComponent : UHierarchicalInstancedStaticMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013AE3 RID: 80611 RVA: 0x001CE880 File Offset: 0x001CCA80
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UImposterHISMComponent._ClassPtr;
		}

		// Token: 0x06013AE4 RID: 80612 RVA: 0x001CE88C File Offset: 0x001CCA8C
		public UImposterHISMComponent() : this(BuiltinUtils.AllocNativeUObject(UImposterHISMComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013AE5 RID: 80613 RVA: 0x001CE8B4 File Offset: 0x001CCAB4
		[NullableContext(1)]
		public UImposterHISMComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UImposterHISMComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013AE6 RID: 80614 RVA: 0x001CE8E7 File Offset: 0x001CCAE7
		static UImposterHISMComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ImposterManager.ImposterHISMComponent");
		}

		// Token: 0x06013AE7 RID: 80615 RVA: 0x001CE8F5 File Offset: 0x001CCAF5
		protected UImposterHISMComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AA09 RID: 43529
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ImposterManager.ImposterHISMComponent";

		// Token: 0x0400AA0A RID: 43530
		private static IntPtr _ClassPtr;

		// Token: 0x0400AA0B RID: 43531
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
