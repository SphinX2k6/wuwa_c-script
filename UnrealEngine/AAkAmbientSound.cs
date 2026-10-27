using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001E9 RID: 489
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkAmbientSound")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class AAkAmbientSound : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001CDE RID: 7390 RVA: 0x0002AFFC File Offset: 0x000291FC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AAkAmbientSound._ClassPtr;
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x0002B008 File Offset: 0x00029208
		public AAkAmbientSound() : this(BuiltinUtils.AllocNativeUObject(AAkAmbientSound.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x0002B030 File Offset: 0x00029230
		[NullableContext(1)]
		public AAkAmbientSound(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AAkAmbientSound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x0002B063 File Offset: 0x00029263
		// (set) Token: 0x06001CE2 RID: 7394 RVA: 0x0002B077 File Offset: 0x00029277
		public unsafe UAkAudioEvent AkAudioEvent_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + AAkAmbientSound.__PropertyOffset_AkAudioEvent_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AAkAmbientSound.__PropertyOffset_AkAudioEvent_DEPRECATED, value);
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x0002B08C File Offset: 0x0002928C
		// (set) Token: 0x06001CE4 RID: 7396 RVA: 0x0002B0A0 File Offset: 0x000292A0
		public unsafe UAkComponent AkComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AAkAmbientSound.__PropertyOffset_AkComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AAkAmbientSound.__PropertyOffset_AkComponent, value);
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x0002B0B5 File Offset: 0x000292B5
		// (set) Token: 0x06001CE6 RID: 7398 RVA: 0x0002B0C5 File Offset: 0x000292C5
		public unsafe bool StopWhenOwnerIsDestroyed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AAkAmbientSound.__PropertyOffset_StopWhenOwnerIsDestroyed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AAkAmbientSound.__PropertyOffset_StopWhenOwnerIsDestroyed) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06001CE7 RID: 7399 RVA: 0x0002B0D6 File Offset: 0x000292D6
		// (set) Token: 0x06001CE8 RID: 7400 RVA: 0x0002B0E6 File Offset: 0x000292E6
		public unsafe bool AutoPost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AAkAmbientSound.__PropertyOffset_AutoPost) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AAkAmbientSound.__PropertyOffset_AutoPost) = (value ? 1 : 0);
			}
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x0002B0F7 File Offset: 0x000292F7
		public void StopAmbientSound()
		{
			AAkAmbientSound.__StopAmbientSound_Internal(base.NativePtr);
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x0002B104 File Offset: 0x00029304
		public void StartAmbientSound()
		{
			AAkAmbientSound.__StartAmbientSound_Internal(base.NativePtr);
		}

		// Token: 0x06001CEB RID: 7403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAmbientSound_Internal(IntPtr @this);

		// Token: 0x06001CEC RID: 7404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartAmbientSound_Internal(IntPtr @this);

		// Token: 0x06001CED RID: 7405 RVA: 0x0002B111 File Offset: 0x00029311
		static AAkAmbientSound()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkAmbientSound");
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x0002B11F File Offset: 0x0002931F
		protected AAkAmbientSound(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000974 RID: 2420
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkAmbientSound";

		// Token: 0x04000975 RID: 2421
		private static IntPtr _ClassPtr;

		// Token: 0x04000976 RID: 2422
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000977 RID: 2423
		internal static int __PropertyOffset_AkAudioEvent_DEPRECATED;

		// Token: 0x04000978 RID: 2424
		internal static int __PropertyOffset_AkComponent;

		// Token: 0x04000979 RID: 2425
		internal static int __PropertyOffset_StopWhenOwnerIsDestroyed;

		// Token: 0x0400097A RID: 2426
		internal static int __PropertyOffset_AutoPost;
	}
}
