using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200213C RID: 8508
	[UnrealObjectPath("/Script/LGUI.UIDrawcallMesh")]
	[UnrealStructLayout(1728, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1728)]
	public class UUIDrawcallMesh : ULGUIMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602008F RID: 131215 RVA: 0x002FA547 File Offset: 0x002F8747
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIDrawcallMesh._ClassPtr;
		}

		// Token: 0x06020090 RID: 131216 RVA: 0x002FA554 File Offset: 0x002F8754
		public UUIDrawcallMesh() : this(BuiltinUtils.AllocNativeUObject(UUIDrawcallMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020091 RID: 131217 RVA: 0x002FA57C File Offset: 0x002F877C
		[NullableContext(1)]
		public UUIDrawcallMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIDrawcallMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06020092 RID: 131218 RVA: 0x002FA5AF File Offset: 0x002F87AF
		static UUIDrawcallMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIDrawcallMesh");
		}

		// Token: 0x06020093 RID: 131219 RVA: 0x002FA5BD File Offset: 0x002F87BD
		protected UUIDrawcallMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040113FE RID: 70654
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIDrawcallMesh";

		// Token: 0x040113FF RID: 70655
		private static IntPtr _ClassPtr;

		// Token: 0x04011400 RID: 70656
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
