using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200222C RID: 8748
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkTransformStaticData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FLiveLinkTransformStaticData : FLiveLinkBaseStaticData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060214E1 RID: 136417 RVA: 0x003116DA File Offset: 0x0030F8DA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkTransformStaticData._ScriptStructPtr != 0) ? FLiveLinkTransformStaticData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkTransformStaticData", ref FLiveLinkTransformStaticData._ScriptStructPtr);
		}

		// Token: 0x170081F8 RID: 33272
		// (get) Token: 0x060214E2 RID: 136418 RVA: 0x003116FE File Offset: 0x0030F8FE
		// (set) Token: 0x060214E3 RID: 136419 RVA: 0x0031170E File Offset: 0x0030F90E
		public unsafe bool bIsLocationSupported
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTransformStaticData.__PropertyOffset_bIsLocationSupported) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTransformStaticData.__PropertyOffset_bIsLocationSupported) = (value ? 1 : 0);
			}
		}

		// Token: 0x170081F9 RID: 33273
		// (get) Token: 0x060214E4 RID: 136420 RVA: 0x0031171F File Offset: 0x0030F91F
		// (set) Token: 0x060214E5 RID: 136421 RVA: 0x0031172F File Offset: 0x0030F92F
		public unsafe bool bIsRotationSupported
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTransformStaticData.__PropertyOffset_bIsRotationSupported) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTransformStaticData.__PropertyOffset_bIsRotationSupported) = (value ? 1 : 0);
			}
		}

		// Token: 0x170081FA RID: 33274
		// (get) Token: 0x060214E6 RID: 136422 RVA: 0x00311740 File Offset: 0x0030F940
		// (set) Token: 0x060214E7 RID: 136423 RVA: 0x00311750 File Offset: 0x0030F950
		public unsafe bool bIsScaleSupported
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTransformStaticData.__PropertyOffset_bIsScaleSupported) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTransformStaticData.__PropertyOffset_bIsScaleSupported) = (value ? 1 : 0);
			}
		}

		// Token: 0x060214E8 RID: 136424 RVA: 0x00311761 File Offset: 0x0030F961
		public FLiveLinkTransformStaticData()
		{
		}

		// Token: 0x060214E9 RID: 136425 RVA: 0x00311769 File Offset: 0x0030F969
		[NullableContext(1)]
		public FLiveLinkTransformStaticData(bool bIsLocationSupported, bool bIsRotationSupported, bool bIsScaleSupported, TArray<FName> PropertyNames)
		{
			this.bIsLocationSupported = bIsLocationSupported;
			this.bIsRotationSupported = bIsRotationSupported;
			this.bIsScaleSupported = bIsScaleSupported;
			base.PropertyNames = PropertyNames;
		}

		// Token: 0x060214EA RID: 136426 RVA: 0x0031178E File Offset: 0x0030F98E
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkTransformStaticData.StaticStruct();
		}

		// Token: 0x060214EB RID: 136427 RVA: 0x0031179A File Offset: 0x0030F99A
		[NullableContext(2)]
		public FLiveLinkTransformStaticData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060214EC RID: 136428 RVA: 0x003117A4 File Offset: 0x0030F9A4
		public FLiveLinkTransformStaticData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060214ED RID: 136429 RVA: 0x003117AF File Offset: 0x0030F9AF
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkTransformStaticData(Pointer, false, true);
		}

		// Token: 0x060214EE RID: 136430 RVA: 0x003117B9 File Offset: 0x0030F9B9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkTransformStaticData(Pointer, MemoryOwner);
		}

		// Token: 0x04011C29 RID: 72745
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkTransformStaticData";

		// Token: 0x04011C2A RID: 72746
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011C2B RID: 72747
		internal static int __PropertyOffset_bIsLocationSupported;

		// Token: 0x04011C2C RID: 72748
		internal static int __PropertyOffset_bIsRotationSupported;

		// Token: 0x04011C2D RID: 72749
		internal static int __PropertyOffset_bIsScaleSupported;
	}
}
