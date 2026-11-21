using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000366 RID: 870
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroDataBag.KuroDataBag")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKuroDataBag : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060058AE RID: 22702 RVA: 0x0007CE86 File Offset: 0x0007B086
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroDataBag._ClassPtr;
		}

		// Token: 0x060058AF RID: 22703 RVA: 0x0007CE94 File Offset: 0x0007B094
		public UKuroDataBag() : this(BuiltinUtils.AllocNativeUObject(UKuroDataBag.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060058B0 RID: 22704 RVA: 0x0007CEBC File Offset: 0x0007B0BC
		public UKuroDataBag(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroDataBag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x060058B1 RID: 22705 RVA: 0x0007CEEF File Offset: 0x0007B0EF
		// (set) Token: 0x060058B2 RID: 22706 RVA: 0x0007CF04 File Offset: 0x0007B104
		public TSoftClassPtr<UObject> RegisteredClass
		{
			get
			{
				return new TSoftClassPtr<UObject>(base.NativePtr + (IntPtr)UKuroDataBag.__PropertyOffset_RegisteredClass, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UKuroDataBag.__PropertyOffset_RegisteredClass, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x060058B3 RID: 22707 RVA: 0x0007CF29 File Offset: 0x0007B129
		static UKuroDataBag()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroDataBag.KuroDataBag");
		}

		// Token: 0x060058B4 RID: 22708 RVA: 0x0007CF37 File Offset: 0x0007B137
		protected UKuroDataBag(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400249D RID: 9373
		public new const string __ObjectPath = "/Script/KuroDataBag.KuroDataBag";

		// Token: 0x0400249E RID: 9374
		private static IntPtr _ClassPtr;

		// Token: 0x0400249F RID: 9375
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040024A0 RID: 9376
		internal static int __PropertyOffset_RegisteredClass;
	}
}
