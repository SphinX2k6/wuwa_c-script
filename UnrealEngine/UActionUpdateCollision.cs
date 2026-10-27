using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016C1 RID: 5825
	[UnrealObjectPath("/Script/KuroBulletCore.ActionUpdateCollision")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UActionUpdateCollision : UBulletActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601519D RID: 86429 RVA: 0x001F0652 File Offset: 0x001EE852
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActionUpdateCollision._ClassPtr;
		}

		// Token: 0x0601519E RID: 86430 RVA: 0x001F0660 File Offset: 0x001EE860
		public UActionUpdateCollision() : this(BuiltinUtils.AllocNativeUObject(UActionUpdateCollision.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601519F RID: 86431 RVA: 0x001F0688 File Offset: 0x001EE888
		[NullableContext(1)]
		public UActionUpdateCollision(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActionUpdateCollision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060151A0 RID: 86432 RVA: 0x001F06BB File Offset: 0x001EE8BB
		static UActionUpdateCollision()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.ActionUpdateCollision");
		}

		// Token: 0x060151A1 RID: 86433 RVA: 0x001F06C9 File Offset: 0x001EE8C9
		protected UActionUpdateCollision(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B7BD RID: 47037
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.ActionUpdateCollision";

		// Token: 0x0400B7BE RID: 47038
		private static IntPtr _ClassPtr;

		// Token: 0x0400B7BF RID: 47039
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
