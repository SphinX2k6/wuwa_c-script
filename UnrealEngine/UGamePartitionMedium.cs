using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001872 RID: 6258
	[UnrealObjectPath("/Script/KuroGamePartition.GamePartitionMedium")]
	[UnrealStructLayout(712, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 712)]
	public class UGamePartitionMedium : UGamePartition, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060170C7 RID: 94407 RVA: 0x00219639 File Offset: 0x00217839
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGamePartitionMedium._ClassPtr;
		}

		// Token: 0x060170C8 RID: 94408 RVA: 0x00219648 File Offset: 0x00217848
		public UGamePartitionMedium() : this(BuiltinUtils.AllocNativeUObject(UGamePartitionMedium.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060170C9 RID: 94409 RVA: 0x00219670 File Offset: 0x00217870
		[NullableContext(1)]
		public UGamePartitionMedium(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGamePartitionMedium.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060170CA RID: 94410 RVA: 0x002196A3 File Offset: 0x002178A3
		static UGamePartitionMedium()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGamePartition.GamePartitionMedium");
		}

		// Token: 0x060170CB RID: 94411 RVA: 0x002196B1 File Offset: 0x002178B1
		protected UGamePartitionMedium(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C81C RID: 51228
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGamePartition.GamePartitionMedium";

		// Token: 0x0400C81D RID: 51229
		private static IntPtr _ClassPtr;

		// Token: 0x0400C81E RID: 51230
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
