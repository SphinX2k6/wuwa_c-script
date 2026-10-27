using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200248E RID: 9358
	[UnrealObjectPath("/Script/NavigationSystem.NavigationGraph")]
	[UnrealStructLayout(1632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1632)]
	public abstract class ANavigationGraph : ANavigationData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023010 RID: 143376 RVA: 0x0033C1B4 File Offset: 0x0033A3B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavigationGraph._ClassPtr;
		}

		// Token: 0x06023011 RID: 143377 RVA: 0x0033C1C0 File Offset: 0x0033A3C0
		static ANavigationGraph()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavigationGraph");
		}

		// Token: 0x06023012 RID: 143378 RVA: 0x0033C1D0 File Offset: 0x0033A3D0
		protected ANavigationGraph() : this(BuiltinUtils.AllocNativeUObject(ANavigationGraph.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023013 RID: 143379 RVA: 0x0033C1F8 File Offset: 0x0033A3F8
		protected ANavigationGraph(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012B07 RID: 76551
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavigationGraph";

		// Token: 0x04012B08 RID: 76552
		private static IntPtr _ClassPtr;

		// Token: 0x04012B09 RID: 76553
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
