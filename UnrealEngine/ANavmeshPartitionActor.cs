using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024BA RID: 9402
	[UnrealObjectPath("/Script/NavmeshPartition.NavmeshPartitionActor")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class ANavmeshPartitionActor : ANavmeshPartitionBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602333C RID: 144188 RVA: 0x0034122E File Offset: 0x0033F42E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavmeshPartitionActor._ClassPtr;
		}

		// Token: 0x0602333D RID: 144189 RVA: 0x0034123C File Offset: 0x0033F43C
		public ANavmeshPartitionActor() : this(BuiltinUtils.AllocNativeUObject(ANavmeshPartitionActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602333E RID: 144190 RVA: 0x00341264 File Offset: 0x0033F464
		[NullableContext(1)]
		public ANavmeshPartitionActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANavmeshPartitionActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008760 RID: 34656
		// (get) Token: 0x0602333F RID: 144191 RVA: 0x00341297 File Offset: 0x0033F497
		// (set) Token: 0x06023340 RID: 144192 RVA: 0x003412AB File Offset: 0x0033F4AB
		[Nullable(2)]
		public unsafe UAudioMaterialComponent AudioMaterialComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAudioMaterialComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ANavmeshPartitionActor.__PropertyOffset_AudioMaterialComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANavmeshPartitionActor.__PropertyOffset_AudioMaterialComp, value);
			}
		}

		// Token: 0x06023341 RID: 144193 RVA: 0x003412C0 File Offset: 0x0033F4C0
		static ANavmeshPartitionActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavmeshPartition.NavmeshPartitionActor");
		}

		// Token: 0x06023342 RID: 144194 RVA: 0x003412CE File Offset: 0x0033F4CE
		protected ANavmeshPartitionActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012CD3 RID: 77011
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavmeshPartition.NavmeshPartitionActor";

		// Token: 0x04012CD4 RID: 77012
		private static IntPtr _ClassPtr;

		// Token: 0x04012CD5 RID: 77013
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012CD6 RID: 77014
		internal static int __PropertyOffset_AudioMaterialComp;
	}
}
