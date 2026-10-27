using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B43 RID: 6979
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_Dither")]
	[UnrealStructLayout(432, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 432)]
	public class FKuroMaterialControllerParam_Dither : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A6D3 RID: 108243 RVA: 0x0026F6AF File Offset: 0x0026D8AF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_Dither._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_Dither._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_Dither", ref FKuroMaterialControllerParam_Dither._ScriptStructPtr);
		}

		// Token: 0x17006A41 RID: 27201
		// (get) Token: 0x0601A6D4 RID: 108244 RVA: 0x0026F6D4 File Offset: 0x0026D8D4
		// (set) Token: 0x0601A6D5 RID: 108245 RVA: 0x0026F717 File Offset: 0x0026D917
		public FKuroMaterialCurveFloatGroup DitherValue
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup result;
				if ((result = this._DitherValue) == null)
				{
					result = (this._DitherValue = new FKuroMaterialCurveFloatGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Dither.__PropertyOffset_DitherValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Dither.__PropertyOffset_DitherValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601A6D6 RID: 108246 RVA: 0x0026F738 File Offset: 0x0026D938
		public FKuroMaterialControllerParam_Dither()
		{
		}

		// Token: 0x0601A6D7 RID: 108247 RVA: 0x0026F740 File Offset: 0x0026D940
		public FKuroMaterialControllerParam_Dither(FKuroMaterialCurveFloatGroup DitherValue)
		{
			this.DitherValue = DitherValue;
		}

		// Token: 0x0601A6D8 RID: 108248 RVA: 0x0026F74F File Offset: 0x0026D94F
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_Dither.StaticStruct();
		}

		// Token: 0x0601A6D9 RID: 108249 RVA: 0x0026F75B File Offset: 0x0026D95B
		[NullableContext(2)]
		public FKuroMaterialControllerParam_Dither(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A6DA RID: 108250 RVA: 0x0026F765 File Offset: 0x0026D965
		public FKuroMaterialControllerParam_Dither(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A6DB RID: 108251 RVA: 0x0026F770 File Offset: 0x0026D970
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_Dither(Pointer, false, true);
		}

		// Token: 0x0601A6DC RID: 108252 RVA: 0x0026F77A File Offset: 0x0026D97A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_Dither(Pointer, MemoryOwner);
		}

		// Token: 0x0400E51E RID: 58654
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_Dither";

		// Token: 0x0400E51F RID: 58655
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E520 RID: 58656
		internal static int __PropertyOffset_DitherValue;

		// Token: 0x0400E521 RID: 58657
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup _DitherValue;
	}
}
