using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000372 RID: 882
	[UnrealObjectPath("/Script/AudioMaterialPlugin.AudioMaterialPartitionActor")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class AAudioMaterialPartitionActor : AKuroWorldPartitionActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600305F RID: 12383 RVA: 0x0004AEC2 File Offset: 0x000490C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AAudioMaterialPartitionActor._ClassPtr;
		}

		// Token: 0x06003060 RID: 12384 RVA: 0x0004AED0 File Offset: 0x000490D0
		public AAudioMaterialPartitionActor() : this(BuiltinUtils.AllocNativeUObject(AAudioMaterialPartitionActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x0004AEF8 File Offset: 0x000490F8
		[NullableContext(1)]
		public AAudioMaterialPartitionActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AAudioMaterialPartitionActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06003062 RID: 12386 RVA: 0x0004AF2B File Offset: 0x0004912B
		// (set) Token: 0x06003063 RID: 12387 RVA: 0x0004AF3F File Offset: 0x0004913F
		[Nullable(2)]
		public unsafe UAudioMaterialComponent AudioMaterialComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAudioMaterialComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AAudioMaterialPartitionActor.__PropertyOffset_AudioMaterialComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AAudioMaterialPartitionActor.__PropertyOffset_AudioMaterialComp, value);
			}
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x0004AF54 File Offset: 0x00049154
		static AAudioMaterialPartitionActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioMaterialPlugin.AudioMaterialPartitionActor");
		}

		// Token: 0x06003065 RID: 12389 RVA: 0x0004AF62 File Offset: 0x00049162
		protected AAudioMaterialPartitionActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001517 RID: 5399
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioMaterialPlugin.AudioMaterialPartitionActor";

		// Token: 0x04001518 RID: 5400
		private static IntPtr _ClassPtr;

		// Token: 0x04001519 RID: 5401
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400151A RID: 5402
		internal static int __PropertyOffset_AudioMaterialComp;
	}
}
