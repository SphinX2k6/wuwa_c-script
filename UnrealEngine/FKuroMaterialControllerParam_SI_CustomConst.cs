using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B52 RID: 6994
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_CustomConst")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FKuroMaterialControllerParam_SI_CustomConst : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A7A7 RID: 108455 RVA: 0x0027086B File Offset: 0x0026EA6B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_SI_CustomConst._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_SI_CustomConst._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_CustomConst", ref FKuroMaterialControllerParam_SI_CustomConst._ScriptStructPtr);
		}

		// Token: 0x17006A6F RID: 27247
		// (get) Token: 0x0601A7A8 RID: 108456 RVA: 0x00270890 File Offset: 0x0026EA90
		// (set) Token: 0x0601A7A9 RID: 108457 RVA: 0x002708D3 File Offset: 0x0026EAD3
		public TMap<FName, float> FloatParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._FloatParams) == null)
				{
					result = (this._FloatParams = new TMap<FName, float>(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_CustomConst.__PropertyOffset_FloatParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatParams.CopyAssign(value);
			}
		}

		// Token: 0x17006A70 RID: 27248
		// (get) Token: 0x0601A7AA RID: 108458 RVA: 0x002708E4 File Offset: 0x0026EAE4
		// (set) Token: 0x0601A7AB RID: 108459 RVA: 0x00270927 File Offset: 0x0026EB27
		public TMap<FName, FLinearColor> ColorParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._ColorParams) == null)
				{
					result = (this._ColorParams = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_CustomConst.__PropertyOffset_ColorParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ColorParams.CopyAssign(value);
			}
		}

		// Token: 0x0601A7AC RID: 108460 RVA: 0x00270935 File Offset: 0x0026EB35
		public FKuroMaterialControllerParam_SI_CustomConst()
		{
		}

		// Token: 0x0601A7AD RID: 108461 RVA: 0x0027093D File Offset: 0x0026EB3D
		public FKuroMaterialControllerParam_SI_CustomConst(TMap<FName, float> FloatParams, TMap<FName, FLinearColor> ColorParams)
		{
			this.FloatParams = FloatParams;
			this.ColorParams = ColorParams;
		}

		// Token: 0x0601A7AE RID: 108462 RVA: 0x00270953 File Offset: 0x0026EB53
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_SI_CustomConst.StaticStruct();
		}

		// Token: 0x0601A7AF RID: 108463 RVA: 0x0027095F File Offset: 0x0026EB5F
		[NullableContext(2)]
		public FKuroMaterialControllerParam_SI_CustomConst(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A7B0 RID: 108464 RVA: 0x00270969 File Offset: 0x0026EB69
		public FKuroMaterialControllerParam_SI_CustomConst(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A7B1 RID: 108465 RVA: 0x00270974 File Offset: 0x0026EB74
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_SI_CustomConst(Pointer, false, true);
		}

		// Token: 0x0601A7B2 RID: 108466 RVA: 0x0027097E File Offset: 0x0026EB7E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_SI_CustomConst(Pointer, MemoryOwner);
		}

		// Token: 0x0400E57B RID: 58747
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_CustomConst";

		// Token: 0x0400E57C RID: 58748
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E57D RID: 58749
		internal static int __PropertyOffset_FloatParams;

		// Token: 0x0400E57E RID: 58750
		[Nullable(2)]
		private TMap<FName, float> _FloatParams;

		// Token: 0x0400E57F RID: 58751
		internal static int __PropertyOffset_ColorParams;

		// Token: 0x0400E580 RID: 58752
		[Nullable(2)]
		private TMap<FName, FLinearColor> _ColorParams;
	}
}
