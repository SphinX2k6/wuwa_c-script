using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200248F RID: 9359
	[UnrealObjectPath("/Script/NavigationSystem.NavigationGraphNode")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public abstract class ANavigationGraphNode : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023014 RID: 143380 RVA: 0x0033C201 File Offset: 0x0033A401
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavigationGraphNode._ClassPtr;
		}

		// Token: 0x06023015 RID: 143381 RVA: 0x0033C20D File Offset: 0x0033A40D
		static ANavigationGraphNode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavigationGraphNode");
		}

		// Token: 0x06023016 RID: 143382 RVA: 0x0033C21C File Offset: 0x0033A41C
		protected ANavigationGraphNode() : this(BuiltinUtils.AllocNativeUObject(ANavigationGraphNode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023017 RID: 143383 RVA: 0x0033C244 File Offset: 0x0033A444
		protected ANavigationGraphNode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012B0A RID: 76554
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavigationGraphNode";

		// Token: 0x04012B0B RID: 76555
		private static IntPtr _ClassPtr;

		// Token: 0x04012B0C RID: 76556
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
