using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200277A RID: 10106
	[UnrealObjectPath("/Script/SimplygonUObjects.AttributeTessellationSettings")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAttributeTessellationSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025C71 RID: 154737 RVA: 0x00394516 File Offset: 0x00392716
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAttributeTessellationSettings._ScriptStructPtr != 0) ? FAttributeTessellationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.AttributeTessellationSettings", ref FAttributeTessellationSettings._ScriptStructPtr);
		}

		// Token: 0x17009174 RID: 37236
		// (get) Token: 0x06025C72 RID: 154738 RVA: 0x0039453A File Offset: 0x0039273A
		// (set) Token: 0x06025C73 RID: 154739 RVA: 0x00394553 File Offset: 0x00392753
		public unsafe bool EnableAttributeTessellation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_EnableAttributeTessellation) & FAttributeTessellationSettings.__PropertyMask_EnableAttributeTessellation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_EnableAttributeTessellation) = ((*(base.NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_EnableAttributeTessellation) & ~FAttributeTessellationSettings.__PropertyMask_EnableAttributeTessellation) | (value ? FAttributeTessellationSettings.__PropertyMask_EnableAttributeTessellation : 0));
			}
		}

		// Token: 0x17009175 RID: 37237
		// (get) Token: 0x06025C74 RID: 154740 RVA: 0x00394583 File Offset: 0x00392783
		// (set) Token: 0x06025C75 RID: 154741 RVA: 0x00394593 File Offset: 0x00392793
		public unsafe EAttributeTessellationDensityMode AttributeTessellationDensityMode
		{
			get
			{
				return (EAttributeTessellationDensityMode)(*(base.NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_AttributeTessellationDensityMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_AttributeTessellationDensityMode) = (byte)value;
			}
		}

		// Token: 0x17009176 RID: 37238
		// (get) Token: 0x06025C76 RID: 154742 RVA: 0x003945A4 File Offset: 0x003927A4
		// (set) Token: 0x06025C77 RID: 154743 RVA: 0x003945B4 File Offset: 0x003927B4
		public unsafe ETransformationSpace TransformationSpace
		{
			get
			{
				return (ETransformationSpace)(*(base.NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_TransformationSpace));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_TransformationSpace) = (byte)value;
			}
		}

		// Token: 0x17009177 RID: 37239
		// (get) Token: 0x06025C78 RID: 154744 RVA: 0x003945C5 File Offset: 0x003927C5
		// (set) Token: 0x06025C79 RID: 154745 RVA: 0x003945D5 File Offset: 0x003927D5
		public unsafe float MaxAreaOfTessellatedValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_MaxAreaOfTessellatedValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_MaxAreaOfTessellatedValue) = value;
			}
		}

		// Token: 0x17009178 RID: 37240
		// (get) Token: 0x06025C7A RID: 154746 RVA: 0x003945E6 File Offset: 0x003927E6
		// (set) Token: 0x06025C7B RID: 154747 RVA: 0x003945F6 File Offset: 0x003927F6
		public unsafe float MaxLengthOfTessellatedValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_MaxLengthOfTessellatedValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_MaxLengthOfTessellatedValue) = value;
			}
		}

		// Token: 0x17009179 RID: 37241
		// (get) Token: 0x06025C7C RID: 154748 RVA: 0x00394607 File Offset: 0x00392807
		// (set) Token: 0x06025C7D RID: 154749 RVA: 0x00394617 File Offset: 0x00392817
		public unsafe int OnScreenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_OnScreenSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_OnScreenSize) = value;
			}
		}

		// Token: 0x1700917A RID: 37242
		// (get) Token: 0x06025C7E RID: 154750 RVA: 0x00394628 File Offset: 0x00392828
		// (set) Token: 0x06025C7F RID: 154751 RVA: 0x00394641 File Offset: 0x00392841
		public unsafe bool OnlyAllowOneLevelOfDifference
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_OnlyAllowOneLevelOfDifference) & FAttributeTessellationSettings.__PropertyMask_OnlyAllowOneLevelOfDifference) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_OnlyAllowOneLevelOfDifference) = ((*(base.NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_OnlyAllowOneLevelOfDifference) & ~FAttributeTessellationSettings.__PropertyMask_OnlyAllowOneLevelOfDifference) | (value ? FAttributeTessellationSettings.__PropertyMask_OnlyAllowOneLevelOfDifference : 0));
			}
		}

		// Token: 0x1700917B RID: 37243
		// (get) Token: 0x06025C80 RID: 154752 RVA: 0x00394671 File Offset: 0x00392871
		// (set) Token: 0x06025C81 RID: 154753 RVA: 0x00394681 File Offset: 0x00392881
		public unsafe int MinTessellationLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_MinTessellationLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_MinTessellationLevel) = value;
			}
		}

		// Token: 0x1700917C RID: 37244
		// (get) Token: 0x06025C82 RID: 154754 RVA: 0x00394692 File Offset: 0x00392892
		// (set) Token: 0x06025C83 RID: 154755 RVA: 0x003946A2 File Offset: 0x003928A2
		public unsafe int MaxTessellationLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_MaxTessellationLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_MaxTessellationLevel) = value;
			}
		}

		// Token: 0x1700917D RID: 37245
		// (get) Token: 0x06025C84 RID: 154756 RVA: 0x003946B3 File Offset: 0x003928B3
		// (set) Token: 0x06025C85 RID: 154757 RVA: 0x003946C3 File Offset: 0x003928C3
		public unsafe int MaxTotalValuesCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_MaxTotalValuesCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAttributeTessellationSettings.__PropertyOffset_MaxTotalValuesCount) = value;
			}
		}

		// Token: 0x06025C86 RID: 154758 RVA: 0x003946D4 File Offset: 0x003928D4
		public FAttributeTessellationSettings()
		{
		}

		// Token: 0x06025C87 RID: 154759 RVA: 0x003946DC File Offset: 0x003928DC
		public FAttributeTessellationSettings(bool EnableAttributeTessellation, EAttributeTessellationDensityMode AttributeTessellationDensityMode, ETransformationSpace TransformationSpace, float MaxAreaOfTessellatedValue, float MaxLengthOfTessellatedValue, int OnScreenSize, bool OnlyAllowOneLevelOfDifference, int MinTessellationLevel, int MaxTessellationLevel, int MaxTotalValuesCount)
		{
			this.EnableAttributeTessellation = EnableAttributeTessellation;
			this.AttributeTessellationDensityMode = AttributeTessellationDensityMode;
			this.TransformationSpace = TransformationSpace;
			this.MaxAreaOfTessellatedValue = MaxAreaOfTessellatedValue;
			this.MaxLengthOfTessellatedValue = MaxLengthOfTessellatedValue;
			this.OnScreenSize = OnScreenSize;
			this.OnlyAllowOneLevelOfDifference = OnlyAllowOneLevelOfDifference;
			this.MinTessellationLevel = MinTessellationLevel;
			this.MaxTessellationLevel = MaxTessellationLevel;
			this.MaxTotalValuesCount = MaxTotalValuesCount;
		}

		// Token: 0x06025C88 RID: 154760 RVA: 0x0039473C File Offset: 0x0039293C
		protected override IntPtr GetUStructPtr()
		{
			return FAttributeTessellationSettings.StaticStruct();
		}

		// Token: 0x06025C89 RID: 154761 RVA: 0x00394748 File Offset: 0x00392948
		[NullableContext(2)]
		public FAttributeTessellationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025C8A RID: 154762 RVA: 0x00394752 File Offset: 0x00392952
		public FAttributeTessellationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025C8B RID: 154763 RVA: 0x0039475D File Offset: 0x0039295D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAttributeTessellationSettings(Pointer, false, true);
		}

		// Token: 0x06025C8C RID: 154764 RVA: 0x00394767 File Offset: 0x00392967
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAttributeTessellationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0401490E RID: 84238
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SimplygonUObjects.AttributeTessellationSettings";

		// Token: 0x0401490F RID: 84239
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014910 RID: 84240
		internal static int __PropertyOffset_EnableAttributeTessellation;

		// Token: 0x04014911 RID: 84241
		internal static byte __PropertyMask_EnableAttributeTessellation;

		// Token: 0x04014912 RID: 84242
		internal static int __PropertyOffset_AttributeTessellationDensityMode;

		// Token: 0x04014913 RID: 84243
		internal static int __PropertyOffset_TransformationSpace;

		// Token: 0x04014914 RID: 84244
		internal static int __PropertyOffset_MaxAreaOfTessellatedValue;

		// Token: 0x04014915 RID: 84245
		internal static int __PropertyOffset_MaxLengthOfTessellatedValue;

		// Token: 0x04014916 RID: 84246
		internal static int __PropertyOffset_OnScreenSize;

		// Token: 0x04014917 RID: 84247
		internal static int __PropertyOffset_OnlyAllowOneLevelOfDifference;

		// Token: 0x04014918 RID: 84248
		internal static byte __PropertyMask_OnlyAllowOneLevelOfDifference;

		// Token: 0x04014919 RID: 84249
		internal static int __PropertyOffset_MinTessellationLevel;

		// Token: 0x0401491A RID: 84250
		internal static int __PropertyOffset_MaxTessellationLevel;

		// Token: 0x0401491B RID: 84251
		internal static int __PropertyOffset_MaxTotalValuesCount;
	}
}
