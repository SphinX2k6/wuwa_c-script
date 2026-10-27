using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014E3 RID: 5347
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniMeshSplitInstancerComponent_V1")]
	[UnrealStructLayout(608, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class UHoudiniMeshSplitInstancerComponent_V1 : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060135BC RID: 79292 RVA: 0x001C774B File Offset: 0x001C594B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniMeshSplitInstancerComponent_V1._ClassPtr;
		}

		// Token: 0x060135BD RID: 79293 RVA: 0x001C7758 File Offset: 0x001C5958
		public UHoudiniMeshSplitInstancerComponent_V1() : this(BuiltinUtils.AllocNativeUObject(UHoudiniMeshSplitInstancerComponent_V1.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060135BE RID: 79294 RVA: 0x001C7780 File Offset: 0x001C5980
		[NullableContext(1)]
		public UHoudiniMeshSplitInstancerComponent_V1(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniMeshSplitInstancerComponent_V1.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060135BF RID: 79295 RVA: 0x001C77B3 File Offset: 0x001C59B3
		static UHoudiniMeshSplitInstancerComponent_V1()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniMeshSplitInstancerComponent_V1");
		}

		// Token: 0x060135C0 RID: 79296 RVA: 0x001C77C1 File Offset: 0x001C59C1
		protected UHoudiniMeshSplitInstancerComponent_V1(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A755 RID: 42837
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniMeshSplitInstancerComponent_V1";

		// Token: 0x0400A756 RID: 42838
		private static IntPtr _ClassPtr;

		// Token: 0x0400A757 RID: 42839
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
