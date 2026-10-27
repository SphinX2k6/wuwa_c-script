using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000483 RID: 1155
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ClothingSystemRuntimeCommon.ClothParameterMask_Legacy")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FClothParameterMask_Legacy : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003E20 RID: 15904 RVA: 0x0005D689 File Offset: 0x0005B889
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClothParameterMask_Legacy._ScriptStructPtr != 0) ? FClothParameterMask_Legacy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ClothingSystemRuntimeCommon.ClothParameterMask_Legacy", ref FClothParameterMask_Legacy._ScriptStructPtr);
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06003E21 RID: 15905 RVA: 0x0005D6AD File Offset: 0x0005B8AD
		// (set) Token: 0x06003E22 RID: 15906 RVA: 0x0005D6C1 File Offset: 0x0005B8C1
		public unsafe FName MaskName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothParameterMask_Legacy.__PropertyOffset_MaskName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothParameterMask_Legacy.__PropertyOffset_MaskName) = value;
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06003E23 RID: 15907 RVA: 0x0005D6D6 File Offset: 0x0005B8D6
		// (set) Token: 0x06003E24 RID: 15908 RVA: 0x0005D6E6 File Offset: 0x0005B8E6
		public unsafe EWeightMapTargetCommon CurrentTarget
		{
			get
			{
				return (EWeightMapTargetCommon)(*(base.NativePtr + (IntPtr)FClothParameterMask_Legacy.__PropertyOffset_CurrentTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothParameterMask_Legacy.__PropertyOffset_CurrentTarget) = (byte)value;
			}
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06003E25 RID: 15909 RVA: 0x0005D6F7 File Offset: 0x0005B8F7
		// (set) Token: 0x06003E26 RID: 15910 RVA: 0x0005D707 File Offset: 0x0005B907
		public unsafe float MaxValue_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothParameterMask_Legacy.__PropertyOffset_MaxValue_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothParameterMask_Legacy.__PropertyOffset_MaxValue_DEPRECATED) = value;
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06003E27 RID: 15911 RVA: 0x0005D718 File Offset: 0x0005B918
		// (set) Token: 0x06003E28 RID: 15912 RVA: 0x0005D728 File Offset: 0x0005B928
		public unsafe float MinValue_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothParameterMask_Legacy.__PropertyOffset_MinValue_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothParameterMask_Legacy.__PropertyOffset_MinValue_DEPRECATED) = value;
			}
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06003E29 RID: 15913 RVA: 0x0005D73C File Offset: 0x0005B93C
		// (set) Token: 0x06003E2A RID: 15914 RVA: 0x0005D77F File Offset: 0x0005B97F
		public TArray<float> Values
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Values) == null)
				{
					result = (this._Values = new TArray<float>(base.NativePtr + (IntPtr)FClothParameterMask_Legacy.__PropertyOffset_Values, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Values.CopyAssign(value);
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06003E2B RID: 15915 RVA: 0x0005D78D File Offset: 0x0005B98D
		// (set) Token: 0x06003E2C RID: 15916 RVA: 0x0005D79D File Offset: 0x0005B99D
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothParameterMask_Legacy.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothParameterMask_Legacy.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x0005D7AE File Offset: 0x0005B9AE
		public FClothParameterMask_Legacy()
		{
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x0005D7B6 File Offset: 0x0005B9B6
		public FClothParameterMask_Legacy(FName MaskName, EWeightMapTargetCommon CurrentTarget, float MaxValue_DEPRECATED, float MinValue_DEPRECATED, TArray<float> Values, bool bEnabled)
		{
			this.MaskName = MaskName;
			this.CurrentTarget = CurrentTarget;
			this.MaxValue_DEPRECATED = MaxValue_DEPRECATED;
			this.MinValue_DEPRECATED = MinValue_DEPRECATED;
			this.Values = Values;
			this.bEnabled = bEnabled;
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x0005D7EB File Offset: 0x0005B9EB
		protected override IntPtr GetUStructPtr()
		{
			return FClothParameterMask_Legacy.StaticStruct();
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x0005D7F7 File Offset: 0x0005B9F7
		[NullableContext(2)]
		public FClothParameterMask_Legacy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x0005D801 File Offset: 0x0005BA01
		public FClothParameterMask_Legacy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x0005D80C File Offset: 0x0005BA0C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClothParameterMask_Legacy(Pointer, false, true);
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x0005D816 File Offset: 0x0005BA16
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClothParameterMask_Legacy(Pointer, MemoryOwner);
		}

		// Token: 0x04001D36 RID: 7478
		public const string __ObjectPath = "/Script/ClothingSystemRuntimeCommon.ClothParameterMask_Legacy";

		// Token: 0x04001D37 RID: 7479
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001D38 RID: 7480
		internal static int __PropertyOffset_MaskName;

		// Token: 0x04001D39 RID: 7481
		internal static int __PropertyOffset_CurrentTarget;

		// Token: 0x04001D3A RID: 7482
		internal static int __PropertyOffset_MaxValue_DEPRECATED;

		// Token: 0x04001D3B RID: 7483
		internal static int __PropertyOffset_MinValue_DEPRECATED;

		// Token: 0x04001D3C RID: 7484
		internal static int __PropertyOffset_Values;

		// Token: 0x04001D3D RID: 7485
		[Nullable(2)]
		private TArray<float> _Values;

		// Token: 0x04001D3E RID: 7486
		internal static int __PropertyOffset_bEnabled;
	}
}
