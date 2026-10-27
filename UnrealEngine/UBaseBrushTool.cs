using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001538 RID: 5432
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.BaseBrushTool")]
	[UnrealStructLayout(504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 504)]
	public class UBaseBrushTool : UMeshSurfacePointTool, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013B93 RID: 80787 RVA: 0x001CF76A File Offset: 0x001CD96A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBaseBrushTool._ClassPtr;
		}

		// Token: 0x06013B94 RID: 80788 RVA: 0x001CF778 File Offset: 0x001CD978
		public UBaseBrushTool() : this(BuiltinUtils.AllocNativeUObject(UBaseBrushTool.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013B95 RID: 80789 RVA: 0x001CF7A0 File Offset: 0x001CD9A0
		public UBaseBrushTool(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBaseBrushTool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D3E RID: 19774
		// (get) Token: 0x06013B96 RID: 80790 RVA: 0x001CF7D3 File Offset: 0x001CD9D3
		// (set) Token: 0x06013B97 RID: 80791 RVA: 0x001CF7E7 File Offset: 0x001CD9E7
		[Nullable(2)]
		public unsafe UBrushBaseProperties BrushProperties
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBrushBaseProperties>(base.NativePtr / (IntPtr)sizeof(void*) + UBaseBrushTool.__PropertyOffset_BrushProperties);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBaseBrushTool.__PropertyOffset_BrushProperties, value);
			}
		}

		// Token: 0x17004D3F RID: 19775
		// (get) Token: 0x06013B98 RID: 80792 RVA: 0x001CF7FC File Offset: 0x001CD9FC
		// (set) Token: 0x06013B99 RID: 80793 RVA: 0x001CF80C File Offset: 0x001CDA0C
		public unsafe bool bInBrushStroke
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBaseBrushTool.__PropertyOffset_bInBrushStroke) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBaseBrushTool.__PropertyOffset_bInBrushStroke) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D40 RID: 19776
		// (get) Token: 0x06013B9A RID: 80794 RVA: 0x001CF81D File Offset: 0x001CDA1D
		// (set) Token: 0x06013B9B RID: 80795 RVA: 0x001CF82D File Offset: 0x001CDA2D
		public unsafe float WorldToLocalScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBaseBrushTool.__PropertyOffset_WorldToLocalScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBaseBrushTool.__PropertyOffset_WorldToLocalScale) = value;
			}
		}

		// Token: 0x17004D41 RID: 19777
		// (get) Token: 0x06013B9C RID: 80796 RVA: 0x001CF840 File Offset: 0x001CDA40
		// (set) Token: 0x06013B9D RID: 80797 RVA: 0x001CF879 File Offset: 0x001CDA79
		public FBrushStampData LastBrushStamp
		{
			get
			{
				base.FastCheckIsValid();
				FBrushStampData result;
				if ((result = this._LastBrushStamp) == null)
				{
					result = (this._LastBrushStamp = new FBrushStampData(base.NativePtr + (IntPtr)UBaseBrushTool.__PropertyOffset_LastBrushStamp, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBrushStampData.StaticStruct(), base.NativePtr + (IntPtr)UBaseBrushTool.__PropertyOffset_LastBrushStamp, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004D42 RID: 19778
		// (get) Token: 0x06013B9E RID: 80798 RVA: 0x001CF89A File Offset: 0x001CDA9A
		// (set) Token: 0x06013B9F RID: 80799 RVA: 0x001CF8AF File Offset: 0x001CDAAF
		public TSoftClassPtr<UBrushBaseProperties> PropertyClass
		{
			get
			{
				return new TSoftClassPtr<UBrushBaseProperties>(base.NativePtr + (IntPtr)UBaseBrushTool.__PropertyOffset_PropertyClass, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UBaseBrushTool.__PropertyOffset_PropertyClass, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17004D43 RID: 19779
		// (get) Token: 0x06013BA0 RID: 80800 RVA: 0x001CF8D4 File Offset: 0x001CDAD4
		// (set) Token: 0x06013BA1 RID: 80801 RVA: 0x001CF8E8 File Offset: 0x001CDAE8
		[Nullable(2)]
		public unsafe UBrushStampIndicator BrushStampIndicator
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBrushStampIndicator>(base.NativePtr / (IntPtr)sizeof(void*) + UBaseBrushTool.__PropertyOffset_BrushStampIndicator);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBaseBrushTool.__PropertyOffset_BrushStampIndicator, value);
			}
		}

		// Token: 0x06013BA2 RID: 80802 RVA: 0x001CF8FD File Offset: 0x001CDAFD
		static UBaseBrushTool()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.BaseBrushTool");
		}

		// Token: 0x06013BA3 RID: 80803 RVA: 0x001CF90B File Offset: 0x001CDB0B
		protected UBaseBrushTool(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AAB5 RID: 43701
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.BaseBrushTool";

		// Token: 0x0400AAB6 RID: 43702
		private static IntPtr _ClassPtr;

		// Token: 0x0400AAB7 RID: 43703
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AAB8 RID: 43704
		internal static int __PropertyOffset_BrushProperties;

		// Token: 0x0400AAB9 RID: 43705
		internal static int __PropertyOffset_bInBrushStroke;

		// Token: 0x0400AABA RID: 43706
		internal static int __PropertyOffset_WorldToLocalScale;

		// Token: 0x0400AABB RID: 43707
		internal static int __PropertyOffset_LastBrushStamp;

		// Token: 0x0400AABC RID: 43708
		[Nullable(2)]
		private FBrushStampData _LastBrushStamp;

		// Token: 0x0400AABD RID: 43709
		internal static int __PropertyOffset_PropertyClass;

		// Token: 0x0400AABE RID: 43710
		internal static int __PropertyOffset_BrushStampIndicator;
	}
}
