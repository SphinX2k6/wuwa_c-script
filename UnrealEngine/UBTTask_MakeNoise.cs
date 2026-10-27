using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000158 RID: 344
	[UnrealObjectPath("/Script/AIModule.BTTask_MakeNoise")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UBTTask_MakeNoise : UBTTaskNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060017A7 RID: 6055 RVA: 0x00022C31 File Offset: 0x00020E31
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_MakeNoise._ClassPtr;
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x00022C40 File Offset: 0x00020E40
		public UBTTask_MakeNoise() : this(BuiltinUtils.AllocNativeUObject(UBTTask_MakeNoise.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x00022C68 File Offset: 0x00020E68
		[NullableContext(1)]
		public UBTTask_MakeNoise(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTTask_MakeNoise.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x00022C9B File Offset: 0x00020E9B
		// (set) Token: 0x060017AB RID: 6059 RVA: 0x00022CAB File Offset: 0x00020EAB
		public unsafe float Loudnes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTTask_MakeNoise.__PropertyOffset_Loudnes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTTask_MakeNoise.__PropertyOffset_Loudnes) = value;
			}
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x00022CBC File Offset: 0x00020EBC
		static UBTTask_MakeNoise()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTask_MakeNoise");
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x00022CCA File Offset: 0x00020ECA
		protected UBTTask_MakeNoise(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005A8 RID: 1448
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTTask_MakeNoise";

		// Token: 0x040005A9 RID: 1449
		private static IntPtr _ClassPtr;

		// Token: 0x040005AA RID: 1450
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040005AB RID: 1451
		internal static int __PropertyOffset_Loudnes;
	}
}
