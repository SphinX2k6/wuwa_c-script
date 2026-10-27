using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016C2 RID: 5826
	[UnrealObjectPath("/Script/KuroBulletCore.ActionUpdateLiveTime")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UActionUpdateLiveTime : UBulletActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060151A2 RID: 86434 RVA: 0x001F06D2 File Offset: 0x001EE8D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActionUpdateLiveTime._ClassPtr;
		}

		// Token: 0x060151A3 RID: 86435 RVA: 0x001F06E0 File Offset: 0x001EE8E0
		public UActionUpdateLiveTime() : this(BuiltinUtils.AllocNativeUObject(UActionUpdateLiveTime.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060151A4 RID: 86436 RVA: 0x001F0708 File Offset: 0x001EE908
		[NullableContext(1)]
		public UActionUpdateLiveTime(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActionUpdateLiveTime.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060151A5 RID: 86437 RVA: 0x001F073B File Offset: 0x001EE93B
		static UActionUpdateLiveTime()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.ActionUpdateLiveTime");
		}

		// Token: 0x060151A6 RID: 86438 RVA: 0x001F0749 File Offset: 0x001EE949
		protected UActionUpdateLiveTime(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B7C0 RID: 47040
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.ActionUpdateLiveTime";

		// Token: 0x0400B7C1 RID: 47041
		private static IntPtr _ClassPtr;

		// Token: 0x0400B7C2 RID: 47042
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
