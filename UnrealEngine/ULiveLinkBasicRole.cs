using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021F7 RID: 8695
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkBasicRole")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class ULiveLinkBasicRole : ULiveLinkRole, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602124E RID: 135758 RVA: 0x0030DF72 File Offset: 0x0030C172
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULiveLinkBasicRole._ClassPtr;
		}

		// Token: 0x0602124F RID: 135759 RVA: 0x0030DF80 File Offset: 0x0030C180
		public ULiveLinkBasicRole() : this(BuiltinUtils.AllocNativeUObject(ULiveLinkBasicRole.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021250 RID: 135760 RVA: 0x0030DFA8 File Offset: 0x0030C1A8
		[NullableContext(1)]
		public ULiveLinkBasicRole(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULiveLinkBasicRole.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021251 RID: 135761 RVA: 0x0030DFDB File Offset: 0x0030C1DB
		static ULiveLinkBasicRole()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LiveLinkInterface.LiveLinkBasicRole");
		}

		// Token: 0x06021252 RID: 135762 RVA: 0x0030DFE9 File Offset: 0x0030C1E9
		protected ULiveLinkBasicRole(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011AF8 RID: 72440
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkBasicRole";

		// Token: 0x04011AF9 RID: 72441
		private static IntPtr _ClassPtr;

		// Token: 0x04011AFA RID: 72442
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
