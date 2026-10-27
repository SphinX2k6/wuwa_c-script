using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001706 RID: 5894
	[UnrealObjectPath("/Script/KuroBulletCore.KuroTimeScaleBase")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroTimeScaleBase : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015480 RID: 87168 RVA: 0x001F468F File Offset: 0x001F288F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroTimeScaleBase._ScriptStructPtr != 0) ? FKuroTimeScaleBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.KuroTimeScaleBase", ref FKuroTimeScaleBase._ScriptStructPtr);
		}

		// Token: 0x06015481 RID: 87169 RVA: 0x001F46B3 File Offset: 0x001F28B3
		public FKuroTimeScaleBase()
		{
		}

		// Token: 0x06015482 RID: 87170 RVA: 0x001F46BB File Offset: 0x001F28BB
		protected override IntPtr GetUStructPtr()
		{
			return FKuroTimeScaleBase.StaticStruct();
		}

		// Token: 0x06015483 RID: 87171 RVA: 0x001F46C7 File Offset: 0x001F28C7
		[NullableContext(2)]
		public FKuroTimeScaleBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015484 RID: 87172 RVA: 0x001F46D1 File Offset: 0x001F28D1
		public FKuroTimeScaleBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015485 RID: 87173 RVA: 0x001F46DC File Offset: 0x001F28DC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroTimeScaleBase(Pointer, false, true);
		}

		// Token: 0x06015486 RID: 87174 RVA: 0x001F46E6 File Offset: 0x001F28E6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroTimeScaleBase(Pointer, MemoryOwner);
		}

		// Token: 0x0400B9A2 RID: 47522
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBulletCore.KuroTimeScaleBase";

		// Token: 0x0400B9A3 RID: 47523
		private static IntPtr _ScriptStructPtr;
	}
}
