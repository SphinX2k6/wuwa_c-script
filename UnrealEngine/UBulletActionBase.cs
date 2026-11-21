using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000323 RID: 803
	[UnrealObjectPath("/Script/KuroBulletCore.BulletActionBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UBulletActionBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005457 RID: 21591 RVA: 0x0007628A File Offset: 0x0007448A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBulletActionBase._ClassPtr;
		}

		// Token: 0x06005458 RID: 21592 RVA: 0x00076298 File Offset: 0x00074498
		public UBulletActionBase() : this(BuiltinUtils.AllocNativeUObject(UBulletActionBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005459 RID: 21593 RVA: 0x000762C0 File Offset: 0x000744C0
		[NullableContext(1)]
		public UBulletActionBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBulletActionBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600545A RID: 21594 RVA: 0x000762F3 File Offset: 0x000744F3
		static UBulletActionBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.BulletActionBase");
		}

		// Token: 0x0600545B RID: 21595 RVA: 0x00076301 File Offset: 0x00074501
		protected UBulletActionBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002277 RID: 8823
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.BulletActionBase";

		// Token: 0x04002278 RID: 8824
		private static IntPtr _ClassPtr;

		// Token: 0x04002279 RID: 8825
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
