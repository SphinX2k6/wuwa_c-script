using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200129A RID: 4762
	[UnrealObjectPath("/Script/FastGeoStreaming.FastGeoPrimitiveComponentEditorProxy")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UFastGeoPrimitiveComponentEditorProxy : UFastGeoComponentEditorProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601178F RID: 71567 RVA: 0x0019A63B File Offset: 0x0019883B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFastGeoPrimitiveComponentEditorProxy._ClassPtr;
		}

		// Token: 0x06011790 RID: 71568 RVA: 0x0019A648 File Offset: 0x00198848
		public UFastGeoPrimitiveComponentEditorProxy() : this(BuiltinUtils.AllocNativeUObject(UFastGeoPrimitiveComponentEditorProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011791 RID: 71569 RVA: 0x0019A670 File Offset: 0x00198870
		[NullableContext(1)]
		public UFastGeoPrimitiveComponentEditorProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFastGeoPrimitiveComponentEditorProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011792 RID: 71570 RVA: 0x0019A6A3 File Offset: 0x001988A3
		static UFastGeoPrimitiveComponentEditorProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FastGeoStreaming.FastGeoPrimitiveComponentEditorProxy");
		}

		// Token: 0x06011793 RID: 71571 RVA: 0x0019A6B1 File Offset: 0x001988B1
		protected UFastGeoPrimitiveComponentEditorProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040095A4 RID: 38308
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FastGeoStreaming.FastGeoPrimitiveComponentEditorProxy";

		// Token: 0x040095A5 RID: 38309
		private static IntPtr _ClassPtr;

		// Token: 0x040095A6 RID: 38310
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
