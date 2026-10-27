using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BED RID: 7149
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroWorldRainCustomData")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FKuroWorldRainCustomData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B82B RID: 112683 RVA: 0x00288266 File Offset: 0x00286466
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroWorldRainCustomData._ScriptStructPtr != 0) ? FKuroWorldRainCustomData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroWorldRainCustomData", ref FKuroWorldRainCustomData._ScriptStructPtr);
		}

		// Token: 0x17006EB9 RID: 28345
		// (get) Token: 0x0601B82C RID: 112684 RVA: 0x0028828A File Offset: 0x0028648A
		// (set) Token: 0x0601B82D RID: 112685 RVA: 0x0028829E File Offset: 0x0028649E
		public unsafe FName CurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWorldRainCustomData.__PropertyOffset_CurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWorldRainCustomData.__PropertyOffset_CurveName) = value;
			}
		}

		// Token: 0x17006EBA RID: 28346
		// (get) Token: 0x0601B82E RID: 112686 RVA: 0x002882B3 File Offset: 0x002864B3
		// (set) Token: 0x0601B82F RID: 112687 RVA: 0x002882C3 File Offset: 0x002864C3
		public unsafe int CustomRandomIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWorldRainCustomData.__PropertyOffset_CustomRandomIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWorldRainCustomData.__PropertyOffset_CustomRandomIndex) = value;
			}
		}

		// Token: 0x17006EBB RID: 28347
		// (get) Token: 0x0601B830 RID: 112688 RVA: 0x002882D4 File Offset: 0x002864D4
		// (set) Token: 0x0601B831 RID: 112689 RVA: 0x002882E4 File Offset: 0x002864E4
		public unsafe EKuroWorldRainCustomRandomDriver Driver
		{
			get
			{
				return (EKuroWorldRainCustomRandomDriver)(*(base.NativePtr + (IntPtr)FKuroWorldRainCustomData.__PropertyOffset_Driver));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWorldRainCustomData.__PropertyOffset_Driver) = (byte)value;
			}
		}

		// Token: 0x17006EBC RID: 28348
		// (get) Token: 0x0601B832 RID: 112690 RVA: 0x002882F8 File Offset: 0x002864F8
		// (set) Token: 0x0601B833 RID: 112691 RVA: 0x0028833B File Offset: 0x0028653B
		public FKuroCurveFloat Curve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._Curve) == null)
				{
					result = (this._Curve = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroWorldRainCustomData.__PropertyOffset_Curve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroWorldRainCustomData.__PropertyOffset_Curve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601B834 RID: 112692 RVA: 0x0028835C File Offset: 0x0028655C
		public FKuroWorldRainCustomData()
		{
		}

		// Token: 0x0601B835 RID: 112693 RVA: 0x00288364 File Offset: 0x00286564
		public FKuroWorldRainCustomData(FName CurveName, int CustomRandomIndex, EKuroWorldRainCustomRandomDriver Driver, FKuroCurveFloat Curve)
		{
			this.CurveName = CurveName;
			this.CustomRandomIndex = CustomRandomIndex;
			this.Driver = Driver;
			this.Curve = Curve;
		}

		// Token: 0x0601B836 RID: 112694 RVA: 0x00288389 File Offset: 0x00286589
		protected override IntPtr GetUStructPtr()
		{
			return FKuroWorldRainCustomData.StaticStruct();
		}

		// Token: 0x0601B837 RID: 112695 RVA: 0x00288395 File Offset: 0x00286595
		[NullableContext(2)]
		public FKuroWorldRainCustomData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B838 RID: 112696 RVA: 0x0028839F File Offset: 0x0028659F
		public FKuroWorldRainCustomData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B839 RID: 112697 RVA: 0x002883AA File Offset: 0x002865AA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroWorldRainCustomData(Pointer, false, true);
		}

		// Token: 0x0601B83A RID: 112698 RVA: 0x002883B4 File Offset: 0x002865B4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroWorldRainCustomData(Pointer, MemoryOwner);
		}

		// Token: 0x0400ECD2 RID: 60626
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroWorldRainCustomData";

		// Token: 0x0400ECD3 RID: 60627
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400ECD4 RID: 60628
		internal static int __PropertyOffset_CurveName;

		// Token: 0x0400ECD5 RID: 60629
		internal static int __PropertyOffset_CustomRandomIndex;

		// Token: 0x0400ECD6 RID: 60630
		internal static int __PropertyOffset_Driver;

		// Token: 0x0400ECD7 RID: 60631
		internal static int __PropertyOffset_Curve;

		// Token: 0x0400ECD8 RID: 60632
		[Nullable(2)]
		private FKuroCurveFloat _Curve;
	}
}
