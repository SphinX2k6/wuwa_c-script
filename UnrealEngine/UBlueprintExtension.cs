using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008C0 RID: 2240
	[UnrealObjectPath("/Script/Engine.BlueprintExtension")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UBlueprintExtension : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007A5D RID: 31325 RVA: 0x000AF029 File Offset: 0x000AD229
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlueprintExtension._ClassPtr;
		}

		// Token: 0x06007A5E RID: 31326 RVA: 0x000AF038 File Offset: 0x000AD238
		public UBlueprintExtension() : this(BuiltinUtils.AllocNativeUObject(UBlueprintExtension.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007A5F RID: 31327 RVA: 0x000AF060 File Offset: 0x000AD260
		[NullableContext(1)]
		public UBlueprintExtension(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlueprintExtension.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007A60 RID: 31328 RVA: 0x000AF093 File Offset: 0x000AD293
		static UBlueprintExtension()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BlueprintExtension");
		}

		// Token: 0x06007A61 RID: 31329 RVA: 0x000AF0A1 File Offset: 0x000AD2A1
		protected UBlueprintExtension(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003AD4 RID: 15060
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BlueprintExtension";

		// Token: 0x04003AD5 RID: 15061
		private static IntPtr _ClassPtr;

		// Token: 0x04003AD6 RID: 15062
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
