using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015F5 RID: 5621
	[UnrealObjectPath("/Script/KuroAI.BTDecorator_ForceFailure")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UBTDecorator_ForceFailure : UBTDecorator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060143E6 RID: 82918 RVA: 0x001DB9B8 File Offset: 0x001D9BB8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator_ForceFailure._ClassPtr;
		}

		// Token: 0x060143E7 RID: 82919 RVA: 0x001DB9C4 File Offset: 0x001D9BC4
		public UBTDecorator_ForceFailure() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_ForceFailure.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060143E8 RID: 82920 RVA: 0x001DB9EC File Offset: 0x001D9BEC
		[NullableContext(1)]
		public UBTDecorator_ForceFailure(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_ForceFailure.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060143E9 RID: 82921 RVA: 0x001DBA1F File Offset: 0x001D9C1F
		static UBTDecorator_ForceFailure()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAI.BTDecorator_ForceFailure");
		}

		// Token: 0x060143EA RID: 82922 RVA: 0x001DBA2D File Offset: 0x001D9C2D
		protected UBTDecorator_ForceFailure(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B036 RID: 45110
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAI.BTDecorator_ForceFailure";

		// Token: 0x0400B037 RID: 45111
		private static IntPtr _ClassPtr;

		// Token: 0x0400B038 RID: 45112
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
