using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021A0 RID: 8608
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UISafeZone")]
	[UnrealStructLayout(568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 568)]
	public class UUISafeZone : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020A5D RID: 133725 RVA: 0x00304FF6 File Offset: 0x003031F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISafeZone._ClassPtr;
		}

		// Token: 0x06020A5E RID: 133726 RVA: 0x00305004 File Offset: 0x00303204
		public UUISafeZone() : this(BuiltinUtils.AllocNativeUObject(UUISafeZone.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020A5F RID: 133727 RVA: 0x0030502C File Offset: 0x0030322C
		public UUISafeZone(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISafeZone.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F9C RID: 32668
		// (get) Token: 0x06020A60 RID: 133728 RVA: 0x0030505F File Offset: 0x0030325F
		// (set) Token: 0x06020A61 RID: 133729 RVA: 0x0030506F File Offset: 0x0030326F
		public unsafe ESafeZoneAdaptionStrategy AdaptionStrategy
		{
			get
			{
				return (ESafeZoneAdaptionStrategy)(*(base.NativePtr + (IntPtr)UUISafeZone.__PropertyOffset_AdaptionStrategy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISafeZone.__PropertyOffset_AdaptionStrategy) = (byte)value;
			}
		}

		// Token: 0x17007F9D RID: 32669
		// (get) Token: 0x06020A62 RID: 133730 RVA: 0x00305080 File Offset: 0x00303280
		// (set) Token: 0x06020A63 RID: 133731 RVA: 0x00305094 File Offset: 0x00303294
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISafeZone.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISafeZone.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x17007F9E RID: 32670
		// (get) Token: 0x06020A64 RID: 133732 RVA: 0x003050A9 File Offset: 0x003032A9
		// (set) Token: 0x06020A65 RID: 133733 RVA: 0x003050BD File Offset: 0x003032BD
		public unsafe FMargin DefaultMargin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISafeZone.__PropertyOffset_DefaultMargin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISafeZone.__PropertyOffset_DefaultMargin) = value;
			}
		}

		// Token: 0x17007F9F RID: 32671
		// (get) Token: 0x06020A66 RID: 133734 RVA: 0x003050D2 File Offset: 0x003032D2
		// (set) Token: 0x06020A67 RID: 133735 RVA: 0x003050E6 File Offset: 0x003032E6
		public unsafe FMargin PadMargin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISafeZone.__PropertyOffset_PadMargin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISafeZone.__PropertyOffset_PadMargin) = value;
			}
		}

		// Token: 0x17007FA0 RID: 32672
		// (get) Token: 0x06020A68 RID: 133736 RVA: 0x003050FB File Offset: 0x003032FB
		// (set) Token: 0x06020A69 RID: 133737 RVA: 0x0030510F File Offset: 0x0030330F
		public unsafe FMargin DefFoldableSquareMargin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISafeZone.__PropertyOffset_DefFoldableSquareMargin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISafeZone.__PropertyOffset_DefFoldableSquareMargin) = value;
			}
		}

		// Token: 0x17007FA1 RID: 32673
		// (get) Token: 0x06020A6A RID: 133738 RVA: 0x00305124 File Offset: 0x00303324
		// (set) Token: 0x06020A6B RID: 133739 RVA: 0x0030515D File Offset: 0x0030335D
		public TMap<string, FMargin> CustomDeviceMargins
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FMargin> result;
				if ((result = this._CustomDeviceMargins) == null)
				{
					result = (this._CustomDeviceMargins = new TMap<string, FMargin>(base.NativePtr + (IntPtr)UUISafeZone.__PropertyOffset_CustomDeviceMargins, this));
				}
				return result;
			}
			set
			{
				this.CustomDeviceMargins.CopyAssign(value);
			}
		}

		// Token: 0x17007FA2 RID: 32674
		// (get) Token: 0x06020A6C RID: 133740 RVA: 0x0030516B File Offset: 0x0030336B
		// (set) Token: 0x06020A6D RID: 133741 RVA: 0x0030517F File Offset: 0x0030337F
		[Nullable(2)]
		public unsafe ULGUICustomDeviceMarginsParam CustomDeviceMarginsParam
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUICustomDeviceMarginsParam>(base.NativePtr / (IntPtr)sizeof(void*) + UUISafeZone.__PropertyOffset_CustomDeviceMarginsParam);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISafeZone.__PropertyOffset_CustomDeviceMarginsParam, value);
			}
		}

		// Token: 0x17007FA3 RID: 32675
		// (get) Token: 0x06020A6E RID: 133742 RVA: 0x00305194 File Offset: 0x00303394
		// (set) Token: 0x06020A6F RID: 133743 RVA: 0x003051CD File Offset: 0x003033CD
		public TMap<string, FFoldableMargins> FoldableDeviceMargins
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FFoldableMargins> result;
				if ((result = this._FoldableDeviceMargins) == null)
				{
					result = (this._FoldableDeviceMargins = new TMap<string, FFoldableMargins>(base.NativePtr + (IntPtr)UUISafeZone.__PropertyOffset_FoldableDeviceMargins, this));
				}
				return result;
			}
			set
			{
				this.FoldableDeviceMargins.CopyAssign(value);
			}
		}

		// Token: 0x06020A70 RID: 133744 RVA: 0x003051DC File Offset: 0x003033DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetWidthAndHeightRadio(float Left = 0f, float Right = 0f, float Top = 0f, float Bottom = 0f)
		{
			UUISafeZone.__SetWidthAndHeightRadio_FunctionParams* ptr = stackalloc UUISafeZone.__SetWidthAndHeightRadio_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UUISafeZone.__SetWidthAndHeightRadio_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UUISafeZone.__SetWidthAndHeightRadio_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Left = Left;
			ptr->Right = Right;
			ptr->Top = Top;
			ptr->Bottom = Bottom;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UUISafeZone.__SetWidthAndHeightRadio_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020A71 RID: 133745 RVA: 0x00305239 File Offset: 0x00303439
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ForceApplyScreenAdaptation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UUISafeZone.__ForceApplyScreenAdaptation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020A72 RID: 133746 RVA: 0x0030524E File Offset: 0x0030344E
		static UUISafeZone()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISafeZone");
		}

		// Token: 0x06020A73 RID: 133747 RVA: 0x0030525C File Offset: 0x0030345C
		protected UUISafeZone(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011780 RID: 71552
		public new const string __ObjectPath = "/Script/LGUI.UISafeZone";

		// Token: 0x04011781 RID: 71553
		private static IntPtr _ClassPtr;

		// Token: 0x04011782 RID: 71554
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011783 RID: 71555
		internal static int __PropertyOffset_AdaptionStrategy;

		// Token: 0x04011784 RID: 71556
		internal static int __PropertyOffset_Padding;

		// Token: 0x04011785 RID: 71557
		internal static int __PropertyOffset_DefaultMargin;

		// Token: 0x04011786 RID: 71558
		internal static int __PropertyOffset_PadMargin;

		// Token: 0x04011787 RID: 71559
		internal static int __PropertyOffset_DefFoldableSquareMargin;

		// Token: 0x04011788 RID: 71560
		internal static int __PropertyOffset_CustomDeviceMargins;

		// Token: 0x04011789 RID: 71561
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FMargin> _CustomDeviceMargins;

		// Token: 0x0401178A RID: 71562
		internal static int __PropertyOffset_CustomDeviceMarginsParam;

		// Token: 0x0401178B RID: 71563
		internal static int __PropertyOffset_FoldableDeviceMargins;

		// Token: 0x0401178C RID: 71564
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FFoldableMargins> _FoldableDeviceMargins;

		// Token: 0x0401178D RID: 71565
		private static IntPtr __SetWidthAndHeightRadio_NativeFunctionPtr;

		// Token: 0x0401178E RID: 71566
		private static IntPtr __ForceApplyScreenAdaptation_NativeFunctionPtr;

		// Token: 0x02003501 RID: 13569
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetWidthAndHeightRadio_FunctionParams
		{
			// Token: 0x04017527 RID: 95527
			[FieldOffset(0)]
			public float Left;

			// Token: 0x04017528 RID: 95528
			[FieldOffset(4)]
			public float Right;

			// Token: 0x04017529 RID: 95529
			[FieldOffset(8)]
			public float Top;

			// Token: 0x0401752A RID: 95530
			[FieldOffset(12)]
			public float Bottom;
		}
	}
}
