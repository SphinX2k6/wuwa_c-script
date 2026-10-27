using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B99 RID: 7065
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroRainMaterialColorParameter")]
	[UnrealStructLayout(560, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 560)]
	public class FKuroRainMaterialColorParameter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601AE5D RID: 110173 RVA: 0x0027A662 File Offset: 0x00278862
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRainMaterialColorParameter._ScriptStructPtr != 0) ? FKuroRainMaterialColorParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroRainMaterialColorParameter", ref FKuroRainMaterialColorParameter._ScriptStructPtr);
		}

		// Token: 0x17006C53 RID: 27731
		// (get) Token: 0x0601AE5E RID: 110174 RVA: 0x0027A686 File Offset: 0x00278886
		// (set) Token: 0x0601AE5F RID: 110175 RVA: 0x0027A69A File Offset: 0x0027889A
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRainMaterialColorParameter.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRainMaterialColorParameter.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17006C54 RID: 27732
		// (get) Token: 0x0601AE60 RID: 110176 RVA: 0x0027A6B0 File Offset: 0x002788B0
		// (set) Token: 0x0601AE61 RID: 110177 RVA: 0x0027A6F3 File Offset: 0x002788F3
		public FKuroCurveLinearColor Value
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._Value) == null)
				{
					result = (this._Value = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)FKuroRainMaterialColorParameter.__PropertyOffset_Value, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroRainMaterialColorParameter.__PropertyOffset_Value, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601AE62 RID: 110178 RVA: 0x0027A714 File Offset: 0x00278914
		public FKuroRainMaterialColorParameter()
		{
		}

		// Token: 0x0601AE63 RID: 110179 RVA: 0x0027A71C File Offset: 0x0027891C
		public FKuroRainMaterialColorParameter(FName ParameterName, FKuroCurveLinearColor Value)
		{
			this.ParameterName = ParameterName;
			this.Value = Value;
		}

		// Token: 0x0601AE64 RID: 110180 RVA: 0x0027A732 File Offset: 0x00278932
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRainMaterialColorParameter.StaticStruct();
		}

		// Token: 0x0601AE65 RID: 110181 RVA: 0x0027A73E File Offset: 0x0027893E
		[NullableContext(2)]
		public FKuroRainMaterialColorParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601AE66 RID: 110182 RVA: 0x0027A748 File Offset: 0x00278948
		public FKuroRainMaterialColorParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601AE67 RID: 110183 RVA: 0x0027A753 File Offset: 0x00278953
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRainMaterialColorParameter(Pointer, false, true);
		}

		// Token: 0x0601AE68 RID: 110184 RVA: 0x0027A75D File Offset: 0x0027895D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRainMaterialColorParameter(Pointer, MemoryOwner);
		}

		// Token: 0x0400E8CD RID: 59597
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroRainMaterialColorParameter";

		// Token: 0x0400E8CE RID: 59598
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E8CF RID: 59599
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x0400E8D0 RID: 59600
		internal static int __PropertyOffset_Value;

		// Token: 0x0400E8D1 RID: 59601
		[Nullable(2)]
		private FKuroCurveLinearColor _Value;
	}
}
