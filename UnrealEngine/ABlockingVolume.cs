using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200018C RID: 396
	[UnrealObjectPath("/Script/Engine.BlockingVolume")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class ABlockingVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060019DE RID: 6622 RVA: 0x00026D17 File Offset: 0x00024F17
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ABlockingVolume._ClassPtr;
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x00026D24 File Offset: 0x00024F24
		public ABlockingVolume() : this(BuiltinUtils.AllocNativeUObject(ABlockingVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x00026D4C File Offset: 0x00024F4C
		[NullableContext(1)]
		public ABlockingVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABlockingVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x00026D7F File Offset: 0x00024F7F
		static ABlockingVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BlockingVolume");
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00026D8D File Offset: 0x00024F8D
		protected ABlockingVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000846 RID: 2118
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BlockingVolume";

		// Token: 0x04000847 RID: 2119
		private static IntPtr _ClassPtr;

		// Token: 0x04000848 RID: 2120
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
