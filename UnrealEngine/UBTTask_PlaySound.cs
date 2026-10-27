using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200015D RID: 349
	[UnrealObjectPath("/Script/AIModule.BTTask_PlaySound")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UBTTask_PlaySound : UBTTaskNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060017E9 RID: 6121 RVA: 0x00023383 File Offset: 0x00021583
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_PlaySound._ClassPtr;
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x00023390 File Offset: 0x00021590
		public UBTTask_PlaySound() : this(BuiltinUtils.AllocNativeUObject(UBTTask_PlaySound.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x000233B8 File Offset: 0x000215B8
		[NullableContext(1)]
		public UBTTask_PlaySound(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTTask_PlaySound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x000233EB File Offset: 0x000215EB
		// (set) Token: 0x060017ED RID: 6125 RVA: 0x000233FF File Offset: 0x000215FF
		[Nullable(2)]
		public unsafe USoundCue SoundToPlay
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundCue>(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_PlaySound.__PropertyOffset_SoundToPlay);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_PlaySound.__PropertyOffset_SoundToPlay, value);
			}
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x00023414 File Offset: 0x00021614
		static UBTTask_PlaySound()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTask_PlaySound");
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x00023422 File Offset: 0x00021622
		protected UBTTask_PlaySound(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005DA RID: 1498
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTTask_PlaySound";

		// Token: 0x040005DB RID: 1499
		private static IntPtr _ClassPtr;

		// Token: 0x040005DC RID: 1500
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040005DD RID: 1501
		internal static int __PropertyOffset_SoundToPlay;
	}
}
