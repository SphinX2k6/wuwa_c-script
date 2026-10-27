using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022C6 RID: 8902
	[UnrealObjectPath("/Script/MeshBlend.MeshBlendSubSystem")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UMeshBlendSubSystem : UEngineSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021CE8 RID: 138472 RVA: 0x0031F92D File Offset: 0x0031DB2D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMeshBlendSubSystem._ClassPtr;
		}

		// Token: 0x06021CE9 RID: 138473 RVA: 0x0031F93C File Offset: 0x0031DB3C
		public UMeshBlendSubSystem() : this(BuiltinUtils.AllocNativeUObject(UMeshBlendSubSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021CEA RID: 138474 RVA: 0x0031F964 File Offset: 0x0031DB64
		[NullableContext(1)]
		public UMeshBlendSubSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMeshBlendSubSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008315 RID: 33557
		// (get) Token: 0x06021CEB RID: 138475 RVA: 0x0031F997 File Offset: 0x0031DB97
		// (set) Token: 0x06021CEC RID: 138476 RVA: 0x0031F9AB File Offset: 0x0031DBAB
		[Nullable(2)]
		public unsafe UTexture2D NoiseTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UMeshBlendSubSystem.__PropertyOffset_NoiseTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMeshBlendSubSystem.__PropertyOffset_NoiseTexture, value);
			}
		}

		// Token: 0x06021CED RID: 138477 RVA: 0x0031F9C0 File Offset: 0x0031DBC0
		static UMeshBlendSubSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MeshBlend.MeshBlendSubSystem");
		}

		// Token: 0x06021CEE RID: 138478 RVA: 0x0031F9CE File Offset: 0x0031DBCE
		protected UMeshBlendSubSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012095 RID: 73877
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MeshBlend.MeshBlendSubSystem";

		// Token: 0x04012096 RID: 73878
		private static IntPtr _ClassPtr;

		// Token: 0x04012097 RID: 73879
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012098 RID: 73880
		internal static int __PropertyOffset_NoiseTexture;
	}
}
