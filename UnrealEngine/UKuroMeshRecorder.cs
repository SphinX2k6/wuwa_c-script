using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001667 RID: 5735
	[UnrealObjectPath("/Script/KuroAnim.KuroMeshRecorder")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UKuroMeshRecorder : UKuroTrackRecorder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014C63 RID: 85091 RVA: 0x001E8D00 File Offset: 0x001E6F00
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMeshRecorder._ClassPtr;
		}

		// Token: 0x06014C64 RID: 85092 RVA: 0x001E8D0C File Offset: 0x001E6F0C
		public UKuroMeshRecorder() : this(BuiltinUtils.AllocNativeUObject(UKuroMeshRecorder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014C65 RID: 85093 RVA: 0x001E8D34 File Offset: 0x001E6F34
		[NullableContext(1)]
		public UKuroMeshRecorder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMeshRecorder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06014C66 RID: 85094 RVA: 0x001E8D67 File Offset: 0x001E6F67
		static UKuroMeshRecorder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroMeshRecorder");
		}

		// Token: 0x06014C67 RID: 85095 RVA: 0x001E8D75 File Offset: 0x001E6F75
		protected UKuroMeshRecorder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B538 RID: 46392
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroMeshRecorder";

		// Token: 0x0400B539 RID: 46393
		private static IntPtr _ClassPtr;

		// Token: 0x0400B53A RID: 46394
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
