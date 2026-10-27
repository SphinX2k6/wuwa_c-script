using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EA4 RID: 3748
	[UnrealObjectPath("/Script/Engine.MeshMergeCullingVolume")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class AMeshMergeCullingVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CA6D RID: 51821 RVA: 0x00126BEC File Offset: 0x00124DEC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AMeshMergeCullingVolume._ClassPtr;
		}

		// Token: 0x0600CA6E RID: 51822 RVA: 0x00126BF8 File Offset: 0x00124DF8
		public AMeshMergeCullingVolume() : this(BuiltinUtils.AllocNativeUObject(AMeshMergeCullingVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CA6F RID: 51823 RVA: 0x00126C20 File Offset: 0x00124E20
		[NullableContext(1)]
		public AMeshMergeCullingVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AMeshMergeCullingVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600CA70 RID: 51824 RVA: 0x00126C53 File Offset: 0x00124E53
		static AMeshMergeCullingVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MeshMergeCullingVolume");
		}

		// Token: 0x0600CA71 RID: 51825 RVA: 0x00126C61 File Offset: 0x00124E61
		protected AMeshMergeCullingVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006CF7 RID: 27895
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MeshMergeCullingVolume";

		// Token: 0x04006CF8 RID: 27896
		private static IntPtr _ClassPtr;

		// Token: 0x04006CF9 RID: 27897
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
