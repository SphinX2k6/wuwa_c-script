using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A5B RID: 10843
	[UnrealObjectPath("/Script/VolumeGIRender.VolumeGIRenderSystem")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UVolumeGIRenderSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602809C RID: 163996 RVA: 0x003CF1D3 File Offset: 0x003CD3D3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVolumeGIRenderSystem._ClassPtr;
		}

		// Token: 0x0602809D RID: 163997 RVA: 0x003CF1E0 File Offset: 0x003CD3E0
		public UVolumeGIRenderSystem() : this(BuiltinUtils.AllocNativeUObject(UVolumeGIRenderSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602809E RID: 163998 RVA: 0x003CF208 File Offset: 0x003CD408
		[NullableContext(1)]
		public UVolumeGIRenderSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVolumeGIRenderSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602809F RID: 163999 RVA: 0x003CF23B File Offset: 0x003CD43B
		static UVolumeGIRenderSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/VolumeGIRender.VolumeGIRenderSystem");
		}

		// Token: 0x060280A0 RID: 164000 RVA: 0x003CF249 File Offset: 0x003CD449
		protected UVolumeGIRenderSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015F5B RID: 89947
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/VolumeGIRender.VolumeGIRenderSystem";

		// Token: 0x04015F5C RID: 89948
		private static IntPtr _ClassPtr;

		// Token: 0x04015F5D RID: 89949
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
