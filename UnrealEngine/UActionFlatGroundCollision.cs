using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016BD RID: 5821
	[UnrealObjectPath("/Script/KuroBulletCore.ActionFlatGroundCollision")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UActionFlatGroundCollision : UBulletActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015189 RID: 86409 RVA: 0x001F0452 File Offset: 0x001EE652
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActionFlatGroundCollision._ClassPtr;
		}

		// Token: 0x0601518A RID: 86410 RVA: 0x001F0460 File Offset: 0x001EE660
		public UActionFlatGroundCollision() : this(BuiltinUtils.AllocNativeUObject(UActionFlatGroundCollision.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601518B RID: 86411 RVA: 0x001F0488 File Offset: 0x001EE688
		[NullableContext(1)]
		public UActionFlatGroundCollision(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActionFlatGroundCollision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601518C RID: 86412 RVA: 0x001F04BB File Offset: 0x001EE6BB
		static UActionFlatGroundCollision()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.ActionFlatGroundCollision");
		}

		// Token: 0x0601518D RID: 86413 RVA: 0x001F04C9 File Offset: 0x001EE6C9
		protected UActionFlatGroundCollision(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B7B1 RID: 47025
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.ActionFlatGroundCollision";

		// Token: 0x0400B7B2 RID: 47026
		private static IntPtr _ClassPtr;

		// Token: 0x0400B7B3 RID: 47027
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
