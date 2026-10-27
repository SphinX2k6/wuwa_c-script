using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002791 RID: 10129
	[UnrealObjectPath("/Script/SimplygonUObjects.EmissiveCaster")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UEmissiveCaster : UBaseColorCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025D94 RID: 155028 RVA: 0x003961BC File Offset: 0x003943BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEmissiveCaster._ClassPtr;
		}

		// Token: 0x06025D95 RID: 155029 RVA: 0x003961C8 File Offset: 0x003943C8
		public UEmissiveCaster() : this(BuiltinUtils.AllocNativeUObject(UEmissiveCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025D96 RID: 155030 RVA: 0x003961F0 File Offset: 0x003943F0
		[NullableContext(1)]
		public UEmissiveCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEmissiveCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06025D97 RID: 155031 RVA: 0x00396223 File Offset: 0x00394423
		static UEmissiveCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.EmissiveCaster");
		}

		// Token: 0x06025D98 RID: 155032 RVA: 0x00396231 File Offset: 0x00394431
		protected UEmissiveCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040149FC RID: 84476
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SimplygonUObjects.EmissiveCaster";

		// Token: 0x040149FD RID: 84477
		private static IntPtr _ClassPtr;

		// Token: 0x040149FE RID: 84478
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
