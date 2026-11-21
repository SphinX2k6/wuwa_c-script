using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200029A RID: 666
	[UnrealObjectPath("/Script/Engine.TextureCube")]
	[UnrealStructLayout(4208, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4208)]
	public class UTextureCube : UTexture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004975 RID: 18805 RVA: 0x00067028 File Offset: 0x00065228
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextureCube._ClassPtr;
		}

		// Token: 0x06004976 RID: 18806 RVA: 0x00067034 File Offset: 0x00065234
		public UTextureCube() : this(BuiltinUtils.AllocNativeUObject(UTextureCube.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004977 RID: 18807 RVA: 0x0006705C File Offset: 0x0006525C
		[NullableContext(1)]
		public UTextureCube(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextureCube.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06004978 RID: 18808 RVA: 0x0006708F File Offset: 0x0006528F
		static UTextureCube()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TextureCube");
		}

		// Token: 0x06004979 RID: 18809 RVA: 0x0006709D File Offset: 0x0006529D
		protected UTextureCube(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001C99 RID: 7321
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TextureCube";

		// Token: 0x04001C9A RID: 7322
		private static IntPtr _ClassPtr;

		// Token: 0x04001C9B RID: 7323
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
