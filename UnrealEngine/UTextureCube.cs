using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011D3 RID: 4563
	[UnrealObjectPath("/Script/Engine.TextureCube")]
	[UnrealStructLayout(4000, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4000)]
	public class UTextureCube : UTexture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010D07 RID: 68871 RVA: 0x0018B189 File Offset: 0x00189389
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextureCube._ClassPtr;
		}

		// Token: 0x06010D08 RID: 68872 RVA: 0x0018B198 File Offset: 0x00189398
		public UTextureCube() : this(BuiltinUtils.AllocNativeUObject(UTextureCube.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010D09 RID: 68873 RVA: 0x0018B1C0 File Offset: 0x001893C0
		[NullableContext(1)]
		public UTextureCube(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextureCube.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06010D0A RID: 68874 RVA: 0x0018B1F3 File Offset: 0x001893F3
		static UTextureCube()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TextureCube");
		}

		// Token: 0x06010D0B RID: 68875 RVA: 0x0018B201 File Offset: 0x00189401
		protected UTextureCube(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008FDC RID: 36828
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TextureCube";

		// Token: 0x04008FDD RID: 36829
		private static IntPtr _ClassPtr;

		// Token: 0x04008FDE RID: 36830
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
