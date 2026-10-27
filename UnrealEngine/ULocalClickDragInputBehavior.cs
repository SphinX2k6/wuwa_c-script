using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001587 RID: 5511
	[UnrealObjectPath("/Script/InteractiveToolsFramework.LocalClickDragInputBehavior")]
	[UnrealStructLayout(752, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 752)]
	public class ULocalClickDragInputBehavior : UClickDragInputBehavior, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013E67 RID: 81511 RVA: 0x001D3862 File Offset: 0x001D1A62
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULocalClickDragInputBehavior._ClassPtr;
		}

		// Token: 0x06013E68 RID: 81512 RVA: 0x001D3870 File Offset: 0x001D1A70
		public ULocalClickDragInputBehavior() : this(BuiltinUtils.AllocNativeUObject(ULocalClickDragInputBehavior.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013E69 RID: 81513 RVA: 0x001D3898 File Offset: 0x001D1A98
		[NullableContext(1)]
		public ULocalClickDragInputBehavior(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULocalClickDragInputBehavior.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013E6A RID: 81514 RVA: 0x001D38CB File Offset: 0x001D1ACB
		static ULocalClickDragInputBehavior()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.LocalClickDragInputBehavior");
		}

		// Token: 0x06013E6B RID: 81515 RVA: 0x001D38D9 File Offset: 0x001D1AD9
		protected ULocalClickDragInputBehavior(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC4F RID: 44111
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.LocalClickDragInputBehavior";

		// Token: 0x0400AC50 RID: 44112
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC51 RID: 44113
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
