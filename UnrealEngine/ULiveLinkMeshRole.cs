using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200220E RID: 8718
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkMeshRole")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class ULiveLinkMeshRole : ULiveLinkBasicRole, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602135E RID: 136030 RVA: 0x0030F672 File Offset: 0x0030D872
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULiveLinkMeshRole._ClassPtr;
		}

		// Token: 0x0602135F RID: 136031 RVA: 0x0030F680 File Offset: 0x0030D880
		public ULiveLinkMeshRole() : this(BuiltinUtils.AllocNativeUObject(ULiveLinkMeshRole.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021360 RID: 136032 RVA: 0x0030F6A8 File Offset: 0x0030D8A8
		[NullableContext(1)]
		public ULiveLinkMeshRole(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULiveLinkMeshRole.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021361 RID: 136033 RVA: 0x0030F6DB File Offset: 0x0030D8DB
		static ULiveLinkMeshRole()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LiveLinkInterface.LiveLinkMeshRole");
		}

		// Token: 0x06021362 RID: 136034 RVA: 0x0030F6E9 File Offset: 0x0030D8E9
		protected ULiveLinkMeshRole(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B78 RID: 72568
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkMeshRole";

		// Token: 0x04011B79 RID: 72569
		private static IntPtr _ClassPtr;

		// Token: 0x04011B7A RID: 72570
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
