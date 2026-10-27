using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016CA RID: 5834
	[UnrealObjectPath("/Script/KuroBulletCore.BulletOnHitAction")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UBulletOnHitAction : UBulletActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060151EB RID: 86507 RVA: 0x001F0DEF File Offset: 0x001EEFEF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBulletOnHitAction._ClassPtr;
		}

		// Token: 0x060151EC RID: 86508 RVA: 0x001F0DFC File Offset: 0x001EEFFC
		public UBulletOnHitAction() : this(BuiltinUtils.AllocNativeUObject(UBulletOnHitAction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060151ED RID: 86509 RVA: 0x001F0E24 File Offset: 0x001EF024
		[NullableContext(1)]
		public UBulletOnHitAction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBulletOnHitAction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060151EE RID: 86510 RVA: 0x001F0E57 File Offset: 0x001EF057
		static UBulletOnHitAction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.BulletOnHitAction");
		}

		// Token: 0x060151EF RID: 86511 RVA: 0x001F0E65 File Offset: 0x001EF065
		protected UBulletOnHitAction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B7EE RID: 47086
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.BulletOnHitAction";

		// Token: 0x0400B7EF RID: 47087
		private static IntPtr _ClassPtr;

		// Token: 0x0400B7F0 RID: 47088
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
