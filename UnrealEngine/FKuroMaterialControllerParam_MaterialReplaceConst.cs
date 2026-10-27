using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B46 RID: 6982
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_MaterialReplaceConst")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKuroMaterialControllerParam_MaterialReplaceConst : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A6F9 RID: 108281 RVA: 0x0026F9C2 File Offset: 0x0026DBC2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_MaterialReplaceConst._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_MaterialReplaceConst._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_MaterialReplaceConst", ref FKuroMaterialControllerParam_MaterialReplaceConst._ScriptStructPtr);
		}

		// Token: 0x17006A48 RID: 27208
		// (get) Token: 0x0601A6FA RID: 108282 RVA: 0x0026F9E6 File Offset: 0x0026DBE6
		// (set) Token: 0x0601A6FB RID: 108283 RVA: 0x0026F9FA File Offset: 0x0026DBFA
		[Nullable(2)]
		public unsafe UMaterialInterface ReplaceMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_MaterialReplaceConst.__PropertyOffset_ReplaceMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_MaterialReplaceConst.__PropertyOffset_ReplaceMaterial, value);
			}
		}

		// Token: 0x17006A49 RID: 27209
		// (get) Token: 0x0601A6FC RID: 108284 RVA: 0x0026FA0F File Offset: 0x0026DC0F
		// (set) Token: 0x0601A6FD RID: 108285 RVA: 0x0026FA23 File Offset: 0x0026DC23
		[Nullable(2)]
		public unsafe UMaterialInterface ReplaceMaterialMobile
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_MaterialReplaceConst.__PropertyOffset_ReplaceMaterialMobile);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_MaterialReplaceConst.__PropertyOffset_ReplaceMaterialMobile, value);
			}
		}

		// Token: 0x17006A4A RID: 27210
		// (get) Token: 0x0601A6FE RID: 108286 RVA: 0x0026FA38 File Offset: 0x0026DC38
		// (set) Token: 0x0601A6FF RID: 108287 RVA: 0x0026FA4C File Offset: 0x0026DC4C
		[Nullable(2)]
		public unsafe UMaterialInterface ReplaceMaterialMac
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_MaterialReplaceConst.__PropertyOffset_ReplaceMaterialMac);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_MaterialReplaceConst.__PropertyOffset_ReplaceMaterialMac, value);
			}
		}

		// Token: 0x17006A4B RID: 27211
		// (get) Token: 0x0601A700 RID: 108288 RVA: 0x0026FA64 File Offset: 0x0026DC64
		// (set) Token: 0x0601A701 RID: 108289 RVA: 0x0026FAA7 File Offset: 0x0026DCA7
		public TArray<FKuroMaterialNamedFloat> ReplaceMaterialFloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialNamedFloat> result;
				if ((result = this._ReplaceMaterialFloatParameters) == null)
				{
					result = (this._ReplaceMaterialFloatParameters = new TArray<FKuroMaterialNamedFloat>(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_MaterialReplaceConst.__PropertyOffset_ReplaceMaterialFloatParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ReplaceMaterialFloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006A4C RID: 27212
		// (get) Token: 0x0601A702 RID: 108290 RVA: 0x0026FAB8 File Offset: 0x0026DCB8
		// (set) Token: 0x0601A703 RID: 108291 RVA: 0x0026FAFB File Offset: 0x0026DCFB
		public TArray<FKuroMaterialNamedColor> ReplaceMaterialColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialNamedColor> result;
				if ((result = this._ReplaceMaterialColorParameters) == null)
				{
					result = (this._ReplaceMaterialColorParameters = new TArray<FKuroMaterialNamedColor>(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_MaterialReplaceConst.__PropertyOffset_ReplaceMaterialColorParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ReplaceMaterialColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x0601A704 RID: 108292 RVA: 0x0026FB09 File Offset: 0x0026DD09
		public FKuroMaterialControllerParam_MaterialReplaceConst()
		{
		}

		// Token: 0x0601A705 RID: 108293 RVA: 0x0026FB11 File Offset: 0x0026DD11
		public FKuroMaterialControllerParam_MaterialReplaceConst(UMaterialInterface ReplaceMaterial, UMaterialInterface ReplaceMaterialMobile, UMaterialInterface ReplaceMaterialMac, TArray<FKuroMaterialNamedFloat> ReplaceMaterialFloatParameters, TArray<FKuroMaterialNamedColor> ReplaceMaterialColorParameters)
		{
			this.ReplaceMaterial = ReplaceMaterial;
			this.ReplaceMaterialMobile = ReplaceMaterialMobile;
			this.ReplaceMaterialMac = ReplaceMaterialMac;
			this.ReplaceMaterialFloatParameters = ReplaceMaterialFloatParameters;
			this.ReplaceMaterialColorParameters = ReplaceMaterialColorParameters;
		}

		// Token: 0x0601A706 RID: 108294 RVA: 0x0026FB3E File Offset: 0x0026DD3E
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_MaterialReplaceConst.StaticStruct();
		}

		// Token: 0x0601A707 RID: 108295 RVA: 0x0026FB4A File Offset: 0x0026DD4A
		[NullableContext(2)]
		public FKuroMaterialControllerParam_MaterialReplaceConst(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A708 RID: 108296 RVA: 0x0026FB54 File Offset: 0x0026DD54
		public FKuroMaterialControllerParam_MaterialReplaceConst(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A709 RID: 108297 RVA: 0x0026FB5F File Offset: 0x0026DD5F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_MaterialReplaceConst(Pointer, false, true);
		}

		// Token: 0x0601A70A RID: 108298 RVA: 0x0026FB69 File Offset: 0x0026DD69
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_MaterialReplaceConst(Pointer, MemoryOwner);
		}

		// Token: 0x0400E52E RID: 58670
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_MaterialReplaceConst";

		// Token: 0x0400E52F RID: 58671
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E530 RID: 58672
		internal static int __PropertyOffset_ReplaceMaterial;

		// Token: 0x0400E531 RID: 58673
		internal static int __PropertyOffset_ReplaceMaterialMobile;

		// Token: 0x0400E532 RID: 58674
		internal static int __PropertyOffset_ReplaceMaterialMac;

		// Token: 0x0400E533 RID: 58675
		internal static int __PropertyOffset_ReplaceMaterialFloatParameters;

		// Token: 0x0400E534 RID: 58676
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialNamedFloat> _ReplaceMaterialFloatParameters;

		// Token: 0x0400E535 RID: 58677
		internal static int __PropertyOffset_ReplaceMaterialColorParameters;

		// Token: 0x0400E536 RID: 58678
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialNamedColor> _ReplaceMaterialColorParameters;
	}
}
