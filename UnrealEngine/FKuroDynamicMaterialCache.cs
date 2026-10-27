using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AE8 RID: 6888
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroDynamicMaterialCache")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroDynamicMaterialCache : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019B10 RID: 105232 RVA: 0x0025F5DF File Offset: 0x0025D7DF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroDynamicMaterialCache._ScriptStructPtr != 0) ? FKuroDynamicMaterialCache._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroDynamicMaterialCache", ref FKuroDynamicMaterialCache._ScriptStructPtr);
		}

		// Token: 0x170066A5 RID: 26277
		// (get) Token: 0x06019B11 RID: 105233 RVA: 0x0025F604 File Offset: 0x0025D804
		// (set) Token: 0x06019B12 RID: 105234 RVA: 0x0025F647 File Offset: 0x0025D847
		[Nullable(1)]
		public TArray<FName> Keyword
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Keyword) == null)
				{
					result = (this._Keyword = new TArray<FName>(base.NativePtr + (IntPtr)FKuroDynamicMaterialCache.__PropertyOffset_Keyword, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Keyword.CopyAssign(value);
			}
		}

		// Token: 0x170066A6 RID: 26278
		// (get) Token: 0x06019B13 RID: 105235 RVA: 0x0025F655 File Offset: 0x0025D855
		// (set) Token: 0x06019B14 RID: 105236 RVA: 0x0025F669 File Offset: 0x0025D869
		public unsafe UMaterialInstance OriginalVariationMaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroDynamicMaterialCache.__PropertyOffset_OriginalVariationMaterialInstance);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroDynamicMaterialCache.__PropertyOffset_OriginalVariationMaterialInstance, value);
			}
		}

		// Token: 0x170066A7 RID: 26279
		// (get) Token: 0x06019B15 RID: 105237 RVA: 0x0025F67E File Offset: 0x0025D87E
		// (set) Token: 0x06019B16 RID: 105238 RVA: 0x0025F692 File Offset: 0x0025D892
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroDynamicMaterialCache.__PropertyOffset_DynamicMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroDynamicMaterialCache.__PropertyOffset_DynamicMaterial, value);
			}
		}

		// Token: 0x06019B17 RID: 105239 RVA: 0x0025F6A7 File Offset: 0x0025D8A7
		public FKuroDynamicMaterialCache()
		{
		}

		// Token: 0x06019B18 RID: 105240 RVA: 0x0025F6AF File Offset: 0x0025D8AF
		[NullableContext(1)]
		public FKuroDynamicMaterialCache(TArray<FName> Keyword, UMaterialInstance OriginalVariationMaterialInstance, UMaterialInstanceDynamic DynamicMaterial)
		{
			this.Keyword = Keyword;
			this.OriginalVariationMaterialInstance = OriginalVariationMaterialInstance;
			this.DynamicMaterial = DynamicMaterial;
		}

		// Token: 0x06019B19 RID: 105241 RVA: 0x0025F6CC File Offset: 0x0025D8CC
		protected override IntPtr GetUStructPtr()
		{
			return FKuroDynamicMaterialCache.StaticStruct();
		}

		// Token: 0x06019B1A RID: 105242 RVA: 0x0025F6D8 File Offset: 0x0025D8D8
		public FKuroDynamicMaterialCache(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019B1B RID: 105243 RVA: 0x0025F6E2 File Offset: 0x0025D8E2
		public FKuroDynamicMaterialCache(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019B1C RID: 105244 RVA: 0x0025F6ED File Offset: 0x0025D8ED
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroDynamicMaterialCache(Pointer, false, true);
		}

		// Token: 0x06019B1D RID: 105245 RVA: 0x0025F6F7 File Offset: 0x0025D8F7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroDynamicMaterialCache(Pointer, MemoryOwner);
		}

		// Token: 0x0400DF96 RID: 57238
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroDynamicMaterialCache";

		// Token: 0x0400DF97 RID: 57239
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DF98 RID: 57240
		internal static int __PropertyOffset_Keyword;

		// Token: 0x0400DF99 RID: 57241
		private TArray<FName> _Keyword;

		// Token: 0x0400DF9A RID: 57242
		internal static int __PropertyOffset_OriginalVariationMaterialInstance;

		// Token: 0x0400DF9B RID: 57243
		internal static int __PropertyOffset_DynamicMaterial;
	}
}
