using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012AC RID: 4780
	[UnrealObjectPath("/Script/FieldSystemEngine.FieldNodeBase")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UFieldNodeBase : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601184F RID: 71759 RVA: 0x0019B525 File Offset: 0x00199725
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFieldNodeBase._ClassPtr;
		}

		// Token: 0x06011850 RID: 71760 RVA: 0x0019B534 File Offset: 0x00199734
		public UFieldNodeBase() : this(BuiltinUtils.AllocNativeUObject(UFieldNodeBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011851 RID: 71761 RVA: 0x0019B55C File Offset: 0x0019975C
		[NullableContext(1)]
		public UFieldNodeBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFieldNodeBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011852 RID: 71762 RVA: 0x0019B58F File Offset: 0x0019978F
		static UFieldNodeBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.FieldNodeBase");
		}

		// Token: 0x06011853 RID: 71763 RVA: 0x0019B59D File Offset: 0x0019979D
		protected UFieldNodeBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009632 RID: 38450
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.FieldNodeBase";

		// Token: 0x04009633 RID: 38451
		private static IntPtr _ClassPtr;

		// Token: 0x04009634 RID: 38452
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
