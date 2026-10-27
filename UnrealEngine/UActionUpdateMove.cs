using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016C3 RID: 5827
	[UnrealObjectPath("/Script/KuroBulletCore.ActionUpdateMove")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UActionUpdateMove : UBulletActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060151A7 RID: 86439 RVA: 0x001F0752 File Offset: 0x001EE952
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActionUpdateMove._ClassPtr;
		}

		// Token: 0x060151A8 RID: 86440 RVA: 0x001F0760 File Offset: 0x001EE960
		public UActionUpdateMove() : this(BuiltinUtils.AllocNativeUObject(UActionUpdateMove.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060151A9 RID: 86441 RVA: 0x001F0788 File Offset: 0x001EE988
		[NullableContext(1)]
		public UActionUpdateMove(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActionUpdateMove.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060151AA RID: 86442 RVA: 0x001F07BB File Offset: 0x001EE9BB
		static UActionUpdateMove()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.ActionUpdateMove");
		}

		// Token: 0x060151AB RID: 86443 RVA: 0x001F07C9 File Offset: 0x001EE9C9
		protected UActionUpdateMove(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B7C3 RID: 47043
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.ActionUpdateMove";

		// Token: 0x0400B7C4 RID: 47044
		private static IntPtr _ClassPtr;

		// Token: 0x0400B7C5 RID: 47045
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
