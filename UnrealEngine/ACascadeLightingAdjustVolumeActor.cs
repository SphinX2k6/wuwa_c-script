using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200091E RID: 2334
	[UnrealObjectPath("/Script/Engine.CascadeLightingAdjustVolumeActor")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class ACascadeLightingAdjustVolumeActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060080BD RID: 32957 RVA: 0x000B8945 File Offset: 0x000B6B45
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACascadeLightingAdjustVolumeActor._ClassPtr;
		}

		// Token: 0x060080BE RID: 32958 RVA: 0x000B8954 File Offset: 0x000B6B54
		public ACascadeLightingAdjustVolumeActor() : this(BuiltinUtils.AllocNativeUObject(ACascadeLightingAdjustVolumeActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060080BF RID: 32959 RVA: 0x000B897C File Offset: 0x000B6B7C
		[NullableContext(1)]
		public ACascadeLightingAdjustVolumeActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACascadeLightingAdjustVolumeActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E3B RID: 7739
		// (get) Token: 0x060080C0 RID: 32960 RVA: 0x000B89AF File Offset: 0x000B6BAF
		// (set) Token: 0x060080C1 RID: 32961 RVA: 0x000B89C3 File Offset: 0x000B6BC3
		[Nullable(2)]
		public unsafe UBoxComponent BoxComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACascadeLightingAdjustVolumeActor.__PropertyOffset_BoxComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACascadeLightingAdjustVolumeActor.__PropertyOffset_BoxComponent, value);
			}
		}

		// Token: 0x17001E3C RID: 7740
		// (get) Token: 0x060080C2 RID: 32962 RVA: 0x000B89D8 File Offset: 0x000B6BD8
		// (set) Token: 0x060080C3 RID: 32963 RVA: 0x000B89E8 File Offset: 0x000B6BE8
		public unsafe float IndirectLightingScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingAdjustVolumeActor.__PropertyOffset_IndirectLightingScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingAdjustVolumeActor.__PropertyOffset_IndirectLightingScale) = value;
			}
		}

		// Token: 0x17001E3D RID: 7741
		// (get) Token: 0x060080C4 RID: 32964 RVA: 0x000B89F9 File Offset: 0x000B6BF9
		// (set) Token: 0x060080C5 RID: 32965 RVA: 0x000B8A09 File Offset: 0x000B6C09
		public unsafe bool bEnableEditorPreview
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingAdjustVolumeActor.__PropertyOffset_bEnableEditorPreview) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingAdjustVolumeActor.__PropertyOffset_bEnableEditorPreview) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E3E RID: 7742
		// (get) Token: 0x060080C6 RID: 32966 RVA: 0x000B8A1A File Offset: 0x000B6C1A
		// (set) Token: 0x060080C7 RID: 32967 RVA: 0x000B8A2A File Offset: 0x000B6C2A
		public unsafe bool bApplyDuringBake
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingAdjustVolumeActor.__PropertyOffset_bApplyDuringBake) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingAdjustVolumeActor.__PropertyOffset_bApplyDuringBake) = (value ? 1 : 0);
			}
		}

		// Token: 0x060080C8 RID: 32968 RVA: 0x000B8A3B File Offset: 0x000B6C3B
		static ACascadeLightingAdjustVolumeActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CascadeLightingAdjustVolumeActor");
		}

		// Token: 0x060080C9 RID: 32969 RVA: 0x000B8A49 File Offset: 0x000B6C49
		protected ACascadeLightingAdjustVolumeActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003D94 RID: 15764
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CascadeLightingAdjustVolumeActor";

		// Token: 0x04003D95 RID: 15765
		private static IntPtr _ClassPtr;

		// Token: 0x04003D96 RID: 15766
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003D97 RID: 15767
		internal static int __PropertyOffset_BoxComponent;

		// Token: 0x04003D98 RID: 15768
		internal static int __PropertyOffset_IndirectLightingScale;

		// Token: 0x04003D99 RID: 15769
		internal static int __PropertyOffset_bEnableEditorPreview;

		// Token: 0x04003D9A RID: 15770
		internal static int __PropertyOffset_bApplyDuringBake;
	}
}
