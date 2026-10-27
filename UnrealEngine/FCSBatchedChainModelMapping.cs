using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001775 RID: 6005
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.CSBatchedChainModelMapping")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FCSBatchedChainModelMapping : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060159FE RID: 88574 RVA: 0x001FCC8F File Offset: 0x001FAE8F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCSBatchedChainModelMapping._ScriptStructPtr != 0) ? FCSBatchedChainModelMapping._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.CSBatchedChainModelMapping", ref FCSBatchedChainModelMapping._ScriptStructPtr);
		}

		// Token: 0x17005569 RID: 21865
		// (get) Token: 0x060159FF RID: 88575 RVA: 0x001FCCB3 File Offset: 0x001FAEB3
		// (set) Token: 0x06015A00 RID: 88576 RVA: 0x001FCCC7 File Offset: 0x001FAEC7
		public unsafe UStaticMesh SourceMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FCSBatchedChainModelMapping.__PropertyOffset_SourceMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FCSBatchedChainModelMapping.__PropertyOffset_SourceMesh, value);
			}
		}

		// Token: 0x1700556A RID: 21866
		// (get) Token: 0x06015A01 RID: 88577 RVA: 0x001FCCDC File Offset: 0x001FAEDC
		// (set) Token: 0x06015A02 RID: 88578 RVA: 0x001FCCF0 File Offset: 0x001FAEF0
		public unsafe UJacobiChainAsset SimulationProfile
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UJacobiChainAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FCSBatchedChainModelMapping.__PropertyOffset_SimulationProfile);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FCSBatchedChainModelMapping.__PropertyOffset_SimulationProfile, value);
			}
		}

		// Token: 0x1700556B RID: 21867
		// (get) Token: 0x06015A03 RID: 88579 RVA: 0x001FCD05 File Offset: 0x001FAF05
		// (set) Token: 0x06015A04 RID: 88580 RVA: 0x001FCD15 File Offset: 0x001FAF15
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCSBatchedChainModelMapping.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCSBatchedChainModelMapping.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06015A05 RID: 88581 RVA: 0x001FCD26 File Offset: 0x001FAF26
		public FCSBatchedChainModelMapping()
		{
		}

		// Token: 0x06015A06 RID: 88582 RVA: 0x001FCD2E File Offset: 0x001FAF2E
		[NullableContext(1)]
		public FCSBatchedChainModelMapping(UStaticMesh SourceMesh, UJacobiChainAsset SimulationProfile, bool bEnabled)
		{
			this.SourceMesh = SourceMesh;
			this.SimulationProfile = SimulationProfile;
			this.bEnabled = bEnabled;
		}

		// Token: 0x06015A07 RID: 88583 RVA: 0x001FCD4B File Offset: 0x001FAF4B
		protected override IntPtr GetUStructPtr()
		{
			return FCSBatchedChainModelMapping.StaticStruct();
		}

		// Token: 0x06015A08 RID: 88584 RVA: 0x001FCD57 File Offset: 0x001FAF57
		public FCSBatchedChainModelMapping(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015A09 RID: 88585 RVA: 0x001FCD61 File Offset: 0x001FAF61
		public FCSBatchedChainModelMapping(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015A0A RID: 88586 RVA: 0x001FCD6C File Offset: 0x001FAF6C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCSBatchedChainModelMapping(Pointer, false, true);
		}

		// Token: 0x06015A0B RID: 88587 RVA: 0x001FCD76 File Offset: 0x001FAF76
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCSBatchedChainModelMapping(Pointer, MemoryOwner);
		}

		// Token: 0x0400BCB7 RID: 48311
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.CSBatchedChainModelMapping";

		// Token: 0x0400BCB8 RID: 48312
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BCB9 RID: 48313
		internal static int __PropertyOffset_SourceMesh;

		// Token: 0x0400BCBA RID: 48314
		internal static int __PropertyOffset_SimulationProfile;

		// Token: 0x0400BCBB RID: 48315
		internal static int __PropertyOffset_bEnabled;
	}
}
