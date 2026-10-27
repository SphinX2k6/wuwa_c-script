using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200158C RID: 5516
	[UnrealObjectPath("/Script/InteractiveToolsFramework.MouseHoverBehavior")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UMouseHoverBehavior : UInputBehavior, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013E8A RID: 81546 RVA: 0x001D3C2A File Offset: 0x001D1E2A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMouseHoverBehavior._ClassPtr;
		}

		// Token: 0x06013E8B RID: 81547 RVA: 0x001D3C38 File Offset: 0x001D1E38
		public UMouseHoverBehavior() : this(BuiltinUtils.AllocNativeUObject(UMouseHoverBehavior.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013E8C RID: 81548 RVA: 0x001D3C60 File Offset: 0x001D1E60
		[NullableContext(1)]
		public UMouseHoverBehavior(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMouseHoverBehavior.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013E8D RID: 81549 RVA: 0x001D3C93 File Offset: 0x001D1E93
		static UMouseHoverBehavior()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.MouseHoverBehavior");
		}

		// Token: 0x06013E8E RID: 81550 RVA: 0x001D3CA1 File Offset: 0x001D1EA1
		protected UMouseHoverBehavior(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC67 RID: 44135
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.MouseHoverBehavior";

		// Token: 0x0400AC68 RID: 44136
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC69 RID: 44137
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
