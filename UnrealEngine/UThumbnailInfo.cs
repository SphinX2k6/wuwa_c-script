using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011E5 RID: 4581
	[UnrealObjectPath("/Script/Engine.ThumbnailInfo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UThumbnailInfo : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010DFD RID: 69117 RVA: 0x0018C7E0 File Offset: 0x0018A9E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UThumbnailInfo._ClassPtr;
		}

		// Token: 0x06010DFE RID: 69118 RVA: 0x0018C7EC File Offset: 0x0018A9EC
		public UThumbnailInfo() : this(BuiltinUtils.AllocNativeUObject(UThumbnailInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010DFF RID: 69119 RVA: 0x0018C814 File Offset: 0x0018AA14
		[NullableContext(1)]
		public UThumbnailInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UThumbnailInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06010E00 RID: 69120 RVA: 0x0018C847 File Offset: 0x0018AA47
		static UThumbnailInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ThumbnailInfo");
		}

		// Token: 0x06010E01 RID: 69121 RVA: 0x0018C855 File Offset: 0x0018AA55
		protected UThumbnailInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040090B8 RID: 37048
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ThumbnailInfo";

		// Token: 0x040090B9 RID: 37049
		private static IntPtr _ClassPtr;

		// Token: 0x040090BA RID: 37050
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
