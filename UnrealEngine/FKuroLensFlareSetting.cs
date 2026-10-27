using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B30 RID: 6960
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroLensFlareSetting")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FKuroLensFlareSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A45B RID: 107611 RVA: 0x0026C3E2 File Offset: 0x0026A5E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroLensFlareSetting._ScriptStructPtr != 0) ? FKuroLensFlareSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroLensFlareSetting", ref FKuroLensFlareSetting._ScriptStructPtr);
		}

		// Token: 0x170069A4 RID: 27044
		// (get) Token: 0x0601A45C RID: 107612 RVA: 0x0026C406 File Offset: 0x0026A606
		// (set) Token: 0x0601A45D RID: 107613 RVA: 0x0026C41F File Offset: 0x0026A61F
		public unsafe bool bOverride_LensFlareConfigData
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_bOverride_LensFlareConfigData) & FKuroLensFlareSetting.__PropertyMask_bOverride_LensFlareConfigData) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_bOverride_LensFlareConfigData) = ((*(base.NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_bOverride_LensFlareConfigData) & ~FKuroLensFlareSetting.__PropertyMask_bOverride_LensFlareConfigData) | (value ? FKuroLensFlareSetting.__PropertyMask_bOverride_LensFlareConfigData : 0));
			}
		}

		// Token: 0x170069A5 RID: 27045
		// (get) Token: 0x0601A45E RID: 107614 RVA: 0x0026C44F File Offset: 0x0026A64F
		// (set) Token: 0x0601A45F RID: 107615 RVA: 0x0026C468 File Offset: 0x0026A668
		public unsafe bool bOverride_LensFlareTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_bOverride_LensFlareTint) & FKuroLensFlareSetting.__PropertyMask_bOverride_LensFlareTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_bOverride_LensFlareTint) = ((*(base.NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_bOverride_LensFlareTint) & ~FKuroLensFlareSetting.__PropertyMask_bOverride_LensFlareTint) | (value ? FKuroLensFlareSetting.__PropertyMask_bOverride_LensFlareTint : 0));
			}
		}

		// Token: 0x170069A6 RID: 27046
		// (get) Token: 0x0601A460 RID: 107616 RVA: 0x0026C498 File Offset: 0x0026A698
		// (set) Token: 0x0601A461 RID: 107617 RVA: 0x0026C4B1 File Offset: 0x0026A6B1
		public unsafe bool bOverride_LensFlareRampIndex
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_bOverride_LensFlareRampIndex) & FKuroLensFlareSetting.__PropertyMask_bOverride_LensFlareRampIndex) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_bOverride_LensFlareRampIndex) = ((*(base.NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_bOverride_LensFlareRampIndex) & ~FKuroLensFlareSetting.__PropertyMask_bOverride_LensFlareRampIndex) | (value ? FKuroLensFlareSetting.__PropertyMask_bOverride_LensFlareRampIndex : 0));
			}
		}

		// Token: 0x170069A7 RID: 27047
		// (get) Token: 0x0601A462 RID: 107618 RVA: 0x0026C4E1 File Offset: 0x0026A6E1
		// (set) Token: 0x0601A463 RID: 107619 RVA: 0x0026C4FA File Offset: 0x0026A6FA
		public unsafe bool bOverride_LensFlareColorThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_bOverride_LensFlareColorThreshold) & FKuroLensFlareSetting.__PropertyMask_bOverride_LensFlareColorThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_bOverride_LensFlareColorThreshold) = ((*(base.NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_bOverride_LensFlareColorThreshold) & ~FKuroLensFlareSetting.__PropertyMask_bOverride_LensFlareColorThreshold) | (value ? FKuroLensFlareSetting.__PropertyMask_bOverride_LensFlareColorThreshold : 0));
			}
		}

		// Token: 0x170069A8 RID: 27048
		// (get) Token: 0x0601A464 RID: 107620 RVA: 0x0026C52A File Offset: 0x0026A72A
		// (set) Token: 0x0601A465 RID: 107621 RVA: 0x0026C53E File Offset: 0x0026A73E
		[Nullable(2)]
		public unsafe USunLensFlareConfig LensFlareConfigData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USunLensFlareConfig>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroLensFlareSetting.__PropertyOffset_LensFlareConfigData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroLensFlareSetting.__PropertyOffset_LensFlareConfigData, value);
			}
		}

		// Token: 0x170069A9 RID: 27049
		// (get) Token: 0x0601A466 RID: 107622 RVA: 0x0026C553 File Offset: 0x0026A753
		// (set) Token: 0x0601A467 RID: 107623 RVA: 0x0026C567 File Offset: 0x0026A767
		public unsafe FLinearColor LensFlareTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_LensFlareTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_LensFlareTint) = value;
			}
		}

		// Token: 0x170069AA RID: 27050
		// (get) Token: 0x0601A468 RID: 107624 RVA: 0x0026C57C File Offset: 0x0026A77C
		// (set) Token: 0x0601A469 RID: 107625 RVA: 0x0026C58C File Offset: 0x0026A78C
		public unsafe int LensFlareRampIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_LensFlareRampIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_LensFlareRampIndex) = value;
			}
		}

		// Token: 0x170069AB RID: 27051
		// (get) Token: 0x0601A46A RID: 107626 RVA: 0x0026C59D File Offset: 0x0026A79D
		// (set) Token: 0x0601A46B RID: 107627 RVA: 0x0026C5AD File Offset: 0x0026A7AD
		public unsafe float LensFlareColorThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_LensFlareColorThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_LensFlareColorThreshold) = value;
			}
		}

		// Token: 0x170069AC RID: 27052
		// (get) Token: 0x0601A46C RID: 107628 RVA: 0x0026C5BE File Offset: 0x0026A7BE
		// (set) Token: 0x0601A46D RID: 107629 RVA: 0x0026C5D7 File Offset: 0x0026A7D7
		public unsafe bool bOverride_PPLensflareType
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_bOverride_PPLensflareType) & FKuroLensFlareSetting.__PropertyMask_bOverride_PPLensflareType) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_bOverride_PPLensflareType) = ((*(base.NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_bOverride_PPLensflareType) & ~FKuroLensFlareSetting.__PropertyMask_bOverride_PPLensflareType) | (value ? FKuroLensFlareSetting.__PropertyMask_bOverride_PPLensflareType : 0));
			}
		}

		// Token: 0x170069AD RID: 27053
		// (get) Token: 0x0601A46E RID: 107630 RVA: 0x0026C607 File Offset: 0x0026A807
		// (set) Token: 0x0601A46F RID: 107631 RVA: 0x0026C61B File Offset: 0x0026A81B
		public unsafe TEnumAsByte<EKuroPPLensflareType> PPLensflareType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_PPLensflareType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLensFlareSetting.__PropertyOffset_PPLensflareType) = value;
			}
		}

		// Token: 0x0601A470 RID: 107632 RVA: 0x0026C630 File Offset: 0x0026A830
		public FKuroLensFlareSetting()
		{
		}

		// Token: 0x0601A471 RID: 107633 RVA: 0x0026C638 File Offset: 0x0026A838
		public FKuroLensFlareSetting(bool bOverride_LensFlareConfigData, bool bOverride_LensFlareTint, bool bOverride_LensFlareRampIndex, bool bOverride_LensFlareColorThreshold, [Nullable(1)] USunLensFlareConfig LensFlareConfigData, FLinearColor LensFlareTint, int LensFlareRampIndex, float LensFlareColorThreshold, bool bOverride_PPLensflareType, TEnumAsByte<EKuroPPLensflareType> PPLensflareType)
		{
			this.bOverride_LensFlareConfigData = bOverride_LensFlareConfigData;
			this.bOverride_LensFlareTint = bOverride_LensFlareTint;
			this.bOverride_LensFlareRampIndex = bOverride_LensFlareRampIndex;
			this.bOverride_LensFlareColorThreshold = bOverride_LensFlareColorThreshold;
			this.LensFlareConfigData = LensFlareConfigData;
			this.LensFlareTint = LensFlareTint;
			this.LensFlareRampIndex = LensFlareRampIndex;
			this.LensFlareColorThreshold = LensFlareColorThreshold;
			this.bOverride_PPLensflareType = bOverride_PPLensflareType;
			this.PPLensflareType = PPLensflareType;
		}

		// Token: 0x0601A472 RID: 107634 RVA: 0x0026C698 File Offset: 0x0026A898
		protected override IntPtr GetUStructPtr()
		{
			return FKuroLensFlareSetting.StaticStruct();
		}

		// Token: 0x0601A473 RID: 107635 RVA: 0x0026C6A4 File Offset: 0x0026A8A4
		[NullableContext(2)]
		public FKuroLensFlareSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A474 RID: 107636 RVA: 0x0026C6AE File Offset: 0x0026A8AE
		public FKuroLensFlareSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A475 RID: 107637 RVA: 0x0026C6B9 File Offset: 0x0026A8B9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroLensFlareSetting(Pointer, false, true);
		}

		// Token: 0x0601A476 RID: 107638 RVA: 0x0026C6C3 File Offset: 0x0026A8C3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroLensFlareSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400E41D RID: 58397
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroLensFlareSetting";

		// Token: 0x0400E41E RID: 58398
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E41F RID: 58399
		internal static int __PropertyOffset_bOverride_LensFlareConfigData;

		// Token: 0x0400E420 RID: 58400
		internal static byte __PropertyMask_bOverride_LensFlareConfigData;

		// Token: 0x0400E421 RID: 58401
		internal static int __PropertyOffset_bOverride_LensFlareTint;

		// Token: 0x0400E422 RID: 58402
		internal static byte __PropertyMask_bOverride_LensFlareTint;

		// Token: 0x0400E423 RID: 58403
		internal static int __PropertyOffset_bOverride_LensFlareRampIndex;

		// Token: 0x0400E424 RID: 58404
		internal static byte __PropertyMask_bOverride_LensFlareRampIndex;

		// Token: 0x0400E425 RID: 58405
		internal static int __PropertyOffset_bOverride_LensFlareColorThreshold;

		// Token: 0x0400E426 RID: 58406
		internal static byte __PropertyMask_bOverride_LensFlareColorThreshold;

		// Token: 0x0400E427 RID: 58407
		internal static int __PropertyOffset_LensFlareConfigData;

		// Token: 0x0400E428 RID: 58408
		internal static int __PropertyOffset_LensFlareTint;

		// Token: 0x0400E429 RID: 58409
		internal static int __PropertyOffset_LensFlareRampIndex;

		// Token: 0x0400E42A RID: 58410
		internal static int __PropertyOffset_LensFlareColorThreshold;

		// Token: 0x0400E42B RID: 58411
		internal static int __PropertyOffset_bOverride_PPLensflareType;

		// Token: 0x0400E42C RID: 58412
		internal static byte __PropertyMask_bOverride_PPLensflareType;

		// Token: 0x0400E42D RID: 58413
		internal static int __PropertyOffset_PPLensflareType;
	}
}
