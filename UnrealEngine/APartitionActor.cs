using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FCC RID: 4044
	[UnrealObjectPath("/Script/Engine.PartitionActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public abstract class APartitionActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DA37 RID: 55863 RVA: 0x001420C4 File Offset: 0x001402C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APartitionActor._ClassPtr;
		}

		// Token: 0x17003386 RID: 13190
		// (get) Token: 0x0600DA38 RID: 55864 RVA: 0x001420D0 File Offset: 0x001402D0
		// (set) Token: 0x0600DA39 RID: 55865 RVA: 0x001420E0 File Offset: 0x001402E0
		public unsafe uint GridSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APartitionActor.__PropertyOffset_GridSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APartitionActor.__PropertyOffset_GridSize) = (int)value;
			}
		}

		// Token: 0x0600DA3A RID: 55866 RVA: 0x001420F1 File Offset: 0x001402F1
		static APartitionActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PartitionActor");
		}

		// Token: 0x0600DA3B RID: 55867 RVA: 0x00142100 File Offset: 0x00140300
		protected APartitionActor() : this(BuiltinUtils.AllocNativeUObject(APartitionActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DA3C RID: 55868 RVA: 0x00142128 File Offset: 0x00140328
		protected APartitionActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400764C RID: 30284
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PartitionActor";

		// Token: 0x0400764D RID: 30285
		private static IntPtr _ClassPtr;

		// Token: 0x0400764E RID: 30286
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400764F RID: 30287
		internal static int __PropertyOffset_GridSize;
	}
}
