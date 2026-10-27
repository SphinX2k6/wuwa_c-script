using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B65 RID: 7013
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialCustomParamsForEachMaterial")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKuroMaterialCustomParamsForEachMaterial : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A8C2 RID: 108738 RVA: 0x0027254E File Offset: 0x0027074E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialCustomParamsForEachMaterial._ScriptStructPtr != 0) ? FKuroMaterialCustomParamsForEachMaterial._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialCustomParamsForEachMaterial", ref FKuroMaterialCustomParamsForEachMaterial._ScriptStructPtr);
		}

		// Token: 0x17006AB1 RID: 27313
		// (get) Token: 0x0601A8C3 RID: 108739 RVA: 0x00272572 File Offset: 0x00270772
		// (set) Token: 0x0601A8C4 RID: 108740 RVA: 0x00272582 File Offset: 0x00270782
		public unsafe int MaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialCustomParamsForEachMaterial.__PropertyOffset_MaterialIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialCustomParamsForEachMaterial.__PropertyOffset_MaterialIndex) = value;
			}
		}

		// Token: 0x17006AB2 RID: 27314
		// (get) Token: 0x0601A8C5 RID: 108741 RVA: 0x00272594 File Offset: 0x00270794
		// (set) Token: 0x0601A8C6 RID: 108742 RVA: 0x002725D7 File Offset: 0x002707D7
		public TArray<FKuroMaterialNamedFloat> CustomFloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialNamedFloat> result;
				if ((result = this._CustomFloatParameters) == null)
				{
					result = (this._CustomFloatParameters = new TArray<FKuroMaterialNamedFloat>(base.NativePtr + (IntPtr)FKuroMaterialCustomParamsForEachMaterial.__PropertyOffset_CustomFloatParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomFloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006AB3 RID: 27315
		// (get) Token: 0x0601A8C7 RID: 108743 RVA: 0x002725E8 File Offset: 0x002707E8
		// (set) Token: 0x0601A8C8 RID: 108744 RVA: 0x0027262B File Offset: 0x0027082B
		public TArray<FKuroMaterialNamedColor> CustomColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialNamedColor> result;
				if ((result = this._CustomColorParameters) == null)
				{
					result = (this._CustomColorParameters = new TArray<FKuroMaterialNamedColor>(base.NativePtr + (IntPtr)FKuroMaterialCustomParamsForEachMaterial.__PropertyOffset_CustomColorParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006AB4 RID: 27316
		// (get) Token: 0x0601A8C9 RID: 108745 RVA: 0x0027263C File Offset: 0x0027083C
		// (set) Token: 0x0601A8CA RID: 108746 RVA: 0x0027267F File Offset: 0x0027087F
		public TArray<FKuroMaterialNamedTexture> CustomTextureParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialNamedTexture> result;
				if ((result = this._CustomTextureParameters) == null)
				{
					result = (this._CustomTextureParameters = new TArray<FKuroMaterialNamedTexture>(base.NativePtr + (IntPtr)FKuroMaterialCustomParamsForEachMaterial.__PropertyOffset_CustomTextureParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomTextureParameters.CopyAssign(value);
			}
		}

		// Token: 0x0601A8CB RID: 108747 RVA: 0x0027268D File Offset: 0x0027088D
		public FKuroMaterialCustomParamsForEachMaterial()
		{
		}

		// Token: 0x0601A8CC RID: 108748 RVA: 0x00272695 File Offset: 0x00270895
		public FKuroMaterialCustomParamsForEachMaterial(int MaterialIndex, TArray<FKuroMaterialNamedFloat> CustomFloatParameters, TArray<FKuroMaterialNamedColor> CustomColorParameters, TArray<FKuroMaterialNamedTexture> CustomTextureParameters)
		{
			this.MaterialIndex = MaterialIndex;
			this.CustomFloatParameters = CustomFloatParameters;
			this.CustomColorParameters = CustomColorParameters;
			this.CustomTextureParameters = CustomTextureParameters;
		}

		// Token: 0x0601A8CD RID: 108749 RVA: 0x002726BA File Offset: 0x002708BA
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialCustomParamsForEachMaterial.StaticStruct();
		}

		// Token: 0x0601A8CE RID: 108750 RVA: 0x002726C6 File Offset: 0x002708C6
		[NullableContext(2)]
		public FKuroMaterialCustomParamsForEachMaterial(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A8CF RID: 108751 RVA: 0x002726D0 File Offset: 0x002708D0
		public FKuroMaterialCustomParamsForEachMaterial(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A8D0 RID: 108752 RVA: 0x002726DB File Offset: 0x002708DB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialCustomParamsForEachMaterial(Pointer, false, true);
		}

		// Token: 0x0601A8D1 RID: 108753 RVA: 0x002726E5 File Offset: 0x002708E5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialCustomParamsForEachMaterial(Pointer, MemoryOwner);
		}

		// Token: 0x0400E607 RID: 58887
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialCustomParamsForEachMaterial";

		// Token: 0x0400E608 RID: 58888
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E609 RID: 58889
		internal static int __PropertyOffset_MaterialIndex;

		// Token: 0x0400E60A RID: 58890
		internal static int __PropertyOffset_CustomFloatParameters;

		// Token: 0x0400E60B RID: 58891
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialNamedFloat> _CustomFloatParameters;

		// Token: 0x0400E60C RID: 58892
		internal static int __PropertyOffset_CustomColorParameters;

		// Token: 0x0400E60D RID: 58893
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialNamedColor> _CustomColorParameters;

		// Token: 0x0400E60E RID: 58894
		internal static int __PropertyOffset_CustomTextureParameters;

		// Token: 0x0400E60F RID: 58895
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialNamedTexture> _CustomTextureParameters;
	}
}
