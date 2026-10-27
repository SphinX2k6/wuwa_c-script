using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200122B RID: 4651
	[UnrealObjectPath("/Script/Engine.ViewModeUtils")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UViewModeUtils : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060111C5 RID: 70085 RVA: 0x00191AD3 File Offset: 0x0018FCD3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UViewModeUtils._ClassPtr;
		}

		// Token: 0x060111C6 RID: 70086 RVA: 0x00191AE0 File Offset: 0x0018FCE0
		public UViewModeUtils() : this(BuiltinUtils.AllocNativeUObject(UViewModeUtils.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060111C7 RID: 70087 RVA: 0x00191B08 File Offset: 0x0018FD08
		[NullableContext(1)]
		public UViewModeUtils(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UViewModeUtils.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060111C8 RID: 70088 RVA: 0x00191B3B File Offset: 0x0018FD3B
		static UViewModeUtils()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ViewModeUtils");
		}

		// Token: 0x060111C9 RID: 70089 RVA: 0x00191B49 File Offset: 0x0018FD49
		protected UViewModeUtils(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009289 RID: 37513
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ViewModeUtils";

		// Token: 0x0400928A RID: 37514
		private static IntPtr _ClassPtr;

		// Token: 0x0400928B RID: 37515
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
