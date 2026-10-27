using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B64 RID: 7012
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialCustomParamGroupForEachMaterial")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKuroMaterialCustomParamGroupForEachMaterial : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A8B2 RID: 108722 RVA: 0x002723AF File Offset: 0x002705AF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialCustomParamGroupForEachMaterial._ScriptStructPtr != 0) ? FKuroMaterialCustomParamGroupForEachMaterial._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialCustomParamGroupForEachMaterial", ref FKuroMaterialCustomParamGroupForEachMaterial._ScriptStructPtr);
		}

		// Token: 0x17006AAD RID: 27309
		// (get) Token: 0x0601A8B3 RID: 108723 RVA: 0x002723D3 File Offset: 0x002705D3
		// (set) Token: 0x0601A8B4 RID: 108724 RVA: 0x002723E3 File Offset: 0x002705E3
		public unsafe int MaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialCustomParamGroupForEachMaterial.__PropertyOffset_MaterialIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialCustomParamGroupForEachMaterial.__PropertyOffset_MaterialIndex) = value;
			}
		}

		// Token: 0x17006AAE RID: 27310
		// (get) Token: 0x0601A8B5 RID: 108725 RVA: 0x002723F4 File Offset: 0x002705F4
		// (set) Token: 0x0601A8B6 RID: 108726 RVA: 0x00272437 File Offset: 0x00270637
		public TArray<FKuroMaterialNamedFloatGroup> CustomFloatGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialNamedFloatGroup> result;
				if ((result = this._CustomFloatGroups) == null)
				{
					result = (this._CustomFloatGroups = new TArray<FKuroMaterialNamedFloatGroup>(base.NativePtr + (IntPtr)FKuroMaterialCustomParamGroupForEachMaterial.__PropertyOffset_CustomFloatGroups, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomFloatGroups.CopyAssign(value);
			}
		}

		// Token: 0x17006AAF RID: 27311
		// (get) Token: 0x0601A8B7 RID: 108727 RVA: 0x00272448 File Offset: 0x00270648
		// (set) Token: 0x0601A8B8 RID: 108728 RVA: 0x0027248B File Offset: 0x0027068B
		public TArray<FKuroMaterialNamedColorGroup> CustomColorGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialNamedColorGroup> result;
				if ((result = this._CustomColorGroups) == null)
				{
					result = (this._CustomColorGroups = new TArray<FKuroMaterialNamedColorGroup>(base.NativePtr + (IntPtr)FKuroMaterialCustomParamGroupForEachMaterial.__PropertyOffset_CustomColorGroups, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomColorGroups.CopyAssign(value);
			}
		}

		// Token: 0x17006AB0 RID: 27312
		// (get) Token: 0x0601A8B9 RID: 108729 RVA: 0x0027249C File Offset: 0x0027069C
		// (set) Token: 0x0601A8BA RID: 108730 RVA: 0x002724DF File Offset: 0x002706DF
		public TArray<FKuroMaterialNamedTextureGroup> CustomTextureGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialNamedTextureGroup> result;
				if ((result = this._CustomTextureGroups) == null)
				{
					result = (this._CustomTextureGroups = new TArray<FKuroMaterialNamedTextureGroup>(base.NativePtr + (IntPtr)FKuroMaterialCustomParamGroupForEachMaterial.__PropertyOffset_CustomTextureGroups, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomTextureGroups.CopyAssign(value);
			}
		}

		// Token: 0x0601A8BB RID: 108731 RVA: 0x002724ED File Offset: 0x002706ED
		public FKuroMaterialCustomParamGroupForEachMaterial()
		{
		}

		// Token: 0x0601A8BC RID: 108732 RVA: 0x002724F5 File Offset: 0x002706F5
		public FKuroMaterialCustomParamGroupForEachMaterial(int MaterialIndex, TArray<FKuroMaterialNamedFloatGroup> CustomFloatGroups, TArray<FKuroMaterialNamedColorGroup> CustomColorGroups, TArray<FKuroMaterialNamedTextureGroup> CustomTextureGroups)
		{
			this.MaterialIndex = MaterialIndex;
			this.CustomFloatGroups = CustomFloatGroups;
			this.CustomColorGroups = CustomColorGroups;
			this.CustomTextureGroups = CustomTextureGroups;
		}

		// Token: 0x0601A8BD RID: 108733 RVA: 0x0027251A File Offset: 0x0027071A
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialCustomParamGroupForEachMaterial.StaticStruct();
		}

		// Token: 0x0601A8BE RID: 108734 RVA: 0x00272526 File Offset: 0x00270726
		[NullableContext(2)]
		public FKuroMaterialCustomParamGroupForEachMaterial(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A8BF RID: 108735 RVA: 0x00272530 File Offset: 0x00270730
		public FKuroMaterialCustomParamGroupForEachMaterial(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A8C0 RID: 108736 RVA: 0x0027253B File Offset: 0x0027073B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialCustomParamGroupForEachMaterial(Pointer, false, true);
		}

		// Token: 0x0601A8C1 RID: 108737 RVA: 0x00272545 File Offset: 0x00270745
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialCustomParamGroupForEachMaterial(Pointer, MemoryOwner);
		}

		// Token: 0x0400E5FE RID: 58878
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialCustomParamGroupForEachMaterial";

		// Token: 0x0400E5FF RID: 58879
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E600 RID: 58880
		internal static int __PropertyOffset_MaterialIndex;

		// Token: 0x0400E601 RID: 58881
		internal static int __PropertyOffset_CustomFloatGroups;

		// Token: 0x0400E602 RID: 58882
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialNamedFloatGroup> _CustomFloatGroups;

		// Token: 0x0400E603 RID: 58883
		internal static int __PropertyOffset_CustomColorGroups;

		// Token: 0x0400E604 RID: 58884
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialNamedColorGroup> _CustomColorGroups;

		// Token: 0x0400E605 RID: 58885
		internal static int __PropertyOffset_CustomTextureGroups;

		// Token: 0x0400E606 RID: 58886
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialNamedTextureGroup> _CustomTextureGroups;
	}
}
