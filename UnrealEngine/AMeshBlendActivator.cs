using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022B9 RID: 8889
	[UnrealObjectPath("/Script/MeshBlend.MeshBlendActivator")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AMeshBlendActivator : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021C51 RID: 138321 RVA: 0x0031ED1C File Offset: 0x0031CF1C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AMeshBlendActivator._ClassPtr;
		}

		// Token: 0x06021C52 RID: 138322 RVA: 0x0031ED28 File Offset: 0x0031CF28
		public AMeshBlendActivator() : this(BuiltinUtils.AllocNativeUObject(AMeshBlendActivator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021C53 RID: 138323 RVA: 0x0031ED50 File Offset: 0x0031CF50
		[NullableContext(1)]
		public AMeshBlendActivator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AMeshBlendActivator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021C54 RID: 138324 RVA: 0x0031ED83 File Offset: 0x0031CF83
		static AMeshBlendActivator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MeshBlend.MeshBlendActivator");
		}

		// Token: 0x06021C55 RID: 138325 RVA: 0x0031ED91 File Offset: 0x0031CF91
		protected AMeshBlendActivator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012054 RID: 73812
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MeshBlend.MeshBlendActivator";

		// Token: 0x04012055 RID: 73813
		private static IntPtr _ClassPtr;

		// Token: 0x04012056 RID: 73814
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
