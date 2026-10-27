using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F94 RID: 8084
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.LayerBlendInput")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FLayerBlendInput : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EB17 RID: 125719 RVA: 0x002DA080 File Offset: 0x002D8280
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLayerBlendInput._ScriptStructPtr != 0) ? FLayerBlendInput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.LayerBlendInput", ref FLayerBlendInput._ScriptStructPtr);
		}

		// Token: 0x17007A43 RID: 31299
		// (get) Token: 0x0601EB18 RID: 125720 RVA: 0x002DA0A4 File Offset: 0x002D82A4
		// (set) Token: 0x0601EB19 RID: 125721 RVA: 0x002DA0B8 File Offset: 0x002D82B8
		public unsafe FName LayerName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLayerBlendInput.__PropertyOffset_LayerName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLayerBlendInput.__PropertyOffset_LayerName) = value;
			}
		}

		// Token: 0x17007A44 RID: 31300
		// (get) Token: 0x0601EB1A RID: 125722 RVA: 0x002DA0CD File Offset: 0x002D82CD
		// (set) Token: 0x0601EB1B RID: 125723 RVA: 0x002DA0E1 File Offset: 0x002D82E1
		[Nullable(0)]
		public unsafe TEnumAsByte<ELandscapeLayerBlendType> BlendType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FLayerBlendInput.__PropertyOffset_BlendType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FLayerBlendInput.__PropertyOffset_BlendType) = value;
			}
		}

		// Token: 0x17007A45 RID: 31301
		// (get) Token: 0x0601EB1C RID: 125724 RVA: 0x002DA0F8 File Offset: 0x002D82F8
		// (set) Token: 0x0601EB1D RID: 125725 RVA: 0x002DA13B File Offset: 0x002D833B
		public FExpressionInput LayerInput
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._LayerInput) == null)
				{
					result = (this._LayerInput = new FExpressionInput(base.NativePtr + (IntPtr)FLayerBlendInput.__PropertyOffset_LayerInput, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)FLayerBlendInput.__PropertyOffset_LayerInput, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007A46 RID: 31302
		// (get) Token: 0x0601EB1E RID: 125726 RVA: 0x002DA15C File Offset: 0x002D835C
		// (set) Token: 0x0601EB1F RID: 125727 RVA: 0x002DA19F File Offset: 0x002D839F
		public FExpressionInput HeightInput
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._HeightInput) == null)
				{
					result = (this._HeightInput = new FExpressionInput(base.NativePtr + (IntPtr)FLayerBlendInput.__PropertyOffset_HeightInput, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)FLayerBlendInput.__PropertyOffset_HeightInput, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007A47 RID: 31303
		// (get) Token: 0x0601EB20 RID: 125728 RVA: 0x002DA1C0 File Offset: 0x002D83C0
		// (set) Token: 0x0601EB21 RID: 125729 RVA: 0x002DA1D0 File Offset: 0x002D83D0
		public unsafe float PreviewWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLayerBlendInput.__PropertyOffset_PreviewWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLayerBlendInput.__PropertyOffset_PreviewWeight) = value;
			}
		}

		// Token: 0x17007A48 RID: 31304
		// (get) Token: 0x0601EB22 RID: 125730 RVA: 0x002DA1E1 File Offset: 0x002D83E1
		// (set) Token: 0x0601EB23 RID: 125731 RVA: 0x002DA1F5 File Offset: 0x002D83F5
		public unsafe FVector ConstLayerInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLayerBlendInput.__PropertyOffset_ConstLayerInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLayerBlendInput.__PropertyOffset_ConstLayerInput) = value;
			}
		}

		// Token: 0x17007A49 RID: 31305
		// (get) Token: 0x0601EB24 RID: 125732 RVA: 0x002DA20A File Offset: 0x002D840A
		// (set) Token: 0x0601EB25 RID: 125733 RVA: 0x002DA21A File Offset: 0x002D841A
		public unsafe float ConstHeightInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLayerBlendInput.__PropertyOffset_ConstHeightInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLayerBlendInput.__PropertyOffset_ConstHeightInput) = value;
			}
		}

		// Token: 0x0601EB26 RID: 125734 RVA: 0x002DA22B File Offset: 0x002D842B
		public FLayerBlendInput()
		{
		}

		// Token: 0x0601EB27 RID: 125735 RVA: 0x002DA233 File Offset: 0x002D8433
		public FLayerBlendInput(FName LayerName, [Nullable(0)] TEnumAsByte<ELandscapeLayerBlendType> BlendType, FExpressionInput LayerInput, FExpressionInput HeightInput, float PreviewWeight, FVector ConstLayerInput, float ConstHeightInput)
		{
			this.LayerName = LayerName;
			this.BlendType = BlendType;
			this.LayerInput = LayerInput;
			this.HeightInput = HeightInput;
			this.PreviewWeight = PreviewWeight;
			this.ConstLayerInput = ConstLayerInput;
			this.ConstHeightInput = ConstHeightInput;
		}

		// Token: 0x0601EB28 RID: 125736 RVA: 0x002DA270 File Offset: 0x002D8470
		protected override IntPtr GetUStructPtr()
		{
			return FLayerBlendInput.StaticStruct();
		}

		// Token: 0x0601EB29 RID: 125737 RVA: 0x002DA27C File Offset: 0x002D847C
		[NullableContext(2)]
		public FLayerBlendInput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EB2A RID: 125738 RVA: 0x002DA286 File Offset: 0x002D8486
		public FLayerBlendInput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EB2B RID: 125739 RVA: 0x002DA291 File Offset: 0x002D8491
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLayerBlendInput(Pointer, false, true);
		}

		// Token: 0x0601EB2C RID: 125740 RVA: 0x002DA29B File Offset: 0x002D849B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLayerBlendInput(Pointer, MemoryOwner);
		}

		// Token: 0x04010980 RID: 67968
		public const string __ObjectPath = "/Script/Landscape.LayerBlendInput";

		// Token: 0x04010981 RID: 67969
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010982 RID: 67970
		internal static int __PropertyOffset_LayerName;

		// Token: 0x04010983 RID: 67971
		internal static int __PropertyOffset_BlendType;

		// Token: 0x04010984 RID: 67972
		internal static int __PropertyOffset_LayerInput;

		// Token: 0x04010985 RID: 67973
		[Nullable(2)]
		private FExpressionInput _LayerInput;

		// Token: 0x04010986 RID: 67974
		internal static int __PropertyOffset_HeightInput;

		// Token: 0x04010987 RID: 67975
		[Nullable(2)]
		private FExpressionInput _HeightInput;

		// Token: 0x04010988 RID: 67976
		internal static int __PropertyOffset_PreviewWeight;

		// Token: 0x04010989 RID: 67977
		internal static int __PropertyOffset_ConstLayerInput;

		// Token: 0x0401098A RID: 67978
		internal static int __PropertyOffset_ConstHeightInput;
	}
}
