using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000322 RID: 802
	[UnrealObjectPath("/Script/KuroBulletCore.ActionFlatGroundCollision")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UActionFlatGroundCollision : UBulletActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005452 RID: 21586 RVA: 0x0007620B File Offset: 0x0007440B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActionFlatGroundCollision._ClassPtr;
		}

		// Token: 0x06005453 RID: 21587 RVA: 0x00076218 File Offset: 0x00074418
		public UActionFlatGroundCollision() : this(BuiltinUtils.AllocNativeUObject(UActionFlatGroundCollision.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005454 RID: 21588 RVA: 0x00076240 File Offset: 0x00074440
		[NullableContext(1)]
		public UActionFlatGroundCollision(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActionFlatGroundCollision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06005455 RID: 21589 RVA: 0x00076273 File Offset: 0x00074473
		static UActionFlatGroundCollision()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.ActionFlatGroundCollision");
		}

		// Token: 0x06005456 RID: 21590 RVA: 0x00076281 File Offset: 0x00074481
		protected UActionFlatGroundCollision(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002274 RID: 8820
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.ActionFlatGroundCollision";

		// Token: 0x04002275 RID: 8821
		private static IntPtr _ClassPtr;

		// Token: 0x04002276 RID: 8822
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
