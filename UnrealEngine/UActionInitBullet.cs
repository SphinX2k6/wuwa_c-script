using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016BE RID: 5822
	[UnrealObjectPath("/Script/KuroBulletCore.ActionInitBullet")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UActionInitBullet : UBulletActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601518E RID: 86414 RVA: 0x001F04D2 File Offset: 0x001EE6D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActionInitBullet._ClassPtr;
		}

		// Token: 0x0601518F RID: 86415 RVA: 0x001F04E0 File Offset: 0x001EE6E0
		public UActionInitBullet() : this(BuiltinUtils.AllocNativeUObject(UActionInitBullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015190 RID: 86416 RVA: 0x001F0508 File Offset: 0x001EE708
		[NullableContext(1)]
		public UActionInitBullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActionInitBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06015191 RID: 86417 RVA: 0x001F053B File Offset: 0x001EE73B
		static UActionInitBullet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.ActionInitBullet");
		}

		// Token: 0x06015192 RID: 86418 RVA: 0x001F0549 File Offset: 0x001EE749
		protected UActionInitBullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B7B4 RID: 47028
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.ActionInitBullet";

		// Token: 0x0400B7B5 RID: 47029
		private static IntPtr _ClassPtr;

		// Token: 0x0400B7B6 RID: 47030
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
