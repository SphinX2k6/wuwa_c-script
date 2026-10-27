using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AAA RID: 6826
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroAsyncMoveSubsystem")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKuroAsyncMoveSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601944A RID: 103498 RVA: 0x00255E8A File Offset: 0x0025408A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAsyncMoveSubsystem._ClassPtr;
		}

		// Token: 0x0601944B RID: 103499 RVA: 0x00255E98 File Offset: 0x00254098
		public UKuroAsyncMoveSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroAsyncMoveSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601944C RID: 103500 RVA: 0x00255EC0 File Offset: 0x002540C0
		[NullableContext(1)]
		public UKuroAsyncMoveSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAsyncMoveSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601944D RID: 103501 RVA: 0x00255EF3 File Offset: 0x002540F3
		static UKuroAsyncMoveSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroAsyncMoveSubsystem");
		}

		// Token: 0x0601944E RID: 103502 RVA: 0x00255F01 File Offset: 0x00254101
		protected UKuroAsyncMoveSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DC79 RID: 56441
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroAsyncMoveSubsystem";

		// Token: 0x0400DC7A RID: 56442
		private static IntPtr _ClassPtr;

		// Token: 0x0400DC7B RID: 56443
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
