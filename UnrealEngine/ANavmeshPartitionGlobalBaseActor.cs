using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024BE RID: 9406
	[UnrealObjectPath("/Script/NavmeshPartition.NavmeshPartitionGlobalBaseActor")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class ANavmeshPartitionGlobalBaseActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023356 RID: 144214 RVA: 0x0034149E File Offset: 0x0033F69E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavmeshPartitionGlobalBaseActor._ClassPtr;
		}

		// Token: 0x06023357 RID: 144215 RVA: 0x003414AC File Offset: 0x0033F6AC
		public ANavmeshPartitionGlobalBaseActor() : this(BuiltinUtils.AllocNativeUObject(ANavmeshPartitionGlobalBaseActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023358 RID: 144216 RVA: 0x003414D4 File Offset: 0x0033F6D4
		[NullableContext(1)]
		public ANavmeshPartitionGlobalBaseActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANavmeshPartitionGlobalBaseActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008763 RID: 34659
		// (get) Token: 0x06023359 RID: 144217 RVA: 0x00341507 File Offset: 0x0033F707
		// (set) Token: 0x0602335A RID: 144218 RVA: 0x00341517 File Offset: 0x0033F717
		public unsafe ENavPartition Type
		{
			get
			{
				return (ENavPartition)(*(base.NativePtr + (IntPtr)ANavmeshPartitionGlobalBaseActor.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavmeshPartitionGlobalBaseActor.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x0602335B RID: 144219 RVA: 0x00341528 File Offset: 0x0033F728
		static ANavmeshPartitionGlobalBaseActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavmeshPartition.NavmeshPartitionGlobalBaseActor");
		}

		// Token: 0x0602335C RID: 144220 RVA: 0x00341536 File Offset: 0x0033F736
		protected ANavmeshPartitionGlobalBaseActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012CE2 RID: 77026
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavmeshPartition.NavmeshPartitionGlobalBaseActor";

		// Token: 0x04012CE3 RID: 77027
		private static IntPtr _ClassPtr;

		// Token: 0x04012CE4 RID: 77028
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012CE5 RID: 77029
		internal static int __PropertyOffset_Type;
	}
}
