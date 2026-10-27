using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C30 RID: 3120
	[UnrealObjectPath("/Script/Engine.HLODInstancedStaticMeshComponent")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2288)]
	public class UHLODInstancedStaticMeshComponent : UInstancedStaticMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009E33 RID: 40499 RVA: 0x000E0DC2 File Offset: 0x000DEFC2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHLODInstancedStaticMeshComponent._ClassPtr;
		}

		// Token: 0x06009E34 RID: 40500 RVA: 0x000E0DD0 File Offset: 0x000DEFD0
		public UHLODInstancedStaticMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UHLODInstancedStaticMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009E35 RID: 40501 RVA: 0x000E0DF8 File Offset: 0x000DEFF8
		[NullableContext(1)]
		public UHLODInstancedStaticMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHLODInstancedStaticMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06009E36 RID: 40502 RVA: 0x000E0E2B File Offset: 0x000DF02B
		static UHLODInstancedStaticMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HLODInstancedStaticMeshComponent");
		}

		// Token: 0x06009E37 RID: 40503 RVA: 0x000E0E39 File Offset: 0x000DF039
		protected UHLODInstancedStaticMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005737 RID: 22327
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.HLODInstancedStaticMeshComponent";

		// Token: 0x04005738 RID: 22328
		private static IntPtr _ClassPtr;

		// Token: 0x04005739 RID: 22329
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
