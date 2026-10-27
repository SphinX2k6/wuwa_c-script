using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B9A RID: 7066
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroRainMaterialFloatParameter")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FKuroRainMaterialFloatParameter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601AE69 RID: 110185 RVA: 0x0027A766 File Offset: 0x00278966
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRainMaterialFloatParameter._ScriptStructPtr != 0) ? FKuroRainMaterialFloatParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroRainMaterialFloatParameter", ref FKuroRainMaterialFloatParameter._ScriptStructPtr);
		}

		// Token: 0x17006C55 RID: 27733
		// (get) Token: 0x0601AE6A RID: 110186 RVA: 0x0027A78A File Offset: 0x0027898A
		// (set) Token: 0x0601AE6B RID: 110187 RVA: 0x0027A79E File Offset: 0x0027899E
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRainMaterialFloatParameter.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRainMaterialFloatParameter.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17006C56 RID: 27734
		// (get) Token: 0x0601AE6C RID: 110188 RVA: 0x0027A7B4 File Offset: 0x002789B4
		// (set) Token: 0x0601AE6D RID: 110189 RVA: 0x0027A7F7 File Offset: 0x002789F7
		public FKuroCurveFloat Value
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._Value) == null)
				{
					result = (this._Value = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroRainMaterialFloatParameter.__PropertyOffset_Value, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroRainMaterialFloatParameter.__PropertyOffset_Value, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601AE6E RID: 110190 RVA: 0x0027A818 File Offset: 0x00278A18
		public FKuroRainMaterialFloatParameter()
		{
		}

		// Token: 0x0601AE6F RID: 110191 RVA: 0x0027A820 File Offset: 0x00278A20
		public FKuroRainMaterialFloatParameter(FName ParameterName, FKuroCurveFloat Value)
		{
			this.ParameterName = ParameterName;
			this.Value = Value;
		}

		// Token: 0x0601AE70 RID: 110192 RVA: 0x0027A836 File Offset: 0x00278A36
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRainMaterialFloatParameter.StaticStruct();
		}

		// Token: 0x0601AE71 RID: 110193 RVA: 0x0027A842 File Offset: 0x00278A42
		[NullableContext(2)]
		public FKuroRainMaterialFloatParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601AE72 RID: 110194 RVA: 0x0027A84C File Offset: 0x00278A4C
		public FKuroRainMaterialFloatParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601AE73 RID: 110195 RVA: 0x0027A857 File Offset: 0x00278A57
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRainMaterialFloatParameter(Pointer, false, true);
		}

		// Token: 0x0601AE74 RID: 110196 RVA: 0x0027A861 File Offset: 0x00278A61
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRainMaterialFloatParameter(Pointer, MemoryOwner);
		}

		// Token: 0x0400E8D2 RID: 59602
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroRainMaterialFloatParameter";

		// Token: 0x0400E8D3 RID: 59603
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E8D4 RID: 59604
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x0400E8D5 RID: 59605
		internal static int __PropertyOffset_Value;

		// Token: 0x0400E8D6 RID: 59606
		[Nullable(2)]
		private FKuroCurveFloat _Value;
	}
}
