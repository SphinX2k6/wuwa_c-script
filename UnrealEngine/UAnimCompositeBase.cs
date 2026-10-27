using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007F5 RID: 2037
	[UnrealObjectPath("/Script/Engine.AnimCompositeBase")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 440)]
	public abstract class UAnimCompositeBase : UAnimSequenceBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006CB7 RID: 27831 RVA: 0x0009C7F5 File Offset: 0x0009A9F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimCompositeBase._ClassPtr;
		}

		// Token: 0x06006CB8 RID: 27832 RVA: 0x0009C801 File Offset: 0x0009AA01
		static UAnimCompositeBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimCompositeBase");
		}

		// Token: 0x06006CB9 RID: 27833 RVA: 0x0009C810 File Offset: 0x0009AA10
		protected UAnimCompositeBase() : this(BuiltinUtils.AllocNativeUObject(UAnimCompositeBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006CBA RID: 27834 RVA: 0x0009C838 File Offset: 0x0009AA38
		protected UAnimCompositeBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003471 RID: 13425
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimCompositeBase";

		// Token: 0x04003472 RID: 13426
		private static IntPtr _ClassPtr;

		// Token: 0x04003473 RID: 13427
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
