using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001736 RID: 5942
	[UnrealObjectPath("/Script/KuroBullet.WorldBulletComponent")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UWorldBulletComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601563B RID: 87611 RVA: 0x001F6D3D File Offset: 0x001F4F3D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldBulletComponent._ClassPtr;
		}

		// Token: 0x0601563C RID: 87612 RVA: 0x001F6D4C File Offset: 0x001F4F4C
		public UWorldBulletComponent() : this(BuiltinUtils.AllocNativeUObject(UWorldBulletComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601563D RID: 87613 RVA: 0x001F6D74 File Offset: 0x001F4F74
		[NullableContext(1)]
		public UWorldBulletComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldBulletComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005482 RID: 21634
		// (get) Token: 0x0601563E RID: 87614 RVA: 0x001F6DA7 File Offset: 0x001F4FA7
		// (set) Token: 0x0601563F RID: 87615 RVA: 0x001F6DB7 File Offset: 0x001F4FB7
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldBulletComponent.__PropertyOffset_bEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldBulletComponent.__PropertyOffset_bEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005483 RID: 21635
		// (get) Token: 0x06015640 RID: 87616 RVA: 0x001F6DC8 File Offset: 0x001F4FC8
		// (set) Token: 0x06015641 RID: 87617 RVA: 0x001F6DD8 File Offset: 0x001F4FD8
		public unsafe EWorldBulletType WorldBulletType
		{
			get
			{
				return (EWorldBulletType)(*(base.NativePtr + (IntPtr)UWorldBulletComponent.__PropertyOffset_WorldBulletType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldBulletComponent.__PropertyOffset_WorldBulletType) = (byte)value;
			}
		}

		// Token: 0x06015642 RID: 87618 RVA: 0x001F6DE9 File Offset: 0x001F4FE9
		static UWorldBulletComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.WorldBulletComponent");
		}

		// Token: 0x06015643 RID: 87619 RVA: 0x001F6DF7 File Offset: 0x001F4FF7
		protected UWorldBulletComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BAA0 RID: 47776
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.WorldBulletComponent";

		// Token: 0x0400BAA1 RID: 47777
		private static IntPtr _ClassPtr;

		// Token: 0x0400BAA2 RID: 47778
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BAA3 RID: 47779
		internal static int __PropertyOffset_bEnable;

		// Token: 0x0400BAA4 RID: 47780
		internal static int __PropertyOffset_WorldBulletType;
	}
}
