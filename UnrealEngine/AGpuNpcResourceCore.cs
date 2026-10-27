using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C0B RID: 3083
	[UnrealObjectPath("/Script/Engine.GpuNpcResourceCore")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class AGpuNpcResourceCore : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009B50 RID: 39760 RVA: 0x000DCADE File Offset: 0x000DACDE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGpuNpcResourceCore._ClassPtr;
		}

		// Token: 0x06009B51 RID: 39761 RVA: 0x000DCAEC File Offset: 0x000DACEC
		public AGpuNpcResourceCore() : this(BuiltinUtils.AllocNativeUObject(AGpuNpcResourceCore.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009B52 RID: 39762 RVA: 0x000DCB14 File Offset: 0x000DAD14
		[NullableContext(1)]
		public AGpuNpcResourceCore(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGpuNpcResourceCore.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170024EC RID: 9452
		// (get) Token: 0x06009B53 RID: 39763 RVA: 0x000DCB47 File Offset: 0x000DAD47
		// (set) Token: 0x06009B54 RID: 39764 RVA: 0x000DCB5B File Offset: 0x000DAD5B
		[Nullable(2)]
		public unsafe UBakedBoneSplitComponent CoreComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBakedBoneSplitComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AGpuNpcResourceCore.__PropertyOffset_CoreComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGpuNpcResourceCore.__PropertyOffset_CoreComponent, value);
			}
		}

		// Token: 0x06009B55 RID: 39765 RVA: 0x000DCB70 File Offset: 0x000DAD70
		static AGpuNpcResourceCore()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GpuNpcResourceCore");
		}

		// Token: 0x06009B56 RID: 39766 RVA: 0x000DCB7E File Offset: 0x000DAD7E
		protected AGpuNpcResourceCore(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040055BA RID: 21946
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.GpuNpcResourceCore";

		// Token: 0x040055BB RID: 21947
		private static IntPtr _ClassPtr;

		// Token: 0x040055BC RID: 21948
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040055BD RID: 21949
		internal static int __PropertyOffset_CoreComponent;
	}
}
