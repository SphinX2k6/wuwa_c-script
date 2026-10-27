using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001719 RID: 5913
	[UnrealObjectPath("/Script/KuroBullet.ActionUpdateCollisionKsc")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UActionUpdateCollisionKsc : UActionUpdateCollision, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015527 RID: 87335 RVA: 0x001F56DE File Offset: 0x001F38DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActionUpdateCollisionKsc._ClassPtr;
		}

		// Token: 0x06015528 RID: 87336 RVA: 0x001F56EC File Offset: 0x001F38EC
		public UActionUpdateCollisionKsc() : this(BuiltinUtils.AllocNativeUObject(UActionUpdateCollisionKsc.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015529 RID: 87337 RVA: 0x001F5714 File Offset: 0x001F3914
		[NullableContext(1)]
		public UActionUpdateCollisionKsc(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActionUpdateCollisionKsc.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601552A RID: 87338 RVA: 0x001F5747 File Offset: 0x001F3947
		static UActionUpdateCollisionKsc()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.ActionUpdateCollisionKsc");
		}

		// Token: 0x0601552B RID: 87339 RVA: 0x001F5755 File Offset: 0x001F3955
		protected UActionUpdateCollisionKsc(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B9F3 RID: 47603
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.ActionUpdateCollisionKsc";

		// Token: 0x0400B9F4 RID: 47604
		private static IntPtr _ClassPtr;

		// Token: 0x0400B9F5 RID: 47605
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
