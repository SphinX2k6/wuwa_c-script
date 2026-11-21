using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000708 RID: 1800
	[UnrealObjectPath("/Script/LGUI.UIGridLayout")]
	[UnrealStructLayout(480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class UUIGridLayout : UUILayoutWithAnimation, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009929 RID: 39209 RVA: 0x000E6A6D File Offset: 0x000E4C6D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIGridLayout._ClassPtr;
		}

		// Token: 0x0600992A RID: 39210 RVA: 0x000E6A7C File Offset: 0x000E4C7C
		public UUIGridLayout() : this(BuiltinUtils.AllocNativeUObject(UUIGridLayout.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600992B RID: 39211 RVA: 0x000E6AA4 File Offset: 0x000E4CA4
		[NullableContext(1)]
		public UUIGridLayout(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIGridLayout.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C78 RID: 7288
		// (get) Token: 0x0600992C RID: 39212 RVA: 0x000E6AD7 File Offset: 0x000E4CD7
		// (set) Token: 0x0600992D RID: 39213 RVA: 0x000E6AEB File Offset: 0x000E4CEB
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x17001C79 RID: 7289
		// (get) Token: 0x0600992E RID: 39214 RVA: 0x000E6B00 File Offset: 0x000E4D00
		// (set) Token: 0x0600992F RID: 39215 RVA: 0x000E6B14 File Offset: 0x000E4D14
		public unsafe FVector2D Spacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_Spacing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_Spacing) = value;
			}
		}

		// Token: 0x17001C7A RID: 7290
		// (get) Token: 0x06009930 RID: 39216 RVA: 0x000E6B29 File Offset: 0x000E4D29
		// (set) Token: 0x06009931 RID: 39217 RVA: 0x000E6B39 File Offset: 0x000E4D39
		public unsafe ELGUILayoutAlignmentType Align
		{
			get
			{
				return (ELGUILayoutAlignmentType)(*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_Align));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_Align) = (byte)value;
			}
		}

		// Token: 0x17001C7B RID: 7291
		// (get) Token: 0x06009932 RID: 39218 RVA: 0x000E6B4A File Offset: 0x000E4D4A
		// (set) Token: 0x06009933 RID: 39219 RVA: 0x000E6B5A File Offset: 0x000E4D5A
		public unsafe bool LastLineCanAlign
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_LastLineCanAlign) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_LastLineCanAlign) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x06009934 RID: 39220 RVA: 0x000E6B6B File Offset: 0x000E4D6B
		// (set) Token: 0x06009935 RID: 39221 RVA: 0x000E6B7B File Offset: 0x000E4D7B
		public unsafe bool HorizontalOrVertical
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_HorizontalOrVertical) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_HorizontalOrVertical) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C7D RID: 7293
		// (get) Token: 0x06009936 RID: 39222 RVA: 0x000E6B8C File Offset: 0x000E4D8C
		// (set) Token: 0x06009937 RID: 39223 RVA: 0x000E6B9C File Offset: 0x000E4D9C
		public unsafe bool DependOnSizeOrCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_DependOnSizeOrCount) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_DependOnSizeOrCount) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x06009938 RID: 39224 RVA: 0x000E6BAD File Offset: 0x000E4DAD
		// (set) Token: 0x06009939 RID: 39225 RVA: 0x000E6BBD File Offset: 0x000E4DBD
		public unsafe bool ExpendChildSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_ExpendChildSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_ExpendChildSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x0600993A RID: 39226 RVA: 0x000E6BCE File Offset: 0x000E4DCE
		// (set) Token: 0x0600993B RID: 39227 RVA: 0x000E6BE2 File Offset: 0x000E4DE2
		public unsafe FVector2D CellSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_CellSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_CellSize) = value;
			}
		}

		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x0600993C RID: 39228 RVA: 0x000E6BF7 File Offset: 0x000E4DF7
		// (set) Token: 0x0600993D RID: 39229 RVA: 0x000E6C07 File Offset: 0x000E4E07
		public unsafe uint LineCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_LineCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_LineCount) = (int)value;
			}
		}

		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x0600993E RID: 39230 RVA: 0x000E6C18 File Offset: 0x000E4E18
		// (set) Token: 0x0600993F RID: 39231 RVA: 0x000E6C28 File Offset: 0x000E4E28
		public unsafe bool WidthFitToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_WidthFitToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_WidthFitToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x06009940 RID: 39232 RVA: 0x000E6C39 File Offset: 0x000E4E39
		// (set) Token: 0x06009941 RID: 39233 RVA: 0x000E6C49 File Offset: 0x000E4E49
		public unsafe bool HeightFitToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_HeightFitToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_HeightFitToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C83 RID: 7299
		// (get) Token: 0x06009942 RID: 39234 RVA: 0x000E6C5A File Offset: 0x000E4E5A
		// (set) Token: 0x06009943 RID: 39235 RVA: 0x000E6C6E File Offset: 0x000E4E6E
		public unsafe FVector2D CellScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_CellScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_CellScale) = value;
			}
		}

		// Token: 0x06009944 RID: 39236 RVA: 0x000E6C83 File Offset: 0x000E4E83
		public void SetWidthFitToChildren(bool value)
		{
			UUIGridLayout.__SetWidthFitToChildren_Internal(base.NativePtr, value);
		}

		// Token: 0x06009945 RID: 39237 RVA: 0x000E6C91 File Offset: 0x000E4E91
		public void SetSpacing(FVector2D value)
		{
			UUIGridLayout.__SetSpacing_Internal(base.NativePtr, value);
		}

		// Token: 0x06009946 RID: 39238 RVA: 0x000E6C9F File Offset: 0x000E4E9F
		public void SetPadding(FMargin value)
		{
			UUIGridLayout.__SetPadding_Internal(base.NativePtr, value);
		}

		// Token: 0x06009947 RID: 39239 RVA: 0x000E6CAD File Offset: 0x000E4EAD
		public void SetMaxItemCountInOneLine(int value)
		{
			UUIGridLayout.__SetMaxItemCountInOneLine_Internal(base.NativePtr, value);
		}

		// Token: 0x06009948 RID: 39240 RVA: 0x000E6CBB File Offset: 0x000E4EBB
		public void SetLineCount(int value)
		{
			UUIGridLayout.__SetLineCount_Internal(base.NativePtr, value);
		}

		// Token: 0x06009949 RID: 39241 RVA: 0x000E6CC9 File Offset: 0x000E4EC9
		public void SetLastLineCanAlign(bool value)
		{
			UUIGridLayout.__SetLastLineCanAlign_Internal(base.NativePtr, value);
		}

		// Token: 0x0600994A RID: 39242 RVA: 0x000E6CD7 File Offset: 0x000E4ED7
		public void SetHeightFitToChildren(bool value)
		{
			UUIGridLayout.__SetHeightFitToChildren_Internal(base.NativePtr, value);
		}

		// Token: 0x0600994B RID: 39243 RVA: 0x000E6CE5 File Offset: 0x000E4EE5
		public void SetExpendChildSize(bool value)
		{
			UUIGridLayout.__SetExpendChildSize_Internal(base.NativePtr, value);
		}

		// Token: 0x0600994C RID: 39244 RVA: 0x000E6CF3 File Offset: 0x000E4EF3
		public void SetDependOnSizeOrCount(bool value)
		{
			UUIGridLayout.__SetDependOnSizeOrCount_Internal(base.NativePtr, value);
		}

		// Token: 0x0600994D RID: 39245 RVA: 0x000E6D01 File Offset: 0x000E4F01
		public void SetCellSize(FVector2D value)
		{
			UUIGridLayout.__SetCellSize_Internal(base.NativePtr, value);
		}

		// Token: 0x0600994E RID: 39246 RVA: 0x000E6D0F File Offset: 0x000E4F0F
		public void SetCellScale(FVector2D value)
		{
			UUIGridLayout.__SetCellScale_Internal(base.NativePtr, value);
		}

		// Token: 0x0600994F RID: 39247 RVA: 0x000E6D1D File Offset: 0x000E4F1D
		public void SetAlign(ELGUILayoutAlignmentType value)
		{
			UUIGridLayout.__SetAlign_Internal(base.NativePtr, value);
		}

		// Token: 0x06009950 RID: 39248 RVA: 0x000E6D2B File Offset: 0x000E4F2B
		public bool GetWidthFitToChildren()
		{
			return UUIGridLayout.__GetWidthFitToChildren_Internal(base.NativePtr);
		}

		// Token: 0x06009951 RID: 39249 RVA: 0x000E6D38 File Offset: 0x000E4F38
		public FVector2D GetSpacing()
		{
			return UUIGridLayout.__GetSpacing_Internal(base.NativePtr);
		}

		// Token: 0x06009952 RID: 39250 RVA: 0x000E6D45 File Offset: 0x000E4F45
		public FMargin GetPadding()
		{
			return UUIGridLayout.__GetPadding_Internal(base.NativePtr);
		}

		// Token: 0x06009953 RID: 39251 RVA: 0x000E6D52 File Offset: 0x000E4F52
		public int GetMaxItemCountInOneLine()
		{
			return UUIGridLayout.__GetMaxItemCountInOneLine_Internal(base.NativePtr);
		}

		// Token: 0x06009954 RID: 39252 RVA: 0x000E6D5F File Offset: 0x000E4F5F
		public int GetLineCount()
		{
			return UUIGridLayout.__GetLineCount_Internal(base.NativePtr);
		}

		// Token: 0x06009955 RID: 39253 RVA: 0x000E6D6C File Offset: 0x000E4F6C
		public bool GetLastLineCanAlign()
		{
			return UUIGridLayout.__GetLastLineCanAlign_Internal(base.NativePtr);
		}

		// Token: 0x06009956 RID: 39254 RVA: 0x000E6D79 File Offset: 0x000E4F79
		public bool GetHorizontalOrVertical()
		{
			return UUIGridLayout.__GetHorizontalOrVertical_Internal(base.NativePtr);
		}

		// Token: 0x06009957 RID: 39255 RVA: 0x000E6D86 File Offset: 0x000E4F86
		public bool GetHeightFitToChildren()
		{
			return UUIGridLayout.__GetHeightFitToChildren_Internal(base.NativePtr);
		}

		// Token: 0x06009958 RID: 39256 RVA: 0x000E6D93 File Offset: 0x000E4F93
		public bool GetExpendChildSize()
		{
			return UUIGridLayout.__GetExpendChildSize_Internal(base.NativePtr);
		}

		// Token: 0x06009959 RID: 39257 RVA: 0x000E6DA0 File Offset: 0x000E4FA0
		public bool GetDependOnSizeOrCount()
		{
			return UUIGridLayout.__GetDependOnSizeOrCount_Internal(base.NativePtr);
		}

		// Token: 0x0600995A RID: 39258 RVA: 0x000E6DAD File Offset: 0x000E4FAD
		public FVector2D GetCellSize()
		{
			return UUIGridLayout.__GetCellSize_Internal(base.NativePtr);
		}

		// Token: 0x0600995B RID: 39259 RVA: 0x000E6DBA File Offset: 0x000E4FBA
		public ELGUILayoutAlignmentType GetAlign()
		{
			return UUIGridLayout.__GetAlign_Internal(base.NativePtr);
		}

		// Token: 0x0600995C RID: 39260 RVA: 0x000E6DC7 File Offset: 0x000E4FC7
		public FVector2D GetActuralRange()
		{
			return UUIGridLayout.__GetActuralRange_Internal(base.NativePtr);
		}

		// Token: 0x0600995D RID: 39261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWidthFitToChildren_Internal(IntPtr @this, bool value);

		// Token: 0x0600995E RID: 39262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpacing_Internal(IntPtr @this, FVector2D value);

		// Token: 0x0600995F RID: 39263
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin value);

		// Token: 0x06009960 RID: 39264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxItemCountInOneLine_Internal(IntPtr @this, int value);

		// Token: 0x06009961 RID: 39265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLineCount_Internal(IntPtr @this, int value);

		// Token: 0x06009962 RID: 39266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLastLineCanAlign_Internal(IntPtr @this, bool value);

		// Token: 0x06009963 RID: 39267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHeightFitToChildren_Internal(IntPtr @this, bool value);

		// Token: 0x06009964 RID: 39268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExpendChildSize_Internal(IntPtr @this, bool value);

		// Token: 0x06009965 RID: 39269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDependOnSizeOrCount_Internal(IntPtr @this, bool value);

		// Token: 0x06009966 RID: 39270
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCellSize_Internal(IntPtr @this, FVector2D value);

		// Token: 0x06009967 RID: 39271
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCellScale_Internal(IntPtr @this, FVector2D value);

		// Token: 0x06009968 RID: 39272
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAlign_Internal(IntPtr @this, ELGUILayoutAlignmentType value);

		// Token: 0x06009969 RID: 39273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetWidthFitToChildren_Internal(IntPtr @this);

		// Token: 0x0600996A RID: 39274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetSpacing_Internal(IntPtr @this);

		// Token: 0x0600996B RID: 39275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMargin __GetPadding_Internal(IntPtr @this);

		// Token: 0x0600996C RID: 39276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMaxItemCountInOneLine_Internal(IntPtr @this);

		// Token: 0x0600996D RID: 39277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetLineCount_Internal(IntPtr @this);

		// Token: 0x0600996E RID: 39278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLastLineCanAlign_Internal(IntPtr @this);

		// Token: 0x0600996F RID: 39279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHorizontalOrVertical_Internal(IntPtr @this);

		// Token: 0x06009970 RID: 39280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHeightFitToChildren_Internal(IntPtr @this);

		// Token: 0x06009971 RID: 39281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetExpendChildSize_Internal(IntPtr @this);

		// Token: 0x06009972 RID: 39282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetDependOnSizeOrCount_Internal(IntPtr @this);

		// Token: 0x06009973 RID: 39283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetCellSize_Internal(IntPtr @this);

		// Token: 0x06009974 RID: 39284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ELGUILayoutAlignmentType __GetAlign_Internal(IntPtr @this);

		// Token: 0x06009975 RID: 39285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetActuralRange_Internal(IntPtr @this);

		// Token: 0x06009976 RID: 39286 RVA: 0x000E6DD4 File Offset: 0x000E4FD4
		static UUIGridLayout()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIGridLayout");
		}

		// Token: 0x06009977 RID: 39287 RVA: 0x000E6DE2 File Offset: 0x000E4FE2
		protected UUIGridLayout(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004298 RID: 17048
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIGridLayout";

		// Token: 0x04004299 RID: 17049
		private static IntPtr _ClassPtr;

		// Token: 0x0400429A RID: 17050
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400429B RID: 17051
		internal static int __PropertyOffset_Padding;

		// Token: 0x0400429C RID: 17052
		internal static int __PropertyOffset_Spacing;

		// Token: 0x0400429D RID: 17053
		internal static int __PropertyOffset_Align;

		// Token: 0x0400429E RID: 17054
		internal static int __PropertyOffset_LastLineCanAlign;

		// Token: 0x0400429F RID: 17055
		internal static int __PropertyOffset_HorizontalOrVertical;

		// Token: 0x040042A0 RID: 17056
		internal static int __PropertyOffset_DependOnSizeOrCount;

		// Token: 0x040042A1 RID: 17057
		internal static int __PropertyOffset_ExpendChildSize;

		// Token: 0x040042A2 RID: 17058
		internal static int __PropertyOffset_CellSize;

		// Token: 0x040042A3 RID: 17059
		internal static int __PropertyOffset_LineCount;

		// Token: 0x040042A4 RID: 17060
		internal static int __PropertyOffset_WidthFitToChildren;

		// Token: 0x040042A5 RID: 17061
		internal static int __PropertyOffset_HeightFitToChildren;

		// Token: 0x040042A6 RID: 17062
		internal static int __PropertyOffset_CellScale;
	}
}
