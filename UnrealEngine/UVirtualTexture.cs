using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001230 RID: 4656
	[UnrealObjectPath("/Script/Engine.VirtualTexture")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UVirtualTexture : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011200 RID: 70144 RVA: 0x001920BB File Offset: 0x001902BB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVirtualTexture._ClassPtr;
		}

		// Token: 0x06011201 RID: 70145 RVA: 0x001920C8 File Offset: 0x001902C8
		public UVirtualTexture() : this(BuiltinUtils.AllocNativeUObject(UVirtualTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011202 RID: 70146 RVA: 0x001920F0 File Offset: 0x001902F0
		[NullableContext(1)]
		public UVirtualTexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVirtualTexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011203 RID: 70147 RVA: 0x00192123 File Offset: 0x00190323
		static UVirtualTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.VirtualTexture");
		}

		// Token: 0x06011204 RID: 70148 RVA: 0x00192131 File Offset: 0x00190331
		protected UVirtualTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040092A0 RID: 37536
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.VirtualTexture";

		// Token: 0x040092A1 RID: 37537
		private static IntPtr _ClassPtr;

		// Token: 0x040092A2 RID: 37538
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
