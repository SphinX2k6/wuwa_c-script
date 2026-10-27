using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001410 RID: 5136
	[UnrealObjectPath("/Script/GeometryCache.GeometryCacheCodecV1")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UGeometryCacheCodecV1 : UGeometryCacheCodecBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012BE1 RID: 76769 RVA: 0x001B975B File Offset: 0x001B795B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGeometryCacheCodecV1._ClassPtr;
		}

		// Token: 0x06012BE2 RID: 76770 RVA: 0x001B9768 File Offset: 0x001B7968
		public UGeometryCacheCodecV1() : this(BuiltinUtils.AllocNativeUObject(UGeometryCacheCodecV1.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012BE3 RID: 76771 RVA: 0x001B9790 File Offset: 0x001B7990
		[NullableContext(1)]
		public UGeometryCacheCodecV1(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGeometryCacheCodecV1.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06012BE4 RID: 76772 RVA: 0x001B97C3 File Offset: 0x001B79C3
		static UGeometryCacheCodecV1()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCache.GeometryCacheCodecV1");
		}

		// Token: 0x06012BE5 RID: 76773 RVA: 0x001B97D1 File Offset: 0x001B79D1
		protected UGeometryCacheCodecV1(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A057 RID: 41047
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GeometryCache.GeometryCacheCodecV1";

		// Token: 0x0400A058 RID: 41048
		private static IntPtr _ClassPtr;

		// Token: 0x0400A059 RID: 41049
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
