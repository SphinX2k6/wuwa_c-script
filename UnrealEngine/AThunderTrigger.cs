using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C31 RID: 7217
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.ThunderTrigger")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class AThunderTrigger : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601BF74 RID: 114548 RVA: 0x002926CB File Offset: 0x002908CB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AThunderTrigger._ClassPtr;
		}

		// Token: 0x0601BF75 RID: 114549 RVA: 0x002926D8 File Offset: 0x002908D8
		public AThunderTrigger() : this(BuiltinUtils.AllocNativeUObject(AThunderTrigger.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601BF76 RID: 114550 RVA: 0x00292700 File Offset: 0x00290900
		[NullableContext(1)]
		public AThunderTrigger(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AThunderTrigger.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070F5 RID: 28917
		// (get) Token: 0x0601BF77 RID: 114551 RVA: 0x00292733 File Offset: 0x00290933
		// (set) Token: 0x0601BF78 RID: 114552 RVA: 0x00292743 File Offset: 0x00290943
		public unsafe int ThunderIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderTrigger.__PropertyOffset_ThunderIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderTrigger.__PropertyOffset_ThunderIndex) = value;
			}
		}

		// Token: 0x170070F6 RID: 28918
		// (get) Token: 0x0601BF79 RID: 114553 RVA: 0x00292754 File Offset: 0x00290954
		// (set) Token: 0x0601BF7A RID: 114554 RVA: 0x00292768 File Offset: 0x00290968
		public unsafe FVector2D ThunderPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderTrigger.__PropertyOffset_ThunderPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderTrigger.__PropertyOffset_ThunderPosition) = value;
			}
		}

		// Token: 0x170070F7 RID: 28919
		// (get) Token: 0x0601BF7B RID: 114555 RVA: 0x0029277D File Offset: 0x0029097D
		// (set) Token: 0x0601BF7C RID: 114556 RVA: 0x0029278D File Offset: 0x0029098D
		public unsafe float Emission
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderTrigger.__PropertyOffset_Emission);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderTrigger.__PropertyOffset_Emission) = value;
			}
		}

		// Token: 0x170070F8 RID: 28920
		// (get) Token: 0x0601BF7D RID: 114557 RVA: 0x0029279E File Offset: 0x0029099E
		// (set) Token: 0x0601BF7E RID: 114558 RVA: 0x002927AE File Offset: 0x002909AE
		public unsafe float SpeedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderTrigger.__PropertyOffset_SpeedScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderTrigger.__PropertyOffset_SpeedScale) = value;
			}
		}

		// Token: 0x170070F9 RID: 28921
		// (get) Token: 0x0601BF7F RID: 114559 RVA: 0x002927BF File Offset: 0x002909BF
		// (set) Token: 0x0601BF80 RID: 114560 RVA: 0x002927CF File Offset: 0x002909CF
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderTrigger.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderTrigger.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x170070FA RID: 28922
		// (get) Token: 0x0601BF81 RID: 114561 RVA: 0x002927E0 File Offset: 0x002909E0
		// (set) Token: 0x0601BF82 RID: 114562 RVA: 0x002927F0 File Offset: 0x002909F0
		public unsafe float Power
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderTrigger.__PropertyOffset_Power);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderTrigger.__PropertyOffset_Power) = value;
			}
		}

		// Token: 0x170070FB RID: 28923
		// (get) Token: 0x0601BF83 RID: 114563 RVA: 0x00292801 File Offset: 0x00290A01
		// (set) Token: 0x0601BF84 RID: 114564 RVA: 0x00292811 File Offset: 0x00290A11
		public unsafe float BrightnessLighting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderTrigger.__PropertyOffset_BrightnessLighting);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderTrigger.__PropertyOffset_BrightnessLighting) = value;
			}
		}

		// Token: 0x170070FC RID: 28924
		// (get) Token: 0x0601BF85 RID: 114565 RVA: 0x00292822 File Offset: 0x00290A22
		// (set) Token: 0x0601BF86 RID: 114566 RVA: 0x00292832 File Offset: 0x00290A32
		public unsafe float BrightnessCloudLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderTrigger.__PropertyOffset_BrightnessCloudLight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderTrigger.__PropertyOffset_BrightnessCloudLight) = value;
			}
		}

		// Token: 0x0601BF87 RID: 114567 RVA: 0x00292843 File Offset: 0x00290A43
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void TriggerThunderAttack()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AThunderTrigger.__TriggerThunderAttack_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601BF88 RID: 114568 RVA: 0x00292858 File Offset: 0x00290A58
		static AThunderTrigger()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.ThunderTrigger");
		}

		// Token: 0x0601BF89 RID: 114569 RVA: 0x00292866 File Offset: 0x00290A66
		protected AThunderTrigger(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F04A RID: 61514
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.ThunderTrigger";

		// Token: 0x0400F04B RID: 61515
		private static IntPtr _ClassPtr;

		// Token: 0x0400F04C RID: 61516
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F04D RID: 61517
		internal static int __PropertyOffset_ThunderIndex;

		// Token: 0x0400F04E RID: 61518
		internal static int __PropertyOffset_ThunderPosition;

		// Token: 0x0400F04F RID: 61519
		internal static int __PropertyOffset_Emission;

		// Token: 0x0400F050 RID: 61520
		internal static int __PropertyOffset_SpeedScale;

		// Token: 0x0400F051 RID: 61521
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400F052 RID: 61522
		internal static int __PropertyOffset_Power;

		// Token: 0x0400F053 RID: 61523
		internal static int __PropertyOffset_BrightnessLighting;

		// Token: 0x0400F054 RID: 61524
		internal static int __PropertyOffset_BrightnessCloudLight;

		// Token: 0x0400F055 RID: 61525
		private static IntPtr __TriggerThunderAttack_NativeFunctionPtr;
	}
}
