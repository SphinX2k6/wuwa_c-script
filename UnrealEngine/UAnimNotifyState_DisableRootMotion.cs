using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200082B RID: 2091
	[UnrealObjectPath("/Script/Engine.AnimNotifyState_DisableRootMotion")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UAnimNotifyState_DisableRootMotion : UAnimNotifyState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600709E RID: 28830 RVA: 0x000A1769 File Offset: 0x0009F969
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimNotifyState_DisableRootMotion._ClassPtr;
		}

		// Token: 0x0600709F RID: 28831 RVA: 0x000A1778 File Offset: 0x0009F978
		public UAnimNotifyState_DisableRootMotion() : this(BuiltinUtils.AllocNativeUObject(UAnimNotifyState_DisableRootMotion.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060070A0 RID: 28832 RVA: 0x000A17A0 File Offset: 0x0009F9A0
		[NullableContext(1)]
		public UAnimNotifyState_DisableRootMotion(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimNotifyState_DisableRootMotion.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060070A1 RID: 28833 RVA: 0x000A17D3 File Offset: 0x0009F9D3
		static UAnimNotifyState_DisableRootMotion()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimNotifyState_DisableRootMotion");
		}

		// Token: 0x060070A2 RID: 28834 RVA: 0x000A17E1 File Offset: 0x0009F9E1
		protected UAnimNotifyState_DisableRootMotion(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400360C RID: 13836
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimNotifyState_DisableRootMotion";

		// Token: 0x0400360D RID: 13837
		private static IntPtr _ClassPtr;

		// Token: 0x0400360E RID: 13838
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
