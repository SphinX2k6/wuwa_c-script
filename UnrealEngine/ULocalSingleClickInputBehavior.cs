using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001588 RID: 5512
	[UnrealObjectPath("/Script/InteractiveToolsFramework.LocalSingleClickInputBehavior")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class ULocalSingleClickInputBehavior : USingleClickInputBehavior, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013E6C RID: 81516 RVA: 0x001D38E2 File Offset: 0x001D1AE2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULocalSingleClickInputBehavior._ClassPtr;
		}

		// Token: 0x06013E6D RID: 81517 RVA: 0x001D38F0 File Offset: 0x001D1AF0
		public ULocalSingleClickInputBehavior() : this(BuiltinUtils.AllocNativeUObject(ULocalSingleClickInputBehavior.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013E6E RID: 81518 RVA: 0x001D3918 File Offset: 0x001D1B18
		[NullableContext(1)]
		public ULocalSingleClickInputBehavior(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULocalSingleClickInputBehavior.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013E6F RID: 81519 RVA: 0x001D394B File Offset: 0x001D1B4B
		static ULocalSingleClickInputBehavior()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.LocalSingleClickInputBehavior");
		}

		// Token: 0x06013E70 RID: 81520 RVA: 0x001D3959 File Offset: 0x001D1B59
		protected ULocalSingleClickInputBehavior(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC52 RID: 44114
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.LocalSingleClickInputBehavior";

		// Token: 0x0400AC53 RID: 44115
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC54 RID: 44116
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
