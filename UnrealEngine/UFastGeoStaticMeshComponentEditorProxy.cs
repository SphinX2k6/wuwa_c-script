using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200129B RID: 4763
	[UnrealObjectPath("/Script/FastGeoStreaming.FastGeoStaticMeshComponentEditorProxy")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UFastGeoStaticMeshComponentEditorProxy : UFastGeoPrimitiveComponentEditorProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011794 RID: 71572 RVA: 0x0019A6BA File Offset: 0x001988BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFastGeoStaticMeshComponentEditorProxy._ClassPtr;
		}

		// Token: 0x06011795 RID: 71573 RVA: 0x0019A6C8 File Offset: 0x001988C8
		public UFastGeoStaticMeshComponentEditorProxy() : this(BuiltinUtils.AllocNativeUObject(UFastGeoStaticMeshComponentEditorProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011796 RID: 71574 RVA: 0x0019A6F0 File Offset: 0x001988F0
		[NullableContext(1)]
		public UFastGeoStaticMeshComponentEditorProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFastGeoStaticMeshComponentEditorProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011797 RID: 71575 RVA: 0x0019A723 File Offset: 0x00198923
		static UFastGeoStaticMeshComponentEditorProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FastGeoStreaming.FastGeoStaticMeshComponentEditorProxy");
		}

		// Token: 0x06011798 RID: 71576 RVA: 0x0019A731 File Offset: 0x00198931
		protected UFastGeoStaticMeshComponentEditorProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040095A7 RID: 38311
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FastGeoStreaming.FastGeoStaticMeshComponentEditorProxy";

		// Token: 0x040095A8 RID: 38312
		private static IntPtr _ClassPtr;

		// Token: 0x040095A9 RID: 38313
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
