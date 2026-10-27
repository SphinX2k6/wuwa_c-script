using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FCD RID: 4045
	[UnrealObjectPath("/Script/Engine.PassiveSoundMixModifier")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPassiveSoundMixModifier : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600DA3D RID: 55869 RVA: 0x00142131 File Offset: 0x00140331
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPassiveSoundMixModifier._ScriptStructPtr != 0) ? FPassiveSoundMixModifier._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PassiveSoundMixModifier", ref FPassiveSoundMixModifier._ScriptStructPtr);
		}

		// Token: 0x17003387 RID: 13191
		// (get) Token: 0x0600DA3E RID: 55870 RVA: 0x00142155 File Offset: 0x00140355
		// (set) Token: 0x0600DA3F RID: 55871 RVA: 0x00142169 File Offset: 0x00140369
		[Nullable(2)]
		public unsafe USoundMix SoundMix
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundMix>(base.NativePtr / (IntPtr)sizeof(void*) + FPassiveSoundMixModifier.__PropertyOffset_SoundMix);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPassiveSoundMixModifier.__PropertyOffset_SoundMix, value);
			}
		}

		// Token: 0x17003388 RID: 13192
		// (get) Token: 0x0600DA40 RID: 55872 RVA: 0x0014217E File Offset: 0x0014037E
		// (set) Token: 0x0600DA41 RID: 55873 RVA: 0x0014218E File Offset: 0x0014038E
		public unsafe float MinVolumeThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPassiveSoundMixModifier.__PropertyOffset_MinVolumeThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPassiveSoundMixModifier.__PropertyOffset_MinVolumeThreshold) = value;
			}
		}

		// Token: 0x17003389 RID: 13193
		// (get) Token: 0x0600DA42 RID: 55874 RVA: 0x0014219F File Offset: 0x0014039F
		// (set) Token: 0x0600DA43 RID: 55875 RVA: 0x001421AF File Offset: 0x001403AF
		public unsafe float MaxVolumeThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPassiveSoundMixModifier.__PropertyOffset_MaxVolumeThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPassiveSoundMixModifier.__PropertyOffset_MaxVolumeThreshold) = value;
			}
		}

		// Token: 0x0600DA44 RID: 55876 RVA: 0x001421C0 File Offset: 0x001403C0
		public FPassiveSoundMixModifier()
		{
		}

		// Token: 0x0600DA45 RID: 55877 RVA: 0x001421C8 File Offset: 0x001403C8
		[NullableContext(1)]
		public FPassiveSoundMixModifier(USoundMix SoundMix, float MinVolumeThreshold, float MaxVolumeThreshold)
		{
			this.SoundMix = SoundMix;
			this.MinVolumeThreshold = MinVolumeThreshold;
			this.MaxVolumeThreshold = MaxVolumeThreshold;
		}

		// Token: 0x0600DA46 RID: 55878 RVA: 0x001421E5 File Offset: 0x001403E5
		protected override IntPtr GetUStructPtr()
		{
			return FPassiveSoundMixModifier.StaticStruct();
		}

		// Token: 0x0600DA47 RID: 55879 RVA: 0x001421F1 File Offset: 0x001403F1
		[NullableContext(2)]
		public FPassiveSoundMixModifier(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DA48 RID: 55880 RVA: 0x001421FB File Offset: 0x001403FB
		public FPassiveSoundMixModifier(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DA49 RID: 55881 RVA: 0x00142206 File Offset: 0x00140406
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPassiveSoundMixModifier(Pointer, false, true);
		}

		// Token: 0x0600DA4A RID: 55882 RVA: 0x00142210 File Offset: 0x00140410
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPassiveSoundMixModifier(Pointer, MemoryOwner);
		}

		// Token: 0x04007650 RID: 30288
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PassiveSoundMixModifier";

		// Token: 0x04007651 RID: 30289
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007652 RID: 30290
		internal static int __PropertyOffset_SoundMix;

		// Token: 0x04007653 RID: 30291
		internal static int __PropertyOffset_MinVolumeThreshold;

		// Token: 0x04007654 RID: 30292
		internal static int __PropertyOffset_MaxVolumeThreshold;
	}
}
