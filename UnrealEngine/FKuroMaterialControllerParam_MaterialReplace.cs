using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B45 RID: 6981
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_MaterialReplace")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKuroMaterialControllerParam_MaterialReplace : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A6E7 RID: 108263 RVA: 0x0026F813 File Offset: 0x0026DA13
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_MaterialReplace._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_MaterialReplace._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_MaterialReplace", ref FKuroMaterialControllerParam_MaterialReplace._ScriptStructPtr);
		}

		// Token: 0x17006A43 RID: 27203
		// (get) Token: 0x0601A6E8 RID: 108264 RVA: 0x0026F837 File Offset: 0x0026DA37
		// (set) Token: 0x0601A6E9 RID: 108265 RVA: 0x0026F84B File Offset: 0x0026DA4B
		[Nullable(2)]
		public unsafe UMaterialInterface ReplaceMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_MaterialReplace.__PropertyOffset_ReplaceMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_MaterialReplace.__PropertyOffset_ReplaceMaterial, value);
			}
		}

		// Token: 0x17006A44 RID: 27204
		// (get) Token: 0x0601A6EA RID: 108266 RVA: 0x0026F860 File Offset: 0x0026DA60
		// (set) Token: 0x0601A6EB RID: 108267 RVA: 0x0026F874 File Offset: 0x0026DA74
		[Nullable(2)]
		public unsafe UMaterialInterface ReplaceMaterialMobile
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_MaterialReplace.__PropertyOffset_ReplaceMaterialMobile);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_MaterialReplace.__PropertyOffset_ReplaceMaterialMobile, value);
			}
		}

		// Token: 0x17006A45 RID: 27205
		// (get) Token: 0x0601A6EC RID: 108268 RVA: 0x0026F889 File Offset: 0x0026DA89
		// (set) Token: 0x0601A6ED RID: 108269 RVA: 0x0026F89D File Offset: 0x0026DA9D
		[Nullable(2)]
		public unsafe UMaterialInterface ReplaceMaterialMac
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_MaterialReplace.__PropertyOffset_ReplaceMaterialMac);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_MaterialReplace.__PropertyOffset_ReplaceMaterialMac, value);
			}
		}

		// Token: 0x17006A46 RID: 27206
		// (get) Token: 0x0601A6EE RID: 108270 RVA: 0x0026F8B4 File Offset: 0x0026DAB4
		// (set) Token: 0x0601A6EF RID: 108271 RVA: 0x0026F8F7 File Offset: 0x0026DAF7
		public TArray<FKuroMaterialNamedFloatGroup> ReplaceMaterialFloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialNamedFloatGroup> result;
				if ((result = this._ReplaceMaterialFloatParameters) == null)
				{
					result = (this._ReplaceMaterialFloatParameters = new TArray<FKuroMaterialNamedFloatGroup>(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_MaterialReplace.__PropertyOffset_ReplaceMaterialFloatParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ReplaceMaterialFloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006A47 RID: 27207
		// (get) Token: 0x0601A6F0 RID: 108272 RVA: 0x0026F908 File Offset: 0x0026DB08
		// (set) Token: 0x0601A6F1 RID: 108273 RVA: 0x0026F94B File Offset: 0x0026DB4B
		public TArray<FKuroMaterialNamedColorGroup> ReplaceMaterialColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialNamedColorGroup> result;
				if ((result = this._ReplaceMaterialColorParameters) == null)
				{
					result = (this._ReplaceMaterialColorParameters = new TArray<FKuroMaterialNamedColorGroup>(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_MaterialReplace.__PropertyOffset_ReplaceMaterialColorParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ReplaceMaterialColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x0601A6F2 RID: 108274 RVA: 0x0026F959 File Offset: 0x0026DB59
		public FKuroMaterialControllerParam_MaterialReplace()
		{
		}

		// Token: 0x0601A6F3 RID: 108275 RVA: 0x0026F961 File Offset: 0x0026DB61
		public FKuroMaterialControllerParam_MaterialReplace(UMaterialInterface ReplaceMaterial, UMaterialInterface ReplaceMaterialMobile, UMaterialInterface ReplaceMaterialMac, TArray<FKuroMaterialNamedFloatGroup> ReplaceMaterialFloatParameters, TArray<FKuroMaterialNamedColorGroup> ReplaceMaterialColorParameters)
		{
			this.ReplaceMaterial = ReplaceMaterial;
			this.ReplaceMaterialMobile = ReplaceMaterialMobile;
			this.ReplaceMaterialMac = ReplaceMaterialMac;
			this.ReplaceMaterialFloatParameters = ReplaceMaterialFloatParameters;
			this.ReplaceMaterialColorParameters = ReplaceMaterialColorParameters;
		}

		// Token: 0x0601A6F4 RID: 108276 RVA: 0x0026F98E File Offset: 0x0026DB8E
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_MaterialReplace.StaticStruct();
		}

		// Token: 0x0601A6F5 RID: 108277 RVA: 0x0026F99A File Offset: 0x0026DB9A
		[NullableContext(2)]
		public FKuroMaterialControllerParam_MaterialReplace(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A6F6 RID: 108278 RVA: 0x0026F9A4 File Offset: 0x0026DBA4
		public FKuroMaterialControllerParam_MaterialReplace(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A6F7 RID: 108279 RVA: 0x0026F9AF File Offset: 0x0026DBAF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_MaterialReplace(Pointer, false, true);
		}

		// Token: 0x0601A6F8 RID: 108280 RVA: 0x0026F9B9 File Offset: 0x0026DBB9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_MaterialReplace(Pointer, MemoryOwner);
		}

		// Token: 0x0400E525 RID: 58661
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_MaterialReplace";

		// Token: 0x0400E526 RID: 58662
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E527 RID: 58663
		internal static int __PropertyOffset_ReplaceMaterial;

		// Token: 0x0400E528 RID: 58664
		internal static int __PropertyOffset_ReplaceMaterialMobile;

		// Token: 0x0400E529 RID: 58665
		internal static int __PropertyOffset_ReplaceMaterialMac;

		// Token: 0x0400E52A RID: 58666
		internal static int __PropertyOffset_ReplaceMaterialFloatParameters;

		// Token: 0x0400E52B RID: 58667
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialNamedFloatGroup> _ReplaceMaterialFloatParameters;

		// Token: 0x0400E52C RID: 58668
		internal static int __PropertyOffset_ReplaceMaterialColorParameters;

		// Token: 0x0400E52D RID: 58669
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialNamedColorGroup> _ReplaceMaterialColorParameters;
	}
}
