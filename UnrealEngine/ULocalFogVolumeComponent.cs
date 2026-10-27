using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D5F RID: 3423
	[UnrealObjectPath("/Script/Engine.LocalFogVolumeComponent")]
	[UnrealStructLayout(640, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 640)]
	public class ULocalFogVolumeComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B8D6 RID: 47318 RVA: 0x001071E3 File Offset: 0x001053E3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULocalFogVolumeComponent._ClassPtr;
		}

		// Token: 0x0600B8D7 RID: 47319 RVA: 0x001071F0 File Offset: 0x001053F0
		public ULocalFogVolumeComponent() : this(BuiltinUtils.AllocNativeUObject(ULocalFogVolumeComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B8D8 RID: 47320 RVA: 0x00107218 File Offset: 0x00105418
		[NullableContext(1)]
		public ULocalFogVolumeComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULocalFogVolumeComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A56 RID: 10838
		// (get) Token: 0x0600B8D9 RID: 47321 RVA: 0x0010724B File Offset: 0x0010544B
		// (set) Token: 0x0600B8DA RID: 47322 RVA: 0x0010725B File Offset: 0x0010545B
		public unsafe float RadialFogExtinction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULocalFogVolumeComponent.__PropertyOffset_RadialFogExtinction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULocalFogVolumeComponent.__PropertyOffset_RadialFogExtinction) = value;
			}
		}

		// Token: 0x17002A57 RID: 10839
		// (get) Token: 0x0600B8DB RID: 47323 RVA: 0x0010726C File Offset: 0x0010546C
		// (set) Token: 0x0600B8DC RID: 47324 RVA: 0x0010727C File Offset: 0x0010547C
		public unsafe float HeightFogExtinction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULocalFogVolumeComponent.__PropertyOffset_HeightFogExtinction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULocalFogVolumeComponent.__PropertyOffset_HeightFogExtinction) = value;
			}
		}

		// Token: 0x17002A58 RID: 10840
		// (get) Token: 0x0600B8DD RID: 47325 RVA: 0x0010728D File Offset: 0x0010548D
		// (set) Token: 0x0600B8DE RID: 47326 RVA: 0x0010729D File Offset: 0x0010549D
		public unsafe float HeightFogFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULocalFogVolumeComponent.__PropertyOffset_HeightFogFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULocalFogVolumeComponent.__PropertyOffset_HeightFogFalloff) = value;
			}
		}

		// Token: 0x17002A59 RID: 10841
		// (get) Token: 0x0600B8DF RID: 47327 RVA: 0x001072AE File Offset: 0x001054AE
		// (set) Token: 0x0600B8E0 RID: 47328 RVA: 0x001072BE File Offset: 0x001054BE
		public unsafe float HeightFogOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULocalFogVolumeComponent.__PropertyOffset_HeightFogOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULocalFogVolumeComponent.__PropertyOffset_HeightFogOffset) = value;
			}
		}

		// Token: 0x17002A5A RID: 10842
		// (get) Token: 0x0600B8E1 RID: 47329 RVA: 0x001072CF File Offset: 0x001054CF
		// (set) Token: 0x0600B8E2 RID: 47330 RVA: 0x001072DF File Offset: 0x001054DF
		public unsafe float FogPhaseG
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULocalFogVolumeComponent.__PropertyOffset_FogPhaseG);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULocalFogVolumeComponent.__PropertyOffset_FogPhaseG) = value;
			}
		}

		// Token: 0x17002A5B RID: 10843
		// (get) Token: 0x0600B8E3 RID: 47331 RVA: 0x001072F0 File Offset: 0x001054F0
		// (set) Token: 0x0600B8E4 RID: 47332 RVA: 0x00107304 File Offset: 0x00105504
		public unsafe FLinearColor FogAlbedo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULocalFogVolumeComponent.__PropertyOffset_FogAlbedo);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULocalFogVolumeComponent.__PropertyOffset_FogAlbedo) = value;
			}
		}

		// Token: 0x17002A5C RID: 10844
		// (get) Token: 0x0600B8E5 RID: 47333 RVA: 0x00107319 File Offset: 0x00105519
		// (set) Token: 0x0600B8E6 RID: 47334 RVA: 0x0010732D File Offset: 0x0010552D
		public unsafe FLinearColor FogEmissive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULocalFogVolumeComponent.__PropertyOffset_FogEmissive);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULocalFogVolumeComponent.__PropertyOffset_FogEmissive) = value;
			}
		}

		// Token: 0x17002A5D RID: 10845
		// (get) Token: 0x0600B8E7 RID: 47335 RVA: 0x00107342 File Offset: 0x00105542
		// (set) Token: 0x0600B8E8 RID: 47336 RVA: 0x00107352 File Offset: 0x00105552
		public unsafe int FogSortPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULocalFogVolumeComponent.__PropertyOffset_FogSortPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULocalFogVolumeComponent.__PropertyOffset_FogSortPriority) = value;
			}
		}

		// Token: 0x17002A5E RID: 10846
		// (get) Token: 0x0600B8E9 RID: 47337 RVA: 0x00107363 File Offset: 0x00105563
		// (set) Token: 0x0600B8EA RID: 47338 RVA: 0x00107373 File Offset: 0x00105573
		public unsafe float FogCullDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULocalFogVolumeComponent.__PropertyOffset_FogCullDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULocalFogVolumeComponent.__PropertyOffset_FogCullDistance) = value;
			}
		}

		// Token: 0x0600B8EB RID: 47339 RVA: 0x00107384 File Offset: 0x00105584
		public void SetRadialFogExtinction(float NewValue)
		{
			ULocalFogVolumeComponent.__SetRadialFogExtinction_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600B8EC RID: 47340 RVA: 0x00107392 File Offset: 0x00105592
		public void SetHeightFogOffset(float NewValue)
		{
			ULocalFogVolumeComponent.__SetHeightFogOffset_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600B8ED RID: 47341 RVA: 0x001073A0 File Offset: 0x001055A0
		public void SetHeightFogFalloff(float NewValue)
		{
			ULocalFogVolumeComponent.__SetHeightFogFalloff_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600B8EE RID: 47342 RVA: 0x001073AE File Offset: 0x001055AE
		public void SetHeightFogExtinction(float NewValue)
		{
			ULocalFogVolumeComponent.__SetHeightFogExtinction_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600B8EF RID: 47343 RVA: 0x001073BC File Offset: 0x001055BC
		public void SetFogPhaseG(float NewValue)
		{
			ULocalFogVolumeComponent.__SetFogPhaseG_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600B8F0 RID: 47344 RVA: 0x001073CA File Offset: 0x001055CA
		public void SetFogEmissive(FLinearColor NewValue)
		{
			ULocalFogVolumeComponent.__SetFogEmissive_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600B8F1 RID: 47345 RVA: 0x001073D8 File Offset: 0x001055D8
		public void SetFogCullDistance(float NewValue)
		{
			ULocalFogVolumeComponent.__SetFogCullDistance_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600B8F2 RID: 47346 RVA: 0x001073E6 File Offset: 0x001055E6
		public void SetFogAlbedo(FLinearColor NewValue)
		{
			ULocalFogVolumeComponent.__SetFogAlbedo_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600B8F3 RID: 47347
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRadialFogExtinction_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600B8F4 RID: 47348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHeightFogOffset_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600B8F5 RID: 47349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHeightFogFalloff_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600B8F6 RID: 47350
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHeightFogExtinction_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600B8F7 RID: 47351
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFogPhaseG_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600B8F8 RID: 47352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFogEmissive_Internal(IntPtr @this, FLinearColor NewValue);

		// Token: 0x0600B8F9 RID: 47353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFogCullDistance_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600B8FA RID: 47354
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFogAlbedo_Internal(IntPtr @this, FLinearColor NewValue);

		// Token: 0x0600B8FB RID: 47355 RVA: 0x001073F4 File Offset: 0x001055F4
		static ULocalFogVolumeComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LocalFogVolumeComponent");
		}

		// Token: 0x0600B8FC RID: 47356 RVA: 0x00107402 File Offset: 0x00105602
		protected ULocalFogVolumeComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040060DF RID: 24799
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LocalFogVolumeComponent";

		// Token: 0x040060E0 RID: 24800
		private static IntPtr _ClassPtr;

		// Token: 0x040060E1 RID: 24801
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040060E2 RID: 24802
		internal static int __PropertyOffset_RadialFogExtinction;

		// Token: 0x040060E3 RID: 24803
		internal static int __PropertyOffset_HeightFogExtinction;

		// Token: 0x040060E4 RID: 24804
		internal static int __PropertyOffset_HeightFogFalloff;

		// Token: 0x040060E5 RID: 24805
		internal static int __PropertyOffset_HeightFogOffset;

		// Token: 0x040060E6 RID: 24806
		internal static int __PropertyOffset_FogPhaseG;

		// Token: 0x040060E7 RID: 24807
		internal static int __PropertyOffset_FogAlbedo;

		// Token: 0x040060E8 RID: 24808
		internal static int __PropertyOffset_FogEmissive;

		// Token: 0x040060E9 RID: 24809
		internal static int __PropertyOffset_FogSortPriority;

		// Token: 0x040060EA RID: 24810
		internal static int __PropertyOffset_FogCullDistance;
	}
}
