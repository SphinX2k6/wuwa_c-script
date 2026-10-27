using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D19 RID: 3353
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LandScapeFolderCheck")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLandScapeFolderCheck : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B3BC RID: 46012 RVA: 0x001005E1 File Offset: 0x000FE7E1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLandScapeFolderCheck._ScriptStructPtr != 0) ? FLandScapeFolderCheck._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LandScapeFolderCheck", ref FLandScapeFolderCheck._ScriptStructPtr);
		}

		// Token: 0x17002917 RID: 10519
		// (get) Token: 0x0600B3BD RID: 46013 RVA: 0x00100608 File Offset: 0x000FE808
		// (set) Token: 0x0600B3BE RID: 46014 RVA: 0x0010064B File Offset: 0x000FE84B
		public TArray<string> SpecifiedClassName
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SpecifiedClassName) == null)
				{
					result = (this._SpecifiedClassName = new TArray<string>(base.NativePtr + (IntPtr)FLandScapeFolderCheck.__PropertyOffset_SpecifiedClassName, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpecifiedClassName.CopyAssign(value);
			}
		}

		// Token: 0x17002918 RID: 10520
		// (get) Token: 0x0600B3BF RID: 46015 RVA: 0x00100659 File Offset: 0x000FE859
		// (set) Token: 0x0600B3C0 RID: 46016 RVA: 0x00100669 File Offset: 0x000FE869
		public unsafe float CommonScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandScapeFolderCheck.__PropertyOffset_CommonScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandScapeFolderCheck.__PropertyOffset_CommonScale) = value;
			}
		}

		// Token: 0x17002919 RID: 10521
		// (get) Token: 0x0600B3C1 RID: 46017 RVA: 0x0010067A File Offset: 0x000FE87A
		// (set) Token: 0x0600B3C2 RID: 46018 RVA: 0x0010068A File Offset: 0x000FE88A
		public unsafe int ComponentSizeQuads
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandScapeFolderCheck.__PropertyOffset_ComponentSizeQuads);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandScapeFolderCheck.__PropertyOffset_ComponentSizeQuads) = value;
			}
		}

		// Token: 0x1700291A RID: 10522
		// (get) Token: 0x0600B3C3 RID: 46019 RVA: 0x0010069B File Offset: 0x000FE89B
		// (set) Token: 0x0600B3C4 RID: 46020 RVA: 0x001006AB File Offset: 0x000FE8AB
		public unsafe int CommonNumSubSections
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandScapeFolderCheck.__PropertyOffset_CommonNumSubSections);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandScapeFolderCheck.__PropertyOffset_CommonNumSubSections) = value;
			}
		}

		// Token: 0x1700291B RID: 10523
		// (get) Token: 0x0600B3C5 RID: 46021 RVA: 0x001006BC File Offset: 0x000FE8BC
		// (set) Token: 0x0600B3C6 RID: 46022 RVA: 0x001006CC File Offset: 0x000FE8CC
		public unsafe float RecommendRateDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandScapeFolderCheck.__PropertyOffset_RecommendRateDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandScapeFolderCheck.__PropertyOffset_RecommendRateDensity) = value;
			}
		}

		// Token: 0x1700291C RID: 10524
		// (get) Token: 0x0600B3C7 RID: 46023 RVA: 0x001006DD File Offset: 0x000FE8DD
		// (set) Token: 0x0600B3C8 RID: 46024 RVA: 0x001006ED File Offset: 0x000FE8ED
		public unsafe float CommonLOD0ScreenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandScapeFolderCheck.__PropertyOffset_CommonLOD0ScreenSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandScapeFolderCheck.__PropertyOffset_CommonLOD0ScreenSize) = value;
			}
		}

		// Token: 0x1700291D RID: 10525
		// (get) Token: 0x0600B3C9 RID: 46025 RVA: 0x001006FE File Offset: 0x000FE8FE
		// (set) Token: 0x0600B3CA RID: 46026 RVA: 0x0010070E File Offset: 0x000FE90E
		public unsafe float CommonLOD0DistributionSetting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandScapeFolderCheck.__PropertyOffset_CommonLOD0DistributionSetting);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandScapeFolderCheck.__PropertyOffset_CommonLOD0DistributionSetting) = value;
			}
		}

		// Token: 0x1700291E RID: 10526
		// (get) Token: 0x0600B3CB RID: 46027 RVA: 0x0010071F File Offset: 0x000FE91F
		// (set) Token: 0x0600B3CC RID: 46028 RVA: 0x0010072F File Offset: 0x000FE92F
		public unsafe float CommonLODDistributionSetting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandScapeFolderCheck.__PropertyOffset_CommonLODDistributionSetting);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandScapeFolderCheck.__PropertyOffset_CommonLODDistributionSetting) = value;
			}
		}

		// Token: 0x0600B3CD RID: 46029 RVA: 0x00100740 File Offset: 0x000FE940
		public FLandScapeFolderCheck()
		{
		}

		// Token: 0x0600B3CE RID: 46030 RVA: 0x00100748 File Offset: 0x000FE948
		public FLandScapeFolderCheck(TArray<string> SpecifiedClassName, float CommonScale, int ComponentSizeQuads, int CommonNumSubSections, float RecommendRateDensity, float CommonLOD0ScreenSize, float CommonLOD0DistributionSetting, float CommonLODDistributionSetting)
		{
			this.SpecifiedClassName = SpecifiedClassName;
			this.CommonScale = CommonScale;
			this.ComponentSizeQuads = ComponentSizeQuads;
			this.CommonNumSubSections = CommonNumSubSections;
			this.RecommendRateDensity = RecommendRateDensity;
			this.CommonLOD0ScreenSize = CommonLOD0ScreenSize;
			this.CommonLOD0DistributionSetting = CommonLOD0DistributionSetting;
			this.CommonLODDistributionSetting = CommonLODDistributionSetting;
		}

		// Token: 0x0600B3CF RID: 46031 RVA: 0x00100798 File Offset: 0x000FE998
		protected override IntPtr GetUStructPtr()
		{
			return FLandScapeFolderCheck.StaticStruct();
		}

		// Token: 0x0600B3D0 RID: 46032 RVA: 0x001007A4 File Offset: 0x000FE9A4
		[NullableContext(2)]
		public FLandScapeFolderCheck(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B3D1 RID: 46033 RVA: 0x001007AE File Offset: 0x000FE9AE
		public FLandScapeFolderCheck(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B3D2 RID: 46034 RVA: 0x001007B9 File Offset: 0x000FE9B9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLandScapeFolderCheck(Pointer, false, true);
		}

		// Token: 0x0600B3D3 RID: 46035 RVA: 0x001007C3 File Offset: 0x000FE9C3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLandScapeFolderCheck(Pointer, MemoryOwner);
		}

		// Token: 0x04005E7E RID: 24190
		public const string __ObjectPath = "/Script/Engine.LandScapeFolderCheck";

		// Token: 0x04005E7F RID: 24191
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005E80 RID: 24192
		internal static int __PropertyOffset_SpecifiedClassName;

		// Token: 0x04005E81 RID: 24193
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SpecifiedClassName;

		// Token: 0x04005E82 RID: 24194
		internal static int __PropertyOffset_CommonScale;

		// Token: 0x04005E83 RID: 24195
		internal static int __PropertyOffset_ComponentSizeQuads;

		// Token: 0x04005E84 RID: 24196
		internal static int __PropertyOffset_CommonNumSubSections;

		// Token: 0x04005E85 RID: 24197
		internal static int __PropertyOffset_RecommendRateDensity;

		// Token: 0x04005E86 RID: 24198
		internal static int __PropertyOffset_CommonLOD0ScreenSize;

		// Token: 0x04005E87 RID: 24199
		internal static int __PropertyOffset_CommonLOD0DistributionSetting;

		// Token: 0x04005E88 RID: 24200
		internal static int __PropertyOffset_CommonLODDistributionSetting;
	}
}
