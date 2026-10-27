using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200114E RID: 4430
	[UnrealObjectPath("/Script/Engine.SoundNodeSoundClass")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class USoundNodeSoundClass : USoundNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060102F3 RID: 66291 RVA: 0x0017D9A3 File Offset: 0x0017BBA3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeSoundClass._ClassPtr;
		}

		// Token: 0x060102F4 RID: 66292 RVA: 0x0017D9B0 File Offset: 0x0017BBB0
		public USoundNodeSoundClass() : this(BuiltinUtils.AllocNativeUObject(USoundNodeSoundClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060102F5 RID: 66293 RVA: 0x0017D9D8 File Offset: 0x0017BBD8
		[NullableContext(1)]
		public USoundNodeSoundClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeSoundClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F62 RID: 16226
		// (get) Token: 0x060102F6 RID: 66294 RVA: 0x0017DA0B File Offset: 0x0017BC0B
		// (set) Token: 0x060102F7 RID: 66295 RVA: 0x0017DA1F File Offset: 0x0017BC1F
		[Nullable(2)]
		public unsafe USoundClass SoundClassOverride
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundClass>(base.NativePtr / (IntPtr)sizeof(void*) + USoundNodeSoundClass.__PropertyOffset_SoundClassOverride);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USoundNodeSoundClass.__PropertyOffset_SoundClassOverride, value);
			}
		}

		// Token: 0x060102F8 RID: 66296 RVA: 0x0017DA34 File Offset: 0x0017BC34
		static USoundNodeSoundClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeSoundClass");
		}

		// Token: 0x060102F9 RID: 66297 RVA: 0x0017DA42 File Offset: 0x0017BC42
		protected USoundNodeSoundClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008B5A RID: 35674
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundNodeSoundClass";

		// Token: 0x04008B5B RID: 35675
		private static IntPtr _ClassPtr;

		// Token: 0x04008B5C RID: 35676
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008B5D RID: 35677
		internal static int __PropertyOffset_SoundClassOverride;
	}
}
