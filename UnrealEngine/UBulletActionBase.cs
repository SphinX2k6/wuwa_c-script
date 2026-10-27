using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016C5 RID: 5829
	[UnrealObjectPath("/Script/KuroBulletCore.BulletActionBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UBulletActionBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060151B1 RID: 86449 RVA: 0x001F0852 File Offset: 0x001EEA52
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBulletActionBase._ClassPtr;
		}

		// Token: 0x060151B2 RID: 86450 RVA: 0x001F0860 File Offset: 0x001EEA60
		public UBulletActionBase() : this(BuiltinUtils.AllocNativeUObject(UBulletActionBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060151B3 RID: 86451 RVA: 0x001F0888 File Offset: 0x001EEA88
		[NullableContext(1)]
		public UBulletActionBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBulletActionBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060151B4 RID: 86452 RVA: 0x001F08BB File Offset: 0x001EEABB
		static UBulletActionBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.BulletActionBase");
		}

		// Token: 0x060151B5 RID: 86453 RVA: 0x001F08C9 File Offset: 0x001EEAC9
		protected UBulletActionBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B7C9 RID: 47049
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.BulletActionBase";

		// Token: 0x0400B7CA RID: 47050
		private static IntPtr _ClassPtr;

		// Token: 0x0400B7CB RID: 47051
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
