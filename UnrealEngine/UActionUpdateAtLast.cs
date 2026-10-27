using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016C0 RID: 5824
	[UnrealObjectPath("/Script/KuroBulletCore.ActionUpdateAtLast")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UActionUpdateAtLast : UBulletActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015198 RID: 86424 RVA: 0x001F05D2 File Offset: 0x001EE7D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActionUpdateAtLast._ClassPtr;
		}

		// Token: 0x06015199 RID: 86425 RVA: 0x001F05E0 File Offset: 0x001EE7E0
		public UActionUpdateAtLast() : this(BuiltinUtils.AllocNativeUObject(UActionUpdateAtLast.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601519A RID: 86426 RVA: 0x001F0608 File Offset: 0x001EE808
		[NullableContext(1)]
		public UActionUpdateAtLast(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActionUpdateAtLast.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601519B RID: 86427 RVA: 0x001F063B File Offset: 0x001EE83B
		static UActionUpdateAtLast()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.ActionUpdateAtLast");
		}

		// Token: 0x0601519C RID: 86428 RVA: 0x001F0649 File Offset: 0x001EE849
		protected UActionUpdateAtLast(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B7BA RID: 47034
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.ActionUpdateAtLast";

		// Token: 0x0400B7BB RID: 47035
		private static IntPtr _ClassPtr;

		// Token: 0x0400B7BC RID: 47036
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
