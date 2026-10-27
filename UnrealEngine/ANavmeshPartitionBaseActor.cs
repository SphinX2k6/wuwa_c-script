using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024BB RID: 9403
	[UnrealObjectPath("/Script/NavmeshPartition.NavmeshPartitionBaseActor")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class ANavmeshPartitionBaseActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023343 RID: 144195 RVA: 0x003412D7 File Offset: 0x0033F4D7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavmeshPartitionBaseActor._ClassPtr;
		}

		// Token: 0x06023344 RID: 144196 RVA: 0x003412E4 File Offset: 0x0033F4E4
		public ANavmeshPartitionBaseActor() : this(BuiltinUtils.AllocNativeUObject(ANavmeshPartitionBaseActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023345 RID: 144197 RVA: 0x0034130C File Offset: 0x0033F50C
		[NullableContext(1)]
		public ANavmeshPartitionBaseActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANavmeshPartitionBaseActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008761 RID: 34657
		// (get) Token: 0x06023346 RID: 144198 RVA: 0x0034133F File Offset: 0x0033F53F
		// (set) Token: 0x06023347 RID: 144199 RVA: 0x00341353 File Offset: 0x0033F553
		[Nullable(2)]
		public unsafe UNavmeshPartitionComponent NavmeshPartitionComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNavmeshPartitionComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ANavmeshPartitionBaseActor.__PropertyOffset_NavmeshPartitionComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANavmeshPartitionBaseActor.__PropertyOffset_NavmeshPartitionComp, value);
			}
		}

		// Token: 0x17008762 RID: 34658
		// (get) Token: 0x06023348 RID: 144200 RVA: 0x00341368 File Offset: 0x0033F568
		// (set) Token: 0x06023349 RID: 144201 RVA: 0x00341378 File Offset: 0x0033F578
		public unsafe ENavPartition Type
		{
			get
			{
				return (ENavPartition)(*(base.NativePtr + (IntPtr)ANavmeshPartitionBaseActor.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavmeshPartitionBaseActor.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x0602334A RID: 144202 RVA: 0x00341389 File Offset: 0x0033F589
		static ANavmeshPartitionBaseActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavmeshPartition.NavmeshPartitionBaseActor");
		}

		// Token: 0x0602334B RID: 144203 RVA: 0x00341397 File Offset: 0x0033F597
		protected ANavmeshPartitionBaseActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012CD7 RID: 77015
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavmeshPartition.NavmeshPartitionBaseActor";

		// Token: 0x04012CD8 RID: 77016
		private static IntPtr _ClassPtr;

		// Token: 0x04012CD9 RID: 77017
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012CDA RID: 77018
		internal static int __PropertyOffset_NavmeshPartitionComp;

		// Token: 0x04012CDB RID: 77019
		internal static int __PropertyOffset_Type;
	}
}
