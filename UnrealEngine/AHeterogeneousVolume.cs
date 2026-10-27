using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C1B RID: 3099
	[UnrealObjectPath("/Script/Engine.HeterogeneousVolume")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class AHeterogeneousVolume : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009C8C RID: 40076 RVA: 0x000DE9A8 File Offset: 0x000DCBA8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AHeterogeneousVolume._ClassPtr;
		}

		// Token: 0x06009C8D RID: 40077 RVA: 0x000DE9B4 File Offset: 0x000DCBB4
		public AHeterogeneousVolume() : this(BuiltinUtils.AllocNativeUObject(AHeterogeneousVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009C8E RID: 40078 RVA: 0x000DE9DC File Offset: 0x000DCBDC
		[NullableContext(1)]
		public AHeterogeneousVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AHeterogeneousVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002553 RID: 9555
		// (get) Token: 0x06009C8F RID: 40079 RVA: 0x000DEA0F File Offset: 0x000DCC0F
		// (set) Token: 0x06009C90 RID: 40080 RVA: 0x000DEA23 File Offset: 0x000DCC23
		[Nullable(2)]
		public unsafe UHeterogeneousVolumeComponent HeterogeneousVolumeComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHeterogeneousVolumeComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AHeterogeneousVolume.__PropertyOffset_HeterogeneousVolumeComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AHeterogeneousVolume.__PropertyOffset_HeterogeneousVolumeComponent, value);
			}
		}

		// Token: 0x06009C91 RID: 40081 RVA: 0x000DEA38 File Offset: 0x000DCC38
		static AHeterogeneousVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HeterogeneousVolume");
		}

		// Token: 0x06009C92 RID: 40082 RVA: 0x000DEA46 File Offset: 0x000DCC46
		protected AHeterogeneousVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005664 RID: 22116
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.HeterogeneousVolume";

		// Token: 0x04005665 RID: 22117
		private static IntPtr _ClassPtr;

		// Token: 0x04005666 RID: 22118
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005667 RID: 22119
		internal static int __PropertyOffset_HeterogeneousVolumeComponent;
	}
}
