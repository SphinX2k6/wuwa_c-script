using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B3F RID: 6975
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_Custom")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKuroMaterialControllerParam_Custom : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A68F RID: 108175 RVA: 0x0026EF8E File Offset: 0x0026D18E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_Custom._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_Custom._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_Custom", ref FKuroMaterialControllerParam_Custom._ScriptStructPtr);
		}

		// Token: 0x17006A2F RID: 27183
		// (get) Token: 0x0601A690 RID: 108176 RVA: 0x0026EFB4 File Offset: 0x0026D1B4
		// (set) Token: 0x0601A691 RID: 108177 RVA: 0x0026EFF7 File Offset: 0x0026D1F7
		public TArray<FKuroMaterialNamedFloatGroup> CustomFloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialNamedFloatGroup> result;
				if ((result = this._CustomFloatParameters) == null)
				{
					result = (this._CustomFloatParameters = new TArray<FKuroMaterialNamedFloatGroup>(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Custom.__PropertyOffset_CustomFloatParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomFloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006A30 RID: 27184
		// (get) Token: 0x0601A692 RID: 108178 RVA: 0x0026F008 File Offset: 0x0026D208
		// (set) Token: 0x0601A693 RID: 108179 RVA: 0x0026F04B File Offset: 0x0026D24B
		public TArray<FKuroMaterialNamedColorGroup> CustomColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialNamedColorGroup> result;
				if ((result = this._CustomColorParameters) == null)
				{
					result = (this._CustomColorParameters = new TArray<FKuroMaterialNamedColorGroup>(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Custom.__PropertyOffset_CustomColorParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006A31 RID: 27185
		// (get) Token: 0x0601A694 RID: 108180 RVA: 0x0026F05C File Offset: 0x0026D25C
		// (set) Token: 0x0601A695 RID: 108181 RVA: 0x0026F09F File Offset: 0x0026D29F
		public TArray<FKuroMaterialNamedTextureGroup> CustomTextureParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialNamedTextureGroup> result;
				if ((result = this._CustomTextureParameters) == null)
				{
					result = (this._CustomTextureParameters = new TArray<FKuroMaterialNamedTextureGroup>(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Custom.__PropertyOffset_CustomTextureParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomTextureParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006A32 RID: 27186
		// (get) Token: 0x0601A696 RID: 108182 RVA: 0x0026F0B0 File Offset: 0x0026D2B0
		// (set) Token: 0x0601A697 RID: 108183 RVA: 0x0026F0F3 File Offset: 0x0026D2F3
		public TArray<FKuroMaterialCustomParamGroupForEachMaterial> CustomParametersForEachMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialCustomParamGroupForEachMaterial> result;
				if ((result = this._CustomParametersForEachMaterials) == null)
				{
					result = (this._CustomParametersForEachMaterials = new TArray<FKuroMaterialCustomParamGroupForEachMaterial>(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Custom.__PropertyOffset_CustomParametersForEachMaterials, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomParametersForEachMaterials.CopyAssign(value);
			}
		}

		// Token: 0x0601A698 RID: 108184 RVA: 0x0026F101 File Offset: 0x0026D301
		public FKuroMaterialControllerParam_Custom()
		{
		}

		// Token: 0x0601A699 RID: 108185 RVA: 0x0026F109 File Offset: 0x0026D309
		public FKuroMaterialControllerParam_Custom(TArray<FKuroMaterialNamedFloatGroup> CustomFloatParameters, TArray<FKuroMaterialNamedColorGroup> CustomColorParameters, TArray<FKuroMaterialNamedTextureGroup> CustomTextureParameters, TArray<FKuroMaterialCustomParamGroupForEachMaterial> CustomParametersForEachMaterials)
		{
			this.CustomFloatParameters = CustomFloatParameters;
			this.CustomColorParameters = CustomColorParameters;
			this.CustomTextureParameters = CustomTextureParameters;
			this.CustomParametersForEachMaterials = CustomParametersForEachMaterials;
		}

		// Token: 0x0601A69A RID: 108186 RVA: 0x0026F12E File Offset: 0x0026D32E
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_Custom.StaticStruct();
		}

		// Token: 0x0601A69B RID: 108187 RVA: 0x0026F13A File Offset: 0x0026D33A
		[NullableContext(2)]
		public FKuroMaterialControllerParam_Custom(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A69C RID: 108188 RVA: 0x0026F144 File Offset: 0x0026D344
		public FKuroMaterialControllerParam_Custom(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A69D RID: 108189 RVA: 0x0026F14F File Offset: 0x0026D34F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_Custom(Pointer, false, true);
		}

		// Token: 0x0601A69E RID: 108190 RVA: 0x0026F159 File Offset: 0x0026D359
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_Custom(Pointer, MemoryOwner);
		}

		// Token: 0x0400E4F8 RID: 58616
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_Custom";

		// Token: 0x0400E4F9 RID: 58617
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E4FA RID: 58618
		internal static int __PropertyOffset_CustomFloatParameters;

		// Token: 0x0400E4FB RID: 58619
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialNamedFloatGroup> _CustomFloatParameters;

		// Token: 0x0400E4FC RID: 58620
		internal static int __PropertyOffset_CustomColorParameters;

		// Token: 0x0400E4FD RID: 58621
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialNamedColorGroup> _CustomColorParameters;

		// Token: 0x0400E4FE RID: 58622
		internal static int __PropertyOffset_CustomTextureParameters;

		// Token: 0x0400E4FF RID: 58623
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialNamedTextureGroup> _CustomTextureParameters;

		// Token: 0x0400E500 RID: 58624
		internal static int __PropertyOffset_CustomParametersForEachMaterials;

		// Token: 0x0400E501 RID: 58625
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialCustomParamGroupForEachMaterial> _CustomParametersForEachMaterials;
	}
}
