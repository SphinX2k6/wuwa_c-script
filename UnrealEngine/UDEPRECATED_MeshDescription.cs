using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022C9 RID: 8905
	[UnrealObjectPath("/Script/MeshDescription.MeshDescription")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UDEPRECATED_MeshDescription : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021D01 RID: 138497 RVA: 0x0031FAD6 File Offset: 0x0031DCD6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDEPRECATED_MeshDescription._ClassPtr;
		}

		// Token: 0x06021D02 RID: 138498 RVA: 0x0031FAE4 File Offset: 0x0031DCE4
		public UDEPRECATED_MeshDescription() : this(BuiltinUtils.AllocNativeUObject(UDEPRECATED_MeshDescription.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021D03 RID: 138499 RVA: 0x0031FB0C File Offset: 0x0031DD0C
		[NullableContext(1)]
		public UDEPRECATED_MeshDescription(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDEPRECATED_MeshDescription.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021D04 RID: 138500 RVA: 0x0031FB3F File Offset: 0x0031DD3F
		static UDEPRECATED_MeshDescription()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MeshDescription.MeshDescription");
		}

		// Token: 0x06021D05 RID: 138501 RVA: 0x0031FB4D File Offset: 0x0031DD4D
		protected UDEPRECATED_MeshDescription(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401209E RID: 73886
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MeshDescription.MeshDescription";

		// Token: 0x0401209F RID: 73887
		private static IntPtr _ClassPtr;

		// Token: 0x040120A0 RID: 73888
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
