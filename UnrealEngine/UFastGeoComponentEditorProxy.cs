using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001298 RID: 4760
	[UnrealObjectPath("/Script/FastGeoStreaming.FastGeoComponentEditorProxy")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UFastGeoComponentEditorProxy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601177D RID: 71549 RVA: 0x0019A456 File Offset: 0x00198656
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFastGeoComponentEditorProxy._ClassPtr;
		}

		// Token: 0x0601177E RID: 71550 RVA: 0x0019A464 File Offset: 0x00198664
		public UFastGeoComponentEditorProxy() : this(BuiltinUtils.AllocNativeUObject(UFastGeoComponentEditorProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601177F RID: 71551 RVA: 0x0019A48C File Offset: 0x0019868C
		[NullableContext(1)]
		public UFastGeoComponentEditorProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFastGeoComponentEditorProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011780 RID: 71552 RVA: 0x0019A4BF File Offset: 0x001986BF
		static UFastGeoComponentEditorProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FastGeoStreaming.FastGeoComponentEditorProxy");
		}

		// Token: 0x06011781 RID: 71553 RVA: 0x0019A4CD File Offset: 0x001986CD
		protected UFastGeoComponentEditorProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009596 RID: 38294
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FastGeoStreaming.FastGeoComponentEditorProxy";

		// Token: 0x04009597 RID: 38295
		private static IntPtr _ClassPtr;

		// Token: 0x04009598 RID: 38296
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
